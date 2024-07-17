using FourSpices.Data;
using FourSpices.Models;
using FourSpices.Models.ViewModels;
using FourSpices.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FourSpices.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        //Dependancy Injection
        private readonly ApplicationDbContext _db;

        [TempData]
        public string StatusMessage { get; set; }

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            IndexViewModel indexVM = new IndexViewModel()
            {
                MenuItems = await _db.MenuItem.Include(m => m.Category).Include(m => m.SubCategory).ToListAsync(),
                Categories = await _db.Category.ToListAsync(),
                Coupons = await _db.Coupon.Where(c=>c.isActive == true).ToListAsync()
            };

            //adding to shopping cart
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            if (claim != null)
            {
                var cnt = _db.ShoppingCart.Where(u => u.ApplicationUserId == claim.Value).ToList().Count;
                HttpContext.Session.SetInt32(SD.ssCartCount, cnt);
            }
            //
            return View(indexVM);
        }

        [Authorize]
        public async Task<IActionResult> Details(int id)
        {
            var menuItemFromDb = await _db.MenuItem.Include(m => m.Category).Include(m => m.SubCategory).Where(m => m.Id == id).FirstOrDefaultAsync();
            ShoppingCart cartObj = new ShoppingCart()
            {
                MenuItem = menuItemFromDb,
                MenuItemId = menuItemFromDb.Id
            };

            return View(cartObj);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details(ShoppingCart cartObject)
        {
            cartObject.Id = 0;
            if (ModelState.IsValid)
            {
                //We get the identity of the user
                var claimsIdentity = (ClaimsIdentity)this.User.Identity;
                var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

                //now we have the identity of the current logged in user we store it in our cartObject
                cartObject.ApplicationUserId = claim.Value;

                //now we need to retrive the user id from the database
                ShoppingCart cartFromDb = await _db.ShoppingCart.Where(u => u.ApplicationUserId == cartObject.ApplicationUserId 
                                                                         && u.MenuItemId == cartObject.MenuItemId).FirstOrDefaultAsync();

                //if the user did not add the item before
                if(cartFromDb == null)
                {
                    //add it
                    await _db.ShoppingCart.AddAsync(cartObject);
                }
                else
                {
                    //update the count
                    //await _db.ShoppingCart.AddAsync(cartObject);
                    cartFromDb.Count = cartFromDb.Count + cartObject.Count;
                }
                await _db.SaveChangesAsync();

                //Count the number of item that user has in his car
                var count = _db.ShoppingCart.Where(c => c.ApplicationUserId == cartObject.ApplicationUserId).ToList().Count();
                //we assign the count to a session
                HttpContext.Session.SetInt32(SD.ssCartCount, count);

                return RedirectToAction("Index");

            }
            else
            {
                //if modelState is not valid we return back to view page
                var menuItemFromDb = await _db.MenuItem.Include(m => m.Category).Include(m => m.SubCategory).Where(m => m.Id == cartObject.MenuItemId).FirstOrDefaultAsync();
                ShoppingCart cartObj = new ShoppingCart()
                {
                    MenuItem = menuItemFromDb,
                    MenuItemId = menuItemFromDb.Id
                };
                return View(cartObject);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

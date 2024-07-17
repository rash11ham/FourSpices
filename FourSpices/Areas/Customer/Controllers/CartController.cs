using FourSpices.Data;
using FourSpices.Models;
using FourSpices.Models.ViewModels;
using FourSpices.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FourSpices.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public OrderDetailsViewModel orderDetailsViewModel { get; set; }
        public object DataTime { get; private set; }

        public CartController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            orderDetailsViewModel = new OrderDetailsViewModel()
            {
                OrderHeader = new Models.OrderHeader()
            };
            orderDetailsViewModel.OrderHeader.OrderTotal = 0;

            //identity
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            //Shopping Cart
            var cart = _db.ShoppingCart.Where(c => c.ApplicationUserId == claim.Value);
            if(cart != null)
            {
                orderDetailsViewModel.ListCart = cart.ToList();
            }
            //Total price
            foreach(var list in orderDetailsViewModel.ListCart)
            {
                list.MenuItem = await _db.MenuItem.FirstOrDefaultAsync(m => m.Id == list.MenuItemId);
                orderDetailsViewModel.OrderHeader.OrderTotal = orderDetailsViewModel.OrderHeader.OrderTotal + (list.MenuItem.Price * list.Count);
                //convert to text avoid the html tags
                list.MenuItem.Description = SD.ConvertToRawHtml(list.MenuItem.Description);
                //We want to limit the description to 100 chars only
                if (list.MenuItem.Description.Length > 100)
                {
                    list.MenuItem.Description = list.MenuItem.Description.Substring(0, 99) + "...";
                }
            }
            orderDetailsViewModel.OrderHeader.OrderOriginalTotal = orderDetailsViewModel.OrderHeader.OrderTotal;
            if (HttpContext.Session.GetString(SD.ssCouponCode) != null)
            {
                orderDetailsViewModel.OrderHeader.CouponCode = HttpContext.Session.GetString(SD.ssCouponCode);
                var couponFromDb = await _db.Coupon.Where(c => c.Name.ToLower() == orderDetailsViewModel.OrderHeader.CouponCode.ToLower()).FirstOrDefaultAsync();
                orderDetailsViewModel.OrderHeader.OrderTotal = SD.DiscountedPrice(couponFromDb, orderDetailsViewModel.OrderHeader.OrderOriginalTotal);
            }

            return View(orderDetailsViewModel);
        }

        public async Task<IActionResult> Summary()
        {
            orderDetailsViewModel = new OrderDetailsViewModel()
            {
                OrderHeader = new Models.OrderHeader()
            };
            orderDetailsViewModel.OrderHeader.OrderTotal = 0;

            //identity
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            //This line for change of Pick up name
            ApplicationUser applicationUser = await _db.ApplicationUser.Where(u => u.Id == claim.Value).FirstOrDefaultAsync();

            //Shopping Cart
            var cart = _db.ShoppingCart.Where(c => c.ApplicationUserId == claim.Value);
            if (cart != null)
            {
                orderDetailsViewModel.ListCart = cart.ToList();
            }
            //Total price
            foreach (var list in orderDetailsViewModel.ListCart)
            {
                list.MenuItem = await _db.MenuItem.FirstOrDefaultAsync(m => m.Id == list.MenuItemId);
                orderDetailsViewModel.OrderHeader.OrderTotal = orderDetailsViewModel.OrderHeader.OrderTotal + (list.MenuItem.Price * list.Count);
                
            }
            orderDetailsViewModel.OrderHeader.OrderOriginalTotal = orderDetailsViewModel.OrderHeader.OrderTotal;
            //Pick up details
            orderDetailsViewModel.OrderHeader.PickupName = applicationUser.Name;
            orderDetailsViewModel.OrderHeader.PhoneNumber = applicationUser.PhoneNumber;
            orderDetailsViewModel.OrderHeader.PickUpTime = DateTime.Now;


            if (HttpContext.Session.GetString(SD.ssCouponCode) != null)
            {
                orderDetailsViewModel.OrderHeader.CouponCode = HttpContext.Session.GetString(SD.ssCouponCode);
                var couponFromDb = await _db.Coupon.Where(c => c.Name.ToLower() == orderDetailsViewModel.OrderHeader.CouponCode.ToLower()).FirstOrDefaultAsync();
                orderDetailsViewModel.OrderHeader.OrderTotal = SD.DiscountedPrice(couponFromDb, orderDetailsViewModel.OrderHeader.OrderOriginalTotal);
            }

            return View(orderDetailsViewModel);
        }


        [HttpPost, ActionName("Summary")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SummaryPost(string stripeToken)
        {
            //identity
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            
            orderDetailsViewModel.ListCart = await _db.ShoppingCart.Where(u => u.ApplicationUserId == claim.Value).ToListAsync();
            //We list our summary in the shopping cart
            orderDetailsViewModel.OrderHeader.PaymentStatus = SD.PaymentStatusPending;
            orderDetailsViewModel.OrderHeader.OrderDate = DateTime.Now;
            orderDetailsViewModel.OrderHeader.UserId = claim.Value;
            orderDetailsViewModel.OrderHeader.Status = SD.PaymentStatusPending;
            orderDetailsViewModel.OrderHeader.PickUpTime = Convert.ToDateTime(
                                                orderDetailsViewModel.OrderHeader.PickUpDate.ToShortDateString() + " " + 
                                                orderDetailsViewModel.OrderHeader.PickUpTime.ToShortTimeString()
                                            );

            //We list the summary in the database
            List<OrderDetails> orderDetailsList = new List<OrderDetails>();
            //Since we have add all the values needed in the orderheader in the above shopping cart
            //We only need to add the orderheader in the db
            _db.OrderHeader.Add(orderDetailsViewModel.OrderHeader);
            await _db.SaveChangesAsync();

            orderDetailsViewModel.OrderHeader.OrderOriginalTotal = 0;

            //Total price
            foreach (var item in orderDetailsViewModel.ListCart)
            {
                item.MenuItem = await _db.MenuItem.FirstOrDefaultAsync(m => m.Id == item.MenuItemId);
                OrderDetails orderDetails = new OrderDetails
                {
                    MenuItemId = item.MenuItemId,
                    OrderId = orderDetailsViewModel.OrderHeader.Id,
                    Description = item.MenuItem.Description,
                    Name = item.MenuItem.Name,
                    Price = item.MenuItem.Price,
                    Count = item.Count
                };
                //tracking the order original
                orderDetailsViewModel.OrderHeader.OrderOriginalTotal += orderDetails.Count * orderDetails.Price;
                _db.OrderDetails.Add(orderDetails);

            }
            //before we save the changes to db we calcuate the coupons first.
            if (HttpContext.Session.GetString(SD.ssCouponCode) != null)
            {
                orderDetailsViewModel.OrderHeader.CouponCode = HttpContext.Session.GetString(SD.ssCouponCode);
                var couponFromDb = await _db.Coupon.Where(c => c.Name.ToLower() == orderDetailsViewModel.OrderHeader.CouponCode.ToLower()).FirstOrDefaultAsync();
                orderDetailsViewModel.OrderHeader.OrderTotal = SD.DiscountedPrice(couponFromDb, orderDetailsViewModel.OrderHeader.OrderOriginalTotal);
            }
            else
            {
                orderDetailsViewModel.OrderHeader.OrderTotal = orderDetailsViewModel.OrderHeader.OrderOriginalTotal;
            }
            //The amount of discount 
            orderDetailsViewModel.OrderHeader.CouponCodeDiscount = orderDetailsViewModel.OrderHeader.OrderOriginalTotal - orderDetailsViewModel.OrderHeader.OrderTotal;

            //before adding to db we remove all the items from the shopping cart and session
            _db.ShoppingCart.RemoveRange(orderDetailsViewModel.ListCart);
            HttpContext.Session.SetInt32(SD.ssCartCount, 0);
            //now we save to db
            await _db.SaveChangesAsync();

            //payment process
            var options = new ChargeCreateOptions
            {
                Amount = Convert.ToInt32(orderDetailsViewModel.OrderHeader.OrderTotal * 100),
                Currency = "aud",
                Description = "Order ID : " + orderDetailsViewModel.OrderHeader.Id,
                Source = stripeToken
            };
            var service = new ChargeService();
            Charge charge = service.Create(options);
            if (charge.BalanceTransactionId == null)
            {
                orderDetailsViewModel.OrderHeader.PaymentStatus = SD.PaymentStatusRejected;
            }
            else
            {
                orderDetailsViewModel.OrderHeader.TransactionId = charge.BalanceTransactionId;
            }

            if (charge.Status.ToLower() == "succeeded")
            {
                orderDetailsViewModel.OrderHeader.PaymentStatus = SD.PaymentStatusApproved;
                orderDetailsViewModel.OrderHeader.Status = SD.StatusSubmitted;
            }
            else
            {
                orderDetailsViewModel.OrderHeader.PaymentStatus = SD.PaymentStatusRejected;
            }

            await _db.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }


        public IActionResult AddCoupon()
        {
            if (orderDetailsViewModel.OrderHeader.CouponCode == null)
            {
                orderDetailsViewModel.OrderHeader.CouponCode = "";
            }
            HttpContext.Session.SetString(SD.ssCouponCode, orderDetailsViewModel.OrderHeader.CouponCode);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult RemoveCoupon()
        {
            
            HttpContext.Session.SetString(SD.ssCouponCode, string.Empty);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Plus(int cartId)
        {
            var cart = await _db.ShoppingCart.FirstOrDefaultAsync(c => c.Id == cartId);
            cart.Count += 1;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Minus(int cartId)
        {
            var cart = await _db.ShoppingCart.FirstOrDefaultAsync(c => c.Id == cartId);
            if (cart.Count == 1)
            {
                _db.ShoppingCart.Remove(cart);
                await _db.SaveChangesAsync();

                var cnt = _db.ShoppingCart.Where(u => u.ApplicationUserId == cart.ApplicationUserId).ToList().Count;
                HttpContext.Session.SetInt32(SD.ssCartCount, cnt);
            }
            else
            {
                cart.Count -= 1;
                await _db.SaveChangesAsync();
            }
            
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Remove(int cartId)
        {
            var cart = await _db.ShoppingCart.FirstOrDefaultAsync(c => c.Id == cartId);
            
            _db.ShoppingCart.Remove(cart);
            await _db.SaveChangesAsync();

            var cnt = _db.ShoppingCart.Where(u => u.ApplicationUserId == cart.ApplicationUserId).ToList().Count;
            HttpContext.Session.SetInt32(SD.ssCartCount, cnt);

            return RedirectToAction(nameof(Index));
        }

        

    }
}

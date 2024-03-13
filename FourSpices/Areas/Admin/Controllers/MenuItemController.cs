using FourSpices.Data;
using FourSpices.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourSpices.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MenuItemController : Controller
    {
        private readonly ApplicationDbContext _db;
        //We will be saving the image paths to Db
        //when ever we need to save paths to Db we need to use the below property
        //we will fetch that using dependancy injection
        private readonly IWebHostEnvironment _webHostEnvironment;

        [BindProperty]//it will automatically point the viewmodel 
        public MenuItemViewModel MenuItemVM { get; set; }

        public MenuItemController(ApplicationDbContext db, IWebHostEnvironment webHostEnvironment)
        {
            _db = db;
            _webHostEnvironment = webHostEnvironment;
            MenuItemVM = new MenuItemViewModel()
            {
                //We only attach the Category but not the subCat because it will be choosen according to Cat
                Categories = _db.Category,
                MenuItem = new Models.MenuItem()
            };
        }
        public async Task<IActionResult> Index()
        {
            //This is called eagar loading Include(m=>m.SubCategory)
            var menuItemFromDb = await _db.MenuItem.Include(m=>m.Category).Include(m=>m.SubCategory).ToListAsync();
            return View(menuItemFromDb);
        }

        public IActionResult Create()
        {
            return View(MenuItemVM);
        }

    }
}

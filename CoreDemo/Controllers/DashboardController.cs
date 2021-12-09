using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class DashboardController : Controller
    {
        BlogManager blogManager = new BlogManager(new EFBlogRepository());
        CategoryManager categoryManager = new CategoryManager(new EFCategoryRepository());
        
        public IActionResult Index()
        {
            ViewBag.ToplamBlogSayisi = blogManager.GetList().Count();
            ViewBag.YazarinBlogSayisi = blogManager.GetBlogListByWriter(3).Count();
            ViewBag.KategoriSayisi = categoryManager.GetList().Count();
            return View();
        }
    }
}

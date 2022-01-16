using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PazaramaLibrary.Data;
using PazaramaLibrary.Models;
using PazaramaLibrary.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PazaramaLibrary.Controllers
{
    public class HomeController : Controller
    {
        private readonly BooksContext _context;

        public HomeController(BooksContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {


            var model = new HomePageViewModel
            {
                PopularBooks = _context.Books.ToList()
            };
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}

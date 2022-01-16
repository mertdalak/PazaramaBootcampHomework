using Microsoft.AspNetCore.Mvc;
using PazaramaLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PazaramaLibrary.ViewComponents
{
    public class GenresViewComponent : ViewComponent
    {
        private readonly BooksContext _context;
        public GenresViewComponent(BooksContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedGenre = RouteData.Values["id"];
            return View(_context.Genres.ToList());
        }
    }
}

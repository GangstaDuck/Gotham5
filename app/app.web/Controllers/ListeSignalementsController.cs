using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using app.domain.Models;
using app.persistence;

namespace app.web.Controllers
{
    public class ListeSignalementsController : Controller
    {
        private readonly persistence.AppContext _context;

        public ListeSignalementsController(persistence.AppContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }


        public async Task<IActionResult> Feu()
        {
            return View();
        }

        public IActionResult Tsunami()
        {
            return View();
        }

		public IActionResult Tremblement()
		{
			return View();
		}

    }
}

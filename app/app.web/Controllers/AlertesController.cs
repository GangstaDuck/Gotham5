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
    public class AlertesController : Controller
    {
        private readonly persistence.AppContext _context;

        public AlertesController(persistence.AppContext context)
        {
            _context = context;
        }

        // GET: Alertes
        public async Task<IActionResult> Index()
        {
            return View();
        }
		public async Task<IActionResult> Feu()
		{
			return View();
		}
		public async Task<IActionResult> FeuPublier()
		{
			return View();
		}
		public async Task<IActionResult> Canicule()
		{
			return View();
		}
		public async Task<IActionResult> CaniculePublier()
		{
			return View();
		}
		public async Task<IActionResult> Tremblement()
		{
			return View();
		}

		public async Task<IActionResult> TremblementPublier()
		{
			return View();
		}
		public async Task<IActionResult> Editer()
		{
			return View();
		}

		public async Task<IActionResult> Ajouter()
		{
			return View();
		}

	}
}

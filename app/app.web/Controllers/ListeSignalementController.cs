using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using app.web.Models;
using app.domain.Models;
using app.persistence;

namespace app.web.Controllers
{
    public class ListeSignalementController : Controller
    {
		private IRepository<ListeSignalement> _listeSignalementRepository;

		public ListeSignalementController(IRepository<ListeSignalement> listeSignalementRepository)
        {
			_listeSignalementRepository = listeSignalementRepository;

		}

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}

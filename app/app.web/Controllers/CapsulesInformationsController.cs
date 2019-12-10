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
    public class CapsulesInformationsController : Controller
    {
        private readonly persistence.AppContext _context;

        public CapsulesInformationsController(persistence.AppContext context)
        {
            _context = context;
        }

        // GET: CapsulesInformations
        public async Task<IActionResult> Index()
        {
            //return View(await _context.capsulesInformation.ToListAsync());
            return View();
        }

        // GET: CapsulesInformations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            return View();
        }

        // GET: CapsulesInformations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CapsulesInformations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Titre,Texte,Lien,Status,Id")] CapsulesInformation capsulesInformation)
        {
            return View();
        }

        // GET: CapsulesInformations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            return View();
        }

        // POST: CapsulesInformations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Titre,Texte,Lien,Status,Id")] CapsulesInformation capsulesInformation)
        {
            return View();
        }

        // GET: CapsulesInformations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            return View();
        }

        // POST: CapsulesInformations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            return View();
        }
    }
}

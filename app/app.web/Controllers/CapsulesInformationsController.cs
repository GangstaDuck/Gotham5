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
            if (id == null)
            {
                return NotFound();
            }

            var capsulesInformation = await _context.capsulesInformation
                .FirstOrDefaultAsync(m => m.Id == id);
            if (capsulesInformation == null)
            {
                return NotFound();
            }

            return View(capsulesInformation);
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
            if (ModelState.IsValid)
            {
                _context.Add(capsulesInformation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(capsulesInformation);
        }

        // GET: CapsulesInformations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var capsulesInformation = await _context.capsulesInformation.FindAsync(id);
            if (capsulesInformation == null)
            {
                return NotFound();
            }
            return View(capsulesInformation);
        }

        // POST: CapsulesInformations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Titre,Texte,Lien,Status,Id")] CapsulesInformation capsulesInformation)
        {
            if (id != capsulesInformation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(capsulesInformation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CapsulesInformationExists(capsulesInformation.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(capsulesInformation);
        }

        // GET: CapsulesInformations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var capsulesInformation = await _context.capsulesInformation
                .FirstOrDefaultAsync(m => m.Id == id);
            if (capsulesInformation == null)
            {
                return NotFound();
            }

            return View(capsulesInformation);
        }

        // POST: CapsulesInformations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var capsulesInformation = await _context.capsulesInformation.FindAsync(id);
            _context.capsulesInformation.Remove(capsulesInformation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CapsulesInformationExists(int id)
        {
            return _context.capsulesInformation.Any(e => e.Id == id);
        }
    }
}

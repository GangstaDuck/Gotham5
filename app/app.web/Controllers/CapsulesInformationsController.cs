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
        private IRepository<CapsulesInformation> _capsuleInformationRepository;

        public CapsulesInformationsController(IRepository<CapsulesInformation> capsuleInformationRepository)
        {
            _capsuleInformationRepository = capsuleInformationRepository;
        }

        // GET: CapsulesInformations
        public async Task<IActionResult> Index()
        {
            return View(await _capsuleInformationRepository.GetAll());
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
                if ((capsulesInformation.Lien.Length == 43 && capsulesInformation.Lien.Substring(0,5) == "https" ) || capsulesInformation.Lien.Length == 42)
                {
                    await _capsuleInformationRepository.Add(capsulesInformation);
                    return RedirectToAction(nameof(Index));
                }
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
            var capsulesInformation = await _capsuleInformationRepository.GetById(id);
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
                    await _capsuleInformationRepository.Update(capsulesInformation);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CapsuleExists(capsulesInformation.Id))
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

            var capsulesInformation = await _capsuleInformationRepository.GetById(id);
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
            var capsule = await _capsuleInformationRepository.GetById(id);
            await _capsuleInformationRepository.Delete(capsule);
            return RedirectToAction(nameof(Index));
        }

        private bool CapsuleExists(int id)
        {
            var capsule = _capsuleInformationRepository.GetById(id);
            return (capsule != null);
        }
    }
}

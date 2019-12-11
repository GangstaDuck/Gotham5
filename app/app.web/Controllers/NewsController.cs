using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using app.domain;
using app.persistence;

namespace app.web.Controllers
{
    public class NewsController : Controller
    {
        //private readonly persistence.AppContext _context;
        private IRepository<domain.News> _newRepository;

        //persistence.AppContext context,

        public NewsController(IRepository<domain.News> newRepository)
        {
            //_context = context;
            _newRepository = newRepository;
        }

        // GET: News
        public async Task<IActionResult> Index()
        {
            return View(await _newRepository.GetAll());
        }

        // GET: News/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var news = await _newRepository.GetById(id);
            //var news = await _context.Cours.FirstOrDefaultAsync(m => m.Id == id);
            if (news == null)
            {
                return NotFound();
            }

            return View(news);
        }

        // GET: News/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: News/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Text,Link,Status")] domain.News news)
        {
            if (ModelState.IsValid)
            {
                await _newRepository.Add(news);
                //_context.Add(news);
                //await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(news);
        }

        // GET: News/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _newRepository.GetById(id);
            if (news == null)
            {
                return NotFound();
            }
            return View(news);
        }

        // POST: News/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Text,Link,Status")] domain.News news)
        {
            if (id != news.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _newRepository.Update(news);
                    //_context.Update(news);
                    //await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    var newsSearched = await _newRepository.GetById(id);
                    //!NewsExists(news.id)
                    if (newsSearched == null)
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
            return View(news);
        }

        // GET: News/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var news = await _newRepository.GetById(id);
            //var news = await _context.Cours.FirstOrDefaultAsync(m => m.Id == id);
            if (news == null)
            {
                return NotFound();
            }

            return View(news);
        }

        // POST: News/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var newToDelete = await _newRepository.GetById(id);
            await _newRepository.Delete(newToDelete);
            //var news = await _context.Cours.FindAsync(id);
            //_context.Cours.Remove(news);
            //await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> NewsExistsAsync(int id)
        {
            //return _context.Cours.Any(e => e.Id == id);
            var news = await _newRepository.GetById(id);
            return (news != null);
        }

        public async void ChangeState(domain.News news)
        {
            if(news.Status == "Non publié")
            {
                await _newRepository.ChangeState(news, "Publié");
            }
            else
            {
                await _newRepository.ChangeState(news, "Non publié");
            }
        }
    }
}

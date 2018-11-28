using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using test13.Models;

namespace test13.Controllers
{
	[Route("api/[controller]")]
    public class SallereservesController : Controller
    {
        private readonly mabaseContext _context;

        public SallereservesController(mabaseContext context)
        {
            _context = context;
        }

        // GET: Sallereserves
        public async Task<IActionResult> Index()
        {
            var mabaseContext = _context.Sallereserve.Include(s => s.IdAdminNavigation).Include(s => s.IdUserNavigation).Include(s => s.NumSalleNavigation);
            return View(await mabaseContext.ToListAsync());
        }

        // GET: Sallereserves/Details/5
        public async Task<IActionResult> Details(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sallereserve = await _context.Sallereserve
                .Include(s => s.IdAdminNavigation)
                .Include(s => s.IdUserNavigation)
                .Include(s => s.NumSalleNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sallereserve == null)
            {
                return NotFound();
            }

            return View(sallereserve);
        }

        // GET: Sallereserves/Create
        public IActionResult Create()
        {
            ViewData["IdAdmin"] = new SelectList(_context.Admin, "IdAdmin", "AdresseMail");
            ViewData["IdUser"] = new SelectList(_context.User, "IdUser", "AdresseMail");
            ViewData["NumSalle"] = new SelectList(_context.Salle, "NumSalle", "NumSalle");
            return View();
        }

        // POST: Sallereserves/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NumSalle,HeureDebut,HeureFin,Date,IdUser,IdAdmin")] Sallereserve sallereserve)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sallereserve);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdAdmin"] = new SelectList(_context.Admin, "IdAdmin", "AdresseMail", sallereserve.IdAdmin);
            ViewData["IdUser"] = new SelectList(_context.User, "IdUser", "AdresseMail", sallereserve.IdUser);
            ViewData["NumSalle"] = new SelectList(_context.Salle, "NumSalle", "NumSalle", sallereserve.NumSalle);
            return View(sallereserve);
        }

        // GET: Sallereserves/Edit/5
        public async Task<IActionResult> Edit(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sallereserve = await _context.Sallereserve.FindAsync(id);
            if (sallereserve == null)
            {
                return NotFound();
            }
            ViewData["IdAdmin"] = new SelectList(_context.Admin, "IdAdmin", "AdresseMail", sallereserve.IdAdmin);
            ViewData["IdUser"] = new SelectList(_context.User, "IdUser", "AdresseMail", sallereserve.IdUser);
            ViewData["NumSalle"] = new SelectList(_context.Salle, "NumSalle", "NumSalle", sallereserve.NumSalle);
            return View(sallereserve);
        }

        // POST: Sallereserves/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(short id, [Bind("Id,NumSalle,HeureDebut,HeureFin,Date,IdUser,IdAdmin")] Sallereserve sallereserve)
        {
            if (id != sallereserve.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sallereserve);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SallereserveExists(sallereserve.Id))
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
            ViewData["IdAdmin"] = new SelectList(_context.Admin, "IdAdmin", "AdresseMail", sallereserve.IdAdmin);
            ViewData["IdUser"] = new SelectList(_context.User, "IdUser", "AdresseMail", sallereserve.IdUser);
            ViewData["NumSalle"] = new SelectList(_context.Salle, "NumSalle", "NumSalle", sallereserve.NumSalle);
            return View(sallereserve);
        }

        // GET: Sallereserves/Delete/5
        public async Task<IActionResult> Delete(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sallereserve = await _context.Sallereserve
                .Include(s => s.IdAdminNavigation)
                .Include(s => s.IdUserNavigation)
                .Include(s => s.NumSalleNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sallereserve == null)
            {
                return NotFound();
            }

            return View(sallereserve);
        }

        // POST: Sallereserves/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(short id)
        {
            var sallereserve = await _context.Sallereserve.FindAsync(id);
            _context.Sallereserve.Remove(sallereserve);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SallereserveExists(short id)
        {
            return _context.Sallereserve.Any(e => e.Id == id);
        }
    }
}

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
    public class ReservetionsController : Controller
    {
        private readonly mabaseContext _context;

        public ReservetionsController(mabaseContext context)
        {
            _context = context;
        }

        // GET: Reservetions
        public async Task<IActionResult> Index()
        {
            var mabaseContext = _context.Reservetion.Include(r => r.IdUserNavigation).Include(r => r.NumSalleNavigation);
            return View(await mabaseContext.ToListAsync());
        }

        // GET: Reservetions/Details/5
        public async Task<IActionResult> Details(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservetion = await _context.Reservetion
                .Include(r => r.IdUserNavigation)
                .Include(r => r.NumSalleNavigation)
                .FirstOrDefaultAsync(m => m.IdRes == id);
            if (reservetion == null)
            {
                return NotFound();
            }

            return View(reservetion);
        }

        // GET: Reservetions/Create
        public IActionResult Create()
        {
            ViewData["IdUser"] = new SelectList(_context.User, "IdUser", "AdresseMail");
            ViewData["NumSalle"] = new SelectList(_context.Salle, "NumSalle", "NumSalle");
            return View();
        }

        // POST: Reservetions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdRes,NumSalle,HeureDebut,HeureFin,Date,IdUser")] Reservetion reservetion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reservetion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdUser"] = new SelectList(_context.User, "IdUser", "AdresseMail", reservetion.IdUser);
            ViewData["NumSalle"] = new SelectList(_context.Salle, "NumSalle", "NumSalle", reservetion.NumSalle);
            return View(reservetion);
        }

        // GET: Reservetions/Edit/5
        public async Task<IActionResult> Edit(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservetion = await _context.Reservetion.FindAsync(id);
            if (reservetion == null)
            {
                return NotFound();
            }
            ViewData["IdUser"] = new SelectList(_context.User, "IdUser", "AdresseMail", reservetion.IdUser);
            ViewData["NumSalle"] = new SelectList(_context.Salle, "NumSalle", "NumSalle", reservetion.NumSalle);
            return View(reservetion);
        }

        // POST: Reservetions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(short id, [Bind("IdRes,NumSalle,HeureDebut,HeureFin,Date,IdUser")] Reservetion reservetion)
        {
            if (id != reservetion.IdRes)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservetion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservetionExists(reservetion.IdRes))
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
            ViewData["IdUser"] = new SelectList(_context.User, "IdUser", "AdresseMail", reservetion.IdUser);
            ViewData["NumSalle"] = new SelectList(_context.Salle, "NumSalle", "NumSalle", reservetion.NumSalle);
            return View(reservetion);
        }

        // GET: Reservetions/Delete/5
        public async Task<IActionResult> Delete(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservetion = await _context.Reservetion
                .Include(r => r.IdUserNavigation)
                .Include(r => r.NumSalleNavigation)
                .FirstOrDefaultAsync(m => m.IdRes == id);
            if (reservetion == null)
            {
                return NotFound();
            }

            return View(reservetion);
        }

        // POST: Reservetions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(short id)
        {
            var reservetion = await _context.Reservetion.FindAsync(id);
            _context.Reservetion.Remove(reservetion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservetionExists(short id)
        {
            return _context.Reservetion.Any(e => e.IdRes == id);
        }
    }
}

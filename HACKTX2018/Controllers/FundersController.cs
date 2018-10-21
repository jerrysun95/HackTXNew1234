using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HACKTX2018.DAL;
using HACKTX2018.Models;

namespace HACKTX2018.Controllers
{
    public class FundersController : Controller
    {
        private readonly AppDbContext _context;

        public FundersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Funders
        public async Task<IActionResult> Index()
        {
            return View(await _context.Funders.ToListAsync());
        }

        // GET: Funders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funder = await _context.Funders
                .FirstOrDefaultAsync(m => m.FunderID == id);
            if (funder == null)
            {
                return NotFound();
            }

            return View(funder);
        }

        // GET: Funders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Funders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FunderID,Name,Email,PhoneNumber,CreditCard")] Funder funder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(funder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(funder);
        }

        // GET: Funders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funder = await _context.Funders.FindAsync(id);
            if (funder == null)
            {
                return NotFound();
            }
            return View(funder);
        }

        // POST: Funders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FunderID,Name,Email,PhoneNumber,CreditCard")] Funder funder)
        {
            if (id != funder.FunderID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(funder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FunderExists(funder.FunderID))
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
            return View(funder);
        }

        // GET: Funders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funder = await _context.Funders
                .FirstOrDefaultAsync(m => m.FunderID == id);
            if (funder == null)
            {
                return NotFound();
            }

            return View(funder);
        }

        // POST: Funders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var funder = await _context.Funders.FindAsync(id);
            _context.Funders.Remove(funder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FunderExists(int id)
        {
            return _context.Funders.Any(e => e.FunderID == id);
        }
    }
}

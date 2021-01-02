﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SportProject.Data;
using SportProject.Models;

namespace SportProject.Controllers
{
    public class SportsController : Controller
    {

        private readonly ApplicationDbContext _context;

        public SportsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Sports
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sports.ToListAsync());
        }
        [AllowAnonymous]
        public IActionResult Info()
        {
            return View();
        }
        // GET: Sports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sports = await _context.Sports
                .FirstOrDefaultAsync(m => m.SportId == id);
            if (sports == null)
            {
                return NotFound();
            }

            return View(sports);
        }

        // GET: Sports/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SportId,SportName,PhotoUrl,InfoSport")] Sports sports)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sports);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sports);
        }

        // GET: Sports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sports = await _context.Sports.FindAsync(id);
            if (sports == null)
            {
                return NotFound();
            }
            return View(sports);
        }

        // POST: Sports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SportId,SportName,PhotoUrl,InfoSport")] Sports sports)
        {
            if (id != sports.SportId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sports);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SportsExists(sports.SportId))
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
            return View(sports);
        }

        // GET: Sports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sports = await _context.Sports
                .FirstOrDefaultAsync(m => m.SportId == id);
            if (sports == null)
            {
                return NotFound();
            }

            return View(sports);
        }

        // POST: Sports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sports = await _context.Sports.FindAsync(id);
            _context.Sports.Remove(sports);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SportsExists(int id)
        {
            return _context.Sports.Any(e => e.SportId == id);
        }
    }
}

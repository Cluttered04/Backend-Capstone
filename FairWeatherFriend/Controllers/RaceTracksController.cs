using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FairWeatherFriend.Data;
using FairWeatherFriend.Models;

namespace FairWeatherFriend.Controllers
{
    public class RaceTracksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RaceTracksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RaceTracks
        public async Task<IActionResult> Index()
        {
            return View(await _context.RaceTrack.ToListAsync());
        }

        // GET: RaceTracks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var raceTrack = await _context.RaceTrack.Include(r => r.Races)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (raceTrack == null)
            {
                return NotFound();
            }

            return View(raceTrack);
        }

        // GET: RaceTracks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RaceTracks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Location,Name,ZipCode")] RaceTrack raceTrack)
        {
            if (ModelState.IsValid)
            {
                _context.Add(raceTrack);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(raceTrack);
        }

        // GET: RaceTracks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var raceTrack = await _context.RaceTrack.FindAsync(id);
            if (raceTrack == null)
            {
                return NotFound();
            }
            return View(raceTrack);
        }

        // POST: RaceTracks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Location,Name,ZipCode")] RaceTrack raceTrack)
        {
            if (id != raceTrack.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(raceTrack);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RaceTrackExists(raceTrack.Id))
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
            return View(raceTrack);
        }

        // GET: RaceTracks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var raceTrack = await _context.RaceTrack
                .FirstOrDefaultAsync(m => m.Id == id);
            if (raceTrack == null)
            {
                return NotFound();
            }

            return View(raceTrack);
        }

        // POST: RaceTracks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var raceTrack = await _context.RaceTrack.FindAsync(id);
            _context.RaceTrack.Remove(raceTrack);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RaceTrackExists(int id)
        {
            return _context.RaceTrack.Any(e => e.Id == id);
        }
    }
}

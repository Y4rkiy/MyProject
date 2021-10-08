using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyProject.Data;
using MyProject.Models;

namespace MyProject.Controllers
{
    public class MathTasksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MathTasksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MathTasks
        public async Task<IActionResult> Index(string searchString)
        {
            var mathTasks = from t in _context.MathTask
                            select t;

            if (!String.IsNullOrEmpty(searchString))
            {
                mathTasks = mathTasks.Where(s => s.Name.Contains(searchString) || s.Text.Contains(searchString));
            }

            return View(await _context.MathTask.ToListAsync());
        }

        // GET: MathTasks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mathTask = await _context.MathTask
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mathTask == null)
            {
                return NotFound();
            }

            return View(mathTask);
        }

        // GET: MathTasks/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: MathTasks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Topic, Text, ApplicationUserId, Tags")] MathTask mathTask)
        {
            if (ModelState.IsValid)
            {
                mathTask.ApplicationUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                _context.Add(mathTask);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mathTask);
        }

        // GET: MathTasks/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mathTask = await _context.MathTask.FindAsync(id);
            if (mathTask == null)
            {
                return NotFound();
            }
            return View(mathTask);
        }

        // POST: MathTasks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Text,Them, ApplicationUserId, Tags")] MathTask mathTask)
        {
            if (id != mathTask.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mathTask);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MathTaskExists(mathTask.Id))
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
            return View(mathTask);
        }

        // GET: MathTasks/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mathTask = await _context.MathTask
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mathTask == null)
            {
                return NotFound();
            }

            return View(mathTask);
        }

        // POST: MathTasks/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mathTask = await _context.MathTask.FindAsync(id);
            _context.MathTask.Remove(mathTask);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MathTaskExists(int id)
        {
            return _context.MathTask.Any(e => e.Id == id);
        }
    }
}

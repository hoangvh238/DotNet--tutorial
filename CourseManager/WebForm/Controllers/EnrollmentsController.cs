using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccess;

namespace WebForm.Controllers
{
    public class EnrollmentsController : Controller
    {
        private readonly CourseDB _context;

        public EnrollmentsController(CourseDB context)
        {
            _context = context;
        }

        // GET: Enrollments
        public async Task<IActionResult> Index()
        {
            var courseDB = _context.Entrollments.Include(e => e.Course).Include(e => e.Student);
            return View(await courseDB.ToListAsync());
        }

        // GET: Enrollments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Entrollments == null)
            {
                return NotFound();
            }

            var enrollments = await _context.Entrollments
                .Include(e => e.Course)
                .Include(e => e.Student)
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (enrollments == null)
            {
                return NotFound();
            }

            return View(enrollments);
        }

        // GET: Enrollments/Create
        public IActionResult Create()
        {
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseName");
            ViewData["StudentId"] = new SelectList(_context.Students, "StudentId", "Address");
            return View();
        }

        // POST: Enrollments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentId,CourseId,DateUpdate")] Enrollments enrollments)
        {
            if (ModelState.IsValid)
            {
                _context.Add(enrollments);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseName", enrollments.CourseId);
            ViewData["StudentId"] = new SelectList(_context.Students, "StudentId", "Address", enrollments.StudentId);
            return View(enrollments);
        }

        // GET: Enrollments/Edit/5
        public async Task<IActionResult> Edit(int studentId, int courseId)
        {
            if (studentId == null || _context.Entrollments == null)
            {
                return NotFound();
            }

            var enrollments = await _context.Entrollments.FindAsync(studentId,courseId);
            if (enrollments == null)
            {
                return NotFound();
            }
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseName", enrollments.CourseId);
            ViewData["StudentId"] = new SelectList(_context.Students, "StudentId", "Address", enrollments.StudentId);
            return View(enrollments);
        }

        // POST: Enrollments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StudentId,CourseId,DateUpdate")] Enrollments enrollments)
        {
            if (id != enrollments.StudentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(enrollments);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnrollmentsExists(enrollments.StudentId))
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
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseName", enrollments.CourseId);
            ViewData["StudentId"] = new SelectList(_context.Students, "StudentId", "Address", enrollments.StudentId);
            return View(enrollments);
        }

        // GET: Enrollments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Entrollments == null)
            {
                return NotFound();
            }

            var enrollments = await _context.Entrollments
                .Include(e => e.Course)
                .Include(e => e.Student)
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (enrollments == null)
            {
                return NotFound();
            }

            return View(enrollments);
        }

        // POST: Enrollments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Entrollments == null)
            {
                return Problem("Entity set 'CourseDB.Entrollments'  is null.");
            }
            var enrollments = await _context.Entrollments.FindAsync(id);
            if (enrollments != null)
            {
                _context.Entrollments.Remove(enrollments);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnrollmentsExists(int id)
        {
          return (_context.Entrollments?.Any(e => e.StudentId == id)).GetValueOrDefault();
        }
    }
}

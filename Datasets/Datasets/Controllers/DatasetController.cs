using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Datasets.Data;
using Datasets.Models;
using System.IO;

namespace Datasets.Controllers
{
    public class DatasetController : Controller
    {
        private readonly DatasetsContext _context;

        public DatasetController(DatasetsContext context)
        {
            _context = context;
        }

        // GET: Dataset
        public async Task<IActionResult> Index()
        {
            return View(await _context.Dataset.ToListAsync());
        }

        // GET: Dataset/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataset = await _context.Dataset
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dataset == null)
            {
                return NotFound();
            }

            return View(dataset);
        }

        // GET: Dataset/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dataset/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Filename,Url")] Dataset dataset)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dataset);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dataset);
        }

        // GET: Dataset/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataset = await _context.Dataset.FindAsync(id);
            if (dataset == null)
            {
                return NotFound();
            }
            return View(dataset);
        }

        // POST: Dataset/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Filename,Url")] Dataset dataset)
        {
            if (id != dataset.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dataset);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DatasetExists(dataset.Id))
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
            return View(dataset);
        }

        // GET: Dataset/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataset = await _context.Dataset
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dataset == null)
            {
                return NotFound();
            }

            return View(dataset);
        }

        // POST: Dataset/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dataset = await _context.Dataset.FindAsync(id);
            _context.Dataset.Remove(dataset);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DatasetExists(int id)
        {
            return _context.Dataset.Any(e => e.Id == id);
        }

    }
}

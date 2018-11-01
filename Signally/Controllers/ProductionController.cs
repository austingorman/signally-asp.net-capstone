using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Signally.Data;
using Signally.Models;

namespace Signally.Controllers
{
    public class ProductionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductionController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Production
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Order.Include(o => o.CSR).Include(o => o.Customer).Include(o => o.Status).Where(o => o.Status.StatusName == "Order") ;
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Production/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order
                .Include(o => o.CSR)
                .Include(o => o.Customer)
                .Include(o => o.Status)
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: Production/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            ViewData["CSRId"] = new SelectList(_context.CSR, "CSRId", "FirstName", order.CSRId);
            ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "Address", order.CustomerId);
            ViewData["StatusId"] = new SelectList(_context.Status, "StatusId", "StatusName", order.StatusId);
            return View(order);
        }

        // POST: Production/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderId,CSRId,CustomerId,DatePlaced,DateDue,StatusId,Rush,Install,Price")] Order order)
        {
            if (id != order.OrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    //if (!OrderExists(order.OrderId))
                    //{
                    //    return NotFound();
                    //}
                    //else
                    //{
                    //    throw;
                    //}
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CSRId"] = new SelectList(_context.CSR, "CSRId", "FirstName", order.CSRId);
            ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "Address", order.CustomerId);
            ViewData["StatusId"] = new SelectList(_context.Status, "StatusId", "StatusName", order.StatusId);
            return View(order);
        }
    }
}

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
            var orders = _context.Order
                .Include(o => o.CSR)
                .Include(o => o.Customer)
                .Include(o => o.Status)
                .Include(o => o.OrderItem)
                .Where(o => o.Status.StatusName == "Order");
            return View(await orders.ToListAsync());
        }

        // GET: Production/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = _context.OrderItem.Select(o => o)
                .Include(o => o.Order)
                .Include(o => o.Type)
                .Where(m => m.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }
            DetailsProductionViewModel detailsProductionViewModel = new DetailsProductionViewModel();
            detailsProductionViewModel.OrderItemCollection = order.ToList();
            detailsProductionViewModel.OrderId = id;
            return View(detailsProductionViewModel);
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
            EditProductionViewModel editProductionViewModel = new EditProductionViewModel(_context);
            editProductionViewModel.Order = order;
            return View(editProductionViewModel);
        }

        // POST: Production/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Order order)
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
                    if (!OrderExists(order.OrderId))
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
            EditProductionViewModel editProductionViewModel = new EditProductionViewModel(_context);
            editProductionViewModel.Order = order;
            return View(editProductionViewModel);
        }
        // POST: Production/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        public async Task<IActionResult> MarkAsBuilt(int id)
        {

            var order = _context.Order.Where(o => o.OrderId == id).FirstOrDefault();

            if (id != order.OrderId)
            {
                return NotFound();
            }

            order.StatusId = 3;

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.OrderId))
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
            EditProductionViewModel editProductionViewModel = new EditProductionViewModel(_context);
            editProductionViewModel.Order = order;
            return View(editProductionViewModel);
        }
            private bool OrderExists(int id)
            {
                return _context.Order.Any(e => e.OrderId == id);
            }
    }
}

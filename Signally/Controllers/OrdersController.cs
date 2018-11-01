using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Signally.Data;
using Signally.Models;

namespace Signally.Controllers
{
    public class OrdersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrdersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Order
                .Include(o => o.CSR)
                .Include(o => o.Customer)
                .Include(o => o.Status)
                .Include(o => o.OrderItem);

            var OrderList = await applicationDbContext.ToListAsync();

            foreach (var order in OrderList)
            {
            decimal TotalPrice = 0;

                foreach(var orderitem in order.OrderItem)
                {
          
                TotalPrice = TotalPrice + orderitem.Price;
                }
                order.Price = TotalPrice;
            }
            //Taco.

            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Orders/Details/5
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

        // GET: Orders/Create
        public IActionResult Create()
        {
            //ViewData["CSRId"] = new SelectList(_context.CSR, "CSRId", "FirstName");
            //ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "FullName");
            //ViewData["StatusId"] = new SelectList(_context.Status, "StatusId", "StatusName");
            var ViewModel = new CreateOrderViewModel(_context);
            return View(ViewModel);
        }


        //POST: Orders/Create
        //To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CSRId,CustomerId,DatePlaced,DateDue,StatusId,Rush,Install")] Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            CreateOrderViewModel createOrderViewModel = new CreateOrderViewModel(_context);
            createOrderViewModel.Order = order;
            return View(createOrderViewModel);
            //ViewData["CSRId"] = new SelectList(_context.CSR, "CSRId", "FirstName", order.CSRId);
            //ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "Address", order.CustomerId);
            //ViewData["StatusId"] = new SelectList(_context.Status, "StatusId", "StatusName", order.StatusId);
            //return View(order);
        }

        // GET: Orders/Edit/5
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

            EditOrderViewModel editOrderViewModel = new EditOrderViewModel(_context);
            editOrderViewModel.Order = order;
            return View(editOrderViewModel);
        }

        // POST: Orders/Edit/5
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
            EditOrderViewModel editOrderViewModel = new EditOrderViewModel(_context);
            editOrderViewModel.Order = order;
            return View(editOrderViewModel);
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
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

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = await _context.Order.FindAsync(id);
            _context.Order.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return _context.Order.Any(e => e.OrderId == id);
        }
    }
}

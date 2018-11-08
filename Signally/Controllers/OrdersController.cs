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
        public IActionResult Index(string searchString, string searchStringCustomer)
        {
            var orders = _context.Order
                .Include(o => o.CSR)
                .Include(o => o.Customer)
                .Include(o => o.Status)
                .Include(o => o.OrderItem)
                .Select(o => o);

            //var OrderList = await orders.ToListAsync();

            foreach (var order in orders)
            {
            decimal TotalPrice = 0;

                    if (order.Rush == true)
                    {
                        TotalPrice = TotalPrice + 30;
                    }
                    if (order.Install == true){
                        TotalPrice = TotalPrice + 80;
                    }
                foreach(var orderitem in order.OrderItem)
                {
                    TotalPrice = TotalPrice + orderitem.Price;
                }
                order.Price = TotalPrice;
            }

            if (!String.IsNullOrEmpty(searchString))
            {
                orders = orders.Where(o => o.OrderId.ToString() == searchString);
            }
            if (!String.IsNullOrEmpty(searchStringCustomer))
            {
                orders = orders.Where(o => o.Customer.FullName.ToLower().Contains(searchStringCustomer.ToLower()));
            }

            return View(orders);
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
        public async Task<IActionResult> Edit(int id, [Bind("OrderId,CSRId,CustomerId,DatePlaced,DateDue,StatusId,Rush,Install,Price,Content")] Order order)
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

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
    public class OrderItemsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrderItemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: OrderItems
        public async Task<IActionResult> Index(int? TheOrderId)
        {
            if (TheOrderId == null)
            {
                var applicationDbContext2 = _context.OrderItem
                    .Include(o => o.Order)
                    .Include(o => o.Type);

                    return View(await applicationDbContext2.ToListAsync());
            }
            var applicationDbContext = _context.OrderItem
                .Include(o => o.Order)
                .Include(o => o.Type)
                .Where(o => (o.OrderId == TheOrderId));
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: OrderItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var OrderItemPrice = _context.OrderItem.FirstOrDefault(o => o.OrderId == id);

            if(OrderItemPrice == null)
            {
                return RedirectToAction("Index", "Orders", new { area = "" });
            }
            return RedirectToAction(nameof(Index), new { TheOrderId = id });
        }

        // GET: OrderItems/Create
        public IActionResult Create()
        {
            var ViewModel = new CreateOrderItemViewModel(_context);
            return View(ViewModel);
        }

        // POST: OrderItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderItemId,OrderId,TypeId,Quantity,Height,Width,Price")] OrderItem orderItem)
        {
            var OrderItemType = _context.Type.SingleOrDefault(t => t.TypeId == orderItem.TypeId);

            var OrderItemPrice = (OrderItemType.PricePerUnit * (orderItem.Quantity * (orderItem.Height * orderItem.Width)));
            orderItem.Price = OrderItemPrice;
            ModelState.Remove("orderItem.Price");            

            int OrderId;
            var StringId = RouteData.Values["id"].ToString();
            var TheId = int.TryParse(StringId, out OrderId);
            orderItem.OrderId = OrderId;
            ModelState.Remove("orderItem.OrderId");

            if (ModelState.IsValid)
            {
                _context.Add(orderItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new {TheOrderId = orderItem.OrderId});
            }
            CreateOrderItemViewModel createOrderItemViewModel = new CreateOrderItemViewModel(_context);
            createOrderItemViewModel.OrderItem = orderItem;
            return View(createOrderItemViewModel);
        }

        // GET: OrderItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderItem = await _context.OrderItem.FindAsync(id);
            if (orderItem == null)
            {
                return NotFound();
            }
            EditOrderItemViewModel editOrderItemViewModel = new EditOrderItemViewModel(_context);
            editOrderItemViewModel.OrderItem = orderItem;
            return View(editOrderItemViewModel);
        }

        // POST: OrderItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderItemId,OrderId,TypeId,Quantity,Height,Width,Price")] OrderItem orderItem)
        {
            if (id != orderItem.OrderItemId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderItemExists(orderItem.OrderItemId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    } 
                }
                return RedirectToAction(nameof(Index), new { TheOrderId = orderItem.OrderId });
            }
            EditOrderItemViewModel editOrderItemViewModel = new EditOrderItemViewModel(_context);
            editOrderItemViewModel.OrderItem = orderItem;
            return View(editOrderItemViewModel);
        }

        // GET: OrderItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderItem = await _context.OrderItem
                .Include(o => o.Order)
                .Include(o => o.Type)
                .FirstOrDefaultAsync(m => m.OrderItemId == id);
            if (orderItem == null)
            {
                return NotFound();
            }

            return View(orderItem);
        }

        // POST: OrderItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orderItem = await _context.OrderItem.FindAsync(id);
            _context.OrderItem.Remove(orderItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index), new { TheOrderId = orderItem.OrderId });
        }

        private bool OrderItemExists(int id)
        {
            return _context.OrderItem.Any(e => e.OrderItemId == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EmilyChrisSalesAPI.Data;
using EmilyChrisSalesAPI.Models;

namespace EmilyChrisSalesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderLinesController : ControllerBase
    {
        private readonly EmilyChrisSalesAPIContext _context;

        public OrderLinesController(EmilyChrisSalesAPIContext context)
        {
            _context = context;
        }

        // GET: api/OrderLines
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderLines>>> GetOrderLines()
        {
            return await _context.OrderLines.ToListAsync();
        }

        // GET: api/OrderLines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderLines>> GetOrderLines(int id)
        {
            var orderLines = await _context.OrderLines.FindAsync(id);

            if (orderLines == null)
            {
                return NotFound();
            }

            return orderLines;
        }

        // PUT: api/OrderLines/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderLines(int id, OrderLines orderLines)
        {
            if (id != orderLines.Id)
            {
                return BadRequest();
            }

            _context.Entry(orderLines).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderLinesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/OrderLines
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OrderLines>> PostOrderLines(OrderLines orderLines)
        {
            _context.OrderLines.Add(orderLines);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrderLines", new { id = orderLines.Id }, orderLines);
        }

        // DELETE: api/OrderLines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderLines(int id)
        {
            var orderLines = await _context.OrderLines.FindAsync(id);
            if (orderLines == null)
            {
                return NotFound();
            }

            _context.OrderLines.Remove(orderLines);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderLinesExists(int id)
        {
            return _context.OrderLines.Any(e => e.Id == id);
        }
    }
}

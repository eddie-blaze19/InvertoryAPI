using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InvertoryAPI;
using InvertoryAPI.Data;

namespace InvertoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchasesController : ControllerBase
    {
        private readonly DataContext _context;

        public PurchasesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Purchases
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Purchases>>> GetPurchases()
        {
          if (_context.Purchases == null)
          {
              return NotFound();
          }
            return await _context.Purchases.ToListAsync();
        }

        // GET: api/Purchases/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Purchases>> GetPurchases(int id)
        {
          if (_context.Purchases == null)
          {
              return NotFound();
          }
            var purchases = await _context.Purchases.FindAsync(id);

            if (purchases == null)
            {
                return NotFound();
            }

            return purchases;
        }

        // PUT: api/Purchases/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPurchases(int id, Purchases purchases)
        {
            if (id != purchases.Id)
            {
                return BadRequest();
            }

            _context.Entry(purchases).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchasesExists(id))
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

        // POST: api/Purchases
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Purchases>> PostPurchases(Purchases purchases)
        {
          if (_context.Purchases == null)
          {
              return Problem("Entity set 'DataContext.Purchases'  is null.");
          }
            _context.Purchases.Add(purchases);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPurchases", new { id = purchases.Id }, purchases);
        }

        // DELETE: api/Purchases/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePurchases(int id)
        {
            if (_context.Purchases == null)
            {
                return NotFound();
            }
            var purchases = await _context.Purchases.FindAsync(id);
            if (purchases == null)
            {
                return NotFound();
            }

            _context.Purchases.Remove(purchases);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PurchasesExists(int id)
        {
            return (_context.Purchases?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

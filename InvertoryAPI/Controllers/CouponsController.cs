﻿using System;
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
    public class CouponsController : ControllerBase
    {
        private readonly DataContext _context;

        public CouponsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Coupons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Coupons>>> GetCoupons()
        {
          if (_context.Coupons == null)
          {
              return NotFound();
          }
            return await _context.Coupons.ToListAsync();
        }

        // GET: api/Coupons/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Coupons>> GetCoupons(int id)
        {
          if (_context.Coupons == null)
          {
              return NotFound();
          }
            var coupons = await _context.Coupons.FindAsync(id);

            if (coupons == null)
            {
                return NotFound();
            }

            return coupons;
        }

        // PUT: api/Coupons/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCoupons(int id, Coupons coupons)
        {
            if (id != coupons.Id)
            {
                return BadRequest();
            }

            _context.Entry(coupons).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CouponsExists(id))
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

        // POST: api/Coupons
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Coupons>> PostCoupons(Coupons coupons)
        {
          if (_context.Coupons == null)
          {
              return Problem("Entity set 'DataContext.Coupons'  is null.");
          }
            _context.Coupons.Add(coupons);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCoupons", new { id = coupons.Id }, coupons);
        }

        // DELETE: api/Coupons/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCoupons(int id)
        {
            if (_context.Coupons == null)
            {
                return NotFound();
            }
            var coupons = await _context.Coupons.FindAsync(id);
            if (coupons == null)
            {
                return NotFound();
            }

            _context.Coupons.Remove(coupons);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CouponsExists(int id)
        {
            return (_context.Coupons?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

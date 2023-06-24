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
    public class RoleaccessesController : ControllerBase
    {
        private readonly DataContext _context;

        public RoleaccessesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Roleaccesses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Roleaccess>>> GetRoleaccess()
        {
          if (_context.Roleaccess == null)
          {
              return NotFound();
          }
            return await _context.Roleaccess.ToListAsync();
        }

        // GET: api/Roleaccesses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Roleaccess>> GetRoleaccess(int id)
        {
          if (_context.Roleaccess == null)
          {
              return NotFound();
          }
            var roleaccess = await _context.Roleaccess.FindAsync(id);

            if (roleaccess == null)
            {
                return NotFound();
            }

            return roleaccess;
        }

        // PUT: api/Roleaccesses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoleaccess(int id, Roleaccess roleaccess)
        {
            if (id != roleaccess.Id)
            {
                return BadRequest();
            }

            _context.Entry(roleaccess).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoleaccessExists(id))
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

        // POST: api/Roleaccesses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Roleaccess>> PostRoleaccess(Roleaccess roleaccess)
        {
          if (_context.Roleaccess == null)
          {
              return Problem("Entity set 'DataContext.Roleaccess'  is null.");
          }
            _context.Roleaccess.Add(roleaccess);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRoleaccess", new { id = roleaccess.Id }, roleaccess);
        }

        // DELETE: api/Roleaccesses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoleaccess(int id)
        {
            if (_context.Roleaccess == null)
            {
                return NotFound();
            }
            var roleaccess = await _context.Roleaccess.FindAsync(id);
            if (roleaccess == null)
            {
                return NotFound();
            }

            _context.Roleaccess.Remove(roleaccess);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RoleaccessExists(int id)
        {
            return (_context.Roleaccess?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

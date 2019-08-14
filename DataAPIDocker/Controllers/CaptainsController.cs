using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataAPIDocker;
using DataAPIDocker.Models;

namespace DataAPIDocker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaptainsController : ControllerBase
    {
        private readonly CaptainContext _context;

        public CaptainsController(CaptainContext context)
        {
            _context = context;
        }

        // GET: api/Captains
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Captain>>> GetCaptain()
        {
            return await _context.Captains.ToListAsync();
        }

        // GET: api/Captains/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Captain>> GetCaptain(int id)
        {
            var captain = await _context.Captains.FindAsync(id);

            if (captain == null)
            {
                return NotFound();
            }

            return captain;
        }

        // PUT: api/Captains/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCaptain(int id, Captain captain)
        {
            if (id != captain.CaptainId)
            {
                return BadRequest();
            }

            _context.Entry(captain).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CaptainExists(id))
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

        // POST: api/Captains
        [HttpPost]
        public async Task<ActionResult<Captain>> PostCaptain(Captain captain)
        {
            _context.Captains.Add(captain);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCaptain", new { id = captain.CaptainId }, captain);
        }

        // DELETE: api/Captain/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Captain>> DeleteCaptain(int id)
        {
            var captain = await _context.Captains.FindAsync(id);
            if (captain == null)
            {
                return NotFound();
            }

            _context.Captains.Remove(captain);
            await _context.SaveChangesAsync();

            return captain;
        }

        private bool CaptainExists(int id)
        {
            return _context.Captains.Any(e => e.CaptainId == id);
        }
    }
}

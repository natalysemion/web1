using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using C5.Models;

namespace C5.Contollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistEventsController : ControllerBase
    {
        private readonly ApplicationAPIContext _context;

        public ArtistEventsController(ApplicationAPIContext context)
        {
            _context = context;
        }

        // GET: api/ArtistEvents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArtistEvent>>> GetArtistEvent()
        {
          if (_context.ArtistEvent == null)
          {
              return NotFound();
          }
            return await _context.ArtistEvent.ToListAsync();
        }

        // GET: api/ArtistEvents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ArtistEvent>> GetArtistEvent(int id)
        {
          if (_context.ArtistEvent == null)
          {
              return NotFound();
          }
            var artistEvent = await _context.ArtistEvent.FindAsync(id);

            if (artistEvent == null)
            {
                return NotFound();
            }

            return artistEvent;
        }

        // PUT: api/ArtistEvents/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArtistEvent(int id, ArtistEvent artistEvent)
        {
            if (id != artistEvent.Id)
            {
                return BadRequest();
            }

            _context.Entry(artistEvent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArtistEventExists(id))
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

        // POST: api/ArtistEvents
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ArtistEvent>> PostArtistEvent(ArtistEvent artistEvent)
        {
          if (_context.ArtistEvent == null)
          {
              return Problem("Entity set 'ApplicationAPIContext.ArtistEvent'  is null.");
          }
            _context.ArtistEvent.Add(artistEvent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArtistEvent", new { id = artistEvent.Id }, artistEvent);
        }

        // DELETE: api/ArtistEvents/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArtistEvent(int id)
        {
            if (_context.ArtistEvent == null)
            {
                return NotFound();
            }
            var artistEvent = await _context.ArtistEvent.FindAsync(id);
            if (artistEvent == null)
            {
                return NotFound();
            }

            _context.ArtistEvent.Remove(artistEvent);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ArtistEventExists(int id)
        {
            return (_context.ArtistEvent?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

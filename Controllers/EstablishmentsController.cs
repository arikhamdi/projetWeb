using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projetWeb.Models;

namespace projetWeb.Controllers
{
    [Route("api/Establishments")]
    [ApiController]
    public class EstablishmentsController : ControllerBase
    {
        private readonly EstablishmentContext _context;

        public EstablishmentsController(EstablishmentContext context)
        {
            _context = context;
        }

        // GET: api/Establishments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Establishment>>> GetEstablishments()
        {
            return await _context.Establishments.ToListAsync();
        }

        // GET: api/Establishments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Establishment>> GetEstablishment(long id)
        {
            var establishment = await _context.Establishments.FindAsync(id);

            if (establishment == null)
            {
                return NotFound();
            }

            return establishment;
        }

        // PUT: api/Establishments/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstablishment(long id, Establishment establishment)
        {
            if (id != establishment.ID)
            {
                return BadRequest();
            }

            _context.Entry(establishment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstablishmentExists(id))
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

        // POST: api/Establishments
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Establishment>> PostEstablishment(Establishment establishment)
        {
            _context.Establishments.Add(establishment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEstablishment", new { id = establishment.ID }, establishment);
            // return CreatedAtAction(nameof(GetEstablishment), new {id = establishment.ID, establishment});
        }

        // DELETE: api/Establishments/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Establishment>> DeleteEstablishment(long id)
        {
            var establishment = await _context.Establishments.FindAsync(id);
            if (establishment == null)
            {
                return NotFound();
            }

            _context.Establishments.Remove(establishment);
            await _context.SaveChangesAsync();

            return establishment;
        }

        private bool EstablishmentExists(long id)
        {
            return _context.Establishments.Any(e => e.ID == id);
        }
    }
}

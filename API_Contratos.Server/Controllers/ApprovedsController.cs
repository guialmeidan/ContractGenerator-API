using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_Contratos.Server.DataAccess;
using API_Contratos.Shared.Models;

namespace API_Contratos.Server.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ApprovedsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ApprovedsController(AppDbContext context)
        {
            _context = context;
        }

        //// GET: api/Approveds
        //[HttpGet]
        //public IEnumerable<Approveds> GetApproveds()
        //{
        //    return _context.Approveds;
        //}

        //// GET: api/Approveds/5
        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetApproveds([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var approveds = await _context.Approveds.FindAsync(id);

        //    if (approveds == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(approveds);
        //}

        //// PUT: api/Approveds/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutApproveds([FromRoute] int id, [FromBody] Approveds approveds)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != approveds.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(approveds).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ApprovedsExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/Approveds
        [HttpPost]
        public async Task<IActionResult> PostApproveds([FromBody] Approveds approveds)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Approveds.Add(approveds);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetApproveds", new { id = approveds.Id }, approveds);
        }

        //// DELETE: api/Approveds/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteApproveds([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var approveds = await _context.Approveds.FindAsync(id);
        //    if (approveds == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Approveds.Remove(approveds);
        //    await _context.SaveChangesAsync();

        //    return Ok(approveds);
        //}

        private bool ApprovedsExists(int id)
        {
            return _context.Approveds.Any(e => e.Id == id);
        }
    }
}
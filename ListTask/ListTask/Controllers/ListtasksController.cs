using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ListTask.Models;

namespace ListTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListtasksController : ControllerBase
    {
        private readonly ListContext _context;

        public ListtasksController(ListContext context)
        {
            _context = context;
        }

        // GET: api/Listtasks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Listtask>>> GetListtask()
        {
            return await _context.Listtask.ToListAsync();
        }

        // GET: api/Listtasks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Listtask>> GetListtask(long id)
        {
            var listtask = await _context.Listtask.FindAsync(id);

            if (listtask == null)
            {
                return NotFound();
            }

            return listtask;
        }

        // PUT: api/Listtasks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutListtask(long id, Listtask listtask)
        {
            if (id != listtask.Id)
            {
                return BadRequest();
            }

            _context.Entry(listtask).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ListtaskExists(id))
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

        // POST: api/Listtasks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Listtask>> PostListtask(Listtask listtask)
        {
            _context.Listtask.Add(listtask);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetListtask", new { id = listtask.Id }, listtask);
        }

        // DELETE: api/Listtasks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteListtask(long id)
        {
            var listtask = await _context.Listtask.FindAsync(id);
            if (listtask == null)
            {
                return NotFound();
            }

            _context.Listtask.Remove(listtask);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ListtaskExists(long id)
        {
            return _context.Listtask.Any(e => e.Id == id);
        }
    }
}

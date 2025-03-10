﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlogFullStack.Server.Data;
using BlogFullStack.Server.Models;
using Microsoft.AspNetCore.Authorization;

namespace BlogFullStack.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DynamicContentsController : ControllerBase
    {
        private readonly BlogFullStackServerContext _context;

        public DynamicContentsController(BlogFullStackServerContext context)
        {
            _context = context;
        }

        // GET: api/DynamicContents
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<DynamicContent>>> GetDynamicContent()
        {
            return await _context.DynamicContent.ToListAsync();
        }

        // GET: api/DynamicContents/5
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<DynamicContent>> GetDynamicContent(int id)
        {
            var dynamicContent = await _context.DynamicContent.FindAsync(id);

            if (dynamicContent == null)
            {
                return NotFound();
            }

            return dynamicContent;
        }

        // PUT: api/DynamicContents/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDynamicContent(int id, DynamicContent dynamicContent)
        {
            if (id != dynamicContent.DynamicContentID)
            {
                return BadRequest();
            }

            _context.Entry(dynamicContent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DynamicContentExists(id))
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

        // POST: api/DynamicContents
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DynamicContent>> PostDynamicContent(DynamicContent dynamicContent)
        {
            _context.DynamicContent.Add(dynamicContent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDynamicContent", new { id = dynamicContent.DynamicContentID }, dynamicContent);
        }

        // DELETE: api/DynamicContents/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDynamicContent(int id)
        {
            var dynamicContent = await _context.DynamicContent.FindAsync(id);
            if (dynamicContent == null)
            {
                return NotFound();
            }

            _context.DynamicContent.Remove(dynamicContent);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DynamicContentExists(int id)
        {
            return _context.DynamicContent.Any(e => e.DynamicContentID == id);
        }
    }
}

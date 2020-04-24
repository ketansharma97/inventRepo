using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Invent.Models;
using Microsoft.AspNetCore.Cors;

namespace Invent.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]

    public class ShopkeepersController : ControllerBase
    
    {
        private readonly InventDbContext _context;
        //private readonly Shopkeeper _shopkeeper;

        public ShopkeepersController(InventDbContext context)
        {
            _context = context;
            //_shopkeeper = shopkeeper;
        }

        // GET: api/Shopkeepers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Shopkeeper>>> GetShopkeeper()
        {
            return await _context.Shopkeeper.ToListAsync();
        }

        // GET: api/Shopkeepers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Shopkeeper>> GetShopkeeper(int id)
        {
            var shopkeeper = await _context.Shopkeeper.FindAsync(id);

            if (shopkeeper == null)
            {
                return NotFound();
            }

            return shopkeeper;
        }

        // PUT: api/Shopkeepers/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShopkeeper(int id, Shopkeeper shopkeeper)
        {
            if (id != shopkeeper.ProductId)
            {
                return BadRequest();
            }

            _context.Entry(shopkeeper).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShopkeeperExists(id))
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

        // POST: api/Shopkeepers
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Shopkeeper>> PostShopkeeper(Shopkeeper shopkeeper)
        {
            _context.Shopkeeper.Add(shopkeeper);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetShopkeeper", new { id = shopkeeper.ProductId }, shopkeeper);
        }

        // DELETE: api/Shopkeepers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Shopkeeper>> DeleteShopkeeper(int id)
        {
            var shopkeeper = await _context.Shopkeeper.FindAsync(id);
            if (shopkeeper == null)
            {
                return NotFound();
            }

            _context.Shopkeeper.Remove(shopkeeper);
            await _context.SaveChangesAsync();

            return shopkeeper;
        }

        private bool ShopkeeperExists(int id)
        {
            return _context.Shopkeeper.Any(e => e.ProductId == id);
        }

    }
}

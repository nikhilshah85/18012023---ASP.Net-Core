using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using demo_webAPIService_MVC.Models.EF;

namespace demo_webAPIService_MVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class productsController : ControllerBase
    {
        private readonly ShoppingDbMvcContext _context;

        public productsController(ShoppingDbMvcContext context)
        {
            _context = context;
        }

        // GET: api/products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDetail>>> GetProductDetails()
        {
          if (_context.ProductDetails == null)
          {
              return NotFound();
          }
            return await _context.ProductDetails.ToListAsync();
        }

        // GET: api/products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDetail>> GetProductDetail(int id)
        {
          if (_context.ProductDetails == null)
          {
              return NotFound();
          }
            var productDetail = await _context.ProductDetails.FindAsync(id);

            if (productDetail == null)
            {
                return NotFound();
            }

            return productDetail;
        }

        // PUT: api/products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductDetail(int id, ProductDetail productDetail)
        {
            if (id != productDetail.PId)
            {
                return BadRequest();
            }

            _context.Entry(productDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductDetailExists(id))
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

        // POST: api/products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductDetail>> PostProductDetail(ProductDetail productDetail)
        {
          if (_context.ProductDetails == null)
          {
              return Problem("Entity set 'ShoppingDbMvcContext.ProductDetails'  is null.");
          }
            _context.ProductDetails.Add(productDetail);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProductDetailExists(productDetail.PId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProductDetail", new { id = productDetail.PId }, productDetail);
        }

        // DELETE: api/products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductDetail(int id)
        {
            if (_context.ProductDetails == null)
            {
                return NotFound();
            }
            var productDetail = await _context.ProductDetails.FindAsync(id);
            if (productDetail == null)
            {
                return NotFound();
            }

            _context.ProductDetails.Remove(productDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductDetailExists(int id)
        {
            return (_context.ProductDetails?.Any(e => e.PId == id)).GetValueOrDefault();
        }
    }
}

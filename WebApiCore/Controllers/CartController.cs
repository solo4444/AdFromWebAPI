using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCore.Models;

namespace WebApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly Context _context;

        public CartController(Context context)
        {
            _context = context;
        }
        // GET: api/Cart
        [HttpGet]
        public async Task<double> GetCart()
        {
            Cart cart = new Cart();
            List<Item> items = await _context.Items.ToListAsync();
            cart.get_cart_sum(items);
            return cart.cartCost;
        }
    }
}

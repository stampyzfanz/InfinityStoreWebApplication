using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using InfinityWebApplication.Data;
using InfinityWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace InfinityWebApplication.Controllers
{
    [Produces("application/json")]
    [Route("api/StoreLocations")]
    public class StoreLocationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StoreLocationController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/StoreLocations
        [HttpGet]
        public async Task<List<Store>> Get()
        {
            var stores = await _context.Stores.ToListAsync();
            return stores;
        }
    }
}
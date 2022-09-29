using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InfinityWebApplication.Models;
using InfinityWebApplication.Data;

namespace InfinityWebApplication.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DetailsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Product? Product { get; set; }
        public List<string> ImageUrls { get; set; } = new List<string>();
        public List<Store> Stores { get; set; } = new List<Store>();
        // Get the amount of products in the store with the store's title being the key
        public Dictionary<string, int> StoreToStock { get; set; } = new Dictionary<string, int>();

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id is null)
            {
                return NotFound();
            }

            Product = await _context.Products
                .Include(p => p.Images)
                .Include(p => p.Attributes)
                .FirstOrDefaultAsync(p => p.ProductId == id);

            if (Product is null)
            {
                return NotFound();
            }

            Stores = await _context.Stores
                .Include(s => s.ProductStockList.Where(ps => ps.ProductId == id))
                .ToListAsync();

            foreach (Store store in Stores)
            {
                StoreToStock.Add(store.Title, store.ProductStockList![0].Quantity);
            }

            foreach (var image in Product.Images)
            {
                string imageBase64Data = Convert.ToBase64String(image.ImageData);
                string imageDataURL = string.Format("data:image/jpeg;base64,{0}", imageBase64Data);
                ImageUrls.Add(imageDataURL);
            }

            return Page();
        }
    }
}

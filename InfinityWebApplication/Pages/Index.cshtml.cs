using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InfinityWebApplication.Data;
using InfinityWebApplication.Models;

namespace InfinityWebApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Product> Products { get; set; } = null!;
        public List<string> ImageUrls { get; set; } = new List<string>();

        public async Task OnGetAsync()
        {
            Products = await _context.Products
                .Include(p => p.Images)
                .ToListAsync();

            // Populate ImageUrl list by converting the bytes to a blob that browsers can parse
            foreach (Product product in Products)
            {
                string imageBase64Data = Convert.ToBase64String(product.Images[0].ImageData);
                string imageDataURL = string.Format("data:image/jpeg;base64,{0}", imageBase64Data);
                ImageUrls.Add(imageDataURL);
            }
        }
    }
}

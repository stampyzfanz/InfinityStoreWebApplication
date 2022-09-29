using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InfinityWebApplication.Models;
using InfinityWebApplication.Data;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Globalization;

namespace InfinityWebApplication.Pages
{
    public class FinancialReportModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Store> Stores { get; set; } = new List<Store>();
        public string TotalRevenueDisplay { get; set; } = null!;
        public string TotalCostDisplay { get; set; } = null!;
        public string TotalProfitDisplay { get; set; } = null!;
        public string TotalProductsDisplay { get; set; } = null!;
        public string? Product { get; set; }
        public string? Store { get; set; }
        public DateTime? StartTimestamp { get; set; }
        public DateTime? EndTimestamp { get; set; }
        private readonly ApplicationDbContext _context;

        public FinancialReportModel(ILogger<IndexModel> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(string? product, string? store, DateTime? startTimestamp, DateTime? endTimestamp, string password)
        {
            if (password != "correcthorsebatterystaple")
            {
                return NotFound();
            }

            Product = product;
            Store = store;
            StartTimestamp = startTimestamp;
            EndTimestamp = endTimestamp;
            // startTimestamp and endTimestamp are just dates so far, but they are DateTime objects
            // So ensure that one is at the start of the day and the other is the end of the day
            // so that it can find orders that occured on a single day.
            if (endTimestamp != null)
            {
                TimeSpan ts = new TimeSpan(23, 59, 59);
                endTimestamp = endTimestamp + ts;
            }


            // todo if authenticated
            Products = await _context.Products.ToListAsync();
            Stores = await _context.Stores.ToListAsync();

            List<Order> orders = await _context.Orders.ToListAsync();
            List<ProductOrder> productOrders = await _context.ProductOrders.ToListAsync();

            // Since EF Core is very inefficient when using .Include with lots of records
            // and navigation properties, manually create a dictionary to link between
            // product orders and their parent order.
            Dictionary<int, Order> orderDict = new Dictionary<int, Order>();

            foreach (Order order in orders)
            {
                orderDict.Add(order.OrderId, order);
            }

            decimal totalCost = 0;
            decimal totalRevenue = 0;
            int totalProducts = 0;
            foreach (ProductOrder productOrder in productOrders)
            {
                Order order = orderDict[productOrder.OrderId];
                if (product != null && productOrder.Product!.Name != product)
                {
                    continue;
                }
                else if (store != null && order.Store!.Title != store)
                {
                    continue;
                }
                else if (startTimestamp != null && order.Timestamp < startTimestamp)
                {
                    continue;
                }
                else if (endTimestamp != null && order.Timestamp > endTimestamp)
                {
                    continue;
                }

                totalCost += productOrder.Product!.PurchasePrice * productOrder.Quantity;
                totalRevenue += productOrder.Product.SalePrice * productOrder.Quantity;
                totalProducts += productOrder.Quantity;
            }

            TotalCostDisplay = totalCost.ToString("C", new CultureInfo("en-AU"));
            TotalRevenueDisplay = totalRevenue.ToString("C", new CultureInfo("en-AU"));
            TotalProfitDisplay = (totalRevenue - totalCost).ToString("C", new CultureInfo("en-AU"));
            TotalProductsDisplay = totalProducts.ToString() + (totalProducts == 1 ? " product" : " products");

            return Page();
        }
    }
}

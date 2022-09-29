using System;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using InfinityWebApplication.Models;
using InfinityWebApplication.Data;
using Microsoft.EntityFrameworkCore;


namespace InfinityWebApplication.Controllers
{
    [Produces("application/json")]
    [Route("api/purchaseProduct")]
    public class PurchaseProductController : Controller
    {
        private readonly ILogger<PurchaseProductController> _logger;
        private readonly ApplicationDbContext _context;

        public PurchaseProductController(ILogger<PurchaseProductController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public class ProductOrderRequest
        {
            public int ProductId { get; set; }
            public string? StoreTitle { get; set; }
            public int Quantity { get; set; }
            public string? PaymentInfo { get; set; }
        }

        private bool isPaymentInfoValid(string? PaymentDetails)
        {
            // Stub is here
            return true;
        }

        // POST: api/purchaseProduct
        [HttpPost]
        public async Task<string> Post([FromBody] ProductOrderRequest request)
        {
            // Validate parameters. Note that isPaymentDetailsValid is an implemented stub
            if (!isPaymentInfoValid(request.PaymentInfo))
            {
                return "Incorrect payment details";
            }
            else if (request.Quantity <= 0 || request.StoreTitle is null)
            {
                return "Invalid parameters";
            }
            Store? store = await _context.Stores.FirstOrDefaultAsync(s => s.Title == request.StoreTitle);
            Product? product = await _context.Products.FirstOrDefaultAsync(p => p.ProductId == request.ProductId);

            // Ensure that the store and the products are both valid
            // serverside validation is needed as well as client side validation
            // in case a malicious party abuses the API.
            if (store is null || product is null)
            {
                return "Store title is incorrect";
            }
            else if (product is null)
            {
                return "Product Id is incorrect";
            }

            ProductStock productStock = await _context.ProductStockSet.FirstOrDefaultAsync(
                ps => ps.StoreId == store.StoreId && ps.ProductId == request.ProductId
            );

            if (productStock.Quantity < request.Quantity)
            {
                return "Sorry this store doesn't have this product in stock.";
            }

            productStock.Quantity -= request.Quantity;
            _context.SaveChanges();

            Order order = new Order
            {
                Timestamp = DateTime.Now,
                StoreId = store.StoreId
            };

            _context.Orders.Add(order);
            _context.SaveChanges();

            // Note that the OrderId is automatically added to the order pointer
            // when it is added to the Orders DbSet and is saved
            ProductOrder productOrder = new ProductOrder
            {
                OrderId = order.OrderId,
                ProductId = request.ProductId,
                Quantity = request.Quantity
            };
            _context.ProductOrders.Add(productOrder);
            _context.SaveChanges();

            return "Success. Remaining stock is " + productStock.Quantity.ToString() + " items.";
        }
    }
}
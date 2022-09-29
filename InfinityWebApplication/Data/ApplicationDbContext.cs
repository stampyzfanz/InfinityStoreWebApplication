using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using InfinityWebApplication.Models;
using System.Text.Json;
using System.Linq;
using System.Threading.Tasks;
using InfinityWebApplication.Util;

namespace InfinityWebApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        private readonly RandomUtil _randomUtil;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            _randomUtil = new RandomUtil();
        }
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Attributes> AttributesSet { get; set; } = null!;
        public DbSet<Store> Stores { get; set; } = null!;
        public DbSet<ProductStock> ProductStockSet { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<ProductOrder> ProductOrders { get; set; } = null!;
        public DbSet<Image> Images { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // If it doesn't contain data, seed it with data from the JSON file.
            base.OnModelCreating(modelBuilder);

            string file = System.IO.File.ReadAllText("SeedData/stores.json");
            var stores = JsonSerializer.Deserialize<List<Store>>(file)!;
            modelBuilder.Entity<Store>().HasData(stores);

            file = System.IO.File.ReadAllText("SeedData/products.json");
            var products = JsonSerializer.Deserialize<List<Product>>(file)!;
            modelBuilder.Entity<Product>().HasData(products);

            file = System.IO.File.ReadAllText("SeedData/attributes.json");
            var attributes = JsonSerializer.Deserialize<List<Attributes>>(file)!;
            modelBuilder.Entity<Attributes>().HasData(attributes);
        }


        public async Task SeedLargeData()
        {
            // Seeds large binary data, as reccomended by Microsoft https://docs.microsoft.com/en-us/ef/core/modeling/data-seeding
            // Note: In production this would not run, but Mr Nichols needs to initialise his database the first time.
            this.Database.EnsureCreated();

            var containsImages = this.Images.FirstOrDefault() != null;
            if (!containsImages)
            {
                string file = System.IO.File.ReadAllText("SeedData/images.json");
                var images = JsonSerializer.Deserialize<List<Image>>(file)!;
                this.Images.AddRange(images);
                this.SaveChanges();
            }

            var containsOrders = this.Orders.FirstOrDefault() != null;
            if (!containsOrders)
            {
                string file = System.IO.File.ReadAllText("SeedData/orders.json");
                var orders = JsonSerializer.Deserialize<List<Order>>(file)!;
                this.Orders.AddRange(orders);
                this.SaveChanges();
            }

            var containsProductOrders = this.ProductOrders.FirstOrDefault() != null;
            if (!containsProductOrders)
            {
                string file = System.IO.File.ReadAllText("SeedData/productOrders.json");
                var productOrders = JsonSerializer.Deserialize<List<ProductOrder>>(file)!;
                this.ProductOrders.AddRange(productOrders);
                this.SaveChanges();
            }

            bool updatedStoresList = false;

            // Check to see if every store and product has a ProductStock, and if not create one randomly.
            // For each store and each product, there is a 30 chance that it doesn't contain the item.
            // Otherwise, give it a normally distributed random number
            // between 1 and 200 where the median is approximately 15.
            List<Store> stores = await this.Stores.ToListAsync();
            List<Product> products = await this.Products.ToListAsync();
            foreach (Store store in stores)
            {
                // Get all of the store's productStock
                List<int> storeProductStockList = await this.ProductStockSet
                    .Where(ps => ps.StoreId == store.StoreId)
                    .Select(ps => ps.ProductId)
                    .ToListAsync();

                var storeProductStockSet = new HashSet<int>(storeProductStockList);

                foreach (Product product in products)
                {
                    // If the current product and store is not present in the database, create it
                    if (!storeProductStockSet.Contains(product.ProductId))
                    {
                        int Quantity = _randomUtil.DoesEventOccur(0.3)
                            ? (int)Math.Round(_randomUtil.GetRandomGuassian(2, 200, 5))
                            : 1;

                        var productStock = new ProductStock
                        {
                            StoreId = store.StoreId,
                            ProductId = product.ProductId,
                            Quantity = Quantity
                        };
                        this.ProductStockSet.Add(productStock);
                        updatedStoresList = true;
                    }
                }
            }

            if (updatedStoresList)
            {
                this.SaveChanges();
            }
        }
    }
}

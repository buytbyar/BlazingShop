using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public void LoadProducts()
        {
            Products = new List<Product> {
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "The Hitchhiker's Guide to the Galazy",
                    Description = "The Hitchhiker's Guide to the Galazy (sometimes referred to as HG2G, HHGTTG, H2G2, or tHGttG) is a comedy science fiction series",
                    Image = "https://via.placeholder.com/300x300",
                    Price = 9.99m,
                    OriginalPrice = 19.99m,
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    Title = "Car Showroom",
                    Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by value.",
                    Image = "https://images.unsplash.com/photo-1602851247180-925b9cf6c5a2?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1834&q=80",
                    Price = 8.19m,
                    OriginalPrice = 29.99m,
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 1,
                    Title = "Top Dancer",
                    Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by value.",
                    Image = "https://via.placeholder.com/300x300",
                    Price = 8.19m,
                    OriginalPrice = 29.99m,
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 2,
                    Title = "The Hitchhiker's Guide to the Galazy",
                    Description = "The Hitchhiker's Guide to the Galazy (sometimes referred to as HG2G, HHGTTG, H2G2, or tHGttG) is a comedy science fiction series",
                    Image = "https://images.unsplash.com/photo-1582719202047-76d3432ee323?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1834&q=80",
                    Price = 9.99m,
                    OriginalPrice = 19.99m,
                },
                new Product
                {
                    Id = 5,
                    CategoryId = 2,
                    Title = "Old Car",
                    Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by value.",
                    Image = "https://images.unsplash.com/photo-1602851247180-925b9cf6c5a2?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1834&q=80",
                    Price = 8.19m,
                    OriginalPrice = 29.99m,
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 2,
                    Title = "Dancing Tonament",
                    Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by value.",
                    Image = "https://images.unsplash.com/photo-1590803246097-7be47831ab35?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1833&q=80",
                    Price = 8.19m,
                    OriginalPrice = 29.99m,
                },
                new Product
                {
                    Id = 7,
                    CategoryId = 3,
                    Title = "The Hitchhiker's Guide to the Galazy",
                    Description = "The Hitchhiker's Guide to the Galazy (sometimes referred to as HG2G, HHGTTG, H2G2, or tHGttG) is a comedy science fiction series",
                    Image = "https://images.unsplash.com/photo-1582719202047-76d3432ee323?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1834&q=80",
                    Price = 9.99m,
                    OriginalPrice = 19.99m,
                },
                new Product
                {
                    Id = 8,
                    CategoryId = 3,
                    Title = "Forest And Car",
                    Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by value.",
                    Image = "https://images.unsplash.com/photo-1602851247180-925b9cf6c5a2?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1834&q=80",
                    Price = 8.19m,
                    OriginalPrice = 29.99m,
                },
                new Product
                {
                    Id = 9,
                    CategoryId = 3,
                    Title = "Pratic Dancing",
                    Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by value.",
                    Image = "https://images.unsplash.com/photo-1590803246097-7be47831ab35?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1833&q=80",
                    Price = 8.19m,
                    OriginalPrice = 29.99m,
                },
            };
        }
    }
}

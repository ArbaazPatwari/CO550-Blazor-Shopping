using BlazorServerApp.Models;
using System.Collections.Immutable;

namespace BlazorServerApp.Services
{
    public class ProductService
    {
        public static readonly List<Product> Products = new List<Product>()
        {
            new()
            {
                Id = 1,
                Name = "Toshiba SMR+ HDD 22",
                Description = "New 4TB HDD for 2022 by Toshiba.",
                Price = 89.99
            },
            new()
            {
                Id = 2,
                Name = "Seagate MiniCuda HDD",
                Description = "New 1TB HDD for 2022 by Seagate.",
                Price = 65.00
            },
            new()
            {
                Id = 3,
                Name = "Western Digital Box HDD",
                Description = "New 2TB HDD for 2022 by Western Digital.",
                Price = 70.00
            },
            new()
            {
                Id = 4,
                Name = "Kingston Voyager SSD",
                Description = "New 1TB SSD for 2022 by Kingston.",
                Price = 95.00
            },
            new()
            {
                Id = 5,
                Name = "Samsung Nebula SDD 22",
                Description = "New 1TB SDD for 2022 by Samsung.",
                Price = 99.99
            }

        };
    }
}

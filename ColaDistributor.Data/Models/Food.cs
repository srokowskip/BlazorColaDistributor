using ColaDistributor.Data.Enums;
using ColaDistributor.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColaDistributor.Data.Models
{
    public class Food : IProduct
    {
        public string Name { get; set; }
        public int Quantity { get; set ; }
        public decimal Price { get; set; }

        public ProductType Type => ProductType.Food;

        public Guid Id { get; } = Guid.NewGuid();
    }
}

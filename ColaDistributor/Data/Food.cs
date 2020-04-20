using ColaDistributor.Enums;
using ColaDistributor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColaDistributor.Data
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

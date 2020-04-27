using ColaDistributor.Data.Enums;
using ColaDistributor.Data.Interfaces;
using System;

namespace ColaDistributor.Data
{
    public class Drink : IProduct
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public ProductType Type => ProductType.Drink;

        public Guid Id { get; } = Guid.NewGuid();

    }
}
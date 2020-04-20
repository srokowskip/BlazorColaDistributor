using System;
using ColaDistributor.Enums;
using ColaDistributor.Interfaces;

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
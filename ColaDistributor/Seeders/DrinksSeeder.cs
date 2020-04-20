using ColaDistributor.Data;
using ColaDistributor.Enums;
using ColaDistributor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColaDistributor.Seeders
{
    public class DrinksSeeder : IProductsSeeder
    {
        public List<IProduct> InitialProducts => new List<IProduct>()
        {
            new Drink()
            {
                Name = "Coca Cola",
                Quantity = 5,
                Price = 2.5m,
            },
             new Drink()
            {
                Name = "Pepsi",
                Quantity = 10,
                Price = 2.2m
            },
        };


        List<IProduct> IProductsSeeder.GetProducts()
        {
            return InitialProducts;
        }
    }
}

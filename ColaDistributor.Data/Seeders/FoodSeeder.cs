using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ColaDistributor.Data;
using ColaDistributor.Data.Interfaces;
using ColaDistributor.Data.Models;

namespace ColaDistributor.Data.Seeders
{
    public class FoodSeeder : IProductsSeeder
    {
        public List<IProduct> GetProducts()
        {
            return new List<IProduct>() {
             new Food(){Name="Mars", Quantity = 5, Price= 2.5m }, new Food(){Name="Lays", Quantity=2, Price= 3}
            };
        }
    }
}

﻿using ColaDistributor.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColaDistributor.Data.Interfaces
{
   public interface IProduct
    {
        Guid Id { get;}
        string Name { get; set; }
        int Quantity { get; set; }
        decimal Price { get; set; }
        ProductType Type { get; }
    }
}

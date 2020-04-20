using ColaDistributor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColaDistributor.Data
{
    public class Machine : IMachine
    {
        List<IProduct> IMachine.Products { get; set; } = new List<IProduct>();
        List<IMoney> IMachine.MoneyInMachine { get; set; } = new List<IMoney>();
    }
}

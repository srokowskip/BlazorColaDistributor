using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColaDistributor.Interfaces
{
   public interface IMachine
    {
        List<IProduct> Products { get; set; }
        List<IMoney> MoneyInMachine { get; set; }
    }
}

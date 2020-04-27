using ColaDistributor.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColaDistributor.Data.NewFolder
{
    public class Fifty : IMoney
    {
        public decimal Value => 0.5m;

        public string Name => "50gr";
    }
}

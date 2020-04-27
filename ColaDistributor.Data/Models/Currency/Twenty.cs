using ColaDistributor.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColaDistributor.Data.NewFolder
{
    public class Twenty : IMoney
    {
        public decimal Value => 0.2m;

        public string Name => "20gr";
    }
}

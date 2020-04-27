using ColaDistributor.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColaDistributor.Data.NewFolder
{
    public class Ten : IMoney
    {
        public decimal Value => 0.10m;

        public string Name => "10gr";
    }
}

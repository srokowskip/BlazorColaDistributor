using ColaDistributor.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColaDistributor.Data.NewFolder
{
    public class FiveHundred : IMoney
    {
        public decimal Value => 5m;

        public string Name => "5zł";
    }
}

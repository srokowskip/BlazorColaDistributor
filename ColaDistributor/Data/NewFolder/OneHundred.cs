using ColaDistributor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColaDistributor.Data.NewFolder
{
    public class OneHundred : IMoney
    {
        public decimal Value => 1m;

        public string Name => "1zł";
    }
}

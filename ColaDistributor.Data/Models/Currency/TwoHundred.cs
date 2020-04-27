using ColaDistributor.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColaDistributor.Data.NewFolder
{
    public class TwoHundred : IMoney
    {
        public decimal Value => 2m;

        public string Name => "2zł";
    }
}

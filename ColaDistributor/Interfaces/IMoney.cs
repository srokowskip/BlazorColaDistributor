using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColaDistributor.Interfaces
{
    public interface IMoney
    {
        string Name { get; }
        decimal Value { get; }
    }
}

using ColaDistributor.Data;using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColaDistributor.Interfaces
{
    public interface IProductsSeeder
    {
        List<IProduct> GetProducts();
    }
}

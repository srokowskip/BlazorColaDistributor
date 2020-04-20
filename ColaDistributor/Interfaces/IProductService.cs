using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColaDistributor.Interfaces
{
   public interface IProductService
    {
        void FillWithProduct(List<IProduct> products);
        List<IProduct> GetProducts();
        (bool, string, List<IMoney> change) BuyProduct(Guid productId);
    }
}

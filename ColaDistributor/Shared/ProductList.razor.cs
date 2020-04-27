using ColaDistributor.Data.Interfaces;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColaDistributor.Shared
{
    public class ProductListBase : ComponentBase
    {
        [Parameter]
        public List<IProduct> ListOfProducts { get; set; }

        [Parameter]
        public RenderFragment NullTemplate { get; set; }

        [Parameter]
        public RenderFragment EmptyTemplate { get; set; }

        [Inject]
        private IProductService productService { get; set; }

        public void OnBuy(IProduct product)
        {
            //proper messages here cascading values
            var result = productService.BuyProduct(product.Id);
        }
    }
}

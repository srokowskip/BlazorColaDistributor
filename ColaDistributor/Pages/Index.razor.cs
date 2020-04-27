using ColaDistributor.Data.Interfaces;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColaDistributor.Pages
{
    public class IndexBase : ComponentBase
    {
        [Inject]
        protected IProductService ProductService { get; set; }
        
        protected List<IProduct> products;

        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(2000);
            products = ProductService.GetProducts();
        }
        protected void Buy(IProduct product)
        {
            Console.WriteLine(product);
        }

    }
}

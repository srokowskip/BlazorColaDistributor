
using ColaDistributor.Interfaces;
using ColaDistributor.Seeders;
using ColaDistributor.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColaDistributor.Extensions
{
    public static class HostBuilderExtensions
    {
        public static IHost FillMachine(this IHost host)
        {
            IServiceScopeFactory serviceScopeFactory = (IServiceScopeFactory)host.Services.GetService(typeof(IServiceScopeFactory));
            using (var scope = serviceScopeFactory.CreateScope())
            {
                IMachine machine = scope.ServiceProvider.GetService<IMachine>();
                List<IProductsSeeder> productsSeeders = scope.ServiceProvider.GetServices<IProductsSeeder>().ToList();
                foreach (var seeder in productsSeeders)
                {
                    machine.Products.AddRange(seeder.GetProducts());
                }

            }

            return host;
        }
    }
}

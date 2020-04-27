using ColaDistributor.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ColaDistributor.Data.Services
{
    public class ProductsService : IProductService
    {
        private readonly IMachine machine;
        private readonly IMoneyService moneyService;
        public ProductsService(IMachine machine, IMoneyService moneyService)
        {
            this.machine = machine;
            this.moneyService = moneyService;
        }
        public void FillWithProduct(List<IProduct> products)
        {
            machine.Products.AddRange(products);
        }

        public List<IProduct> GetProducts() => machine.Products;

        public (bool, string, List<IMoney>) BuyProduct(Guid productId)
        {
            var product = machine.Products.Where(p => p.Id == productId).FirstOrDefault();

            if (product == null)
                return (false, "No such product", null);

            var machineBalance = moneyService.GetMachineBalance();

            if (product.Price > machineBalance)
                return (false, "Not enough money", null);

            var change = CalculateChange(machineBalance - product.Price);
            machine.MoneyInMachine.Clear();
            return (true, $"{product.Name} bought!", change);
        }

        private List<IMoney> CalculateChange(decimal toChange)
        {
            var supportedMoney = moneyService.GetListOfSupportedMoney().OrderByDescending(m => m.Value);
            var change = new List<IMoney>();


            while (toChange > 0)
            {
                foreach (var money in supportedMoney)
                {
                    if (toChange < money.Value)
                        continue;

                    int howManyMoneyInChange = Convert.ToInt32(Math.Floor(toChange / money.Value));

                    for (int i = 0; i < howManyMoneyInChange; i++)
                    {
                        change.Add(money);
                    }

                    toChange -= money.Value * howManyMoneyInChange;

                }
            }
            return change;
        }
    }
}

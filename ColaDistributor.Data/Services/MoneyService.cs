using ColaDistributor.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColaDistributor.Data.Services
{
    public class MoneyService : IMoneyService
    {
        private readonly IMachine _machine;
        public MoneyService(IMachine machine)
        {
            _machine = machine;
        }

        public List<IMoney> GetListOfSupportedMoney()
        {
            var type = typeof(IMoney);
            var types = AppDomain.CurrentDomain.GetAssemblies().SelectMany(m => m.GetTypes()).Where(p => type.IsAssignableFrom(p) && !p.IsInterface).ToList();

            List<IMoney> instances = new List<IMoney>();

            foreach (var moneyType in types)
            {
                var moneyInstance = (IMoney)Activator.CreateInstance(moneyType);
                instances.Add(moneyInstance);
            }

            return instances.OrderBy(x => x.Value).ToList();
        }

        public decimal GetMachineBalance()
        {
            decimal balance = 0;

            foreach (IMoney money in _machine.MoneyInMachine)
            {
                balance += money.Value;
            }

            return balance;
        }

        public (string message, decimal currentBalance) PushCoin(IMoney money)
        {
            Random rand = new Random();

            if (rand.Next(100) % 3 == 0)
                return ("Push coin false", GetMachineBalance());

            _machine.MoneyInMachine.Add(money);
            return ("Ok", GetMachineBalance());
        }

        public (string message, decimal currentBalance) ReturnCoins()
        {
            var message = "Returned: \n";

            foreach (var coin in GetCoins().OrderByDescending(x => x.Value).ToList())
            {
                message += coin.Name + "\n";
            }

            ClearCoins();
            return (message, GetMachineBalance());
        }

        private List<IMoney> GetCoins() => _machine.MoneyInMachine;

        private void ClearCoins() => _machine.MoneyInMachine.Clear();
    }
}

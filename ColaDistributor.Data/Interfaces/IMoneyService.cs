using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColaDistributor.Data.Interfaces
{
    public interface IMoneyService
    {
        decimal GetMachineBalance();
        (string message, decimal currentBalance) PushCoin(IMoney money);
        (string message, decimal currentBalance) ReturnCoins();
        List<IMoney> GetListOfSupportedMoney();
    }
}

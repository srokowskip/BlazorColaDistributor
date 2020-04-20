using ColaDistributor.Interfaces;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColaDistributor.Shared
{
    public class MoneyPanelBase : ComponentBase
    {

        [Inject]
        private IMoneyService _moneyService { get; set; }

        protected string coinPushMessage;

        protected decimal machineBalance;

        protected string returnCoinsMessage;

        protected List<IMoney> listOfSupportedCoins;

        protected override void OnInitialized()
        {
            listOfSupportedCoins = _moneyService.GetListOfSupportedMoney();
        }

        protected void MoneyPush(IMoney money)
        {
            (coinPushMessage, machineBalance) = _moneyService.PushCoin(money);
        }
    }
}

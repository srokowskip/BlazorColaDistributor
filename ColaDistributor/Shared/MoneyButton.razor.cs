using ColaDistributor.Interfaces;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColaDistributor.Shared
{
    public class MoneyButtonBase : ComponentBase
    {
        [Parameter]
        public IMoney CoinInstance { get; set; }

        private Type coinType;

        [Parameter]
        public EventCallback<IMoney> OnMoneyPush { get; set; }

        protected override void OnInitialized()
        {
            coinType = CoinInstance.GetType();
        }

        protected void PushCoin()
        {
            OnMoneyPush.InvokeAsync(CoinInstance);
            CoinInstance = (IMoney)Activator.CreateInstance(coinType);
        }
    }
}

using System.Collections.Generic;
using UnityEngine;

namespace Wallet
{
    public abstract class View : MonoBehaviour
    {
        public abstract void DisplayWalletInfo(IReadOnlyDictionary<CurrencyType, int> wallet);
    }
}
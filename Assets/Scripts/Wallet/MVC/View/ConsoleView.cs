using System.Collections.Generic;
using UnityEngine;

namespace Wallet
{
    public class ConsoleView : View
    {
        public override void DisplayWalletInfo(IReadOnlyDictionary<CurrencyType, int> wallet)
        {
            foreach (KeyValuePair<CurrencyType,int> valuePair in wallet)
            {
                Debug.Log($"Name: {valuePair.Key.ToString()} \t Amount: {valuePair.Value.ToString()}");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Wallet
{
    public class Wallet : Model
    {
        private event Action<int> AmountChanged ;
        public IReadOnlyDictionary<CurrencyType, int> MyWallet => _myWallet;
        private Dictionary<CurrencyType, int> _myWallet = new Dictionary<CurrencyType, int>();

        public Wallet(View view) : base(view)
        {
            _myWallet.Add(CurrencyType.Coin, 1);
            _myWallet.Add(CurrencyType.Diamond, 1);
            _myWallet.Add(CurrencyType.Energy, 1);
        }
    
        public void AddCurrency(CurrencyType type, int amount)
        {
            //_myWallet[type] = _myWallet.GetValueOrDefault(type) + amount;
            _myWallet[CurrencyType.Coin] = _myWallet[CurrencyType.Coin] + 1;
            Debug.Log("ADDED: " + type + amount);
            Debug.Log("STORe: " + _myWallet[CurrencyType.Coin]);
            //_myWallet.Add(type, amount);
            //CurrencyAdded?.Invoke(type, amount);
        }
    }

    
}
using System;
using System.Collections.Generic;
using UnityEngine;

public class Wallet
{
    public Action<ItemType, int> AmountChanged;
    
    public IReadOnlyDictionary<ItemType, int> MyWallet => _myWallet;
    private Dictionary<ItemType, int> _myWallet = new Dictionary<ItemType, int>();
    private UIView _view;
    public Wallet(UIView view)
    {
        _view = view;
        _myWallet.Add(ItemType.Coin, 1);
        _myWallet.Add(ItemType.Gem, 1);
        _myWallet.Add(ItemType.Energy, 1);
    }

    public void AddCoin()
    {
        _myWallet[ItemType.Coin] += 1;
        AmountChanged?.Invoke(ItemType.Coin, _myWallet[ItemType.Coin]);
    }
    
    public void AddGem()
    {
        _myWallet[ItemType.Gem] += 1;
        AmountChanged?.Invoke(ItemType.Gem, _myWallet[ItemType.Gem]);
    }
    
    public void AddEnergy()
    {
        _myWallet[ItemType.Energy] += 1;
        AmountChanged?.Invoke(ItemType.Energy, _myWallet[ItemType.Energy]);
    }
}
using System;
using System.Collections.Generic;

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

    public void AddItem(ItemType type, int amount)
    {
        _myWallet[type] += 1;
        AmountChanged?.Invoke(type, _myWallet[type]);
    }
    
    public void TakeItem(ItemType type, int amount)
    {
        if (_myWallet[type] > 0)
        {
            _myWallet[type] -= 1;
        }
        AmountChanged?.Invoke(type, _myWallet[type]);
    }
    
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class WalletManager
{
    private List<Currency> _wallet = new();

    public WalletManager()
    {
        _wallet.Add(new Coin());
        _wallet.Add(new Coin());
        _wallet.Add(new Coin());
        _wallet.Add(new Star());
        _wallet.Add(new Star());
        _wallet.Add(new Star());
        _wallet.Add(new Energy());
    }

    public event Action<int> CurrencyAdded;
}

public enum CurrencyType
{
    Coin, Star, Energy
}

public abstract class Currency
{
    public string Name { get; protected set; }
    // private CurrencyType _type;
    //
    // protected Currency(CurrencyType type)
    // {
    //     _type = type;
    // }
    //
    // public string Name => nameof(_type);
}

public class Coin : Currency
{
    public Coin()
    {
        Name = "Coin";
    }
}

public class Star : Currency
{
    public Star()
    {
        Name = "Star";
    }
}

public class Energy : Currency
{
    public Energy()
    {
        Name = "Energy";
    }
}

public interface IWalletView
{
    
}
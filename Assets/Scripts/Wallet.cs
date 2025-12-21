using System;
using System.Collections.Generic;
using System.Diagnostics;

public class Wallet
{
    private Dictionary<CurrencyType, int> _myWallet = new Dictionary<CurrencyType, int>();
    public IReadOnlyDictionary<CurrencyType, int> MyWallet => _myWallet;

    public Wallet()
    {
        _myWallet.Add(CurrencyType.Coin, 1);
        _myWallet.Add(CurrencyType.Diamond, 1);
        _myWallet.Add(CurrencyType.Energy, 1);
        CurrencyAdded += OnCurrencyAdded;
    }

    public event Action<int> CurrencyAdded;

    private void OnCurrencyAdded(int value)
    {
        
    }
}

public enum CurrencyType
{
    Coin, Diamond, Energy
}

public abstract class Currency
{
    public string Name { get; protected set; }
}

public class Coin : Currency
{
    public Coin()
    {
        Name = "Coin";
    }
}

public class Diamond : Currency
{
    public Diamond()
    {
        Name = "Diamond";
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
    void GetWalletInfo(Wallet wallet);
}
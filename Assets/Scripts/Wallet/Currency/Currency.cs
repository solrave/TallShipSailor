namespace Wallet
{
    public abstract class Currency
    {
        public string Name { get; protected set; }
    }

    public enum CurrencyType
    {
        Coin, Diamond, Energy
    }
}
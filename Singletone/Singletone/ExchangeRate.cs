namespace Singletone;
public class ExchangeRate
{
    public ExchangeRate(string baseCurrency, string targetCurrency, decimal amount)
    {
        TargetCurrency = targetCurrency;
        BaseCurrency = baseCurrency;
        Amount = amount;    
    }
    public string TargetCurrency{ get; set; }
    public string BaseCurrency { get; set; }
    public decimal Amount { get; set; }
}

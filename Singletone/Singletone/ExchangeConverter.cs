namespace Singletone;
public class ExchangeConverter
{
    private IEnumerable<ExchangeRate> _exchangeRates;

    public ExchangeConverter()
    {
        LoadExchangeRates();
    }
    private void LoadExchangeRates()
    {
        Thread.Sleep(3000);
        // Simulate a delay for loading exchange rates
        _exchangeRates = new List<ExchangeRate>
        {
            new ExchangeRate("USD", "EUR", 0.85m),
            new ExchangeRate("EUR", "USD", 1.18m),
            new ExchangeRate("USD", "EGP", 50.0m),
            new ExchangeRate("GBP", "USD", 1.33m)
        };
    }

    public decimal Convert(string baseCurrency, string targetCurrecny, decimal amount)
    {
        ExchangeRate? exchangeRate = _exchangeRates
            .FirstOrDefault(rate => rate.BaseCurrency == baseCurrency && rate.TargetCurrency == targetCurrecny);
        return exchangeRate == null ? 0 : amount * exchangeRate.Amount;
    }
}

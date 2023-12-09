namespace SQLiteApp.Data;

public class ExchangeRate{
    public int Id{get;set;}
    public required string CurrencyName{get;set;}
    public double CurrencyRate{get;set;}
    public DateTime RateDate{get;set;}

    
}
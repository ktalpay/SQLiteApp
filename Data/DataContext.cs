using Microsoft.EntityFrameworkCore;

namespace SQLiteApp.Data;

public class DataContext:DbContext{

    public DataContext(DbContextOptions<DataContext> options):base(options){

    }

    public DbSet<ExchangeRate> ExchangeRates => Set<ExchangeRate>();

protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExchangeRate>(entity=>
            {
                entity.HasKey(e=>e.Id);
                entity.Property(e=>e.CurrencyName);
                entity.Property(e=>e.CurrencyRate);
                entity.Property(e=>e.RateDate);

                entity.HasData(new ExchangeRate{Id=1,CurrencyName="$", CurrencyRate=29, RateDate=DateTime.Now});
                entity.HasData(new ExchangeRate{Id=2,CurrencyName="€", CurrencyRate=31, RateDate=DateTime.Now});
                entity.HasData(new ExchangeRate{Id=3,CurrencyName="£", CurrencyRate=36, RateDate=DateTime.Now});
            });
            base.OnModelCreating(modelBuilder);
        }
}
// <copyright file="StockAppSeeder.cs" company="Radosław Oleński">
// Copyright (c) Radosław Oleński. All rights reserved
// </copyright>

namespace StockApp.Infrastructure.Seeders;

using Extensions;
using Persistence;

public sealed class StockAppSeeder(StockAppDbContext dbContext)
{
    public async Task Seed()
    {
        if (!await dbContext.Database.CanConnectAsync())
        {
            return;
        }

        SeedCountries();
        SeedCurrencies();
        SeedCurrencyPairs();
        await dbContext.SaveChangesAsync();
    }

    private void SeedCountries()
    {
        if (dbContext.Countries.Any())
        {
            return;
        }

        dbContext.Countries.AddRange(
            new() { Name = "United States", Code = "USA" },
            new() { Name = "United Kingdom", Code = "UK" },
            new() { Name = "Germany", Code = "DE" },
            new() { Name = "Poland", Code = "PL" });
    }

    private void SeedCurrencies()
    {
        if (dbContext.Currencies.Any())
        {
            return;
        }

        dbContext.Currencies.AddRange(
            new()
            {
                Name = "US dollar", Code = "USD", Number = 840, Symbol = "$",
            },
            new()
            {
                Name = "Pound sterling", Code = "GBP", Number = 826, Symbol = "\u00a3",
            },
            new()
            {
                Name = "Euro", Code = "EUR", Number = 978, Symbol = "\u20ac",
            },
            new()
            {
                Name = "Polish zloty", Code = "PLN", Number = 985, Symbol = "zł",
            });
    }

    private void SeedCurrencyPairs()
    {
        if (dbContext.CurrencyPairs.Any())
        {
            return;
        }

        foreach (var pair in dbContext.Currencies.GetAllCurrencyPairs())
        {
            pair.EncodeName();
            dbContext.CurrencyPairs.Add(pair);
        }
    }
}

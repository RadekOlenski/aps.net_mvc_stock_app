// <copyright file="StockAppSeederExtension.cs" company="Radosław Oleński">
// Copyright (c) Radosław Oleński. All rights reserved
// </copyright>

namespace StockApp.Infrastructure.Extensions;

using Domain.Entities;
using Microsoft.EntityFrameworkCore;

internal static class StockAppSeederExtension
{
    internal static IEnumerable<CurrencyPair> GetAllCurrencyPairs(this DbSet<Currency> currencies) =>
        from bidCurrency in currencies
        from askCurrency in currencies
        where bidCurrency != askCurrency
        select new CurrencyPair { Bid = bidCurrency, Ask = askCurrency };
}

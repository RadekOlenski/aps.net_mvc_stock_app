// <copyright file="CurrencyPair.cs" company="Radosław Oleński">
// Copyright (c) Radosław Oleński. All rights reserved
// </copyright>

namespace StockApp.Domain.Entities;

public class CurrencyPair
{
    public required Currency Ask { get; set; }

    public required Currency Bid { get; set; }

    public string EncodedName { get; private set; } = default!;

    public void EncodeName() => EncodedName = $"{Bid.Code}/{Ask.Code}";
}

// <copyright file="CurrencyPair.cs" company="Radosław Oleński">
// Copyright (c) Radosław Oleński. All rights reserved
// </copyright>

namespace StockApp.Domain.Entities;

public sealed class CurrencyPair
{
    public required Currency Ask { get; init; }

    public required Currency Bid { get; init; }

    public string EncodedName { get; private set; } = default!;

    public int ID { get; init; }

    public void EncodeName() => EncodedName = $"{Bid.Code}/{Ask.Code}";
}

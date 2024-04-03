// <copyright file="Currency.cs" company="Radosław Oleński">
// Copyright (c) Radosław Oleński. All rights reserved
// </copyright>

namespace StockApp.Domain.Entities;

public sealed class Currency
{
    public string Code { get; init; } = string.Empty;

    public int ID { get; init; }

    public Country[]? Locations { get; init; }

    public string Name { get; init; } = string.Empty;

    public int Number { get; init; }

    public string? Symbol { get; init; }
}

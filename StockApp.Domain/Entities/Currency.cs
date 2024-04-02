// <copyright file="Currency.cs" company="Radosław Oleński">
// Copyright (c) Radosław Oleński. All rights reserved
// </copyright>

namespace StockApp.Domain.Entities;

public class Currency
{
    public string Code { get; set; } = string.Empty;

    public required int ID { get; set; } = default;

    public Country[]? Locations { get; set; }

    public string Name { get; set; } = string.Empty;

    public int Number { get; set; } = default;

    public string? Symbol { get; set; }
}

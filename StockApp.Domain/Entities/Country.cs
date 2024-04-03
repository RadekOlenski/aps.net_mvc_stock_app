// <copyright file="Country.cs" company="Radosław Oleński">
// Copyright (c) Radosław Oleński. All rights reserved
// </copyright>

namespace StockApp.Domain.Entities;

public sealed class Country
{
    public string Code { get; init; } = string.Empty;

    public int ID { get; init; }

    public string Name { get; init; } = string.Empty;
}

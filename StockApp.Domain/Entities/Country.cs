// <copyright file="Country.cs" company="Radosław Oleński">
// Copyright (c) Radosław Oleński. All rights reserved
// </copyright>

namespace StockApp.Domain.Entities;

public sealed class Country
{
    public required int ID { get; init; }

    public string Name { get; init; } = string.Empty;
}

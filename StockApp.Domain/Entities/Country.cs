// <copyright file="Country.cs" company="Radosław Oleński">
// Copyright (c) Radosław Oleński. All rights reserved
// </copyright>

namespace StockApp.Domain.Entities;

public class Country
{
    public required int ID { get; set; }

    public string Name { get; set; } = string.Empty;
}

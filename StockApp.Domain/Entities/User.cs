// <copyright file="User.cs" company="Radosław Oleński">
// Copyright (c) Radosław Oleński. All rights reserved
// </copyright>

namespace StockApp.Domain.Entities;

public sealed class User
{
    public int ID { get; init; }

    public required string Username { get; init; } = string.Empty;
}

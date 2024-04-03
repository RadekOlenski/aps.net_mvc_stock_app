// <copyright file="IUserRepository.cs" company="Radosław Oleński">
// Copyright (c) Radosław Oleński. All rights reserved
// </copyright>

namespace StockApp.Domain.Interfaces;

using Entities;

public interface IUserRepository
{
    Task Create(User user);
}

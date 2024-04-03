// <copyright file="IUserService.cs" company="Radosław Oleński">
// Copyright (c) Radosław Oleński. All rights reserved
// </copyright>

namespace StockApp.Application.User.Services;

using Domain.Entities;

public interface IUserService
{
    Task CreateUser(User user);
}

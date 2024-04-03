// <copyright file="UserService.cs" company="Radosław Oleński">
// Copyright (c) Radosław Oleński. All rights reserved
// </copyright>

namespace StockApp.Application.User.Services;

using Domain.Entities;
using Domain.Interfaces;

public class UserService(IUserRepository userRepository) : IUserService
{
    public async Task CreateUser(User user)
    {
        await userRepository.Create(user);
    }
}

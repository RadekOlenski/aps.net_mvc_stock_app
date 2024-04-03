// <copyright file="UserRepository.cs" company="Radosław Oleński">
// Copyright (c) Radosław Oleński. All rights reserved
// </copyright>

namespace StockApp.Infrastructure.Repositories;

using Domain.Entities;
using Domain.Interfaces;
using Persistence;

public class UserRepository(StockAppDbContext dbContext) : IUserRepository
{
    public async Task Create(User user)
    {
        dbContext.Users.Add(user);
        await dbContext.SaveChangesAsync();
    }
}

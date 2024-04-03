// <copyright file="ServiceCollectionExtension.cs" company="Radosław Oleński">
// Copyright (c) Radosław Oleński. All rights reserved
// </copyright>

namespace StockApp.Infrastructure.Extensions;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence;
using Seeders;

public static class ServiceCollectionExtension
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<StockAppDbContext>(
            options => options.UseSqlServer(configuration.GetConnectionString("StockApp")));

        services.AddScoped<StockAppSeeder>();
    }
}

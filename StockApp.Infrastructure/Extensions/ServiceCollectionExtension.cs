// <copyright file="ServiceCollectionExtension.cs" company="Radosław Oleński">
// Copyright (c) Radosław Oleński. All rights reserved
// </copyright>

namespace StockApp.Infrastructure.Extensions;

using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Config;
using NLog.Extensions.Logging;
using Persistence;
using Repositories;
using Seeders;
using LogLevel = Microsoft.Extensions.Logging.LogLevel;

public static class ServiceCollectionExtension
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddLogging();
        services.AddDb(configuration);
        services.AddSeeding();
    }

    private static void AddDb(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<StockAppDbContext>(
            options => options.UseSqlServer(configuration.GetConnectionString("StockApp")));
    }

    private static void AddLogging(this IServiceCollection services)
    {
        services.AddLogging(
            static builder =>
            {
                builder.ClearProviders();
                builder.SetMinimumLevel(LogLevel.Trace);
                builder.AddNLog();
            });

        LogManager.Configuration = new XmlLoggingConfiguration("../StockApp.Infrastructure/NLog.config");
    }

    private static void AddSeeding(this IServiceCollection services)
    {
        services.AddScoped<StockAppSeeder>();
        services.AddScoped<IUserRepository, UserRepository>();
    }
}

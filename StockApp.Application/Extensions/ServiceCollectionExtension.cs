// <copyright file="ServiceCollectionExtension.cs" company="Radosław Oleński">
// Copyright (c) Radosław Oleński. All rights reserved
// </copyright>

namespace StockApp.Application.Extensions;

using Microsoft.Extensions.DependencyInjection;
using User.Services;

public static class ServiceCollectionExtension
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();
    }
}

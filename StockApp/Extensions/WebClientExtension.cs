// <copyright file="WebClientExtension.cs" company="Radosław Oleński">
// Copyright (c) Radosław Oleński. All rights reserved
// </copyright>

namespace StockApp.Extensions;

using Microsoft.AspNetCore.Cors.Infrastructure;

internal static class WebClientExtension
{
    internal static void AddFrontedOrigin(this CorsOptions corsOptions)
    {
        corsOptions.AddPolicy(
            "FrontendClient",
            static builder =>
            {
                builder.AllowAnyMethod();
                builder.AllowAnyHeader();
                builder.WithOrigins("http://localhost:3000");
            });
    }
}

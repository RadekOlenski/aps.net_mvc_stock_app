// <copyright file="Program.cs" company="Radosław Oleński">
// Copyright (c) Radosław Oleński. All rights reserved
// </copyright>

using StockApp.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;
services.AddInfrastructure(builder.Configuration);

var app = builder.Build();
app.Map("/", static context => context.Response.WriteAsync("hello world"));
app.Run();

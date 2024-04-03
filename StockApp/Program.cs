// <copyright file="Program.cs" company="Radosław Oleński">
// Copyright (c) Radosław Oleński. All rights reserved
// </copyright>

using StockApp.Infrastructure.Extensions;
using StockApp.Infrastructure.Seeders;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;
services.AddInfrastructure(builder.Configuration);

var app = builder.Build();
var scope = app.Services.CreateScope();
var seeder = scope.ServiceProvider.GetRequiredService<StockAppSeeder>();
await seeder.Seed();

app.Map("/", static context => context.Response.WriteAsync("hello world"));
app.Run();

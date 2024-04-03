// <copyright file="Program.cs" company="Radosław Oleński">
// Copyright (c) Radosław Oleński. All rights reserved
// </copyright>

using StockApp.Application.Extensions;
using StockApp.Extensions;
using StockApp.Infrastructure.Extensions;
using StockApp.Infrastructure.Seeders;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;
services.AddControllers();
services.AddEndpointsApiExplorer();
services.AddInfrastructure(builder.Configuration);
services.AddApplication();
services.AddCors(static options => options.AddFrontedOrigin());

var app = builder.Build();
var scope = app.Services.CreateScope();
var seeder = scope.ServiceProvider.GetRequiredService<StockAppSeeder>();
await seeder.Seed();

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseCors("FrontendClient");
app.UseRouting();

app.MapControllers();
app.Run();

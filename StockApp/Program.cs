// <copyright file="Program.cs" company="Radosław Oleński">
// Copyright (c) Radosław Oleński. All rights reserved
// </copyright>

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
services.AddControllers();

var app = builder.Build();

app.UseStaticFiles();

app.MapGet("/", static () => "Hello World!");

app.Run();

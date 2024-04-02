// <copyright file="Program.cs" company="Radosław Oleński">
// Copyright (c) Radosław Oleński. All rights reserved
// </copyright>

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

var app = builder.Build();

app.Map("/", static context => context.Response.WriteAsync("hello world"));
app.Run();

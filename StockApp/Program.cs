// <copyright file="Program.cs" company="Radosław Oleński">
// Copyright (c) Radosław Oleński. All rights reserved
// </copyright>

using JavaScriptEngineSwitcher.Extensions.MsDependencyInjection;
using JavaScriptEngineSwitcher.V8;
using React.AspNet;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
services.AddReact();
services.AddJsEngineSwitcher(static options => { options.DefaultEngineName = V8JsEngine.EngineName; });
services.AddControllersWithViews();

var app = builder.Build();

app.UseReact(static config => { });
app.UseStaticFiles();

app.MapGet("/", static () => "Hello World!");

app.Run();

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

app.UseReact(
    static config =>
    {
        // If you want to use server-side rendering of React components,
        // add all the necessary JavaScript files here. This includes
        // your components as well as all of their dependencies.
        // See http://reactjs.net/ for more information. Example:
        //config
        //  .AddScript("~/js/First.jsx")
        //  .AddScript("~/js/Second.jsx");

        // If you use an external build too (for example, Babel, Webpack,
        // Browserify or Gulp), you can improve performance by disabling
        // ReactJS.NET's version of Babel and loading the pre-transpiled
        // scripts. Example:
        //config
        //  .SetLoadBabel(false)
        //  .AddScriptWithoutTransform("~/js/bundle.server.js");
    });
app.UseStaticFiles();

app.MapGet("/", static () => "Hello World!");

app.Run();

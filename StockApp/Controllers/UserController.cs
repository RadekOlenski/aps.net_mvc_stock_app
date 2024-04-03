// <copyright file="UserController.cs" company="Radosław Oleński">
// Copyright (c) Radosław Oleński. All rights reserved
// </copyright>

namespace StockApp.Controllers;

using Application.User.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class UserController(IUserService userService) : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult> Create([FromBody] User user)
    {
        await userService.CreateUser(user);

        // TODO: proper action result implementation
        return RedirectToAction(nameof(Create));
    }
}

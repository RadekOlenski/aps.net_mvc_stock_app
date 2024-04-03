// <copyright file="StockAppDbContext.cs" company="Radosław Oleński">
// Copyright (c) Radosław Oleński. All rights reserved
// </copyright>

namespace StockApp.Infrastructure.Persistence;

using Domain.Entities;
using Microsoft.EntityFrameworkCore;

public class StockAppDbContext(DbContextOptions<StockAppDbContext> options) : DbContext(options)
{
    public DbSet<Country> Countries { get; init; } = null!;

    public DbSet<Currency> Currencies { get; init; } = null!;

    public DbSet<CurrencyPair> CurrencyPairs { get; init; } = null!;

    public DbSet<User> Users { get; init; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CurrencyPair>()
            .HasOne<Currency>(static pair => pair.Ask)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<CurrencyPair>()
            .HasOne<Currency>(static pair => pair.Bid)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);
    }
}

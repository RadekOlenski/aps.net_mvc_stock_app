// <copyright file="StockAppDbContext.cs" company="Radosław Oleński">
// Copyright (c) Radosław Oleński. All rights reserved
// </copyright>

namespace StockApp.Infrastructure.Persistence;

using Domain.Entities;
using Microsoft.EntityFrameworkCore;

public class StockAppDbContext : DbContext
{
    public DbSet<Country> Countries { get; set; }

    public DbSet<Currency> Currencies { get; set; }

    public DbSet<CurrencyPair> CurrencyPairs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=tcp:stock-app.database.windows.net,1433;Initial Catalog=StockApp;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Authentication=\"Active Directory Default\";");
    }

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

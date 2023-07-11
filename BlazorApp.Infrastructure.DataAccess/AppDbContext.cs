using BlazorApp.Domain.Entities;
using BlazorApp.Infrastructure.Abstractions.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlazorApp.Infrastructure.DataAccess;

/// <inheritdoc cref="IAppDbContext"/>
public class AppDbContext : DbContext, IAppDbContext
{
	/// <inheritdoc/>
	public DbSet<SuperHero> SuperHeroes { get; set; }

	/// <summary>
	/// Constructor.
	/// </summary>
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{
	}

	/// <inheritdoc/>
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		ForceHavingAllStringsAsVarchars(modelBuilder);
	}

	private static void ForceHavingAllStringsAsVarchars(ModelBuilder modelBuilder)
	{
		var stringColumns = modelBuilder.Model
			.GetEntityTypes()
			.SelectMany(e => e.GetProperties())
			.Where(p => p.ClrType == typeof(string));
		foreach (IMutableProperty mutableProperty in stringColumns)
		{
			mutableProperty.SetIsUnicode(false);
		}
	}
}
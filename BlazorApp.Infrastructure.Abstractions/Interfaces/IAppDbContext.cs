using BlazorApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Infrastructure.Abstractions.Interfaces;

/// <summary>
/// Application abstraction for unit of work.
/// </summary>
public interface IAppDbContext
{
	/// <summary>
	/// Super Heroes.
	/// </summary>
	DbSet<SuperHero> SuperHeroes { get; }

	/// <summary>
	/// Saves pending changes.
	/// </summary>
	/// <param name="cancellationToken">Cancellation token.</param>
	/// <returns>Amount of records were affected.</returns>
	Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}

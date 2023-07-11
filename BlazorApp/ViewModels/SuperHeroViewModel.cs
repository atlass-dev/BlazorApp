using BlazorApp.Domain.Entities;

namespace BlazorApp.ViewModels;

/// <summary>
/// View model of <see cref="SuperHero"/>
/// </summary>
public record SuperHeroViewModel
{
	/// <inheritdoc cref="SuperHero.Id" />
	public int Id { get; init; }

	/// <inheritdoc cref="SuperHero.Pseudonym" />
	required public string Pseudonym { get; init; }

	/// <inheritdoc cref="SuperHero.Firstname" />
	public string? Firstname { get; init; }

	/// <inheritdoc cref="SuperHero.Lastname" />
	public string? Lastname { get; init; }

	/// <inheritdoc cref="SuperHero.Birthdate" />
	public DateOnly? Birthdate { get; init; }

	/// <inheritdoc cref="SuperHero.PictureUrl" />
	required public string PictureUrl { get; init; }
}

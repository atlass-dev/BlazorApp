using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Domain.Entities;

/// <summary>
/// Represents an entity of super hero.
/// </summary>
public class SuperHero
{
	/// <summary>
	/// Super Hero's identifier.
	/// </summary>
	public int Id { get; set; }

	/// <summary>
	/// Super Hero's pseudonym.
	/// </summary>
	[Required]
	required public string Pseudonym { get; set; }

	/// <summary>
	/// Super Hero's firstname.
	/// </summary>
	[MaxLength(255)]
	public string? Firstname { get; set; }

	/// <summary>
	/// Super Hero's lastname.
	/// </summary>
	[MaxLength(255)]
	public string? Lastname { get; set; }

	/// <summary>
	/// Super Hero's birthdate.
	/// </summary>
	public DateTime? Birthdate { get; set; }

	/// <summary>
	/// Super Hero's picture URL.
	/// </summary>
	[Required]
	required public string PictureUrl { get; set; }
}

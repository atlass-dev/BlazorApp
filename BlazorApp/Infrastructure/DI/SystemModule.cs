using BlazorApp.Infrastructure.Abstractions.Interfaces;
using BlazorApp.Infrastructure.DataAccess;

namespace BlazorApp.Infrastructure.DI;

/// <summary>
/// System specific dependencies.
/// </summary>
internal static class SystemModule
{
	/// <summary>
	/// Registers dependencies.
	/// </summary>
	/// <param name="services">Services.</param>
	public static void Register(this IServiceCollection services)
	{
		services.AddScoped<IAppDbContext, AppDbContext>();
	}
}

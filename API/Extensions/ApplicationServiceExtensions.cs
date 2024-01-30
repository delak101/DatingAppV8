using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions;

public static class ApplicationServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddDbContext<DataContext>(opt =>
            {
                opt.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });
        services.AddCors(); //Adds cross-origin resource sharing services to the specified IServiceCollection.
        services.AddScoped<ITokenService, TokenService>(); //Using Interface is good for testing making it easier to test for interfaces than the code..
        
        return services;
    }
}

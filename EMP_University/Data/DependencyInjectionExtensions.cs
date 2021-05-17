using Data.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Diagnostics.CodeAnalysis;

namespace Data
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddEMPUniData([NotNull] this IServiceCollection services, [NotNull] IConfiguration configuration)
        {
            return services
                .AddEMPUniDatabase<EMPUniDbContext>(configuration: configuration)
                ////.AddEMPUniDatabaseInterface()
                .AddEMPUniIdentity();
        }

        private static IServiceCollection AddEMPUniDatabase<TContext>([NotNull] this IServiceCollection services, [NotNull] Action<DbContextOptionsBuilder> options, ServiceLifetime contextLifetime = ServiceLifetime.Scoped, ServiceLifetime optionsLifetime = ServiceLifetime.Scoped)
            where TContext : DbContext
        {
            return services.AddDbContext<TContext>(options, contextLifetime, optionsLifetime);
        }

        private static IServiceCollection AddEMPUniDatabase<TContext>([NotNull] this IServiceCollection services, [NotNull] IConfiguration configuration)
            where TContext : DbContext
        {
            return services.AddDbContext<TContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")));
        }

        ////private static IServiceCollection AddEMPUniDatabaseInterface([NotNull] this IServiceCollection services)
        ////{
        ////    return services.AddScoped<IEMPUniDbContext>(provider => provider.GetService<EMPUniDbContext>());
        ////}

        private static IServiceCollection AddEMPUniIdentity([NotNull] this IServiceCollection services)
        {
            services.AddDefaultIdentity<Student>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<EMPUniDbContext>();

            return services;
        }
    }
}

using Microsoft.Extensions.DependencyInjection;

using Services.Interfaces;

using System.Diagnostics.CodeAnalysis;

namespace Services
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddEMPUniSerivices([NotNull] this IServiceCollection services)
        {
            return services.AddScoped<ICourseService, CourseService>();
        }
    }
}

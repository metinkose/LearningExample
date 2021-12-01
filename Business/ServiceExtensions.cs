using Abstract;
using Microsoft.Extensions.DependencyInjection;

namespace Business
{
    public static class ServiceExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<IObjectConvertFormat, ObjectConvertFormatManager>();
        }
    }
}

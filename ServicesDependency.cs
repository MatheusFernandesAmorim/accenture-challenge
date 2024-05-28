using AccentureChallenge.Interfaces;
using AccentureChallenge.Services;

namespace AccentureChallenge
{
    public static class ServicesDependency
    {
        public static void AddServiceDependency(this IServiceCollection services)
        {
            services.AddTransient<IUtilService, UtilService>();
        }
    }
}
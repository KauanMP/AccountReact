
namespace AccountReactServer.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            // Configuração do cors
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder => builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            });
        }

        // Configura as opções de IIS (Internet Information Services) usando o IISOptions
        public static void ConfigureIISIntegration(this IServiceCollection services) {
            services.Configure<IISOptions>(options => {});
        }
    }
}
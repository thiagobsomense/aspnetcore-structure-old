using AspNetCore.ApplicationCore.Interfaces.Repositories;
using AspNetCore.Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCore.Infrastructure.CrossCutting.IoC
{
    public static class NativeInjectorContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<DataContext>();

            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            
            services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
        }
    }
}
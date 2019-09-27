using AspNetCore.ApplicationCore.Interfaces.Repositories;
using AspNetCore.ApplicationCore.Interfaces.Services;
using AspNetCore.Infrastructure.Data;
using AspNetCore.Infrastructure.Data.Repositories;
using AspNetCore.Services.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCore.Infrastructure.CrossCutting.IoC
{
    public static class NativeInjectorContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<DataContext>();

            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<ICountryRepository, CountryRepository>();
            
            services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
            services.AddScoped<ICountryService, CountryService>();
        }
    }
}
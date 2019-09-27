using AspNetCore.ApplicationCore.Entities;
using AspNetCore.ApplicationCore.Interfaces.Repositories;
using AspNetCore.ApplicationCore.Interfaces.Services;

namespace AspNetCore.Services.Services
{
    public class CountryService : BaseService<Country>, ICountryService
    {
        public CountryService(ICountryRepository repository) : base(repository)
        {
        }
    }
}

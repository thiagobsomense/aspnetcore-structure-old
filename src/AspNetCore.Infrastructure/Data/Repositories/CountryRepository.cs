using AspNetCore.ApplicationCore.Entities;
using AspNetCore.ApplicationCore.Interfaces.Repositories;

namespace AspNetCore.Infrastructure.Data.Repositories
{
    public class CountryRepository : BaseRepository<Country>, ICountryRepository
    {
        public CountryRepository(DataContext context) : base(context)
        {
        }
    }
}

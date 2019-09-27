using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

        public override async Task<Country> Post(Country entity)
        {
            int codIBGE = 0;
            string codISO = entity.CodeISO;

            if(int.TryParse(entity.CodeIBGE, out codIBGE))
            {
                entity.CodeIBGE = Convert.ToUInt32(codIBGE).ToString(@"000");
            }

            if(!string.IsNullOrEmpty(codISO) || char.IsLetter(codISO, 0))
            {
                entity.CodeISO = codISO.ToUpper();
            }

            return await base.Post(entity);
        }

        public override async Task PostAll(List<Country> entities)
        {
            
        }
    }
}

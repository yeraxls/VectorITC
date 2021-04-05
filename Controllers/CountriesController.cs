using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VectorICT.Class;
using VectorICT.Services;

namespace VectorICT.Controllers
{
    public class CountriesController : ControllerBase
    {
        private readonly IServiceCountries serviceCountrie;

        public CountriesController(IServiceCountries serviceCountrie) => this.serviceCountrie = serviceCountrie;

        [HttpGet]
        [Route("api/Countries/LoadCountries")]
        public List<ModAppCountrie> LoadCountries()
        {
            return serviceCountrie.LoadCountries();
        }
        [HttpGet]
        [Route("api/Countries/LoadCountrieByCode")]
        public ModAppCountrie LoadCountrieByCode(string code)
        {
            return serviceCountrie.LoadCountrieByCode(code);
        }
    }
}

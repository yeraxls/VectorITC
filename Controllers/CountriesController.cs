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
        [Route("api/Countries/LocadCountries")]
        public List<ModAppCountrie> LocadCountries()
        {
            return serviceCountrie.LocadCountries();
        }
    }
}

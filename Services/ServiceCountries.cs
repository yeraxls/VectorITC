using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using VectorICT.Class;

namespace VectorICT.Services
{
    public class ServiceCountries : IServiceCountries
    {
        private readonly IServiceJSON serviceJSON;

        public ServiceCountries(IServiceJSON serviceJSON) => this.serviceJSON = serviceJSON;

        public List<ModAppCountrie> LoadCountries()
        {

            return serviceJSON.DeserializeJSON<ModAppCountrie>();
        }

        public ModAppCountrie LoadCountrieByCode(string code)
        {
            return LoadCountries().Where(c => c.Code == code).FirstOrDefault();
        }

    }
}

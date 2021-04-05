using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using VectorICT.Class;
using VectorITC.Class;

namespace VectorICT.Services
{
    public class ServiceCountries : IServiceCountries
    {
        private readonly string countriesJson = ModAppConstants.countriesJson;
        private readonly IServiceJSON serviceJSON;

        public ServiceCountries(IServiceJSON serviceJSON) => this.serviceJSON = serviceJSON;

        public List<ModAppCountrie> LoadCountries()
        {

            return serviceJSON.DeserializeJSON<ModAppCountrie>(countriesJson);
        }

        public ModAppCountrie LoadCountrieByCode(string code)
        {
            return LoadCountries().Where(c => c.Code == code).FirstOrDefault();
        }
        
        public void CreateFileTxt(ModAppCountrie countrie)
        {
            serviceJSON.CreateFileTxt(countrie, countrie.Name);
        }

    }
}

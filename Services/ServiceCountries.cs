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

        public List<ModAppCountrie> LocadCountries()
        {

            return serviceJSON.DeserializeJSON<ModAppCountrie>();
        }
    }
}

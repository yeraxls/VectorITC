using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VectorICT.Class;

namespace VectorICT.Services
{
    public class ServiceCountries : IServiceCountries
    {
        public List<ModAppCountrie> LocadCountries()
        {
            return new List<ModAppCountrie> { new ModAppCountrie { Name = "asd1", Code = "asd" } };
        }
    }
}

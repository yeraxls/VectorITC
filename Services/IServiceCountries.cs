using System.Collections.Generic;
using VectorICT.Class;

namespace VectorICT.Services
{
    public interface IServiceCountries
    {
        List<ModAppCountrie> LoadCountries();
        ModAppCountrie LoadCountrieByCode(string code);
    }
}
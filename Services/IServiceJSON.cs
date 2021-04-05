using System.Collections.Generic;

namespace VectorICT.Services
{
    public interface IServiceJSON
    {
        List<T> DeserializeJSON<T>() where T : class;
    }
}
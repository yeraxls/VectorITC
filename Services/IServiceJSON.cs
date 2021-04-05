using System.Collections.Generic;
using VectorICT.Class;

namespace VectorICT.Services
{
    public interface IServiceJSON
    {
        List<T> DeserializeJSON<T>(string path) where T : class;
        void CreateFileTxt <T>(T countrie, string name) where T : class;
    }
}
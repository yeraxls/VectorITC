using System.Collections.Generic;
using VectorICT.Class;

namespace VectorICT.Services
{
    public interface IServiceJSON
    {
        List<T> DeserializeJSON<T>() where T : class;
        void CreateFileTxt(ModAppCountrie countrie);
    }
}
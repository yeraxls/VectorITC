using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using VectorICT.Class;

namespace VectorICT.Services
{
    public class ServiceJSON : IServiceJSON
    {
        public List<T> DeserializeJSON<T>() where T : class
        {
            string path = @"./countries.json";
            using (StreamReader jsonStream = File.OpenText(path))
            {
                var json = jsonStream.ReadToEnd();
                List<T> product = JsonConvert.DeserializeObject<List<T>>(json);
                return product;
            }
        }
    }
}

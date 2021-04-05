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
    public class ServiceJSON : IServiceJSON
    {
        readonly string carpet = ModAppConstants.carpetJson;
        public List<T> DeserializeJSON<T>(string path) where T : class
        {
            try
            {
                using (StreamReader jsonStream = File.OpenText(path))
                {
                    var json = jsonStream.ReadToEnd();
                    List<T> product = JsonConvert.DeserializeObject<List<T>>(json);
                    return product;
                }
            }
            catch
            {
                return new List<T>();
            }
        }

        public void CreateFileTxt<T>(T file, string name) where T : class
        {
            CheckCarpet();
            CreateTxt(file, name);
        }

        private void CheckCarpet()
        {
            if (!Directory.Exists(carpet))
                Directory.CreateDirectory(carpet);
        }
        private void CreateTxt<T>(T file, string name) where T : class
        {
            string json = JsonConvert.SerializeObject(file);
            System.IO.File.WriteAllText(carpet + "\\" + name + ".txt", json);
        }
    }
}

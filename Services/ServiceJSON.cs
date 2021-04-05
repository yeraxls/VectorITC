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
        readonly string carpet = @"c:\Storage";
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

        public void CreateFileTxt<T>(T countrie, string name) where T : class
        {
            ComprobarCarpeta();
            CreateTxt(countrie, name);
        }

        private void ComprobarCarpeta()
        {
            if (!Directory.Exists(carpet)) 
                Directory.CreateDirectory(carpet);
        }
        private void CreateTxt <T>(T countrie, string name) where T : class
        {
            string json = JsonConvert.SerializeObject(countrie);
            System.IO.File.WriteAllText(carpet + "\\" + name + ".txt" , json);
        }
    }
}

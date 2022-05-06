using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadJsonFile.Model;

namespace ReadJsonFile
{
    public static class TheJsonReader
    {
        public static List<FilePath> Read(string path)
        {
            List<FilePath> data = new List<FilePath>();
            using (StreamReader file = new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();

                    var serializerSettings = new JsonSerializerSettings
                    {
                        ContractResolver = new CamelCasePropertyNamesContractResolver()
                    };

                    data = JsonConvert.DeserializeObject<List<FilePath>>(json, serializerSettings);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Problem reading file " + ex);
                }

                return data;
            }
        }
    }
}

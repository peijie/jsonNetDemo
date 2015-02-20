using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MountainWind.JsonNetDemo
{
    public class Util
    {
        public static void SaveToFile<T>(string fileName, T obj)
        {
            using (var sw = new StreamWriter(fileName))
            {
                sw.Write(JsonConvert.SerializeObject(obj));
                sw.Close();
            }

        }

        public static T RestoreFromFile<T>(string fileName)
        {
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(fileName));

            using (var sr = new StreamReader("fileName"))
            {
                var sl = new JsonSerializer();
                var jtr = new JsonTextReader(sr);
                return sl.Deserialize<T>(jtr);
            }
        }
    }
}

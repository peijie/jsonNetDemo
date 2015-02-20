using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace MountainWind.JsonNetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new JsonObject();

            string data = JsonConvert.SerializeObject(obj);

            using (var output = new StreamWriter("JsonObject.txt"))
            {
                output.Write(data);
                output.Close();
            }

            MemoryStream ms = new MemoryStream();
            using (var bsonWriter = new Newtonsoft.Json.Bson.BsonWriter(ms))
            {
                var sl = new JsonSerializer();
                sl.Serialize(bsonWriter, obj);
            }

            string bdata = Convert.ToBase64String(ms.ToArray());
            using(var output = new StreamWriter("JsonObject.bjson"))
            {
                output.Write(bdata);
                output.Close();
            }


            Console.WriteLine("Press enter to stop the app");
            Console.ReadLine();

        }
    }
}

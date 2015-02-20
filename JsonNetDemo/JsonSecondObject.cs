using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MountainWind.JsonNetDemo
{
    public class JsonSecondObject
    {

        private JsonThirdObject jsnTO = new JsonThirdObject();
        private List<String> messages;

        public JsonSecondObject() 
        {
            this.Age = 83;
            this.Name = "Clint Eastwood";

            this.messages = new List<String>() 
            {
                    "This is the AK-47 assault..",
                    "Are you feeling lucky..",
                    "When a naked man's chasing a.."
            };
        }

        public int Age { get; set; }
        public string Name { get; set; }
        public List<string> Messages
        {
            get
            {
                return messages;
            }
        }
        public JsonThirdObject JsnTO
        {
            get
            {
                return jsnTO;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("Class name: JsonSecondObject\n");
            builder.Append("age=");
            builder.Append(this.Age);
            builder.Append("\n");

            builder.Append("name=");
            builder.Append(this.Name);
            builder.Append("\n");

            builder.Append("messages={\n");

            foreach (String s in messages)
            {
                builder.Append("\t");
                builder.Append(s);
                builder.Append("\n");
            }
            builder.Append("}");


            return builder.ToString();
        }
    }
}

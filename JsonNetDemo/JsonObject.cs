using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MountainWind.JsonNetDemo
{
    public class JsonObject
    {

        private JsonFirstObject jsnFO = new JsonFirstObject();
        private List<String> messages;

        public JsonObject() 
        {
            this.Age = 52;
            this.Name = "Jim Carrey";
            this.messages = new List<String>() 
            {
                "Hey, maybe I will give you..",
                "Excuse me, I'd like to..",
                "Brain freeze. Alrighty Then I just.."
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
        public JsonFirstObject JsnFO
        {
            get
            {
                return jsnFO;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("Class name: JsonObject\n");
            builder.Append("age=");
            builder.Append(this.Age);

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

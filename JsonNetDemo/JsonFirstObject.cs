using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MountainWind.JsonNetDemo
{
    public class JsonFirstObject
    {
  
        private JsonSecondObject jsnSO = new JsonSecondObject();
        private List<String> messages;

        public JsonFirstObject() 
        {
            this.Age = 76;
            this.Name = "Morgan Freeman";
            this.messages = new List<String>() 
            {
                "I once heard a wise man say..",
                "Well, what is it today? More..",
                "Bruce... I'm God. Circumstances have.."
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
        public JsonSecondObject JsnSO
        {
            get
            {
                return jsnSO;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("Class name: JsonFirstObject\n");
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MountainWind.JsonNetDemo
{
    public class JsonThirdObject
    {
        private List<String> messages;



        public JsonThirdObject()
        {
            Age = 81;
            Name = "Michael Caine";

            this.messages = new List<String>() 
            {
                    "You wouldn't hit a man with no trousers..",
                    "At this point, I'd set you up with a..",
                    "You know, your bobby dangler, giggle stick,.."
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

        public override String ToString() 
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("Class name: JsonThirdObject\n");
            builder.Append("age=");
            builder.Append(this.Age);
            builder.Append("\n");

            builder.Append("name=");
            builder.Append(this.Name);
            builder.Append("\n");

            builder.Append("messages={\n");

            foreach(String s in messages) {
                builder.Append("\t");
                builder.Append(s);
                builder.Append("\n");
            }
            builder.Append("}");


            return builder.ToString();
        }
    }
}

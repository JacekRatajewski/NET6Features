using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace NET6.NewFeatures.NET6
{
    public class JsonTree
    {
        public void Test()
        {
            string jsonString = @"
            {
                ""Name"": ""Jacek"",
                ""SurName"": ""Ratajewski"",
                ""Hobby"": [
                    {
                        ""Name"":""SesjeRPG""
                    },
                    {
                        ""Name"":""Rock""
                    }
                ],
                ""Birthday"": {
                    ""Date"": {
                        ""Day"":15,
                        ""Month"":10,
                        ""Year"":1998
                    }
                }
            }
            ";

            JsonNode jacek = JsonNode.Parse(jsonString);

            var jacekJson = new JsonSerializerOptions { WriteIndented = true };
            Console.WriteLine(jacek.ToJsonString(jacekJson));

            var name = jacek["Name"];
            Console.WriteLine($"Name={name}");

            var name2 = jacek["Name"].GetValue<string>();
            Console.WriteLine($"Name={name2}");

            var name3 = (string)jacek["Name"];
            Console.WriteLine($"Name={name3}");

            JsonArray hobby = (JsonArray)jacek["Hobby"];
            Console.WriteLine($"JSON={hobby.ToJsonString()}");

            var birthDay = (int)jacek["Birthday"]["Date"]["Day"];
            Console.WriteLine($"BirthDay={birthDay}");
        }
    }
}

using System;
using System.IO;
using Newtonsoft.Json;

namespace JsonFileReader
{
    public class CJsonFileReader
    {
         public Root ReadFile(string filepath)
        {
            //string filepath = @"C:\Reference\PShete\API_App11\ConsoleApp1\emp.json";

            if (File.Exists(filepath))
            {
                string text = File.ReadAllText(filepath);

                Root obj = JsonConvert.DeserializeObject<Root>(text);

               // var listOfWebsites = obj.WebsiteSetup;

                return obj;

            }
            return null;
        }

        
    }
        
}


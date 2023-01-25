using Newtonsoft.Json;
using System.IO;

using JsonFileReader;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome");
           //var emp =  Convert_json_to_cs();

           // string? name = emp.Dept_Name;

           // Console.WriteLine(name);

           // var customer = getInfo();

           // for(int i=0;i<customer.Count;i++)
           // {
           //     Console.WriteLine(customer.Count);
           //     Console.WriteLine(customer[i].firstName);
           // }

            TestApp();

        }

        static Employee Convert_json_to_cs()
        {
            
            string filename = @"C:\Reference\PShete\API_App11\ConsoleApp1\emp.json";

            if(File.Exists(filename)) 
            {
                string text = File.ReadAllText(filename);

                Employee e = JsonConvert.DeserializeObject<Employee>(text) ;

                return e;

            }
            return null;
        }

        static List<Customer> getInfo()
        {
            string filename = @"C:\Reference\PShete\API_App11\ConsoleApp1\emp - Copy.json";

            if (File.Exists(filename))
            {
                string text = File.ReadAllText(filename);

                var cust = JsonConvert.DeserializeObject<List<Customer>>(text);

                return cust;

            }
            return null;
        }

        static void TestApp()
        {
            string filepath = @"Z:\ForMarkC\PasswordUpdate\PShete\InstallationSetup.json";
             var fileReader = new CJsonFileReader();
            fileReader.ReadFile(filepath);

        }
    }
}
using Microsoft.AspNetCore.Mvc;
using JsonFileReader;

namespace API_App11.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class JsonDocumentReader : ControllerBase
    {
        [HttpGet("JsonInfo", Name = "getFile")]

        public List<WebsiteSetup> getFile(string filepath)
        {
           // string filepath = @"Z:\ForMarkC\PasswordUpdate\PShete\InstallationSetup.json";
            var fileReader = new CJsonFileReader();
            var data = fileReader.ReadFile(filepath);

            return data.WebsiteSetup;
        }

        [HttpGet("JsonNameList", Name = "GetFileName")]
       // [Route "JsonNameList/{*path}"]

        public List<string> GetFileName(string filepath)
        {
            //string filepath = @"Z:\ForMarkC\PasswordUpdate\PShete\InstallationSetup.json";
            var fileReader = new CJsonFileReader();
            var data = fileReader.ReadFile(filepath);

            

            var WebSiteName = data.WebsiteSetup.Select(x => x.Name).ToList();
            //var WebSiteName = new List<string>();
            //var info = data.WebsiteSetup;

            //foreach ( var item in info)
            //{
            //    WebSiteName.Add(item.Name);    
            //}

            return WebSiteName;
        }

    }
}

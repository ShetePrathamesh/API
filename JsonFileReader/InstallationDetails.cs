using System;
using System.Collections.Generic;
using System.Text;

namespace JsonFileReader
{
       // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class ApplicationSetup
        {
            public int OrderId { get; set; }
            public string Action { get; set; }
            public string Name { get; set; }
            public string ZipName { get; set; }
            public string DestinationFolder { get; set; }
            public string ExcludeBackup { get; set; }
            public List<ConfigSection> ConfigSection { get; set; }
            public List<string> FilterFolders { get; set; }
            public string FullExePath { get; set; }
            public List<string> CleanUp { get; set; }
            public string ExtractZip { get; set; }
            public string ReplaceFolder { get; set; }
        }

        public class BaseConfigurationSetup
        {
            public string Name { get; set; }
            public string ZipName { get; set; }
            public string DestinationFolder { get; set; }
            public bool CleanUpBeforeUnzipping { get; set; }
            public string BackupFolderPath { get; set; }
            public List<string> CleanUp { get; set; }
        }

        public class ConfigSection
        {
            public string File { get; set; }
            public string Destination { get; set; }
            public string Name { get; set; }
        }

        public class Database
        {
            public string ParameterFile { get; set; }
            public string EFCoreMigrationDll { get; set; }
            public string EfCoreMigrationExe { get; set; }
        }

        public class HTTPResponseHeader
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }

        public class IISSection
        {
            public string SiteName { get; set; }
            public string AppPool { get; set; }
            public int Port { get; set; }
            public int SecurePort { get; set; }
            public string PhysicalPath { get; set; }
            public string Authentication { get; set; }
        }

        public class Root
        {
            public BaseConfigurationSetup BaseConfigurationSetup { get; set; }
            public List<ApplicationSetup> ApplicationSetup { get; set; }
            public List<WebsiteSetup> WebsiteSetup { get; set; }
            public List<WindowsServiceSetup> WindowsServiceSetup { get; set; }
        }

        public class Service
        {
            public string ServiceExe { get; set; }
            public string PhysicalPath { get; set; }
            public int? SecurePort { get; set; }
            public int? Port { get; set; }
        }

        public class WebsiteSetup
        {
            public int OrderId { get; set; }
            public string Action { get; set; }
            public string Name { get; set; }
            public string ZipName { get; set; }
            public string DestinationFolder { get; set; }
            public List<ConfigSection> ConfigSection { get; set; }
            public IISSection IISSection { get; set; }
            public List<string> CleanUp { get; set; }
            public List<HTTPResponseHeader> HTTPResponseHeader { get; set; }
            public string BinaryFolder { get; set; }
            public Database Database { get; set; }
        }

        public class WindowsServiceSetup
        {
            public int OrderId { get; set; }
            public string Action { get; set; }
            public string Name { get; set; }
            public string ZipName { get; set; }
            public string DestinationFolder { get; set; }
            public List<ConfigSection> ConfigSection { get; set; }
            public Service Service { get; set; }
            public List<string> CleanUp { get; set; }
            public string BinaryFolder { get; set; }
        }


    
}

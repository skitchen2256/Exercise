using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace HelloWorldUI.Helpers
{
    public class AppSettings
    {
        public readonly bool OutputToFile;
        public readonly bool OutputToView;
        public readonly bool OutputToDatabase;

        public AppSettings()
        {            
            ConfigurationBuilder cb = new ConfigurationBuilder();
            string path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            cb.AddJsonFile(path, false);

            var root = cb.Build();
            var appSetting =  root.GetSection("AppSettings");

            OutputToFile = Convert.ToBoolean(appSetting["OutputToFile"]);
            OutputToView = Convert.ToBoolean(appSetting["OutputToView"]);
            OutputToDatabase = Convert.ToBoolean(appSetting["OutputToDatabase"]);
        }

    }
}
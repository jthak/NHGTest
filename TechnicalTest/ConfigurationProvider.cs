using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TechnicalTest
{
   public class ConfigurationProvider
    {
        private readonly IConfiguration _config;

        public ConfigurationProvider()
        {
            _config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($"appsettings.json", false)
                .Build();
        }

        public string GetUrl()
        {
            return _config.GetSection("url").Value;  
        }
    }
}

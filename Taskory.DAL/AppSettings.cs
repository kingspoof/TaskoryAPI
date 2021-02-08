using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Taskory.DAL
{
    public class AppSettings
    {
        public readonly string _connectionString = string.Empty;

        public AppSettings()
        {
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(System.IO.Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);

            var root = configurationBuilder.Build();
            //_connectionString = root.GetSection("ConnectionString").GetSection("DataConnection").Value;
            _connectionString = root.GetConnectionString("DefaultConnection");
            var appSetting = root.GetSection("ApplicationSettings");
        }
        public string ConnectionString
        {
            get => _connectionString;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletus
{
    public class HostBuilder
    {
        public static IHostBuilder CreateHostBuilder()
        {
            var environment = Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT");
            var configuraiton = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{environment}.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();

            return Host
                .CreateDefaultBuilder()
                .ConfigureAppConfiguration(config => config.AddConfiguration(configuraiton))
                .ConfigureServices(services => services.AddSingleton<Worker>());
        }
    }
}

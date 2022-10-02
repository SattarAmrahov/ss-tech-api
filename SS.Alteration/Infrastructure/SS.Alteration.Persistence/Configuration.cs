using Microsoft.Extensions.Configuration;

namespace SS.Alteration.Persistence
{
    static class Configuration
    {
        public static string ConnectionString
        {
            get { 
                ConfigurationManager configurationManager = new ConfigurationManager();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/SS.Alteration.API"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("SuitSupplyDb");
            }
        }
    }
}

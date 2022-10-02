using Microsoft.Extensions.Configuration;


namespace SS.Alteration.Infrastructure
{
    static class Configuration
    {
        public static ServiceBusConfig ServiceBusConfig
        {
            get
            {
                ConfigurationManager configurationManager = new ConfigurationManager();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/SS.Alteration.API"));
                configurationManager.AddJsonFile("appsettings.json");

                var cfig = new ServiceBusConfig();
                configurationManager.GetSection("ServiceBus").Bind(cfig);
                return cfig;
            }
        }
    }
}

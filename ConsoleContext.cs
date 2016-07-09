using Microsoft.Extensions.Configuration;

namespace ConsoleApplication
{
    public abstract class ConsoleContext
    {
        public IConfigurationRoot Config { get; private set; }

        public string DefaultConnectionString
        {
            get
            {
                return Config["connectionStrings:default"];
            }
        }

        public ConsoleContext()
        {
            this.LoadConfiguration();
        }

        private void LoadConfiguration()
        {
            var builder = new Microsoft.Extensions.Configuration.ConfigurationBuilder();

            this.Config = builder.AddJsonFile("appsettings.json").Build();
        }
    }

}
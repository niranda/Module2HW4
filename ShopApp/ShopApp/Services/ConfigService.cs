using ShopApp.Configs;
using ShopApp.Services.Abstractions;

namespace ShopApp.Services
{
    public class ConfigService : IConfigService
    {
        public ConfigService()
        {
            var config = GetConfig();
            AllowedContainerCapacity = config.AllowedContainerCapacity;
        }

        public int AllowedContainerCapacity { get; }

        private Config GetConfig()
        {
            return new Config
            {
                AllowedContainerCapacity = 4
            };
        }
    }
}

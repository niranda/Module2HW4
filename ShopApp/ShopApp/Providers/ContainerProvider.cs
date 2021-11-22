using ShopApp.Models;
using ShopApp.Services.Abstractions;
using ShopApp.Providers.Abstractions;
namespace ShopApp.Providers
{
    public class ContainerProvider : IContainerProvider
    {
        private readonly IConfigService _configuration;

        public ContainerProvider(IConfigService configService)
        {
            _configuration = configService;
            AnimalsContainer = new Animals[_configuration.AllowedContainerCapacity];
        }

        public Animals[] AnimalsContainer { get; set; }
        public int NumberOfAnimals { get; set; }
    }
}

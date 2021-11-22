using ShopApp.Models;
using ShopApp.Services.Abstractions;
using ShopApp.Providers.Abstractions;
namespace ShopApp.Providers
{
    public class GiftProvider : IGiftProvider
    {
        private readonly IConfigService _configuration;

        public GiftProvider(IConfigService configService)
        {
            _configuration = configService;
            CandiesContainer = new Sweet[_configuration.AllowedContainerCapacity];
        }

        public Sweet[] CandiesContainer { get; set; }
        public double GeneralWeight { get; set; }
    }
}

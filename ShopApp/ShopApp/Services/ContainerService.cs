using System;
using ShopApp.Models;
using ShopApp.Providers.Abstractions;
using ShopApp.Services.Abstractions;

namespace ShopApp.Services
{
    public class ContainerService : IContainerService
    {
        private readonly IContainerProvider _containerProvider;
        private readonly IConfigService _configuration;

        public ContainerService(IContainerProvider giftProvider, IConfigService configService)
        {
            _containerProvider = giftProvider;
            _configuration = configService;
        }

        public void BuildContainer(Animals[] sweets)
        {
            var length = Math.Min(sweets.Length, _configuration.AllowedContainerCapacity);
            for (var i = 0; i < length; i++)
            {
                if (sweets[i] == null)
                {
                    break;
                }

                _containerProvider.AnimalsContainer[i] = sweets[i];
                _containerProvider.NumberOfAnimals++;
            }
        }

        public Animals[] GetContainer()
        {
            return _containerProvider.AnimalsContainer;
        }

        public int GetNumberOfAnimals()
        {
            return _containerProvider.NumberOfAnimals;
        }
    }
}

using System;
using ShopApp.Models;
using ShopApp.Providers.Abstractions;
using ShopApp.Services.Abstractions;

namespace ShopApp.Services
{
    public class GiftService : IGiftService
    {
        private readonly IGiftProvider _giftProvider;
        private readonly IConfigService _configuration;

        public GiftService(IGiftProvider giftProvider, IConfigService configService)
        {
            _giftProvider = giftProvider;
            _configuration = configService;
        }

        public void BuildGift(Sweet[] sweets)
        {
            var length = Math.Min(sweets.Length, _configuration.AllowedContainerCapacity);
            for (var i = 0; i < length; i++)
            {
                if (sweets[i] == null)
                {
                    break;
                }

                _giftProvider.CandiesContainer[i] = sweets[i];
                _giftProvider.GeneralWeight += sweets[i].WeightInGm;
            }
        }

        public Sweet[] GetGift()
        {
            return _giftProvider.CandiesContainer;
        }

        public double GetGiftWeight()
        {
            return _giftProvider.GeneralWeight;
        }
    }
}

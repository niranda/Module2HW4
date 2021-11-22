using ShopApp.Models;
using ShopApp.Services.Abstractions;

namespace ShopApp.Helpers
{
    public static class GiftServiceExtension
    {
        public static Animals[] FindByСriterion(this IContainerService containerService, string criterion)
        {
            var animalsArray = containerService.GetContainer();
            var outputSweetsArray = new Animals[animalsArray.Length];
            var outputIndex = 0;
            for (var i = 0; i < animalsArray.Length; i++)
            {
                if (animalsArray[i] == null)
                {
                    break;
                }

                if (animalsArray[i].Name == criterion)
                {
                    outputSweetsArray[outputIndex] = animalsArray[i];
                    outputIndex++;
                }
            }

            return outputSweetsArray;
        }
    }
}

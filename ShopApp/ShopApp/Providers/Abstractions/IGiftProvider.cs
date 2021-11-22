using ShopApp.Models;

namespace ShopApp.Providers.Abstractions
{
    public interface IGiftProvider
    {
        double GeneralWeight { get; set; }
        Sweet[] CandiesContainer { get; set; }
    }
}

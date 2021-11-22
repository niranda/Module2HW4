using ShopApp.Models;

namespace ShopApp.Providers.Abstractions
{
    public interface IContainerProvider
    {
        int NumberOfAnimals { get; set; }
        Animals[] AnimalsContainer { get; set; }
    }
}

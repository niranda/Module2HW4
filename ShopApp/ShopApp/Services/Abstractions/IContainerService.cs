using ShopApp.Models;

namespace ShopApp.Services.Abstractions
{
    public interface IContainerService
    {
        void BuildContainer(Animals[] sweets);
        Animals[] GetContainer();
        int GetNumberOfAnimals();
    }
}

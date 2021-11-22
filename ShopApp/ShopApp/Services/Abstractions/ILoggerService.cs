using ShopApp.Models;

namespace ShopApp.Services.Abstractions
{
    public interface ILoggerService
    {
        void SuccessfulTemplate(Animals[] animals);
        void SuccessfulBuildLog(Animals[] animals, int numberOfAnimals);
        void SuccessfulSortLog(Animals[] animals);
        void SuccessfulSearchLog(Animals[] animals);
    }
}

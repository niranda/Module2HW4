using ShopApp.Models;

namespace ShopApp.Services.Abstractions
{
    public interface ISortService
    {
        Animals[] SortByWeight(Animals[] animals);
    }
}

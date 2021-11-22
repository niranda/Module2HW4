using System;
using ShopApp.Models;
using ShopApp.Helpers;
using ShopApp.Services.Abstractions;

namespace ShopApp.Services
{
    public class SortService : ISortService
    {
        public Animals[] SortByWeight(Animals[] animals)
        {
            Array.Sort(animals, new WeightComparerService());
            return animals;
        }
    }
}

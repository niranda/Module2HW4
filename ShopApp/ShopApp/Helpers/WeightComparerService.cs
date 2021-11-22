using System.Collections.Generic;
using ShopApp.Models;

namespace ShopApp.Helpers
{
    public class WeightComparerService : IComparer<Animals>
    {
        public int Compare(Animals firstAnimal, Animals secondAnimal)
        {
            if (firstAnimal == null || secondAnimal == null)
            {
                return 0;
            }
            else if (firstAnimal.Weight > secondAnimal.Weight)
            {
                return 1;
            }
            else if (firstAnimal.Weight < secondAnimal.Weight)
            {
                return -1;
            }

            return 0;
        }
    }
}

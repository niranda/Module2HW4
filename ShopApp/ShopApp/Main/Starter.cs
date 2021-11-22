using ShopApp.Models;
using ShopApp.Services.Abstractions;
using ShopApp.Helpers;

namespace StyleCop.Main
{
    public class Starter
    {
        private readonly IContainerService _containerService;
        private readonly ILoggerService _notification;
        private readonly ISortService _sort;

        public Starter(IContainerService giftService, ILoggerService notification, ISortService sort)
        {
            _containerService = giftService;
            _notification = notification;
            _sort = sort;
        }

        public void Run()
        {
            var blackLion = new LionSpecies("Black Lion", 310, true, 120, 15, EatingType.Predator, 30, 23);
            var commonWolf = new WolfSpecies("Common Wolf", 89, true, 80, 20, EatingType.Predator, 25, true);
            var spottedGiraffe = new GiraffeSpecies("Spotted Giraffe", 300, true, 500, 10, EatingType.Herbivorous, "Round", 300, 1970);
            var indianElephant = new ElephantSpecies("Indian Elephant", 1000, true, 300, 2, EatingType.Herbivorous, "Round", 50, 200, "Indian");

            var availableAnimals = new Animals[4] { blackLion, commonWolf, spottedGiraffe, indianElephant };

            _containerService.BuildContainer(availableAnimals);
            var builtContainer = _containerService.GetContainer();
            var numberOfAnimals = _containerService.GetNumberOfAnimals();
            _notification.SuccessfulBuildLog(builtContainer, numberOfAnimals);

            var sortedByWeight = _sort.SortByWeight(builtContainer);
            _notification.SuccessfulSortLog(sortedByWeight);

            var findBlackLion = _containerService.FindByСriterion("Black Lion");
            _notification.SuccessfulSearchLog(findBlackLion);

            var findSpottedGiraffe = _containerService.FindByСriterion("Spotted Giraffe");
            _notification.SuccessfulSearchLog(findSpottedGiraffe);
        }
    }
}

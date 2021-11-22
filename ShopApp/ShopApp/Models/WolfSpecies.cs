namespace ShopApp.Models
{
    public class WolfSpecies : PredatorsSquad
    {
        public WolfSpecies(
            string name,
            double weightInKg,
            bool isCirculatorySystem,
            double heightInCm,
            double woolLengthInMm,
            EatingType eatingType,
            double fangsLengthInMm,
            bool isYellingOnMoon)
            : base(name, weightInKg, isCirculatorySystem, heightInCm, woolLengthInMm, eatingType, fangsLengthInMm)
        {
            IsYellingOnMoon = isYellingOnMoon;
        }

        public bool IsYellingOnMoon { get; set; }
    }
}

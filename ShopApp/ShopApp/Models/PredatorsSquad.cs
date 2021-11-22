namespace ShopApp.Models
{
    public abstract class PredatorsSquad : Chordates
    {
        public PredatorsSquad(
            string name,
            double weightInKg,
            bool isCirculatorySystem,
            double heightInCm,
            double woolLengthInMm,
            EatingType eatingType,
            double fangsLengthInMm)
            : base(name, weightInKg, isCirculatorySystem, heightInCm, woolLengthInMm, eatingType)
        {
            FangsLengthInMm = fangsLengthInMm;
        }

        public double FangsLengthInMm { get; set; }
    }
}

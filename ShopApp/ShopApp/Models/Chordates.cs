namespace ShopApp.Models
{
    public abstract class Chordates : Animals
    {
        public Chordates(string name, double weightInKg, bool isCirculatorySystem, double heightInCm, double woolLengthInMm, EatingType eatingType)
            : base(name, weightInKg, isCirculatorySystem)
        {
            HeightInCm = heightInCm;
            WoolLengthInMm = woolLengthInMm;
            EatingType = eatingType;
        }

        public double HeightInCm { get; set; }
        public double WoolLengthInMm { get; set; }
        public EatingType EatingType { get; set; }
    }
}

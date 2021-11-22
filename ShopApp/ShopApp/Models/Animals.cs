namespace ShopApp.Models
{
    public abstract class Animals
    {
        public Animals(string name, double weight, bool isCirculatorySystem)
        {
            Name = name;
            WeightInKg = weight;
            IsCirculatorySystem = isCirculatorySystem;
        }

        public string Name { get; set; }
        public double WeightInKg { get; set; }
        public bool IsCirculatorySystem { get; set; }
    }
}

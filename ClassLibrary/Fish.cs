namespace ClassLibrary
{
    public abstract class Fish : IFish
    {
        public string? Name { get; set; }
        public abstract double FoodRequiredInGrams();

        public Fish(string _name)
        {
            Name = _name;
        }
    }
}
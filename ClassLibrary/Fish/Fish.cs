namespace ClassLibrary
{
    public abstract class Fish : IFish
    {
        public string? Name { get; set; }

        public abstract double GetFoodWeight();

        public Fish(string _name)
        {
            Name = _name;
        }
    }
}
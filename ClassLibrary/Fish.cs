namespace ClassLibrary
{
    public class Fish
    {
        public string? Name { get; set; }
        public double Weight { get; set; }

        public Fish(string _name, double _weight) => (Name, Weight) = (_name, _weight);
    }
}
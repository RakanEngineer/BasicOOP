namespace BasicOOP
{
    internal class Vehicle : IDrivable
    {
        public string Brand { get; set; }

        public Vehicle(string brand)
        {
            Brand = brand;
        }

        public string Drive(int distance)
        {
            return $"{GetType().Name} drove for {distance} km";
        }
    }
    internal class Car : Vehicle
    {
        public string Model { get; set; }

        public Car(string brand, string model) : base(brand)
        {
            Model = model;
        }
    }
}
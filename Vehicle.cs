namespace BasicOOP
{
    internal class Vehicle : IDrivable
    {
        public string Brand { get; set; }

        public Vehicle(string brand)
        {
            Brand = brand;
        }

        public virtual string Drive(int distance)
        {
            return $"{GetType().Name} drove for {distance} km";
        }
    }
    internal class Car : Vehicle, IStoppable
    {
        public string Model { get; set; }

        public Car(string brand, string model) : base(brand)
        {
            Model = model;
        }
        public void Stop()
        {
            Console.WriteLine("Car stopped!");
        }
        public override string Drive(int distance)
        {
            return $"{base.Drive(distance)} from car";
        }
    }
}
namespace BasicOOP
{
    //internal class Vehicle : IDrivable
    internal abstract class AbstractVehicle : IDrivable
    {
        private int fuel = 50;

        protected bool ProtectedBool;

        public abstract string Turn();

        public virtual string Drive(int distance)
        {
            fuel -= 5;
            return $"{GetType().Name} drove for {distance} km {fuel} fuel remaining";
        }
    }

    internal class Vehicle : AbstractVehicle
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

        public override string Turn()
        {
            ProtectedBool = false;
            return "Turning";

        }
    }
    internal/*sealed*/ class Car : Vehicle, IStoppable
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
    internal class Saab : Car
    {
        public Saab(string model = "900") : base("Saab", model)
        {

        }

        public string SpecialMethod()
        {
            ProtectedBool = true;
            return "From Saab";
        }
    }
}
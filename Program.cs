
using System;
using System.Runtime.ConstrainedExecution;

namespace BasicOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle("Volvo");
            Console.WriteLine(v.Drive(50));
            Car c = new Car("BMW", "R39");
            Console.WriteLine(c.Drive(55));
            //v.Stop();
            c.Stop();

            //Part1();

            Saab s = new Saab();
            //Console.WriteLine(s.Drive(25));
            //Console.WriteLine(s.SpecialMethod());
            //c.SpecialMethod();
            //v.SpecialMethod(); 

            List<IDrivable> vehicles = new List<IDrivable>
            {
                v,
                s,
                c
            };

            foreach (IDrivable vehicle in vehicles)
            {
                Console.WriteLine(vehicle.Drive(50));

                //Unsafe case
                //Saab saab = (Saab)vehicle;

                //Saab saab = vehicle as Saab;
                //if(saab != null)
                //

                //if(vehicle is Saab)
                //{
                //    Saab saab = (Saab)vehicle; 
                //    Console.WriteLine(saab.SpecialMethod());
                //}

                if (vehicle is Saab castedToSaab)
                    Console.WriteLine(castedToSaab.SpecialMethod());



            }

        }

        private static void Part1()
        {
            Person p = new Person();
            p.Name = "Kalle";
            //p.Salary
            Employee e = new Employee();
            e.Name = "Anna";
            e.Salary = 25000;
            Admin a = new Admin();
            a.Name = "Kim";
            a.Salary = 30000;
            a.Department = "IT";

            Employee admin = new Admin();
            Person admin2 = new Admin();
            Admin admin3 = new Admin();

            Do(p);
            Do(e);
            Do(a);
            Do(admin);
            Do(admin2);
            Do(admin3);

            List<Person> people = new List<Person>
            {
                p,
                e,
                a,
                admin,
                admin2,
                admin3
            };

            Console.ReadKey();
        }

        private static void Do(Person person)
        {
            Console.WriteLine(person);
        }
    }
}

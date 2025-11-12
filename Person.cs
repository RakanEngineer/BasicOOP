
namespace BasicOOP
{
    internal class Person
    {
        public string Name { get; set; } = string.Empty;
    }
    internal class Employee : Person
    {
        public int Salary { get; set; }
    }
    internal class Admin : Employee
    {
        public string Department { get; set; } = string.Empty;
    }
}
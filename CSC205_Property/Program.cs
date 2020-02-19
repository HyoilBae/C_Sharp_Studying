using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC205_Property
{
    //Initiate Class name SaleItem
    public class SaleItem
    {
        //Make Name Property using getter and setter
        //setter will set Name as a value from Main method
        //getter will read Name value as it is
        public string Name
        { get; set; }
        //Make Price Property using getter and setter
        //setter will set Name as a value from Main method
        //getter will read Name value as it is
        public decimal Price
        { get; set; }
    }

    //Initiate class name Employee
    public class Employee
    {
        //making fields NumberOfEmployees, _Counter, _Name
        public static int NumberOfEmployees;
        //These two fields are private so they can't be used from out of the class
        //That's why you need to use getter and setter (property)
        private static int _counter;
        private string _name;

        // A read-write instance property:
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        // A read-only static property:
        public static int Counter => _counter;

        // A Constructor:
        public Employee() => _counter = ++NumberOfEmployees; // Calculate the employee's number:            
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Setting up value 107 to NumberOfEmployees field
            Employee.NumberOfEmployees = 107;
            //Instantiating Employee class 
            Employee e1 = new Employee();
            //Setting Claude Vige value to Name fields
            e1.Name = "Claude Vige";

            //Reading Employee Number
            Console.WriteLine("Employee number: {0}", Employee.Counter);
            //Reading Employee Name
            Console.WriteLine("Employee name: {0}", e1.Name);

            //Instantiate var item in SaleItem class with setting up two values; name and price
            var item = new SaleItem { Name = "Shoes", Price = 19.95m };
            //Calling getter to read values of name and price
            Console.WriteLine($"{item.Name}: sells for {item.Price:C2}");
        }
    }
}

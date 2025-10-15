namespace ClassDemo
using System;

namespace ClassDemo
{
    class Student
    {
        // Private field for the name (traditionial field with getter and setter)
        private string name;

        // Property for the address
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        // Automatic property for ID

        public int ID
        {
            get; set: }

        // Default constructor

        public Student() : this("Unknown Name", "Unknown Address", 0)
        {
        }

        // Constructor that only takes name (chaining to primary constructor)

        public Student(string name) : this(name, "Unknown Addess", 0)
        {
        }

        // Primary Constructor (master constructor)

        public Student(string name, string address, int id)
        {
            this.name = name;
            this.address = address;
            this.ID = id;
        }
        // Getter and Setter for the name field

        public string GetName()
        {
            return name;
        }


        public void SetName(string value)
        {
            name = value;
        }

        // Method to print the state of the object

        public void PrintState()
        {
            Console.WriteLine($"Name: {name}, Address: {Address}, ID: {ID}");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance using the primary constructor
            Student stduent1 = new Student("John Doe", "123 Elm Street", 1001);
            student1.PrintState(); // Output: Name: John Doe, Address: 123 Elm Street, ID: 1001

            // Create an instance using the constructor with only a name parameter
            Student student2 = new Student("Jane Smith");
            student2.PrintState(); // Output: Name" Jane Smith, Address: Unknown Address, ID: 0

            // Create an instance using the default constructor
            Student student3 = new Student();
            student3.PrintState(); // Output: Name: Unknown Name, Address: Unknown Address, ID: 0
        }
    }
}


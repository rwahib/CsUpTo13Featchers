using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsUpTo13FeatchersConsole.Tasks
{
    public class DeepCopyUsingWithTask : ITask
    {
        public string Name { get; init; }
        public string Description { get; init; }


        public DeepCopyUsingWithTask()
        {
            Name = "Copy (Shallow or Deep) using \"With\" ";
            Description = " copy objects using with keywords";

        }
        public Task<bool> RunAsync()
        {

            ShallowCopy();
            ShallowCopy2();
            DeepCopy();
            TypeCopyUsingWith();
            return Task.FromResult(true);
        }

        private void ShallowCopy()
        {
            Console.WriteLine("");
            Console.WriteLine("Shallow copy 1: different addresses due to using new Address{} ");

            var originalPerson = new Person("Alice", new Address { City = "Sydney", Country = "Australia" });
            var copiedPerson = originalPerson with { Name = "Bob", Address = new Address { Country = "Australia", City = "Melbourne" } };

            //copiedPerson.Address.City = "Melbourne";


            Console.WriteLine($"Original: {originalPerson}"); // Alice, Melbourne
            Console.WriteLine($"Copied: {copiedPerson}");      // Bob, Melbourne

        }

        private void ShallowCopy2()
        {
            Console.WriteLine("");
            Console.WriteLine("Shallow copy 2 :changing 2nd address affected the original as it is shallow copying ");

            var originalPerson = new Person("Alice", new Address { City = "Sydney", Country = "Australia" });
            var copiedPerson = originalPerson with { Name = "Bob" };

            copiedPerson.Address.City = "Melbourne";


            Console.WriteLine($"Original: {originalPerson}"); // Alice, Melbourne
            Console.WriteLine($"Copied: {copiedPerson}");      // Bob, Melbourne
        }

        private void DeepCopy()
        {
            Console.WriteLine("");
            Console.WriteLine("Deep copy  :Different versions ");

            var originalPerson = new Person("Alice", new Address { City = "Sydney", Country = "Australia" });

            // Deep copy using custom method
            var copiedPerson = originalPerson.DeepCopy() with { Name = "Bob" };

            // Modifying the address of copiedPerson does not affect originalPerson
            copiedPerson.Address.City = "Melbourne";



            Console.WriteLine($"Original: {originalPerson}");
            Console.WriteLine($"Copied: {copiedPerson}");
        }


        private void TypeCopyUsingWith()
        {
            Console.WriteLine("");
            Console.WriteLine($"Test copy for different Person types");

            var originalPerson = new PersonType { Name = "Alice", Address = new Address { City = "Sydney", Country = "Australia" } };

            var copiedPerson = originalPerson with { Name = "Bob" };

           
            copiedPerson.Address.City = "Melbourne";

            Console.WriteLine($"Original: {originalPerson}");
            Console.WriteLine($"Copied: {copiedPerson}");
        }


    }
    public record Person(string Name, Address Address)
    {
        // No need for Name
        //public Person DeepCopy() => this with { Name=Name, Address = new Address { City = Address.City, Country = Address.Country } };
        public Person DeepCopy() => this with { Address = new Address { City = Address.City, Country = Address.Country } };
    }
    public class Address
    {
        public string City { get; set; }
        public string Country { get; set; }
        public override string ToString()
        {
            return $"{City} {Country}";
        }
    }

    //class did not work 

    public record  PersonType
    {
        public required string Name { get; set; }
        public required Address Address { get; set; }

        public override string ToString()
        {
            return $"{Name} {Address}";
        }
    }


}

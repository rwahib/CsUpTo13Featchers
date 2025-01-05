using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsUpTo13FeatchersConsole.Tasks
{
    public class PrimaryConstructor(string _name,string _description) :TaskSampleHelper, ITask
    {
        public string Name { get; init; } = _name ?? string.Empty;
        public string Description { get; init; } = _description ?? string.Empty;


        public (string,string) GetNameDescription()
        {
            return (_name, _description);
        }

        public (string, string) SetNameDescription(string name, string description)
        {
            _name = name; _description=description;
            return (_name, _description);
        }

        //public PrimaryConstructor()
        //{
        //    Name = "Primary Constructor";
        //    Description = "Constructor with class name parentheses";


        //}
        public Task<bool> RunAsync()
        {
            
            Console.WriteLine($"From auto constructor param :\n   Name is \"{_name}\" Description is \"{_description}\" ");
            Console.WriteLine("");
            Console.WriteLine($"From Properties :\n Name is \"{this.Name}\" Description is \"{this.Description}\"");
            Console.WriteLine("");
            Console.WriteLine($"From Get method :\n  Name is \"{this.GetNameDescription().Item1} Description is \"{this.GetNameDescription().Item2}\" ");
            Console.WriteLine("");
            
            this.SetNameDescription(this.GenerateString(5), this.GenerateString(5));

            Console.WriteLine($"From Get method after updates :\n  Name is \"{this.GetNameDescription().Item1}\" Description is \"{this.GetNameDescription().Item2}\"");
            Console.WriteLine("");

            return Task.FromResult( true );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsUpTo13FeatchersConsole.Tasks
{
    public class RequiredProperty : ITask
    { 
        public required string Name { get ; init ; }
        public required  string Description { get ; init ; }

        //public decimal Value { get=> field ?? parent.AmbientValue; set; }
        public RequiredProperty()
        {
           
        }
        public Task<bool> RunAsync()
        {
            Console.WriteLine("Code is running if it is compiled");
            return Task.FromResult( true );
        }
    }
}

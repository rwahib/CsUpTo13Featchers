using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsUpTo13FeatchersConsole.Tasks
{
    public class InterpolatedStringsTask : ITask
    { 
        public required string Name { get ; init ; }
        public required  string Description { get ; init ; }

        
        public InterpolatedStringsTask()
        {
           
        }
        public Task<bool> RunAsync()
        {
            Console.WriteLine($"Value = {50}");
            return Task.FromResult( true );
        }
    }
}

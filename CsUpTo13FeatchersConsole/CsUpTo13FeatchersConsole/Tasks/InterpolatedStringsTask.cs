using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsUpTo13FeatchersConsole.Tasks
{
    public class InterpolatedStringsTask : ITask
    { 
        public  string Name { get ; init ; }
        public   string Description { get ; init ; }

        
        public InterpolatedStringsTask()
        {
            Name = "Interpolated Strings Enhancements";
            Description = "C# 12 introduces enhanced interpolated strings for greater flexibility and performance";


        }
        public Task<bool> RunAsync()
        {
            Console.WriteLine($"Test {Test1()}");
            return Task.FromResult( true );
        }

        private string Test1()
        {
            var st = $"""

                What's new in C# 12
                Article
                06/05/2024
                12 contributors
                In this article
                    Primary constructors
                Collection expressions
                ref readonly parameters
                Default lambda parameters
                Show 5 more

                """;
            return st;
        }


    }
}

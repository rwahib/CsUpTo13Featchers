using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsUpTo13FeatchersConsole.Tasks
{
    public class DefaultInterfaceMethodTask : ITask
    {
        public string Name { get; init; }
        public string Description { get; init; }


        public DefaultInterfaceMethodTask()
        {
            Name = "Implementations that Added to interface";
            Description=string.Empty;


        }
        public Task<bool> RunAsync()
        {
            InvokeDefaultInterfaceExplicity();
            return Task.FromResult(true);
        }

        private void InvokeDefaultInterfaceExplicity()
        {
            ITask defMethodSample = new DefaultInterfaceMethodTask();
            defMethodSample.DefaultInterfaceMethodSample();
        }


    }
}

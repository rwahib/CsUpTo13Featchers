using TaskSample = CsUpTo13FeatchersConsole.Tasks;

namespace CsUpTo13FeatchersConsole
{
    public class SampleTaskFactory
    {
        private static List<TaskSample.ITask> _tasks = new List<TaskSample.ITask>();

        public static void Register()
        {
            _tasks.Add(new TaskSample.DeepCopyUsingWithTask() ); 
            _tasks.Add(new TaskSample.DefaultInterfaceMethodTask() );
            _tasks.Add(new TaskSample.CollectionsTests() );
            _tasks.Add(new TaskSample.PrimaryConstructor ("Primary constructor test", "Auto fields Injected in the class name as constructor") ); ;
            _tasks.Add(new TaskSample.RequiredProperty { Name = "new Required properties", Description = "You must Initialise object via obj Initialiser (not constructor) " });
            _tasks.Add(new TaskSample.InterpolatedStringsTask());

        }


        public static async Task RunAsync()
        {
            

            if (_tasks == null || _tasks.Count == 0)
            {
                Register();
            }


            foreach (var task in _tasks)
            {
                Console.WriteLine($"{task.Name} will run");
                Console.WriteLine("Press any key to run this task");
                Console.ReadLine();

                await task.RunAsync();
                Console.WriteLine($"{task.Name} is ran");
                Console.WriteLine("");
                Console.WriteLine("Press \"X\" to exit or any key for next task");
                var ki=Console.ReadKey();
                
                    var xx = new[] { 'x', 'X' };
                    if (xx.Contains(ki.KeyChar) ) {
                        break;
                    }
                Console.WriteLine("");

            }

        }

    }
}

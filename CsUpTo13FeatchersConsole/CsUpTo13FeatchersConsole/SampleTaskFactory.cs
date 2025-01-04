using CsUpTo13FeatchersConsole.Tasks;

namespace CsUpTo13FeatchersConsole
{
    public class SampleTaskFactory
    {
    private static List<ITask> _tasks = new List<ITask>();

    public static void Register()
        {            
           _tasks.Add(new CsUpTo13FeatchersConsole.Tasks.RequiredProperty { Name = "new Required proerties", Description = "You must Inititialise object via obj initialiser (not constructer) " });

        }


        public static async Task RunAsync()
        {
            if(_tasks==null || _tasks.Count == 0)
            {
                Register();
            }


            foreach (var task in _tasks)
            {
                Console.WriteLine($"{task.Name} is running");
                await task.RunAsync();
                Console.WriteLine($"{task.Name} is finished");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ReadLine();
            }
        }

    }
}

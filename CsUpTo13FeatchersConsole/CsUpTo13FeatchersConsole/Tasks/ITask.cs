
namespace CsUpTo13FeatchersConsole.Tasks
{
    public interface ITask
    {
        string Name { get; init; }
        string Description { get; init; }

        Task<bool> RunAsync();

        void DefaultInterfaceMethodSample()
        {
            Console.WriteLine("Please do not do it :(");
        }
    }

}
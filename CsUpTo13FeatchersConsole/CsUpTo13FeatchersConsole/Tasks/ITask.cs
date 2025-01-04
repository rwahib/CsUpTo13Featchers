
namespace CsUpTo13FeatchersConsole.Tasks
{
    public interface ITask
    {
        string  Name { get; init; }
        string Description { get; init; }

        public Task<bool> RunAsync();
    }

}
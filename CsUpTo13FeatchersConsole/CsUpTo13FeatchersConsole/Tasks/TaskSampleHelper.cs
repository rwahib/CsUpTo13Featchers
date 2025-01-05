
namespace CsUpTo13FeatchersConsole.Tasks
{
    public abstract class TaskSampleHelper{
        
        protected string GenerateString(int max)
        {
            var guidSr=Guid.NewGuid().ToString();
            if (max <= 0 || guidSr.Length >= max) return guidSr;

            return guidSr.Substring(0,max-1);

        }

}

}
using System.Threading;

namespace WorkflowExercise
{
    public class CheckIfAvailable : IActivity
    {
        public void Execute()
        {
            System.Console.WriteLine("Checking if available...");
            Thread.Sleep(2020);
        }
    }

}

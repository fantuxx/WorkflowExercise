using System.Threading;

namespace WorkflowExercise
{
    public class UplodeFiles : IActivity
    {
        public void Execute()
        {
            System.Console.WriteLine("Uploading files");
            Thread.Sleep(1000);

        }
    }

}

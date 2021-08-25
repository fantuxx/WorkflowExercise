using System;
using System.Threading;

namespace WorkflowExercise
{
    public class PrepareFile : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Preparing a file:");
            Thread.Sleep(1000);
        }
    }

}

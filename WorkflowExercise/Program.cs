namespace WorkflowExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Workflow wf = new Workflow();

            wf.RegisterNewActivity(new PrepareFile());
            wf.RegisterNewActivity(new CheckIfAvailable());
            wf.RegisterNewActivity(new UplodeFiles());
            wf.RegisterNewActivity(new FeedBack());
            wf.Execute();
        }
    }

}

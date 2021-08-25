using System.Collections.Generic;

namespace WorkflowExercise
{
    public class Workflow
    {
        private readonly List<IActivity> _activities;
        public Workflow()
        {
            _activities = new List<IActivity>();
        }
        public void Execute()
        {
            foreach (var activity in _activities)
            {
                activity.Execute();
            }
        }
        
        public void RegisterNewActivity (IActivity activity)
        {
            _activities.Add(activity);
        }
    }

}

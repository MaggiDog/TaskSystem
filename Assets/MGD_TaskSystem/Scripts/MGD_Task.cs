
namespace MaggiDog.TaskSystem
{

   public enum TaskType {TYPE1, TYPE2 }


    // Basic class for Task can be extended, so you can create your own custom Task
    public class MGD_Task
    {
       public string TaskName
        {
            get;
            set;
        }

        public IMGD_TaskAgent TaskAgent
        {
            get;
            set;
        }

        public TaskType taskType;
        
    }
}

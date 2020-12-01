using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MaggiDog.TaskSystem
{
    /*
        Simple Task Manager     

     */
    public class MGD_TaskManager : MonoBehaviour
    {

        public List<MGD_Task> tasks;

        public static MGD_TaskManager instance;

        private void Start()
        {
            tasks = new List<MGD_Task>();

            if(instance == null)
            {
                instance = this;
            }
                
        }

        public void AddTask(MGD_Task task)
        {
            tasks.Add(task);
        }
        
        // returns first task or null
        public MGD_Task GetTask()
        {
            if(tasks.Count > 0)
            {
                return tasks[0];

            } else
            {
                return null;

            }
        }

        // returns first task in array that belong to object
        public MGD_Task GetTask(IMGD_TaskAgent taskAgent)
        {
            if (tasks.Count > 0)
            {
                MGD_Task obj = tasks.Find(item => item.TaskAgent == taskAgent);
                if(obj != null)
                    tasks.Remove(obj);
                return obj;

            }
            else
            {
                return null;

            }
        }

        // returns first task in array that has name as given
        public MGD_Task GetTask(string taskName)
        {
            if (tasks.Count > 0)
            {
                MGD_Task obj = tasks.Find(item => item.TaskName.Equals(taskName));
                if (obj != null)
                    tasks.Remove(obj);
                return obj;

            }
            else
            {
                return null;

            }
        }

        // returns first task in array that has name as given
        public MGD_Task GetTask(TaskType taskType)
        {
            if (tasks.Count > 0)
            {
                MGD_Task obj = tasks.Find(item => item.taskType.Equals(taskType));
                if (obj != null)
                    tasks.Remove(obj);
                return obj;

            }
            else
            {
                return null;

            }
        }
    }
}
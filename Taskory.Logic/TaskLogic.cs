using System;
using System.Collections.Generic;
using Taskory.DAL.Models;
using Taskory.DAL;
using System.Linq;

namespace Taskory.Logic
{
    public class TaskLogic
    {

        //Get Task
        public static Task GET(int organisationID, int taskID)
        {
            using TaskoryDBContext context = new TaskoryDBContext();
            return context.Organisations
                .Where(o => o.ID == organisationID).FirstOrDefault()?.Tasks
                    .Where(e => e.ID == taskID).FirstOrDefault();
        }

        public static List<Task> GET(int organisationID)
        {
            using TaskoryDBContext context = new TaskoryDBContext();
            return context.Organisations.
                Where(e => e.ID == organisationID).FirstOrDefault()?.Tasks;
        }

        //Create Task
        public static void Create(int organisationID, Task task)
        {
            //TODO -> check if that even creates the task
            using TaskoryDBContext context = new TaskoryDBContext();
            var org = context.Organisations.Where(o => o.ID == organisationID).FirstOrDefault();
            if (org.Tasks == null)
                org.Tasks = new List<Task>();
            org.Tasks.Add(task);
            context.SaveChanges();
        }

        //Update Task
        public static void UpdateTask(int organisationID, Task task)
        {
            //TODO check if that saves the changes
            using TaskoryDBContext context = new TaskoryDBContext();
            var target = context.Organisations.Where(o => o.ID == organisationID).FirstOrDefault()
                .Tasks.Where(t => t.ID == task.ID).FirstOrDefault();
            target = task;
            context.SaveChanges();
        }

        //Delete Task
        public static void DeleteTask(int organisationID, int taskID)
        {
            using TaskoryDBContext context = new TaskoryDBContext();
            var target = context.Organisations.Where(o => o.ID == organisationID).FirstOrDefault().Tasks.Where(t => t.ID == taskID).FirstOrDefault();
            target.Deleted = true;
            context.SaveChanges();
                
        }
    }
}

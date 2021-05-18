using System;
using System.Collections.Generic;

namespace Intermediate
{
    class Program
    {
        public static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.Add(new StatusChange());
            workflow.Add(new UploadVideo());
            workflow.Add(new WebServiceCall());
            workflow.Add(new SendEmail());

            var engine = new WorkflowEngine();
            engine.Run(workflow);
        }

        public interface ITask
        {
            void Execute();
        }

        public interface IWorkflow
        {
            void Add(ITask task);
            void Remove(ITask task);
            IEnumerable<ITask> GetTasks();
        }

        public class Workflow : IWorkflow
        {
            private List<ITask> _tasks;

            public Workflow()
            {
                _tasks = new List<ITask>();
            }

            public void Add(ITask task)
            {
                _tasks.Add(task);
            }

            public void Remove(ITask task)
            {
                _tasks.Remove(task);
            }

            public IEnumerable<ITask> GetTasks()
            {
                return _tasks;
            }
        }

        class StatusChange : ITask
        {
            public void Execute()
            {
                Console.WriteLine("Status is changed...");
            }
        }

        class UploadVideo : ITask
        {
            public void Execute()
            {
                Console.WriteLine("Video is uploaded...");
            }
        }

        class WebServiceCall : ITask
        {
            public void Execute()
            {
                Console.WriteLine("Calling Web Service...");
            }
        }

        class SendEmail : ITask
        {
            public void Execute()
            {
                Console.WriteLine("Send Email...");
            }
        }

        public class WorkflowEngine
        {
            public void Run(IWorkflow workflow)
            {
                foreach (ITask I in workflow.GetTasks())
                {
                    I.Execute();
                }
            }
        }

    }
}



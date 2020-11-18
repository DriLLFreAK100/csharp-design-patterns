using System;
using System.Threading.Tasks;

/// <summary>
/// This example uses MessageQueue as an example of Singleton implementation. 
/// MessageQueue is the Singleton class, where it acts like a single controller of incoming messages
/// </summary>
namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Started Execute!\n");
            StartAsyncOperations();
            Console.ReadLine();
        }

        /// <summary>
        /// Start 4 tasks parallelly to enqueue 10000 message each
        /// After all tasks done, dequeue all messages from the MessageQueue
        /// </summary>
        static async void StartAsyncOperations()
        {
            await Task.Delay(1000);

            Task task1 = Task.Factory.StartNew(() => { ExecuteQueueTask(1); });
            Task task2 = Task.Factory.StartNew(() => { ExecuteQueueTask(2); });
            Task task3 = Task.Factory.StartNew(() => { ExecuteQueueTask(3); });
            Task task4 = Task.Factory.StartNew(() => { ExecuteQueueTask(4); });

            await Task.WhenAll(task1, task2, task3, task4);

            MessageQueue.Instance.DequeueAll();
        }

        static void ExecuteQueueTask(int taskId)
        {
            for (var a = 0; a < 10000; a++)
            {
                MessageQueue.Instance.EnqueueMessage(new Message(Guid.NewGuid().ToString(), $"Task - ${taskId}: ${a}"));
            }
        }
    }
}

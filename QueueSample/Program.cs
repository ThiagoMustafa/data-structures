using System;

namespace QueueSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceQueueManager = new ServiceQueueManager();

            serviceQueueManager.CreateServiceNumber();
            serviceQueueManager.CreateServiceNumber();
            serviceQueueManager.CreateServiceNumber();

            serviceQueueManager.ShowServiceQueue();

            serviceQueueManager.CallNext();
            serviceQueueManager.CallNext();

            serviceQueueManager.ShowServiceQueue();

            serviceQueueManager.CreateServiceNumber();

            serviceQueueManager.CallNext();

            serviceQueueManager.ShowServiceQueue();

            Console.ReadLine();

        }
    }
}

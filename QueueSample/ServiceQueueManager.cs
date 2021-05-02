using System;
using System.Collections.Generic;

namespace QueueSample
{
    public class ServiceQueueManager
    {
        private Queue<int> _serviceQueue;
        private int _nextServiceNumber = 1;

        public ServiceQueueManager()
        {
            _serviceQueue = new Queue<int>();
        }

        public int CreateServiceNumber()
        {
            _serviceQueue.Enqueue(_nextServiceNumber);

            Console.WriteLine("Service number created.");

            return _nextServiceNumber++;
        }

        public void CallNext()
        {
            var nextServiceNumber = _serviceQueue.Dequeue();

            Console.WriteLine($"Next service number: {nextServiceNumber}");
        }

        public void ShowServiceQueue()
        {
            Console.Write("Service numbers of queue:");

            foreach (var serviceNumber in _serviceQueue)
            {
                Console.Write(serviceNumber + " ");
            }

            Console.WriteLine();
        }

        public void RestartQueue()
        {
            _serviceQueue.Clear();
        }
    }
}

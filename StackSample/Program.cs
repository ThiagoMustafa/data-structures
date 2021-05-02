using System;

namespace StackSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var operationsHistory = new OperationsHistory("Thiago Mustafá");

            operationsHistory.Add("Started an article.");
            operationsHistory.Add("Wrote: Lorem ipsum dolor sit amet, consectetur adipiscing elit");
            operationsHistory.Add("In fermentum dictum ipsum et tempor. Proin id enim quis nisi pretium rutrum.");

            operationsHistory.Undo();

            operationsHistory.ShowLastOperation();

            Console.ReadLine();

        }
    }
}

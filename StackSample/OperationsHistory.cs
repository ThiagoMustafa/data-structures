using System;
using System.Collections.Generic;
using System.Text;

namespace StackSample
{
    public class OperationsHistory
    {
        private Stack<string> _history;
        public string UserName { get; private set; }

        public OperationsHistory(string userName)
        {
            UserName = userName;
            _history = new Stack<string>();
        }

        public void Add(string name)
        {
            _history.Push(name);
        }

        public void Undo()
        {
            Console.WriteLine("Last operation undone.");
            _history.Pop();
        }

        public string ReturnLastOperation()
        {
            var lastOperation = _history.Peek();

            return lastOperation;
        }

        public void ShowLastOperation() {
            Console.WriteLine(ReturnLastOperation());
        }

    }
}

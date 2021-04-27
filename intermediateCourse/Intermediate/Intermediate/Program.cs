using System;
using System.Collections.Generic;

namespace Intermediate
{
    class Stack
    {
        private List<object> _list = new List<object>();

        
        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("You can't pass a null object");

            _list.Add(obj);

        }

        public object Pop()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("list is empty");

            object toReturn = _list[_list.Count - 1];

            var listElements = _list.Count;

            _list.RemoveAt(listElements - 1);

            return toReturn;

        }

        public void Clear()
        {
            while(_list.Count < 0)
            {
                _list.RemoveAt(0);
            }
        }

        public static void Main(string[] args)
        {
            var stack = new Stack();

            int ini = 0;
            int max = 10;

            for (var i = ini; i <= max; i++)
                stack.Push(i);

            for (var i = ini; i <= max; i++)
                Console.WriteLine(stack.Pop());

            stack.Clear();

            Console.WriteLine("Counht:" + stack._list.Count);

            Console.ReadLine();
        }
    }
}



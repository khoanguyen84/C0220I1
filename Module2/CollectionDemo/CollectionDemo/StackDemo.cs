using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemo
{
    class StackDemo
    {
        Stack stack = new Stack();
        public void Show()
        {
            stack.Push(5);
            stack.Push(15);
            stack.Push(25);
            stack.Push(35);
            stack.Push(45);

            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}

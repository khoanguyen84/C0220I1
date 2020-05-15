using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemo
{
    class QueueDemo
    {
        Queue queue = new Queue();

        public void Show()
        {
            queue.Enqueue(5);
            queue.Enqueue(15);
            queue.Enqueue(25);
            queue.Enqueue(35);
            queue.Enqueue(45);

            while(queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}

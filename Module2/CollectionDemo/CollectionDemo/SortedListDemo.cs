using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemo
{
    class SortedListDemo
    {
        SortedList sl = new SortedList();

        public void Show()
        {
            sl.Add(3, "Vu");
            sl.Add(2, "An");
            sl.Add(4, "Ngan");
            sl.Add(1, "Quang");
            sl.Add(5, "Cuong");

            foreach(var key in sl.Keys)
            {
                Console.WriteLine(sl[key]);
            }
        }
    }
}

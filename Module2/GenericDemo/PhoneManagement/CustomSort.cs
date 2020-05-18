using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PhoneManagement
{
    class CustomSort : IComparer
    {
        public int Compare(object x, object y)
        {
            return string.Compare(((Contact)x).Name, ((Contact)y).Name);
        }
    }
}

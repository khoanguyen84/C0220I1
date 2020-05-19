using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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

    class ListSort : IComparer<Contact>
    {
        public int Compare([AllowNull] Contact x, [AllowNull] Contact y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }
}

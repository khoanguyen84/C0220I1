using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneManagement
{
    abstract class Phone
    {
        public abstract void InsertPhone(string name, string phone);
        public abstract void RemovePhone(string name);
        public abstract void UpdatePhone(string name, string newPhone);
        public abstract void Search(string name);
        public abstract void Sort();
    }
}

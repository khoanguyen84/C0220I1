using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PhoneManagement
{
    class PhoneBook : Phone
    {
        public ArrayList PhoneList = new ArrayList();

        public PhoneBook()
        {
            PhoneList.Add(new Contact() { 
                Name = "Duc",
                PhoneNumber = "1234"
            });
            PhoneList.Add(new Contact()
            {
                Name = "Duc",
                PhoneNumber = "567"
            });
            PhoneList.Add(new Contact()
            {
                Name = "An",
                PhoneNumber = "789"
            });
        }

        public override void InsertPhone(string name, string phone)
        {
            if (Check(name, out var index))
            {
                ((Contact)PhoneList[index]).PhoneNumber += $": {phone}";
            }
            else
            {
                PhoneList.Add(new Contact()
                {
                    PhoneNumber = phone,
                    Name = name
                });
            }
        }

        public override void RemovePhone(string name)
        {
            throw new NotImplementedException();
        }

        public override void Search(string name)
        {
            throw new NotImplementedException();
        }

        public override void Sort()
        {
            var customSort = new CustomSort();
            PhoneList.Sort(customSort);
        }

        public override void UpdatePhone(string name, string newPhone)
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            foreach(Contact item in PhoneList)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private bool Check(string name, out int index)
        {
            index = -1;
            foreach(Contact item in PhoneList)
            {
                if (item.Name.Equals(name)) {
                    index = PhoneList.IndexOf(item);
                    return true;
                };
            }
            return false;
        }
    }
}

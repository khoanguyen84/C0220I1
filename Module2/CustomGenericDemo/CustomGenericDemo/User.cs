using System;
using System.Collections.Generic;
using System.Text;

namespace CustomGenericDemo
{
    class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Email: {Email}, Avatar: {Avatar}";
        }
    }
}

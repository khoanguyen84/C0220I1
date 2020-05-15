using System;
using System.Collections.Generic;
using System.Text;

namespace InheritDemo
{
    class PolymorphismDemo
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;


            Object cavoi = new Fish();

            ((Fish)cavoi).Move();

            Fish fish = new Fish();
            fish.Move();

            var vit = new Animal();

            var ca = new object();


            ca = new Fish();
        }
    }


    class Animal
    {
        public virtual string Move()
        {
            return $"Di chuyển bằng chân";
        }
    }

    class Fish : Animal
    {
        public override string Move()
        {
            return $"Di chuyển bằng vây và đuôi";
        }
    }




}

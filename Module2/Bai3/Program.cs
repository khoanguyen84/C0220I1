using System;
using System.Text;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Chào các bạn");

            int number;
            number = 6;

            double n1 = 4.5,n2 = 6.7,n3 = 8.9;
            n1 +=5;

            object a;
            a = 40;
            
            const double pi = Math.PI;

            string lop = "Lớp C0220 CGH";

            Console.WriteLine("Biến number = " + number);
            Console.WriteLine(string.Format("Biến number = {0}", number));
            Console.WriteLine($"Biến number = {number}");
            Console.WriteLine($"PI = {pi}");
            Console.WriteLine($"PI = {Math.PI}");

            int k = 5;
            do{
                Console.WriteLine($"K = {k--}");
            }
            while(k>0);

            k = 5;
            while(k>0){
                Console.WriteLine($"K = {k--}");
            }

            k = 5;
            for(int i = 0; i< k ; i++){
                Console.WriteLine($"K = {i}");
            }

            k=5;
            for(int i = 5; i>0 ; i-- ){
                Console.WriteLine($"K = {i}");
            }
        }
    }
}

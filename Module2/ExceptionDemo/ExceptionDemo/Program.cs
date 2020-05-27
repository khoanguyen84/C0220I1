using System;

namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    int a = 67774567;
            //    int b = 57657568;
            //    int c = 10;
            //    int d = int.MaxValue * c;
            //    Console.WriteLine($"{a}*{d} = {(a * b)}");
            //    int[] arr = { 1, 2, 3, 4, 5 };
            //    int e = arr[6];
            //}
            //catch(IndexOutOfRangeException e)
            //{
            //    Console.WriteLine($"{e.Message}");
            //}
            //catch(OverflowException e)
            //{
            //    Console.WriteLine($"{e.Message}");
            //}
            //catch(OutOfMemoryException e)
            //{
            //    Console.WriteLine($"{e.Message}");
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine($"{e.Message}");
            //}
            //catch (Exception e)
            //{
            //    //Console.WriteLine($"System error, please try again later.");
            //    Console.WriteLine($"Type: {e.GetType().Name}, Message: {e.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine("Run at Finally");
            //}
            //A a = new A();
            //a.Show();

            var result = new Response<int>()
            {
                ErrorCode = ErrorCode.E500,
                Payload = 0,
                Message = "System error."
            };

            try
            {
                int a = 5;
                if(a != 5)
                {
                    //throw new CustomException(a);
                    throw new CustomException($"{a} is not prime");
                }

                result.ErrorCode = ErrorCode.E200;
                result.Payload = a;
                result.Message = $"{a} is prime";
                Console.WriteLine(result.ToString());
            }
            catch(CustomException e)
            {
                //Console.WriteLine($"Type: {e.GetType().Name}, Message: {e.Message}");
                Console.WriteLine(result.ToString());
            }
        }
    }

    class A
    {
        B b = new B();
        public void Show()
        {
            try
            {
                Console.WriteLine(b.Division(6, 0));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }

    class B
    {
        public int Division(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch(Exception e)
            {
                throw new Exception($"{e.GetType().Name}, Message: {e.Message}");
            }
            
        }
    }

    class CustomException : Exception
    {
        public CustomException(int number) : base($"{number} is not prime")
        {

        }
        public CustomException(string message) : base(message)
        {

        }
    }

    public class Response<T>
    {
        public ErrorCode ErrorCode;
        public T Payload;
        public string Message;

        public override string ToString()
        {
            return $"Error: {ErrorCode}, Payload: {Payload}, Message: {Message}";
        }
    }

    public enum ErrorCode
    {
        E404,
        E500,
        E200
    }
}

using System;

namespace AccessModifierDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            std.FullName = Helper.ChangeFullName("Khoa Nguyen");
            std.PhoneNumber = Common.Mask("123456789");
            //std.GetAge();
            var tn = Student.TeacherName;
            Student.GetAge();

            Math.Max(1,2);
            var p1 =Math.PI;

            MyMath.Max(1, 2);
            var p2 = MyMath.PI;

            CustomMath cm = new CustomMath();
            cm.Max(1, 2);
            cm.Max(1, 2);

            Random rnd = new Random();

        }
    }

    class Student
    {
        public static string TeacherName = "Hiep";
        public string FullName { get; set; }
        public static DateTime DoB { get; set; }
        public string PhoneNumber { get; set; }

        public static int GetAge()
        {
            return DateTime.Now.Year - DoB.Year;
        }
    }

    static class Common
    {
        public static string Mask(string str)
        {
            return $"{str.Substring(0, str.Length - 3)}XXX";
        }
    }

    static class Helper
    {
        public static string ChangeFullName(string fn)
        {
            return fn.ToUpper();
        }
    }
}

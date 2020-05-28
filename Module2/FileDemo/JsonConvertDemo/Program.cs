using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JsonConvertDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            //string path = @"C:\CodeGym\Class\C0220I1\C0220I1\Module2\FileDemo\JsonConvertDemo\Data\matrix.json";
            //using (StreamReader sr = File.OpenText(path))
            //{
            //    var data = sr.ReadToEnd();
            //    var payload = JsonConvert.DeserializeObject<Payload>(data);
            //    foreach(var item in payload.matrix)
            //    {
            //        //for(int i=0; i<item.Count; i++)
            //        //{
            //        //    Console.Write($"{item[i]*2} ");
            //        //}

            //        foreach(var value in item)
            //        {
            //            Console.Write($"{value * 2} ");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            Data payload = new Data() {
                students = new List<Student>()
            };
            string path2 = @"C:\CodeGym\Class\C0220I1\C0220I1\Module2\FileDemo\JsonConvertDemo\Data\student.json";
            using (StreamReader sr = File.OpenText(path2))
            {
                var data = sr.ReadToEnd();
                payload = JsonConvert.DeserializeObject<Data>(data);
                Console.WriteLine($"Id\tFullname\t\t\tGender\t\tDate of birth\t\tAge");
                foreach (var student in payload.students)
                {
                    Console.WriteLine(student.ToString());
                }
            }

            string pathResult = @"C:\CodeGym\Class\C0220I1\C0220I1\Module2\FileDemo\JsonConvertDemo\Data\result.json";
            ResData resData = new ResData()
            {
                students = new List<ResStudent>()
            };
            using (StreamWriter sw = File.CreateText(pathResult))
            {
                foreach(var std in payload.students)
                {
                    var res = new ResStudent()
                    {
                        Age = std.age,
                        Average = std.average,
                        DOB = std.dob.ToString("dd MMM yyyy"),
                        Fullname = std.fullName,
                        Gender = std.gender ? "Nam" : "Nu",
                        Id = std.id,
                        Toan = std.courses[0].score,
                        Ly = std.courses[1].score,
                        Hoa = std.courses[2].score
                    };
                    resData.students.Add(res);
                }
                var data = JsonConvert.SerializeObject(resData);
                sw.WriteLine(data);
            }
        }
    }

    class Payload
    {
        public List<List<int>> matrix { get; set; }
        //public List<int[]> matrix { get; set; }
    }

    class Data
    {
        public List<Student> students { get; set; }
    }

    class Student
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public bool gender { get; set; }
        public DateTime dob { get; set; }
        public int age => DateTime.Now.Year - dob.Year;
        public List<Course> courses { get; set; }
        public double average => CalculatorAverage();

        private double CalculatorAverage()
        {
            double total = 0.0;
            foreach(var score in courses)
            {
                total += score.score;
            }
            return total / courses.Count;
        }

        public override string ToString()
        {
            string str = $"{id}\t{fullName}\t\t\t" +
                        $"{(gender ? "Nam" : "Nu")}\t\t" +
                        $"{dob.ToString("dd MMM yyyy")}\t" +
                        $"{age}";
            str = $"{str}\n\tName\tScore";
            foreach(var score in courses)
            {
                str = $"{str}\n\t{score.ToString()}";
            }
            str = $"{str}\n\tAverage {average}";
            return str;
        }
    }

    class Course
    {
        public string name { get; set; }
        public double score { get; set; }
        public override string ToString()
        {
            return $"\t{name}\t{score}";
        }
    }

    class ResData
    {
        public List<ResStudent> students { get; set; }
    }

    class ResStudent
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public int Age { get; set; }
        public double Toan { get; set; }
        public double Ly { get; set; }
        public double Hoa { get; set; }
        public double Average { get; set; }
    }
}

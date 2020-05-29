using System.IO;
using Newtonsoft.Json;

namespace CoffeeManagement.Services
{
    public static class ReadWriteService<T> where T : class
    {
        public static void ReadData(string fullpath, T data)
        {
            using (StreamReader sr = File.OpenText(fullpath))
            {
                var obj = sr.ReadToEnd();
                data = JsonConvert.DeserializeObject<T>(obj);
            }
        }

        public static void WriteData(string fullpath, T data)
        {
            using (StreamWriter sw = File.CreateText(fullpath))
            {
                var resData = JsonConvert.SerializeObject(data);
                sw.WriteLine(resData);
            }
        }
    }
}

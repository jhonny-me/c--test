using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace demo1
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "今天天气真真好啊";
            byte[] buffer = Encoding.Default.GetBytes(str);
            File.WriteAllBytes(@"C:\Users\jhonny\Desktop\demo.txt",buffer);
            Console.WriteLine("done");
            Console.ReadKey();
            buffer = File.ReadAllBytes(@"C:\Users\jhonny\Desktop\demo.txt");
            string demo =Encoding.Default.GetString(buffer);
            Console.WriteLine(demo);
            Console.ReadKey();
        }
    }
}

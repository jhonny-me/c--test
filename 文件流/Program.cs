using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 文件流
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fsread = new FileStream(@"C:\Users\jhonny\Desktop\demo.txt", FileMode.OpenOrCreate,FileAccess.Read);
            byte[] buffer=new byte[1024*1024*5];
            //3.8M  5M
            //返回本次实际读取到的有效字节数
            int r = fsread.Read(buffer, 0, buffer.Length);
            //将字节数组中每一个元素按照制定的编码格式解码成字符串
            string s = Encoding.Default.GetString(buffer,0,r);
            //关闭流
            fsread.Close();
            //释放流所占用的资源
            fsread.Dispose();
            Console.WriteLine(s);
            Console.ReadKey();

            //
            //using (filestream fswrite = new filestream(@"c:\users\jhonny\desktop\demo.txt", filemode.openorcreate, fileaccess.readwrite))
            //{
            //    string str = "testing";
            //    byte[] buffe = encoding.default.getbytes(str);
            //    fswrite.write(buffe, 0, r);
            //}
            //console.readkey();
        }
    }
}

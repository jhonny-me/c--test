using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p=new student();
            p.standup();
            Console.ReadKey();
        }
    }

    public abstract class Person
    {
        public abstract void standup();
    };

    public class student:Person
    {
        public override void standup()
        {
            Console.WriteLine("laoshi hao");
        }
    };

    public class teacher:Person
    {
        public override void standup()
        {
            Console.WriteLine("xiaozhang hao");
            //throw new NotImplementedException();
        }
    };

    public class headmaster:Person
    {
        public override void standup()
        {
            Console.WriteLine("xiaomeimei hao");
            //throw new NotImplementedException();
        }
    };
}

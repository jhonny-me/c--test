using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Dog();
            a.Bark();
            Console.ReadKey();
        }
    }

    public abstract class Animal
    {
        public virtual void T()
        {
            Console.WriteLine("动物有生命");
        }

        //抽象类不能被实例化
        //父类是抽象的没法用，但是用子类方法实现的时候可以调用
        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public abstract string TestString(string name);


        public abstract void Bark();
        public abstract string Name
        {
            get;
            set;
        }
        //public void Test()
        //{
        //    //空实现
        //}

    }

    public class Dog:Animal
    {
        //子类继承父类中的抽象方法签名需要一致，即返回值与参数类型
        //子类继承抽象类后，必须把父类中的所有抽象成员进行重写，除非子类也是抽象类
        public override void Bark()
        {
            Console.WriteLine("dog woof");
        }

        public override string Name
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override string TestString(string name)
        {
            throw new NotImplementedException();
        }
    }

    public class cat:Animal
    {
        public override void Bark()
        {
            Console.WriteLine("cat miaoo");
        }

        public override string Name
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override string TestString(string name)
        {
            throw new NotImplementedException();
        }
    }
}

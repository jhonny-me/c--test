using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建泛型集合对象
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            list.AddRange(new int[] { 1, 2, 3, 4, 5, 6 });
            list.AddRange(list);

            int[] nums = list.ToArray();
            List<int> listtwo = nums.ToList();

            for(int i=0;i<list.Count;i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }
    }
}

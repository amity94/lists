using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 4, 5 };

            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("A");
            foreach (var v in list)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("==================================");

            list.Remove(1);
            foreach (var v in list)
            {
                Console.WriteLine(v);
            }

            List<int> lst = new List<int>();
            lst.Add(4);
            Console.WriteLine("=================================");
            List<Mobile> mobile = new List<Mobile>()
            { new Mobile(2012, "LG", 300, 100),
              new Mobile(2013, "Samsung", 400, 400),
              new Mobile(2014, "iPhone", 500, 1000),
              new Mobile(2015, "Sony Ericsson", 700, 850)
            };

            //mobile.Add(m1);
            //mobile.Add(m3);
            //mobile.Add(m2);
            //mobile.Add(m4);

            mobile.ForEach(n => Console.WriteLine(n));
            Console.WriteLine("=============================");
            mobile.Sort();
            mobile.ForEach(n => Console.WriteLine(n));

            MyStack mystack = new MyStack();
            

        }
    }
}

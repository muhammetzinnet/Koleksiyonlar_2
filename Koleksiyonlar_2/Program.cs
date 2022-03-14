using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            //list.Add("Eyup");
            //list.Add(2);
            //list.Add(true);
            //list.Add('A');

            //Console.WriteLine(list[1]);

            foreach(var item in list)
                Console.WriteLine(item);

            Console.WriteLine("********** Add Range **********");

            //string[] colors = { "red", "yellow", "green" };
            List<int> numbers = new List<int>() {6,2,3,9,5,1,7,8,4};
            //list.AddRange(colors);
            list.AddRange(numbers);

            foreach(var item in list)
                Console.WriteLine(item);

            Console.WriteLine("***************************************");

            list.Sort();

            foreach(var item in list)
                Console.WriteLine(item);

            Console.WriteLine(list.BinarySearch(9));

            Console.WriteLine("*************************************");

            list.Reverse();

            foreach(var item in list)
                Console.WriteLine(item);

            Console.WriteLine("****************************");

            list.Clear();

            foreach (var item in list)
                Console.WriteLine(item);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> mylist = new MyList<int>(5);
            mylist[0] = 1;
            Console.WriteLine("Ємнiсть списку: {0} елемент(-iв)", mylist.Capacity);
            Console.WriteLine("Список фактично має: {0} елемент(-iв)", mylist.Count);
            mylist.Add(15);
            Console.WriteLine("Ємнiсть списку: {0} елемент(-iв)", mylist.Capacity);
            Console.ReadKey();
        }
    }
}
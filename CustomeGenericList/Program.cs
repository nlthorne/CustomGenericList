using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomeGenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list1 = new GenericList<int>();
            list1.AddObject(1);
            list1.AddObject(2);
            list1.AddObject(3);
            list1.AddObject(4);
            list1.AddObject(5);
            list1.RemoveObject(2);
            list1.RemoveObject(4);
            list1.ToString();

            GenericList<int> list2 = new GenericList<int>();
            list2.AddObject(1);
            list2.AddObject(6);
            list2.AddObject(7);
            list2.AddObject(8);
            list2.AddObject(9);
            list2.AddObject(10);
            list2.RemoveObject(6);
            list2.RemoveObject(8);
            list2.RemoveObject(10);
            list2.ToString();


        }
    }
}

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
            GenericList<int> listOne = new GenericList<int>();
            listOne.AddObject(1);
            listOne.AddObject(2);
            listOne.AddObject(3);
            listOne.AddObject(4);
            listOne.AddObject(5);
            listOne.RemoveObject(5);
            listOne.RemoveObject(4);
            

            GenericList<int> listTwo = new GenericList<int>();
            listTwo.AddObject(1);
            listTwo.AddObject(6);
            listTwo.AddObject(7);
            listTwo.AddObject(8);
            listTwo.AddObject(9);
            listTwo.AddObject(10);
            listTwo.RemoveObject(6);
            listTwo.RemoveObject(8);
            listTwo.RemoveObject(10);
            

            GenericList<int> listThree = new GenericList<int>();
            GenericList<int> listFour = new GenericList<int>();

            listThree = listOne + listTwo;
            Console.WriteLine(listThree);
            Console.WriteLine("This is end of list3");
            listFour = listOne - listTwo;
            Console.WriteLine(listFour);
            Console.WriteLine("This is end of list4");
           

            GenericList<int> ZippedList = new GenericList<int>();

            ZippedList.Zipped(listOne, listTwo);

            foreach (var item in listOne) 
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            Console.Read();
        }
    }
}

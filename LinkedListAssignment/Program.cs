using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wlcome to LinkedList program");
            LinkedList list = new LinkedList();
            list.Append(56);
            //list.Append(30);
            list.Append(70);

            Console.WriteLine("The list before inserting 30 is : ");
            list.Display();
            list.InsertAtParticularPosition(2, 30);
            Console.WriteLine("The list after inserting 30 is : ");

            list.Display();

            list.InsertAtParticularPosition(3, 40);
            Console.WriteLine("The list after inserting 40 is :  ");
            list.Display();

            list.RemoveFirstNode();
            Console.WriteLine("The list after removing first node is : ");
            list.Display();

            list.RemoveLastNode();
            Console.WriteLine("The list after removing last node is : ");
            list.Display();

            Console.WriteLine("Searching element: ");

            list.Search(30);


            Console.WriteLine("After deleting 40");
            list.Delete(40);
            list.Display();

            int size = list.Size();
            Console.WriteLine(size);

            SortedLinkedList sortedLinkedList = new SortedLinkedList();

            Console.WriteLine("-----after sorting --------------");
            sortedLinkedList.Add(40);
            sortedLinkedList.Add(20);
            sortedLinkedList.Add(8);
            sortedLinkedList.Display();
        }
    }
}

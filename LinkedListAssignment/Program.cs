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

            list.RemoveFirstNode();
            Console.WriteLine("The list after removing first node is : ");
            list.Display();
        }
    }
}

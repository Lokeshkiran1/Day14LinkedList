using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedListAssignment
{
    public class LinkedList
    {
        internal Node head;
        internal void Append(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the list", node.data);
        }

        public void InsertAtParticularPosition(int position, int data)
        {
            Node node = new Node(data);
            if (position < 1)
                Console.WriteLine("Invalid Position");
            else if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node temp = head;

                while (position > 2)
                {
                    temp = temp.next;
                    position--;
                }
                node.next = temp.next;
                temp.next = node;
            }
        }


        internal Node RemoveFirstNode()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;
        }


        internal Node RemoveLastNode()
        {
            if (head == null)
                return null;
            if (head.next == null)
                return null;
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }


        public bool Search(int value)
        {
            while (this.head != null)
            {
                if (this.head.data == value)
                {
                    return true;
                }
                this.head = this.head.next;
            }
            return false;
        }

        public void Delete(int data)
        {
            Node temp = head, previous = null;
            if (temp != null && temp.data == data)
            {
                head = temp.next;
                return;
            }
            while (temp != null && temp.data != data)
            {
                previous = temp;
                temp = temp.next;
            }
            if (temp == null)
                return;
            previous.next = temp.next;
        }


        public int Size()
        {
            int size = 0;
            Node temp = head;
            while (temp != null)
            {
                size++;
                temp = temp.next;
            }
            return size;
        }





        internal void Display()
        {
            if (this.head == null)
                Console.WriteLine("The list is empty.");
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}

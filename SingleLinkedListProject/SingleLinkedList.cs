using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedListProject
{
    class SingleLinkedList
    {
        private Node startPointer;

        public SingleLinkedList()
        {
            startPointer = null;   
        }

        public void DisplayList()
        {
            Node p;
            if (startPointer == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Console.WriteLine("List is :    ");
            p = startPointer;
            while (p != null)
            {
                Console.WriteLine(p.info + " ");
                p = p.next;
            }
            Console.WriteLine();
        }

        public void CountNodes()
        {
            int n = 0;
            Node p = startPointer;
            while (p != null)
            {
                n++;
                p = p.next;
            }
            Console.WriteLine("Number of nodes in the list = " + n);
        }

        public bool Search(int x)
        {
            Node p = startPointer;
            int position = 1;
            while (p != null)
            {
                if (p.info == x)
                {
                    Console.WriteLine(x + " is at position " + position);
                    return true;
                }
                    
                p = p.next;
                position++;
            }
            Console.WriteLine(x + "is not found in list");
            return false;
        }

        public void InsertInBeginning(int data)
        {
            Node temp = new Node(data);
            temp = startPointer;
            startPointer = temp;
        }

        public void InsertAtEnd(int data)
        {
            Node p;
            Node temp = new Node(data);

            if (startPointer == null)
            {
                startPointer = temp;
                return;
            }

            p = startPointer;
            while (p.next != null)
            {
                p = p.next;
            }

            p.next = temp;
        }

        public void CreatList()
        {
            int i, n, data;

            Console.WriteLine("Enter the number of nodes :  ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                return;


        }
    }
}

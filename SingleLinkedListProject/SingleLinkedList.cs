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
            temp.next = startPointer;
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

        public void InsertAfter(int data, int x)
        {
            Node p = startPointer;
            while (p != null)
            {
                if (p.info == x)
                    break;
                p = p.next;
            }

            if (p == null)
                Console.WriteLine(x + " is not in this linked list");
            else
            {
                Node temp = new Node(data);
                temp.next = p.next;
                p.next = temp;
            }
        }

        public void InsertBefore(int data, int x)
        {
            Node p = startPointer;

            if (startPointer == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            if (x == startPointer.info)
            {
                Node temp = new Node(data);
                temp.next = startPointer;
                startPointer = temp;
                return;
            }
            while (p.next != null)
            {
                if (p.next.info == data)
                    break;
                p = p.next;
            }
            if (p.next == null)
            {
                Console.WriteLine(x + "is not in the linked list");
            }
            else
            {
                Node temp = new Node(data);
                temp.next = p.next;
                p.next = temp;
            }
        }

        public void InsertAtPosition(int data, int k)
        {
            int i = 0;

            if (k == 1)
            {
                Node temp = new Node(data);
                temp.next = startPointer;
                startPointer = temp;
                return;
            }

            Node p = startPointer;
            
            for (i = 1; i < k - 1 && p != null; i++)
            {
                p = p.next;
            }
            
            if (p == null)
            {
                Console.WriteLine("You can insert only upto " + i + "th position");
            }
            else
            {
                Node temp = new Node(data);
                temp.next = p.next;
                p.next = temp;
            }

            return;
        }

        public void CreatList()
        {
            int i, n, data;

            Console.WriteLine("Enter the number of nodes :  ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                return;
            for (i = 1; i <=n; i++)
            {
                Console.WriteLine("Enter the element to be inserted : ");
                data = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(data);
            }
        }
    }
}

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

        }

        public void DisplayList()
        {
            Node p;
            if (startPointer == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Console.Write("List is :    ");
            p = startPointer;
            while (p != null)
            {
                Console.Write(p.info + " ");
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
                if (p.next.info == x)
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

        public void DeleteFirstNode()
        {
            if (startPointer == null)
                return;
            startPointer = startPointer.next;
        }

        public void DeleteLastNode()
        {
            if (startPointer == null)
                return;
            if (startPointer.next == null)
            {
                startPointer = null;
                return;
            }
            Node p = startPointer;
            while (p.next.next != null)
            {
                p = p.next;
            }
            
            p.next = null;
        }

        public void DeleteNode(int x)
        {
            if (startPointer == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            
            if (startPointer.info == x)
            {
                startPointer = startPointer.next;
                return;
            }

            Node p = startPointer;
            while (p.next != null)
            {
                if (p.next.info == x)
                    break;
                p = p.next;
            }
            if (p.next == null)
            {
                Console.WriteLine("Element  " + x + " not in list");
            }
            else
            {
                p.next = p.next.next;
            }                        
        }

        public void ReverseList()
        {
            Node prev, p, next;
            if (startPointer == null)
            {
                Console.WriteLine("List is empty");
            }
            prev = null;
            p = startPointer;

            while (p != null)
            {
                next = p.next;
                p.next = prev;
                prev = p;
                p = next;
            }
            startPointer = prev;
        }


        public void BubbleSortExData()
        {
            Node end, q, p;

            for (end = null; end != startPointer.next; end = p)
            {
                for (p = startPointer; p.next != end; p = p.next)
                {
                    q = p.next;
                    if (p.info > q.info)
                    {
                        int temp = p.info;
                        p.info = q.info;
                        q.info = temp;
                    }
                }

            }
        }

        public void BubbleSortExLinks()
        {
            Node end, r, p, q, temp;

            for (end = null; end != startPointer.next; end = p)
            {
                for (r = p = startPointer; p.next != end; r = p, p = p.next)
                {
                    q = p.next;
                    if (p.info > q.info)
                    {
                        p.next = q.next;
                        q.next = p;
                        if (p != startPointer)
                            r.next = q;
                        else
                            startPointer = q;
                        temp = p;
                        p = q;
                        q = temp;
                    }
                }
            }
        }

        public SingleLinkedList Merge1(SingleLinkedList list)
        {
            SingleLinkedList mergeList = new SingleLinkedList();
            mergeList.startPointer = Merge1(startPointer, list.startPointer);
            return mergeList;
        }

        private Node Merge1(Node p1, Node p2)
        {
            Node startN, p , temp;
            if (p1.info > p2.info)
            {
                startN = new Node(p2.info);
                p2 = p2.next;
            }
            else
            {
                startN = new Node(p1.info);
                p1 = p1.next;
            }
            p = startN;
            while (p1 != null && p2 != null)
            {
                if (p1.info > p2.info)
                {
                    p.next = new Node(p2.info);
                    p2 = p2.next;                   
                }
                else
                {
                    p.next = new Node(p1.info);
                    p1 = p1.next;
                }
            }

            return startN;
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

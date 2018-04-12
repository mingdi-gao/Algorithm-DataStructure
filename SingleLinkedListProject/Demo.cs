using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedListProject
{
    class Demo
    {
        static void Main(string[] args)
        {
            int choice, data, k, x;

            SingleLinkedList list = new SingleLinkedList();

            list.CreatList();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1.Display List");
                Console.WriteLine("2.Count the number of nodes");
                Console.WriteLine("3.Search for an element");
                Console.WriteLine("4.Insert in empty list/Insert in beginning of the list");
                Console.WriteLine("5.Insert a node at the end of the list");
                Console.WriteLine("6.Insert a node after a specific node");
                Console.WriteLine("7.Insert a node before a specific node");
                Console.WriteLine("8.Insert a node at a given position");
                Console.WriteLine("9.Delete first node");
                Console.WriteLine("10.Delete last node");
                Console.WriteLine("11.Delete any node");
                Console.WriteLine("12.Reverse the list");
                Console.WriteLine("13.Bubble sort by exchanging data");
                Console.WriteLine("14.Bubble sort by exchanging links");
                Console.WriteLine("15.MergeSort");
                Console.WriteLine("16.Insert Cycle");
                Console.WriteLine("17.Detect Cycle");
                Console.WriteLine("18.Remove Cycle");
                Console.WriteLine("19.Quit");

                Console.WriteLine("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 19)
                    break;

                switch (choice)
                {
                    case 1:
                        list.DisplayList();
                        break;
                    case 2:
                        list.CountNodes();
                        break;
                    case 3:
                        Console.WriteLine("Enter the element to be searched :");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.Search(data);
                        break;
                    case 4:
                        Console.WriteLine("Enter the element to be inserted");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertInBeginning(data);
                        break;
                    case 5:
                        Console.WriteLine("Enter the element to be inserted");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtEnd(data);
                        break;
                    case 6:
                        Console.WriteLine("Enter the element to be inserted");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the value of the specific node");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertAfter(data, x);
                        break;
                    case 7:
                        Console.WriteLine("Enter the element to be inserted");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the value of the specific node");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertBefore(data, x);
                        break;
                    case 8:
                        Console.WriteLine("Enter the element to be inserted");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the position");
                        k = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtPosition(data, k);
                        break;
                    case 9:
                        list.DeleteFirstNode();
                        break;
                    case 10:
                        list.DeleteLastNode();
                        break;
                    case 11:
                        Console.WriteLine("Enter the element to be deleted");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.DeleteNode(data);
                        break;
                    case 12:
                        list.ReverseList();
                        break;
                    case 19:
                        break;
                }
            }
        }
    }
}

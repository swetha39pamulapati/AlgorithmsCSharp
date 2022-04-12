using System;

namespace DLLOperations
{
    class Program
    {
        public class Node
        {
            public int value;
            public Node prev;
            public Node next;
            public Node(int data)
            {
                value = data; prev = null; next = null;
            }
        }
        public class DoublyLinkedList
        {
            private Node head;
            public DoublyLinkedList()
            {
                head = null;

            }
            public void InsertInEmpty(int data)
            {
                if (head == null)
                {
                    Node newNode = new Node(data);
                    head = newNode;
                }
            }
            public void InsertAtFront(int data)
            {
                
                if(head == null)
                {
                    Node newNode = new Node(data);
                    head = newNode;
                }
               else
                {
                    Node newNode = new Node(data);
                    newNode.next = head;
                    head.prev = newNode;
                    head = newNode;
                }
            }
            public void InsertAtEnd(int data)
            {
                Node newNode = new Node(data);
                if (head == null)
                {
                    head = newNode;
                    return;
                }
                Node p = head;
                while(p.next != null)
                {
                    p = p.next;
                }
                p.next = newNode;
                newNode.prev =p;
            }
            public void InsertAfter(int data,int insertafater)
            {
                Node p = head;
                Node p2 = p;
                if (p == null)
                    return;
                while(p!= null)
                {
                    if (p.value == insertafater)
                        break;
                    p = p.next;
                }
                p2 = p.next;
                if (p == null)
                    Console.WriteLine("The element is not found");
                else
                {
                    Node newNode = new Node(data);
                    p.next = newNode;
                    p2.prev = newNode;
                    newNode.prev = p;
                    newNode.next = p2;

                }
            }
            public void DeleteFirst()
            {
                if (head == null || head.next == null)
                    return;
                else
                {
                    head = head.next;
                    head.prev = null;
                }

            }
            public void InsertBefore(int data, int insertBefore)
            {
                Node p = head;
                Node p2 = p;
                if (p == null)
                    return;
                
                while(p != null)
                {
                    if (p.value == insertBefore)
                        break;
                    p = p.next;
                }
                p2 = p.prev;
                if (p == null)
                    Console.WriteLine("Not found");
                else
                {
                    Node newNode = new Node(data);
                    p.prev = newNode;
                    p2.next = newNode;
                    newNode.prev = p2;
                    newNode.next = p;
                }
            }
            public void DeleteLast()
            {
                if (head == null)
                    return;
                Node p = head;
                while(p.next.next!= null)
                {
                    p = p.next;
                }
                p.next = null;
            }
            public void DeleteValue(int data)
            {
                Node p = head;
                Node p2 = p;
                Node p3 = p;
                Node p4 = p;
                if (p == null )
                    return;
                if(p.next == null)
                {
                   head = null;
                    return;
                }
                if(p.value == data)
                {
                    head = head.next;
                    head.prev = null;
                    return;
                }
                while (p.next != null)
                {
                    if (p.value == data)
                        break;
                    p = p.next;
                }
                if (p.next == null)
                {
                    p4 = p.prev;
                    p4.next = null;
                    return;
                }
                if (p == null)
                    Console.Write("data not found");
                else
                {
                    p2 = p.prev;
                    p3 = p.next;
                    p2.next = p3;
                    p3.prev = p2;
                }
            }
            public void reverse()
            {
                Node p = head;
                Node p2 = p.next;
                p.next = null;
                p.prev = p2;
                while(p2!= null)
                {
                    p2.prev = p2.next;
                    p2.next = p;
                    p = p2;
                    p2 = p2.prev;
                }
                head = p;
            }
            public void search(int data)
            {
                if (head == null)
                    return;
                Node p = head;
                int position = 0;
                while (p != null)
                {
                    if (p.value == data)
                    {
                        Console.WriteLine("Data is found at " + position);
                        break;
                    }

                    position++;
                    p = p.next;
                }
                if (p == null)
                    Console.WriteLine("data not found");
            }

            public void CountList()
            {
                Node p = head;
                int n = 0;
                while(p != null)
                {
                    n++;
                    p = p.next;
                }
                Console.WriteLine("The count is:" + n);
            }
            public void PrintList()
            {
                Node p = head;
                if (p != null)
                {
                    Console.Write("The list contains: ");
                    while (p != null)
                    {
                        Console.Write(p.value + " ");
                        p = p.next;
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("The list is empty.");
                }
            }
        }
            static void Main(string[] args)
            {
                DoublyLinkedList dll = new DoublyLinkedList();
           
                dll.InsertInEmpty(9);
            dll.InsertAtFront(8);
            dll.InsertAtEnd(10);
            dll.InsertAfter(35, 8);
            dll.InsertBefore(45, 10);
            dll.PrintList();
            dll.CountList();
            dll.DeleteFirst();
            dll.PrintList();
            dll.DeleteLast();
            dll.PrintList();
            Console.WriteLine("List without 35");
            dll.DeleteValue(35);
            dll.PrintList();
            Console.WriteLine("List without 45");
            dll.DeleteValue(45);
            dll.PrintList();
            Console.WriteLine("List without 9");
            dll.DeleteValue(9);
            dll.PrintList();
            dll.search(45);
            dll.InsertAtFront(3);
            dll.InsertAtFront(4);
            dll.InsertAtFront(5);
            dll.PrintList();
            Console.WriteLine("Reverse Of the list is :");
            dll.reverse();
            dll.PrintList();
        }
        }
    }


using System;

namespace DoublyLinkedList
{
    class Program
    {
        public class Node
        {
            public int value;
            public Node next;
            public Node prev;
        }
        public class DoubleLinkedList
        {
            Node head;
            public DoubleLinkedList()
            {
                head = null;
            }

            public void InsertFront(int newElement)
            {
                Node newNode = new Node();
                newNode.value = newElement;
                newNode.next = null;
                newNode.prev = null;
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    head.prev = newNode;
                    newNode.next = head;
                    head = newNode;
                }
            }
            public void InsertAfter(int newElement)
            {
                Node newNode = new Node();
                newNode.value = newElement;
                newNode.next = null;
                newNode.prev = null;
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    Node temp = new Node();
                    temp = head;
                    while (temp.next != null)
                        temp = temp.next;
                    temp.next = newNode;
                    newNode.prev = temp;
                }
            }

            //Inserts a new element at the given position
            public void PushAtIndex(int newElement, int position)
            {
                Node newNode = new Node();
                newNode.value = newElement;
                newNode.next = null;
                newNode.prev = null;
                if (position < 1)
                {
                    Console.Write("\nposition should be >= 1.");
                }
                else if (position == 1)
                {
                    newNode.next = head;
                    head.prev = newNode;
                    head = newNode;
                }
                else
                {
                    Node temp = new Node();
                    temp = head;
                    for (int i = 1; i < position - 1; i++)
                    {
                        if (temp != null)
                        {
                            temp = temp.next;
                        }
                    }
                    if (temp != null && temp.next != null)
                    {
                        newNode.next = temp.next;
                        newNode.prev = temp;
                        temp.next = newNode;
                         newNode.next.prev = newNode;
                    }
                    else
                    {
                        Console.Write("\nThe previous node is null.");
                    }
                }
            }
            //Delete first node of the list
            public void RemoveFirst()
            {
                if (head == null)
                    return;
                if(head.next == null)
                    {
                    head = null;
                    return;

                }
                else
                {
                    head = head.next;
                    head.prev = null;
                }
            }
            public void RemoveLast()
            {
                if (head == null)
                    return;
                if (head.next == null)
                    head = null;
                else
                {
                    Node p = head;
                    while(p.next.next != null)
                    {
                        p = p.next;
                    }
                    Node nodeToDel = p.next;
                    p.next = null;
                    nodeToDel = null;
                }
            }
            public void reverse()
            {
                Node temp = null;
                while (head != null)
                {
                    temp = head.prev;
                    head.prev = head.next;
                    head.next = temp;
                    head = head.prev;
                }
                if (temp != null)
                {
                    head = temp.prev;
                }
            }
            public void RemoveAtPos(int position)
            {
                if (position < 1)
                {
                    Console.Write("\nposition should be >= 1.");
                }
                else if (position == 1 && head != null)
                {
                    Node nodeToDelete = head;
                    head = head.next;
                    nodeToDelete = null;
                    if (head != null)
                        head.prev = null;
                }
                else
                {
                    Node temp = new Node();
                    temp = head;
                    for (int i = 1; i < position - 1; i++)
                    {
                        if (temp != null)
                        {
                            temp = temp.next;
                        }
                    }
                    if (temp != null && temp.next != null)
                    {
                        Node nodeToDelete = temp.next;
                        temp.next = temp.next.next;
                        if (temp.next.next != null)
                            temp.next.next.prev = temp.next;
                        nodeToDelete = null;
                    }
                    else
                    {
                        Console.Write("\nThe node is already null.");
                    }
                }
            }
            public void RemoveAtIndex (int index)
            {
                if(head == null)
                    return;
                Node p = head;
                if(index == 0)
                {
                    head = p.next;
                    head.prev = null;
                }
                else
                {
                    for(int i = 0; i<index-1; i++)
                    {
                        if (p != null)
                            p = p.next;
                    }
                    if(p != null && p.next != null)
                    {

                        Node toDel = p.next;
                        p.next = p.next.next;
                        toDel = null;
                        if(p.next != null)
                        p.next.prev = p;
                        

                    }
                    else
                    {
                        Console.WriteLine("previous Node is null");
                    }
                }
               

            }
            public void PrintList()
            {
                Node temp = new Node();
                temp = this.head;
                if (temp != null)
                {
                    Console.Write("The list contains: ");
                    while (temp != null)
                    {
                        Console.Write(temp.value + " ");
                        temp = temp.next;
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
            DoubleLinkedList list = new DoubleLinkedList();
            list.InsertFront(7);
            list.InsertFront(1);
            list.InsertFront(3);
            list.InsertFront(2);
            list.InsertFront(8);
            list.PrintList();
            list.reverse();
            list.PrintList();
            //list.RemoveFirst();
            //list.PrintList();
            //list.RemoveAtIndex(2);
            //list.PrintList();
            //Console.WriteLine("The reversed list is :");
            //list.reverse();
            //list.PrintList();
            //list.InsertAfter(7);
            //list.InsertAfter(1);
            //list.InsertAfter(3);
            //list.InsertAfter(2);
            //list.InsertAfter(8);
            //list.PrintList();

            //list.InsertAfter(7);
            //list.InsertAfter(1);
            //list.InsertAfter(3);
            //list.InsertAfter(2);
            //list.InsertAfter(8);
            //list.PrintList();
            //list.PushAtIndex(100, 2);
            //list.PrintList();

            //list.InsertAfter(7);
            //list.InsertAfter(1);
            //list.InsertAfter(3);
            //list.InsertAfter(2);
            //list.InsertAfter(8);
            //list.RemoveFirst();
            //list.PrintList();

            //list.InsertAfter(7);
            //list.InsertAfter(1);
            //list.InsertAfter(3);
            //list.InsertAfter(2);
            //list.InsertAfter(8);
            //list.RemoveLast();
            //list.PrintList();


            //list.InsertAfter(7);
            //list.InsertAfter(1);
            //list.InsertAfter(3);
            //list.InsertAfter(2);
            //list.InsertAfter(8);
            //list.PrintList();
            ////Console.WriteLine("The reverse list is :");
            ////list.reverse();
            //list.RemoveAtIndex(5);
            //list.PrintList();

        }
    }
}

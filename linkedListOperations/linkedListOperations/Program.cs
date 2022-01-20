using System;

namespace linkedListOperations
{

    class Program
    {
        public class Node
        {
            public int Value;
            public Node Next;


            public Node(int data)
            {
                Value = data; Next = null;
            }
        }
        public class SingleLinkedList
        {
            public Node head;
            public SingleLinkedList()
            {
                head = null;
            }
            public void InsertEmptyList(int data)
            {
                Node newNode = new Node(data);
                head = newNode;
            }
            public void InsertFront(int new_data)
            {
                Node newNode = new Node(new_data);
                newNode.Next = head;
                head = newNode;
            }
            public void InsertEnd(int data)
            {
                Node newNode = new Node(data);
                Node p;
                if (head == null)
                {
                    head = newNode;
                    return;
                }
                p = head;
                while (p.Next != null)
                    p = p.Next;
                p.Next = newNode;


            }
            public void InsertAfter(int data, int x)
            {
                Node p = head;
                while (p != null)
                {
                    if (p.Value == x)
                        break;
                    p = p.Next;
                }
                if (p == null)
                    Console.WriteLine(x + "Not present in list");
                else
                {
                    Node newNode = new Node(data);
                    newNode.Next = p.Next;
                    p.Next = newNode;
                }


            }
            public void InsertBefore(int data, int x)
            {

                if (head == null)
                {
                    Console.WriteLine("List is empty");
                    return;
                }
                //x is in 1st node, new node to be inserted before 1st node;
                if (x == head.Value)
                {
                    Node newNode = new Node(data);
                    newNode.Next = head;
                    head = newNode;
                    return;
                }
                //find reference to predecessor
                Node p = head;
                while (p.Next != null)
                {
                    if (p.Next.Value == x)
                        break;
                    p = p.Next;
                }
                if (p.Next == null)

                    Console.WriteLine(x + "Not present in list");
                else
                {
                    Node newNode = new Node(data);
                    newNode.Next = p.Next;
                    p.Next = newNode;
                }
            }

            public void InsertAtPosition(int data, int k)
            {
                int i;
                if (k == 1)
                {
                    Node newNode = new Node(data);
                    newNode.Next = head;
                    head = newNode;
                    return;
                }
                Node p = head;
                for (i = 1; i < k - 1 && p != null; i++)
                    p = p.Next;
                if (p == null)
                    Console.WriteLine("You Can insert only upto" + i + "th position");
                else
                {
                    Node newNode = new Node(data);
                    newNode.Next = p.Next;
                    p.Next = newNode;
                }
            }

            public void DeleteNodeAtFirst()
            {
                if (head == null)
                    return;
                head = head.Next;

            }
            public void DeleteNodeAtLast()
            {
                if (head == null) //No elements in list
                    return;
                if (head.Next == null) //Only 1 element in the list
                {
                    head = null;
                    return;
                }

                Node p = head;
                while (p.Next.Next != null)
                    p = p.Next;
                p.Next = null;
            }
            public void DeleteValue(int x)
            {
                if (head == null)
                    return;
                if (head.Value == x)
                {
                    head = head.Next;
                    return;
                }
                Node p = head;
                while (p.Next != null)
                {
                    if (p.Next.Value == x)
                        break;
                    p = p.Next;
                }
                if (p == null)
                    Console.WriteLine("element" + x + "not in list");
                else
                    p.Next = p.Next.Next;
            }
            public Node ReverseList(Node head)
            {

                if (head == null)
                    return head;

                //        Node prev = null;
                //Node next = null;

                //while (head != null)
                //{
                //    next = head.Next;
                //    head.Next = prev;
                //    prev = head;
                //    head = next;
                //}
                Node tempNode = head;
                Node prevNode = head;
                Node currentNode = head.Next;
                prevNode.Next = null;
                while(currentNode != null)
                {
                    tempNode = currentNode.Next;
                    currentNode.Next = prevNode;
                    prevNode = currentNode;
                    currentNode = tempNode;
                }
        return prevNode;
    }
            //Search in a list
            public void Search(int data)
            {
                int position = 1;
                Node p = head;
                while (p != null)
                {
                    if (p.Value == data)
                    {
                        Console.WriteLine("The data is found at index :" + position);
                        break;
                    }
                    position++;
                    p = p.Next;
                }
                if (p == null)
                    Console.Write("data Not found");

            }
            //Reference to last Node
            public void refToLastNode()
            {
                Node p = head;
                if (p.Next != null)
                {
                    p = p.Next;
                }
                Console.Write("\n the last item is" + p.Value);
            }

            //Reference to  Secondlast Node
            public void refToSecondLastNode()
            {
                Node p = head;
                if (p.Next.Next != null)
                {
                    p = p.Next;
                }
                Console.Write("\n the second last item is" + p.Value);
            }
            //reference of predecessor of given value;
            public void referToPredecessor(int data)
            {
                Node p = head;
                while (p.Next != null)
                {
                    if (p.Next.Value == data)
                        break;
                    p = p.Next;
                }
                Console.WriteLine("\n the predecessor  of  node is" + p.Value);
            }
            public void printList()
            {
                Node p;
                if (head == null)
                {
                    Console.WriteLine("List is empty");
                    return;
                }
                p = head;
                while (p != null)
                {
                    Console.WriteLine(p.Value);
                    p = p.Next;
                }
            }
            public void CountList()
            {
                Node p = head;
                int count = 0;
                while (p != null)
                {
                    count++;
                    p = p.Next;
                }
                Console.WriteLine("Number of nodes in list are :" + count);
            }
        }

        static void Main(string[] args)
        {
            SingleLinkedList list = new SingleLinkedList();
            Node head = new Node(1);
            head.Next = new Node(2);
            head.Next.Next = new Node(6);
            head.Next.Next.Next = new Node(4);
            head.Next.Next.Next.Next = new Node(5);
            Node currentNode = head;
            Console.Write("Reverse list");
            currentNode = list.ReverseList(head);
            while(currentNode!= null)
            {
                Console.Write(currentNode.Value + " ");
                currentNode = currentNode.Next;
            }
            //Console.WriteLine(currentNode);
            list.InsertEmptyList(9);
            list.InsertFront(7);
            list.InsertFront(1);
            list.InsertFront(3);
            list.InsertFront(2);
            list.InsertFront(8);
            list.InsertEnd(11);
            list.InsertAfter(36, 3);
            list.InsertBefore(45, 8);
            list.InsertBefore(54, 2);
            list.InsertAtPosition(100, 1);
            Console.WriteLine("\nCreated Linked list at the front is: ");
            list.CountList();
            list.printList();
            list.Search(2);
            list.refToLastNode();
            list.refToSecondLastNode();
            list.referToPredecessor(3);
            list.DeleteNodeAtFirst();
            list.printList();
            list.DeleteNodeAtLast();
            Console.WriteLine("LastNode deleted");
            list.printList();
            list.DeleteValue(3);
            Console.WriteLine(" deleted at Index");
            list.printList();
            
        }
    }
}


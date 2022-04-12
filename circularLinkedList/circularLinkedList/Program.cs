using System;

namespace circularLinkedList
{
    class Program
    {
        public class Node
        {
            public int value;
            public Node next;
            public Node(int x)
            {
                value = x; next = null;
            }
        }
        public class circularLinkedList
        {
            Node head;
            public circularLinkedList()
            {
                head = null;
                
            }
            public void addToEmptyList(int data)
            {
                Node newNode = new Node(data);
                head = newNode;
                head.next = head;
            }
            
            public void addToBegin(int data)
            {
                Node newNode = new Node(data);
                if (head == null)
                {
                    
                    head = newNode;
                    head.next = head;
                    return;
                }
                Node temp = head;

                while(temp.next != head)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
                newNode.next = head;
                head = newNode;
            }
            public void addToEnd(int data)
            {
                Node newNode = new Node(data);
                if (head == null)
                {

                    head = newNode;
                    head.next = head;
                    return;
                }
                else
                {
                    Node temp = head;
                    while (temp.next != head)
                        temp = temp.next;
                    temp.next = newNode;
                    newNode.next = head;

                }
            }
            public void addAfter(int data, int insertAfter)
            {
                Node p = head;
                while (p != null)
                {
                    if (p.value == insertAfter)
                        break;
                    p = p.next;
                }
                Node temp = p.next;
                Node newNode = new Node(data);
                newNode.next = temp;
                p.next = newNode;

            }
            public void Search(int value)
            {
                int found = 0;
                int position = 1;
                Node temp = head;
                while(temp!= null) { 

                if(temp.value == value)
                {
                    found = 1;
                        Console.WriteLine("The data is found at index :" + position);
                        break;

                }
                    position++;
                temp = temp.next;
                }
                if(temp== null) {
                    Console.WriteLine("Not found");
                }

            }
            public void deleteFirst()
            {
                if (head == null)
                {
                    return;
                }
                    if (head.next == head)
                    {
                        head = null;
                    }
                    else
                    {
                        Node temp = head;
                        Node firstNode = head;
                        while (temp.next != head)
                        {
                            temp = temp.next;
                        }
                        head = head.next;
                        temp.next = head;
                        firstNode = null;
                    }
               
            }

            public int CountList()
            {
                
               Node temp = this.head;
                int i = 0;
                if (temp != null)
                {
                    i++;
                    temp = temp.next;
                }
                while (temp != this.head)
                {
                    i++;
                    temp = temp.next;
                }
                return i;
            }
            public void deleteLast()
            {
                if (head == null)
                    return;
                    if (head.next == head)
                    {
                        head = null;
                    }
                    else
                    {
                        Node temp = head;
                        while(temp.next.next != head)
                        {
                            temp = temp.next;
                        }
                        Node lastNode = temp.next;
                        temp.next = this.head;
                        lastNode = null;
                        //temp.next = head;
                    }
                
                    }
            public void InsertBefore(int data, int insertBefore)
            {
                Node p = head;
                while (p != null)
                {
                    if (p.next.value == insertBefore)
                        break;
                    p = p.next;
                }
                Node temp = p.next;
                Node newNode = new Node(data);
                newNode.next = temp;
                p.next = newNode;

            }
            public void display()
            {
                Node temp = head;
                if (temp != null)
                {
                    Console.Write("The list contains: ");
                    while (true)
                    {
                        Console.Write(temp.value + " ");
                        temp = temp.next;
                        if (temp == this.head)
                            break;
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
            circularLinkedList list = new circularLinkedList();
            list.addToEmptyList(8);
            list.addToEnd(7);
            list.addToEnd(6);
            list.addToEnd(9);
            list.addToBegin(10);
            list.addToBegin(20);
            list.addAfter(35, 7);
            //list.InsertBefore(45, 6);
            list.display();
            //Console.WriteLine("Node is deleted");
            //list.deleteFirst();
            //list.display();
            //list.deleteLast();
            //list.display();
            //int result = list.CountList();
            //Console.WriteLine("The count is" + result);
            //list.Search(6);
            //list.DeleteAtEnd();
            //list.display();
            //list.createCircularLinkedList(7);
            //list.createCircularLinkedList(8);
            //list.createCircularLinkedList(9);
            //list.createCircularLinkedList(11);
            //list.PrintList();
        }
    }
}

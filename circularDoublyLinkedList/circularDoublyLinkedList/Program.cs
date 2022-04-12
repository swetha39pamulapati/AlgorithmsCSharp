using System;

namespace circularDoublyLinkedList
{
    class Program
    {
      public  class Node
        {
            public int value;
            public Node next;
            public Node prev;
            
            public Node(int x)
            {
                value = x; next = null;prev = null;
            }
        }
        public class CircularDoublyLinkedList
        {
            private Node head;
            public CircularDoublyLinkedList()
            {
                head = null;
            }
            public void createEmptyList(int data)
            {
                Node newNode = new Node(data);
                head = newNode;
                newNode.prev = head;
                newNode.next = head;
            }
            public void insertAtBegin(int data)
            {
                Node newNode = new Node(data);
                Node temp = head;
                if (head == null)
                {
                    head = newNode;
                    newNode.prev = head;
                    newNode.next = head;
                }
                else
                { 

                    while(temp.next!= head)
                    {
                        temp = temp.next;
                    }
                    
                    temp.next = newNode;
                    newNode.next = head;
                    newNode.prev = temp;
                    head.prev = newNode;
                    head = newNode;

                    
                }
                }
            public void insertAfter(int data, int insertAfter)
            {
                Node temp = head;
                Node p = head;
                Node newNode = new Node(data);
                if (head == null)
                    return;
                //else
                //{
                //    while (temp.next != head)
                //    {
                //        temp = temp.next;
                //    }
                //    temp.next = newNode;
                //    newNode.next = head;
                //    newNode.prev = temp;
                //    head.prev = newNode;
                //    head = newNode;
                //}

                while (p != null)
                {
                    if (p.value == insertAfter)
                        break;
                    p = p.next;
                }
                temp = p.next;
                p.next = newNode;
                newNode.next = temp;
                temp.prev = newNode;
                newNode.prev = p;
            }
            public void DeleteFirst()
            {
                Node firstNode = head;
                Node p = head;
                
                if(head!= null) { 
                if (head.next == head)
                {
                    head = null;
                }
                    else
                    {
                        while(p.next!= head)
                        {
                            p = p.next;
                        }
                        Node temp = head.next;
                        head = temp;
                        p.next = head;
                        head.prev = p;
                        firstNode = null;
                    }
                }
            }
            public void countList()
            {
                int count = 1;
                Node p = head;
                while(p.next!= head)
                {
                    count++;
                    p = p.next;
                }
                Console.WriteLine("The count is" + count);
            }
            public void deleteValue(int value)
            {
                //Incomplete to check for delete the 1st Node;
                Node p = head;

                if (head != null)
                {
                    if (head.next == head)
                    {
                        head = null;
                    }
                    else
                    {
                        while(p.next != head)
                        {
                            if (p.next.value == value)
                                break;
                            p = p.next;
                        }
                        Node toDel = p.next;
                        p.next = p.next.next;
                        p.next.prev = p;
                        toDel = null;
                    }
                    }
                }
            public void Search(int value)
            {
                Node p = head;
                int found = 0;
                if(head!= null) { 
                while(p.next!= head)
                {
                    if(p.value== value)
                    {
                        found = 1;
                        break;
                    }
                    p = p.next;
                }
                }
                if (found == 1)
                    Console.WriteLine("data found");
                else
                    Console.WriteLine("DataNot found");
            }
                    
            public void deleteEnd()
            {
                Node firstNode = head;
                Node p = head;
                if (head != null)
                {
                    if (head.next == head)
                    {
                        head = null;
                    }
                    else
                    {
                while(p.next.next != head)
                        {
                            p = p.next;
                        }
                        Node lastNode = p;
                        p.next = head;
                        head.prev = p;
                        lastNode = null;
                    }
                }
                    }
                    public void insertAtEnd(int data)
            {
                Node newNode = new Node(data);
                Node temp = head;
                if(head == null)
                {
                    head = newNode;
                    newNode.prev = head;
                    newNode.next = head;
                }
                else
                {
                    while(temp.next!= head)
                    {
                        temp = temp.next;
                    }
                    temp.next = newNode;
                    newNode.next = head;
                    newNode.prev = temp;
                    head.prev = newNode;
                }
            }
            public void display()
            {
                Node temp = head;
                if (head == null)
                    Console.Write("The list is empty");

                while(temp != null)
                {
                    Console.Write(temp.value +" ");
                    temp = temp.next;
                    if (temp == head)
                        break;
                }
                
            }
        }
        static void Main(string[] args)
        {
            CircularDoublyLinkedList list = new CircularDoublyLinkedList();
            list.createEmptyList(9);
            
            list.insertAtBegin(8);
            list.insertAtEnd(10);
            list.insertAtBegin(12);
            list.insertAfter(11,10);
            list.display();
            list.countList();
            list.Search(10);
            Console.WriteLine("\n Deleted 1st");
            list.DeleteFirst();
            list.display();
            Console.WriteLine("\n Deleted last");
            list.deleteEnd();
            list.display();
            Console.WriteLine("\n Deleted value");
            list.deleteValue(10);
            list.display();
            Console.WriteLine("\n Count is");
            list.countList();
            list.Search(10);
            
        }
    }
}

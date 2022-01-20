using System;
using static SinglyLinkedList.Program;

namespace SinglyLinkedList
{
    class Program
    {


        public class Node
        {
            public int Value;
            public Node Next;
            public Node(int value)
            {
                Value = value;
                Next = null;
            }
        }
        public class SingleLinkedList
        {
           private Node head;
            public SingleLinkedList()
            {
                head = null;
            }
           public void reverse()
            {
                Node tempNode = head;
                Node prevNode = head;
                Node curNode = head.Next;
                prevNode.Next = null;
                while(curNode != null)
                {
                    tempNode = curNode.Next;
                    curNode.Next = prevNode;
                    prevNode = curNode;
                    curNode = tempNode;
                }
                head = prevNode;
            }
            public void InsertFront(int new_data)
            {
                Node new_node = new Node(new_data);
                new_node.Next = head;
                head = new_node;
            }
            public void InsertEnd(int new_data)
            {
                Node new_node = new Node(new_data);

                if (head == null)
                {
                    head = new Node(new_data);
                    return;
                }
                new_node.Next = null;

                Node last = head;
                while (last.Next != null)
                    last = last.Next;

                last.Next = new_node;
                return;
            }
            //Inserts a new element at the given position
            public void PushAtIndex(int newElement, int position)
            {
                Node newNode = new Node(newElement);
                newNode.Value = newElement;
                newNode.Next = null;

                if (position < 1)
                {
                    Console.Write("\nposition should be >= 1.");
                }
                else if (position == 1)
                {
                    newNode.Next = head;
                    head = newNode;
                }
                else
                {

                    Node temp = new Node(newElement);
                    temp = head;
                    for (int i = 1; i < position - 1; i++)
                    {
                        if (temp != null)
                        {
                            temp = temp.Next;
                        }
                    }

                    if (temp != null)
                    {
                        newNode.Next = temp.Next;
                        temp.Next = newNode;
                    }
                    else
                    {
                        Console.Write("\nThe previous node is null.");
                    }
                }
            }

            //Removes element at specified position
            public void deleteNode(int position)
            {
                if (head == null) return;

                Node temp = head;

                if (position == 0)
                {
                    head = temp.Next;
                }
                for (int i = 0; temp != null && i < position - 1; i++)
                    temp = temp.Next;
                if (temp == null || temp.Next == null) return;
                Node next = temp.Next.Next;
                temp.Next = next;
            }
            public Node removeLastNode(Node head)
            {
                if (head == null)
                    return null;

                if (head.Next == null)
                {
                    return null;
                }

                // Find the second last node
                Node second_last = head;
                while (second_last.Next.Next != null)
                    second_last = second_last.Next;

                // Change next of second last
                second_last.Next = null;

                return head;
            }
            public Node push(Node head_ref, int new_data)
            {
                Node new_node = new Node(new_data);
                new_node.Value = new_data;
                new_node.Next = (head_ref);
                (head_ref) = new_node;
                return head_ref;
            }
            public Node removeFirstNode(Node head)
            {
                if (head == null)
                    return null;

                // Move the head pointer to the next node
                Node temp = head;
                head = head.Next;

                return head;
            }

            public void printList()
            {
                Node tnode = head;
                while (tnode != null)
                {
                    Console.Write(tnode.Value + " ");
                    tnode = tnode.Next;
                }
            }


        }
        static void Main(string[] args)
        {

            SingleLinkedList list = new SingleLinkedList();
            Node head = null;


            list.InsertFront(7);
            list.InsertFront(1);
            list.InsertFront(3);
            list.InsertFront(2);
            list.InsertFront(8);
            Console.WriteLine("\nCreated Linked list at the front is: ");
            list.printList();
            Console.WriteLine("\n Reversed List is: ");
            list.reverse();
            list.printList();
            list.InsertEnd(25);
            Console.WriteLine("\nCreated Linked list at the end is: ");
            list.printList();

            list.PushAtIndex(100, 2);
            Console.WriteLine("\nPush element at index 2: ");
            list.printList();

            list.deleteNode(4);
            Console.WriteLine("\nLinked List after Deletion at position 4: ");
            list.printList();

            head = list.push(head, 12);
            head = list.push(head, 29);
            head = list.push(head, 11);
            head = list.push(head, 23);
            head = list.push(head, 8);
            head = list.removeFirstNode(head);
            Console.WriteLine("\nRemove First Node: ");
            for (Node temp = head; temp != null; temp = temp.Next)
                Console.Write(temp.Value + " ");


            Console.WriteLine("\nRemove Last Node: ");
            head = list.removeLastNode(head);
            for (Node temp = head; temp != null; temp = temp.Next)
                Console.Write(temp.Value + " ");
        }

    }
}

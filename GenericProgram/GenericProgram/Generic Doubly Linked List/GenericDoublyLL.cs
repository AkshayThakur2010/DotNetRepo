using System;
using System.Collections.Generic;
using System.Text;

namespace GenericProgram.Generic_Doubly_Linked_List
{
    public class Node<T>
    {
        public T data;
        public Node<T> next;
        public Node<T> prev;
        public Node(T Val)
        {
            data = Val;
            next = null;
            prev = null;
        }
    }
    public class GenericDoublyLL<T>
    {
        Node<T> first = null;

        public void InsertAtFirst(T iValue)
        {
            Node<T> newn = new Node<T>(iValue);
            if (first == null)
            {
                first = newn;
            }
            else
            {
                newn.next = first;
                first.prev = newn;
                first = newn;
            }
        }

        public void InsertAtLast(T iValue)
        {
            Node<T> newn = new Node<T>(iValue);
            if (first == null)
            {
                first = newn;
            }
            else
            {
                Node<T> temp = first;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newn;
                newn.prev = temp;
            }
        }

        public void DeleteList()
        {
            first = null;
        }

        public void DisplayList()
        {
            Node<T> temp = first;
            while (temp != null)
            {
                Console.Write($" {temp.data}");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}

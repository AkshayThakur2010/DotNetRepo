using System;
using System.Collections.Generic;
using System.Text;

namespace GenericProgram
{
    public class Node<T>
    {
        public T data;
        public Node<T> next;
        public Node(T iVal)
        {
            data = iVal;
            next = null;
        }
    }
   public class GenericLinkList<T>
    {
        Node<T> first = null;

        public void InsertAtFirst(T iVal)
        {
            Node<T> newn = new Node<T>(iVal);
            if (first == null)
            {
                first = newn;
            }
            else
            {
                newn.next = first;
                first = newn;
            }
        }

        public void DisplayList()
        {
            Console.WriteLine("Link List Data is given Below :");
            Node<T> temp = first;
            while (temp != null)
            {
                Console.Write($" {temp.data} ");
                temp = temp.next;
            }
            Console.WriteLine();
        }

        public int Count()
        {
            int iCnt = 0;
            if (first == null)
            {
                return iCnt;
            }
            Node<T> temp = first;
            while (temp != null)
            {
                temp = temp.next;
                iCnt++;
            }
            return iCnt;
        }

        public void InsertAtLast(T iVal)
        {
            Node<T> newn = new Node<T>(iVal);
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
            }
        }

        public void DeleteList()
        {
            first = null;
        }
        public void DeleteAtPosition(int iPos)
        {
            int iListSize = Count();
            if (iListSize == 0 || first == null)
            {
                return;
            }
            if (iPos == 1)
            {
                DeleteFirst();
            }
            else if (iPos == iListSize)
            {
                DeleteLast();
            }
            else
            {
                Node<T> temp = first;
                for (int i = 1; i < iPos - 1; i++)
                {
                    temp = temp.next;
                }
                temp.next = temp.next.next;
            }
        }

        public void DeleteFirst()
        {
            if (first == null)
            {
                return;
            }
            else
            {
                first = first.next;
            }
        }

        public void DeleteLast()
        {
            Node<T> temp = first;
            if (temp == null)
            {
                return;
            }
            else if (temp.next == null)
            {
                temp = null;
            }
            else
            {
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                temp.next = null;
            }
        }

        public void InsertAtPosition(T iVal, int iPos)
        {
            Node<T> newn = new Node<T>(iVal);
            Node<T> temp = first;
            int iListSize = Count();
            //if(iPos)
            if (iPos <= 0 || iPos > (iListSize + 1))
            {
                return;
            }
            else if (iPos == 1)
            {
                InsertAtFirst(iVal);
            }
            else if (iPos == (iListSize + 1))
            {
                InsertAtLast(iVal);
            }
            else
            {
                for (int i = 1; i < iPos - 1; i++)
                {
                    temp = temp.next;
                }
                newn.next = temp.next;
                temp.next = newn;
            }
        }
    }
}

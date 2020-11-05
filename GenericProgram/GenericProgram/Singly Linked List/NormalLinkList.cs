using System;
using System.Collections.Generic;
using System.Text;

namespace GenericProgram
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int iVal)
        {
            data = iVal;
            next = null;
        }
    }
    public class NormalLinkList
    {
        Node first = null;

        public void DeleteList()
        {
            first = null;
        }
        public void InsertAtFirst(int iVal)
        {
            Node newn = new Node(iVal);
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
                Node temp = first;
                for (int i = 1; i < iPos - 1; i++)
                {
                    temp = temp.next;
                }
                temp.next = temp.next.next;
            }
        }

        public void InsertAtPosition(int iVal, int iPos)
        {
            Node newn = new Node(iVal);
            Node temp = first;
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
            Node temp = first;
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

        public void InsertAtLast(int iVal)
        {
            Node newn = new Node(iVal);
            if (first == null)
            {
                first = newn;
            }
            else
            {
                Node temp = first;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newn;
            }
        }

        public int Count()
        {
            int iCnt = 0;
            if (first == null)
            {
                return iCnt;
            }
            Node temp = first;
            while (temp != null)
            {
                temp = temp.next;
                iCnt++;
            }
            return iCnt;
        }

        public void DisplayList()
        {
            Console.WriteLine("Link List Data is given Below :");
            Node temp = first;
            while (temp != null)
            {
                Console.Write($" {temp.data} ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }

}

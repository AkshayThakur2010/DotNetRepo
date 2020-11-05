using System;
using System.Collections.Generic;
using System.Text;

namespace GenericProgram.Doubly_Linked_List
{
    public class Node
    {
        public int data;
        public Node next;
        public Node prev;
        public Node(int value)
        {
            data = value;
            next = null;
            prev = null;
        }
    }
    public class NormalDoubleLL
    {
        Node first = null;
        public void InsertAtFirst(int iValue)
        {
            Node newn = new Node(iValue);
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

        public void InsertAtLast(int iValue)
        {
            Node newn = new Node(iValue);
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
                newn.prev = temp;
            }
        }


        public void DeleteAtPosition(int pos)
        {
            int iCount = Count();
            if (first == null || pos < 0 || pos > iCount)
            {
                return;
            }

            if(pos == 1)
            {
                DeleteFirst();
            }
            else if(pos == iCount)
            {
                DeleteLast();
            }
            else
            {
                Node temp = first;
                for (int i = 1; i < (pos - 1); i++)
                {
                    temp = temp.next;
                }

                temp.next = temp.next.next;
                temp.next.next.prev = temp;
            }

        }

        public void InsertAtPosition(int iValue, int pos)
        {
            Node newn = new Node(iValue);
            int iCount = Count();

            if (pos < 0 || pos > (iCount + 1))
            {
                return;
            }

            if (first == null)
            {
                first = newn;
            }
            else if (pos == (iCount + 1))
            {
                InsertAtLast(iValue);
            }
            else
            {
                Node temp = first;
                for (int i = 1; i < (pos - 1); i++)
                {
                    temp = temp.next;
                }
                newn.next = temp.next;
                newn.prev = temp;
                temp.next = newn;
            }
        }

        public void DeleteFirst()
        {
            if (first.next == null)
            {
                first = null;
            }
            else
            {
                first = first.next;
                first.prev = null;
            }
        }

        public void DeleteLast()
        {
            int iCount = Count();
            if (iCount == 1)
            {
                first = null;
            }
            else
            {
                Node temp = first;
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                temp.next = null;
            }
        }

        public void DeleteList()
        {
            first = null;
        }

        public void DisplayList()
        {
            Node temp = first;
            while (temp != null)
            {
                Console.Write($" {temp.data}");
                temp = temp.next;
            }
            Console.WriteLine();
        }

        public int Count()
        {
            int iCnt = 0;
            Node temp = first;

            if (first == null)
            {
                return iCnt;
            }

            while (temp != null)
            {
                iCnt++;
                temp = temp.next;
            }

            return iCnt;
        }
    }
}

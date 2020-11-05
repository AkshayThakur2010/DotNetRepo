using System;
using System.Collections.Generic;
using System.Text;

namespace GenericProgram.Generic_Doubly_Linked_List
{
    public class GenericDoublyLLMenu<T> : GenericDoublyLL<T>
    {
        int iChoice = 1;
        T iValue;
        int iCount = 0;
        int iPos = 0;
        public void DisplayMenu()
        {
            Console.WriteLine("..........................Link List Menu..........................");
            Console.WriteLine("1. Insert At First");
            Console.WriteLine("2. Insert At Last");
            Console.WriteLine("3. Display List");
            Console.WriteLine("4. Count Node");
            Console.WriteLine("5. Delete First");
            Console.WriteLine("6. Delete Last");
            Console.WriteLine("7. Insert At Position");
            Console.WriteLine("8. Delete At Position");
            Console.WriteLine("0. Exit");
        }

        public void GetUserInput()
        {
            while (iChoice != 0)
            {
                DisplayMenu();

                Console.WriteLine("Enter Your choice : ");
                iChoice = Convert.ToInt32(Console.ReadLine());

                switch (iChoice)
                {
                    case 1:
                        Console.WriteLine("Enter Value : ");
                        iValue = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
                        base.InsertAtFirst(iValue);
                        break;

                    case 2:
                        Console.WriteLine("Enter Value : ");
                        iValue = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
                        base.InsertAtLast(iValue);
                        break;
                    case 3:
                        base.DisplayList();
                        break;
                    case 4:
                        //iCount = base.Count();
                        Console.WriteLine($"Total Nodes in List : {iCount}");
                        break;
                    case 5:
                        //base.DeleteFirst();
                        break;
                    case 6:
                       // base.DeleteLast();
                        break;
                    case 7:
                        Console.WriteLine("Enter Position : ");
                        iPos = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Value :");
                        iValue = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
                        //base.InsertAtPosition(iValue, iPos);
                        break;
                    case 8:
                        Console.WriteLine("Enter Position to be delete : ");
                        iPos = Convert.ToInt32(Console.ReadLine());
                        //base.DeleteAtPosition(iPos);
                        break;

                }
            }
            Console.WriteLine("Thank you for Using Linked List...");
            base.DeleteList();
        }
    }
}

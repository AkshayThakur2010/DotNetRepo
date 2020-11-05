using GenericProgram.Doubly_Linked_List;
using System;
using System.Diagnostics;

namespace GenericProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            int iChoice = 0;
            MainMenu mObj = new MainMenu();


            Console.WriteLine("1. Create Normal Singly Link List");
            Console.WriteLine("2. Create Generic Singly Link List");
            Console.WriteLine("3. Create Normal Doubly Link List");
            Console.WriteLine("4. Create Generic Doubly Link List");

            Console.WriteLine("Enter Your Choice : ");
            iChoice = Convert.ToInt32(Console.ReadLine());

            switch (iChoice)
            {
                case 1:
                    mObj.CreateSinglyLL();
                    break;
                case 2:
                    mObj.GenericSinglyLL();
                    break;
                case 3:
                    mObj.CreateDoublyLL();
                    break;
                case 4:
                    mObj.GenericDoublyLL();
                    break;
            }

        }

    }
}

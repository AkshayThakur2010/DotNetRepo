using GenericProgram.Doubly_Linked_List;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericProgram
{
    public class MainMenu
    {
        public void CreateSinglyLL()
        {
            //Non-generic Link List
            NormalMenuLL nObj = new NormalMenuLL();
            nObj.GetUserInput();
        }

        public void CreateDoublyLL()
        {
            // Normal Doubly Linked List
            NormalDoubleLLMenu nObj = new NormalDoubleLLMenu();
            nObj.GetUserInput();
        }
        public void GenericDoublyLL()
        {
            int iChoice = 0;
            //Generic Linked List
            Console.WriteLine("....................Generic Doubly Linked List...................");
            Console.WriteLine("Which Type Link List you want to Creat:");
            Console.WriteLine("1. Integer Type.");
            Console.WriteLine("2. Double Type. ");
            Console.WriteLine("3. Character Type. ");
            Console.WriteLine("4. String Type. ");

            Console.WriteLine();
            Console.WriteLine("Enter Your Choice : ");
            iChoice = Convert.ToInt32(Console.ReadLine());

            switch (iChoice)
            {
                case 1:
                    GenericMenuLL<int> gObj = new GenericMenuLL<int>();
                    gObj.GetUserInput();
                    break;
                case 2:
                    GenericMenuLL<double> gdObj = new GenericMenuLL<double>();
                    gdObj.GetUserInput();
                    break;

                case 3:
                    GenericMenuLL<char> gcObj = new GenericMenuLL<char>();
                    gcObj.GetUserInput();
                    break;
                case 4:
                    GenericMenuLL<string> gsObj = new GenericMenuLL<string>();
                    gsObj.GetUserInput();
                    break;
            }
        }

        public void GenericSinglyLL()
        {
            int iChoice = 0;
            //Generic Linked List
            Console.WriteLine("....................Generic Singly Linked List...................");
            Console.WriteLine("Which Type Link List you want to Creat:");
            Console.WriteLine("1. Integer Type.");
            Console.WriteLine("2. Double Type. ");
            Console.WriteLine("3. Character Type. ");
            Console.WriteLine("4. String Type. ");

            Console.WriteLine();
            Console.WriteLine("Enter Your Choice : ");
            iChoice = Convert.ToInt32(Console.ReadLine());

            switch (iChoice)
            {
                case 1:
                    GenericMenuLL<int> gObj = new GenericMenuLL<int>();
                    gObj.GetUserInput();
                    break;
                case 2:
                    GenericMenuLL<double> gdObj = new GenericMenuLL<double>();
                    gdObj.GetUserInput();
                    break;

                case 3:
                    GenericMenuLL<char> gcObj = new GenericMenuLL<char>();
                    gcObj.GetUserInput();
                    break;
                case 4:
                    GenericMenuLL<string> gsObj = new GenericMenuLL<string>();
                    gsObj.GetUserInput();
                    break;
            }
        }
    }
}

using System;
using System.Diagnostics;

namespace GenericProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int iChoice = 0;


            //Non-generic Link List
            //NormalMenuLL nObj = new NormalMenuLL();
            //nObj.GetUserInput();

            //Generic Linked List
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

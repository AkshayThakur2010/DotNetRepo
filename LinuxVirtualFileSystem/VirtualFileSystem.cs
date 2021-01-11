using LinuxVirtualFileSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinuxVirtualFileSystem
{
    public class VirtualFileSystem
    {
        UFDT[] ufdtArr;
        SuperBlock superBlockObj;
        INode Head;

        public VirtualFileSystem()
        {
            ufdtArr = new UFDT[Constants.TOTALFILES];
            superBlockObj = new SuperBlock();
            Head = null;
        }

        public void CreateVFS()
        {
            CreateSuperBlock();
            CreateDILB();
            CreateUFDT();
            // DisplayAllFiles(Head);
        }

        private void CreateUFDT()
        {
            for (int i = 0; i < ufdtArr.Length; i++)
            {
                ufdtArr[i] = new UFDT();
                ufdtArr[i].ptrFileTable = null;
            }
        }

        private void CreateSuperBlock()
        {
            superBlockObj.FreeINode = Constants.TOTALFILES;
            superBlockObj.TotalINode = Constants.TOTALFILES;
        }

        private void CreateDILB()
        {
            INode[] inode = new INode[Constants.TOTALFILES];
            for (int i = (Constants.TOTALFILES - 1); i >= 0; i--)
            {
                inode[i] = new INode();
                inode[i].FileActualSize = 0;
                inode[i].FileName = $"Akshay {i}";
                inode[i].FileSize = 0;
                inode[i].FileType = Constants.NoFileType;
                inode[i].INodeNumber = i;
                inode[i].LinkCount = 0;
                inode[i].Permission = 0;
                inode[i].ReferenceCount = 0;
                inode[i].Next = null;
                inode[i].Prev = null;
                inode[i].Buffer = new string[Constants.MAXFILESIZE];
                if (i != 49)
                {
                    inode[i].Next = inode[i + 1];
                    inode[i + 1].Prev = inode[i];
                }
            }
            Head = inode[0];
        }

        private int CreateNewFile(INode Head, string fileName, string filePermission)
        {
            bool isFilePresent = false;
            int fd = 0;
            int ufdtPtr = 0;
            INode emptyINode = null;
            // Check Memory is Full or Not
            if (superBlockObj.FreeINode == 0)
            {
                Console.WriteLine("Memory is Full.. Please Delete Some files to Create New File");
                return -1;
            }

            isFilePresent = CheckFileExistByName(fileName);

            if (isFilePresent)
            {
                Console.WriteLine("File Already Exit in FileSystem.");
                return -1;
            }

            // Decrease Free Inode by One
            superBlockObj.FreeINode--;

            // Get Empty UFDT Record
            ufdtPtr = GetEmptyUFDT();

            //Allocate memory to File Table
            ufdtArr[ufdtPtr].ptrFileTable = new FileTable();

            // Get Empty INode
            emptyINode = GetFreeINode();

            emptyINode.FileName = fileName;
            emptyINode.FileType = Constants.REGULAR;
            emptyINode.LinkCount = 1;
            emptyINode.ReferenceCount = 1;
            emptyINode.Permission = Convert.ToInt32(filePermission);

            return fd;
        }

        private INode GetFreeINode()
        {
            INode temp = Head;

            if (temp.FileType == Constants.NoFileType)
            { return temp; }

            while(temp.FileType == Constants.NoFileType)
            {
                temp = temp.Next;
            }

            return temp;
        }

        private int GetEmptyUFDT()
        {
            int ret = 0;
            for (int i = 0; i < Constants.TOTALFILES; i++)
            {
                if (ufdtArr[i].ptrFileTable == null)
                {
                    ret = i;
                    break;
                }
            }
            return ret;
        }

        private bool CheckFileExistByName(string fileName)
        {
            INode temp = Head;
            bool isFilePresent = false;
            if (Head == null)
            {
                return false;
            }
            else
            {
                while (temp.Next == null)
                {
                    isFilePresent = temp.FileName.Equals(fileName) ? true : false;
                    if (isFilePresent)
                    {
                        break;
                    }
                    temp = temp.Next;
                }
            }
            return isFilePresent;
        }

        public void DisplayAllFiles(INode Head)
        {
            INode temp = Head;
            while (temp != null)
            {
                Console.WriteLine($"File : {temp.FileName}");
                temp = temp.Next;
            }
        }

        public void DisplayHelp()
        {
            Console.WriteLine("ls : To List All Files");
            Console.WriteLine("open : Open Regular file in Read Mode");
            Console.WriteLine("read : Read Regular File. ");
            Console.WriteLine("write : Write Data into Regular File.");
            Console.WriteLine("rm : Delete Regular File.");
            Console.WriteLine("stat : Display Info of a Regular File.");
            Console.WriteLine("exit : Exit From VFS");
        }

        public void DisplayManPage(string cmdName)
        {
            if (cmdName == string.Empty) { return; }
            if (cmdName.Equals("creat"))
            {
                Console.WriteLine("Description: Used to Create New Regular File.");
                Console.WriteLine("Usage : creat File_Name Permission");
            }
            if (cmdName.Equals("read"))
            {
                Console.WriteLine("Description: Used to Read File.");
                Console.WriteLine("Usage : read File_Name");
            }
            if (cmdName.Equals("write"))
            {
                Console.WriteLine("Description: Used to Write Data into Regular File.");
                Console.WriteLine("Usage : write File_Name");
            }
            if (cmdName.Equals("ls"))
            {
                Console.WriteLine("Description: Used to Display All Files");
                Console.WriteLine("Usage : ls");
            }
            if (cmdName.Equals("stat"))
            {
                Console.WriteLine("Description: Used to Display All Regular File information.");
                Console.WriteLine("Usage : stat File_Name");
            }
            if (cmdName.Equals("open"))
            {
                Console.WriteLine("Description: Used to open Regular File.");
                Console.WriteLine("Usage : open File_Name");
            }
            if (cmdName.Equals("close"))
            {
                Console.WriteLine("Description: Used to close Regular File.");
                Console.WriteLine("Usage : close File_Name");
            }

            Console.WriteLine();
        }

        public void GetUserInput()
        {
            string user_cmd;
            bool bChoice = true;
            string[] cmdArr;
            while (bChoice)
            {
                Console.WriteLine("Enter Command : ");
                user_cmd = Console.ReadLine();


                cmdArr = (user_cmd.Split(' '));

                //for(int i = 0;i < cmdArr.Length;i++)
                //{
                //    Console.WriteLine($"{cmdArr[i]}");
                //}

                switch (cmdArr.Length)
                {
                    case 1:
                        if (cmdArr[0].Equals("exit"))
                        {
                            Console.WriteLine("Thank you for using Vitual File System");
                            bChoice = false;
                        }
                        if (cmdArr[0].Equals("help"))
                        {
                            DisplayHelp();
                        }
                        break;
                    case 2:
                        if (cmdArr[0].Equals("man"))
                        {
                            DisplayManPage(cmdArr[1]);
                        }
                        break;
                    case 3:
                        if (cmdArr[0].Equals("creat"))
                        {
                            //for (int i = 0; i < cmdArr.Length; i++)
                            //{
                            //    Console.WriteLine($"{cmdArr[i]}");
                            //}
                        }
                        break;
                }
            }
        }
    }
}

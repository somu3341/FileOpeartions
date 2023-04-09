using FileOperations;
using System;
namespace FileOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose Option to Perform\n1.File Exits\n2.Read All Lines\n3.Read All Texts\n4.Copy File\n5.Exit");
                int option=Convert.ToInt32(Console.ReadLine());
                Operation operation = new Operation();
                switch(option)
                {
                    case 1:
                        operation.FileExits(@"D:\BridgeLabs\FileOpeartions\FileOperations\Example.txt");
                        break;
                    case 2:
                        operation.FileReadAllLines(@"D:\BridgeLabs\FileOpeartions\FileOperations\Example.txt");
                        break;
                        case 3:
                        operation.FileReadAllText(@"D:\BridgeLabs\FileOpeartions\FileOperations\Example.txt");
                        break;
                        case 4:
                        operation.FileCopy(@"D:\BridgeLabs\FileOpeartions\FileOperations\Example.txt",newFile:@"D:\BridgeLabs\FileOpeartions\FileOperations\newExample.txt");
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }           
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperations
{
    public class Operation
    {
        public void FileExits(string filePath)
        {
            if (File.Exists(filePath))
                Console.WriteLine("File Exits");
            else
                Console.WriteLine("File not Exits");
        }
    }
}

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
        public void FileReadAllLines(string filePath)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (var data in lines)
                {
                    Console.WriteLine(data);
                }
            }
            else
                Console.WriteLine("File not Exits");
        }
        public void FileReadAllText(string filePath)
        {
            if (!File.Exists(filePath))
            {
                string lines = File.ReadAllText(filePath);
                Console.WriteLine(lines);
            }
            else
                Console.WriteLine("file Not exits");
        }
        public void FileCopy(String filePath, string newFile)
        {
            if (File.Exists(filePath))
            {
                File.Copy(filePath, newFile);
            }
            else
                Console.WriteLine("File not Exits");
        }
        public void FileDelete(string newFile)
        {
            if (File.Exists(newFile))
            {
                File.Delete(newFile);
            }
            else
                Console.WriteLine("File not Exits");
        }
        public void FileStreamReader(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (StreamReader sr = File.OpenText(filePath))
                {
                    while (sr.ReadLine() != null)
                    {
                        Console.WriteLine(sr.ReadLine);
                    }
                }
            }
            else
                Console.WriteLine("File not Exits");
        }
    }
}

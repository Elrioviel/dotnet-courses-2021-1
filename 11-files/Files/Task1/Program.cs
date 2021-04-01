using System;
using System.IO;
using System.Collections.Generic;

namespace Task1
{
    
    class Program
    {
        public static void ProcessFile(string filePath)
        {

            if (File.Exists(filePath))
            {
                string fileContent = File.ReadAllText(filePath);
                string[] integerStrings = fileContent.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                int[] integers = new int[integerStrings.Length];
                for (int i = 0; i < integerStrings.Length; i++)
                {
                    integers[i] = int.Parse(integerStrings[i]);
                }
                for (int i = 0; i< integers.Length; i++)
                {
                    integers[i] *= integers[i];
                    
                }
                File.WriteAllText(filePath, string.Empty);
                File.WriteAllLines(filePath, Array.ConvertAll(integers, x => x.ToString()));
                
                
            }
            
        }
        public static void WriteFileContent(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);
            string line = sr.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
            sr.Close();
        }
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Ghalia\Desktop\Study\dotnet-courses-2021-1\11-files\Files\Task1\disposable_task_file.txt";
            Console.WriteLine("File before changes:");
            WriteFileContent(filePath);
            Console.WriteLine("File processed:");
            ProcessFile(filePath);
            WriteFileContent(filePath);
        }
    }
}

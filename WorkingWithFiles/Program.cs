using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\opilane\data\test.txt";
            List<string> dataFromFile = File.ReadAllLines(filePath).ToList();

            foreach(string line in dataFromFile)
            {
                Console.WriteLine($"Data from file: {line}");
            }


            dataFromFile.Add("grapes");
            File.WriteAllLines(filePath, dataFromFile);
        }
    }
}

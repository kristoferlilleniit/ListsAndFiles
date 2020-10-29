using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace WishList
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\opilane\data\wishlist.txt";
            List<string> dataFromFile = File.ReadAllLines(filePath).ToList();
            Console.WriteLine("Enter your first wish: ");
            string firstwish = Console.ReadLine();
            Console.WriteLine("Enter your second wish: ");
            string secondwish = Console.ReadLine();
            Console.WriteLine("Enter your final wish: ");
            string thirdwish = Console.ReadLine();

            dataFromFile.Add(firstwish);
            File.WriteAllLines(filePath, dataFromFile);
            dataFromFile.Add(secondwish);
            File.WriteAllLines(filePath, dataFromFile);
            dataFromFile.Add(thirdwish);
            File.WriteAllLines(filePath, dataFromFile);
        }
    }
}

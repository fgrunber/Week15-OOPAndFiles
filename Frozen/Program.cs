using System;
using System.Collections.Generic;
using System.IO;

namespace OOPAndFiles
{
    class Program
    {
        class XmasWishes
        {
            string name;
            string wish;

            public XmasWishes(string _name, string _wish)
            {
                name = _name;
                wish = _wish;
            }

            public string Name
            {
                get { return name; }
            }

            public string Wish
            {
                get { return wish; }
            }
        }

        static void Main(string[] args)
        {
            List<XmasWishes> childWishes = new List<XmasWishes>();
            string[] wishesFromFile = GetDataFromFile();

            foreach (string line in wishesFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                XmasWishes newWishes = new XmasWishes(tempArray[0], tempArray[1]);
                childWishes.Add(newWishes);
            }

            foreach (XmasWishes wishFromList in childWishes)
            {
                Console.WriteLine($"{wishFromList.Name} wants {wishFromList.Wish}.");
            }
        }

        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }
        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\Robin\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
}

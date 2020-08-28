using System;
using System.Collections.Generic;

namespace collectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Three Basic Arrays
            int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(String.Join(", ", numbers));

            string[] names = new string[] { "Tim", "Martin", "Nikki", "Sara" };
            Console.WriteLine(String.Join(", ", names));

            bool[] altTf = new bool[10];
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    altTf[i] = true;
                    // Console.WriteLine(altTf[i]);
                }
                else
                {
                    altTf[i] = false;
                    // Console.WriteLine(altTf[i]);
                }
            }
            Console.WriteLine(GetFlavors());
            Dictionary<string, string> result = GetUsers();
            foreach (KeyValuePair<string, string> entry in result)
            {
                Console.WriteLine($"{entry.Key} likes {entry.Value}");
            }

        }
        // List of Flavors
        static string GetFlavors()
        {
            List<string> flavors = new List<string>()
            {
                "Chocolate",
                "Cookie",
                "Vanilla",
                "Strawberry",
                "Nuts"
            };
            Random rand = new Random();
            return flavors[rand.Next(flavors.Count)];
        }

        // User Info Dictionary
        static Dictionary<string, string> GetUsers()
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            List<string> people = new List<string>()
            {
                "Tim",
                "Martin",
                "Nikki",
                "Sara"
            };
            foreach (string person in people)
            {
                users[person] = GetFlavors();
            }
            return users;
        }

    }
}

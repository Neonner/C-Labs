using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Laba1_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:/Users/EpicentrK310/source/repos/Laba1/example.json";
            var json = File.ReadAllText(path);

            Console.WriteLine(json);

            Dictionary<int,string> dict = JsonConvert.DeserializeObject<Dictionary<int,string>>(json);
            Console.WriteLine(string.Join(" ", dict));
            FindDuplicateValues(dict);
        }
        static void FindDuplicateValues(Dictionary<int, string> dict1)
        {       
            Dictionary<string, int> valueCount = new Dictionary<string, int>();

            foreach (var kvp in dict1)
            {
              

                if (valueCount.ContainsKey(kvp.Value))
                {
                    valueCount[kvp.Value]++;
                }
                else
                {
                    valueCount[kvp.Value] = 1;
                }
            }

            Console.WriteLine("\nRepeating values:");
            foreach (var kvp in valueCount)
            {
                if (kvp.Value > 1)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value} times");
                }
            }
            Console.WriteLine("\n");
        }
    }
}

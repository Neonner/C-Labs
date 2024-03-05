using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string> { "sister", "brother", "kiwdasdasdasdasdi", "mama", "papa", "sister", "brother", "kiwdasdasdasdasdi", "mama", "papa"};

            Console.WriteLine(string.Join(" ", words));

            int totalLength = words.Sum(s => s.Length);

            Console.WriteLine("Сума довжин усіх рядків: " + totalLength);
            Console.ReadKey();
        }
    }
    
}

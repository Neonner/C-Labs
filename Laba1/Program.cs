using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Laba1
{
    class Program
    {
        static void Main()
        {
            bool active = true;

            Console.WriteLine("Write number of parking");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Random rnd = new Random();

            List<int> parking = new List<int>();

            for (int i = 0; i < n; i++)
            {
                parking.Add(rnd.Next(0, 1));
            }

            parking.Reverse();

            Console.WriteLine(string.Join("\n", parking));


            while(active)
            {
                Console.WriteLine("\n\t\tChoose an action");
                Console.WriteLine("\t1 - car go to the parking, 2 - car car leaving the parking slot, 3 - leave the project");

                int inputValue = int.Parse(Console.ReadLine());

                if (inputValue == 1)
                {
                    Console.WriteLine("\nChose the palce");
                    int inputPlace = int.Parse(Console.ReadLine());
                    GoCarParking(parking, n, inputPlace);
                    Console.WriteLine(string.Join("\n", parking));

                    active = true;
                }
                else if (inputValue == 2)
                {
                    Console.WriteLine("\nChose the car");
                    int inputNumCar = int.Parse(Console.ReadLine());
                    DeleteTheCar(parking, n, inputNumCar);
                    Console.WriteLine(string.Join("\n", parking));

                    active = true;
                }
                else if (inputValue == 3)
                {
                    active = false;
                }
                Console.WriteLine("\nFree place");
                FreeSeats(parking, n);
            }
            
        } 
        static void FreeSeats(List<int> parking, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (parking[i] == 0)
                {                   
                    Console.Write(i + 1 + " ");
                }
            }
        }
        static void GoCarParking (List<int> parking, int n, int inputPlace)
        {
            
            for (int i = 0; i < n; i++)
            {
                if (parking[inputPlace-1] == 0)
                {
                    Console.WriteLine("\n");
                    parking[inputPlace-1] = 1;
                    break;
                }
                else if (parking[inputPlace - 1] == 1)
                {
                    Console.WriteLine("There is no place for car");
                    break;
                }
            }
        }
        static void DeleteTheCar(List<int> parking, int n, int inputNumCar)
        {
            for (int i = 0; i < n; i++)
            {
                if (parking[inputNumCar - 1] == 1)
                {
                    Console.WriteLine("\n");
                    parking[inputNumCar - 1] = 0;
                    break;
                }
                else if (parking[inputNumCar - 1] == 0)
                {
                    Console.WriteLine("There is no car here");
                    break;
                }
            }
        }


    }
}
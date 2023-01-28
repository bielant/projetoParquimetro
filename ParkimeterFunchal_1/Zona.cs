using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//aSasasd

namespace ParkimeterFunchal_1
{
    internal class Zona
    {
        private double pricePerHour;
        private int maxTime;
        private int capacity;

        public Zona(double pricePerHour, int maxTime, int capacity)
        {
            this.pricePerHour = pricePerHour;
            this.maxTime = maxTime;
            this.capacity = capacity;

            string[] placeToPark = new string[capacity];
            string[] parklicencePlates = new string[capacity];
            Random rdn = new Random();
            
            string[] letters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            for (int i = 0; i < placeToPark.Length; i++)
            {
                placeToPark[i] = rdn.Next(0, 2).ToString();
            }

            for (int i = 0; i < placeToPark.Length; i++)
            {
                int probability = rdn.Next(0, 101);
                if (placeToPark[i] == "0")
                {
                    
                    placeToPark[i] = "Available";
                   
                }
                else
                {
                    if (probability > 0 && probability < 46)
                    {
                        placeToPark[i] = string.Format($"[{rdn.Next(0, 9)} {rdn.Next(0, 9)} - {letters[rdn.Next(0,letters.Length)]} {letters[rdn.Next(0, letters.Length)]} - {rdn.Next(0, 9)} {rdn.Next(0, 9)}]");
                    }
                    else if (probability >= 46 && probability < 91)
                    {
                        placeToPark[i] = string.Format($"[{letters[rdn.Next(0, letters.Length)]} {letters[rdn.Next(0, letters.Length)]} - {rdn.Next(0, 9)} {rdn.Next(0, 9)} - {letters[rdn.Next(0, letters.Length)]} {letters[rdn.Next(0, letters.Length)]}]");
                    }
                    else
                    {
                        placeToPark[i] = string.Format("International license plate");
                    }

                }
            }

            for (int i = 0; i < placeToPark.Length; i++)
            {
                if (placeToPark[i]=="Available")
                {
                    
                    Console.WriteLine($" The place [{i}] -> {placeToPark[i]} ");
                }
                else
                {
                    
                    Console.WriteLine($" The place [{i}] -> {placeToPark[i]} ");
                }

                
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ResortPrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = {200, 200, 180, 180, 160, 160, 160, 145};
            int nights = 0;
            int arrayLocation;
            int pricePerNight = 0;
            int total = 0;

            WriteLine("Enter the number of nights you will be staying");
            nights = Convert.ToInt32(ReadLine());
            arrayLocation = nights - 1;
            pricePerNight = prices[arrayLocation];
            total = pricePerNight * nights;


            if (nights > 8)
            {
                arrayLocation = 7;
            }

            WriteLine("The price for " + nights + " nights is $" + pricePerNight + " per night. Your total will be $" + total);
        } 
    }
}

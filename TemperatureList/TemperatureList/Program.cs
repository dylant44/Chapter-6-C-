using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TemperatureList
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            int total = 0;
            int distance = 0;
            int average = 0;
            string result = "";
            int[] temps = new int[7];

            WriteLine("Enter the high temperature for 7 days");

            for(int i = 0; i < 7; i++)
            {
                WriteLine("Day - " + (i + 1));
                temps[i] = Convert.ToInt32(ReadLine());
                total = temps[i] + total;
            }

            WriteLine("");
            average = total / 7;
            WriteLine("The week average high was " + average);

            for (int j = 0; j < 7; j++)
            {
                distance = average - temps[j];
                if(distance < 0)
                {
                    result = Math.Abs(distance) + " degrees higher than the average";
                }
                else if(distance == 0)
                {
                    result = "the same as the average";
                }
                else
                {
                    result = distance + " degrees lower than the average";
                }
                WriteLine("The day " + j + " high was " + temps[j] + ". It was " + result);
            }
        }
    }
}

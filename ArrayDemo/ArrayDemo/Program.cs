using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            int location = 0;
            int[] arr = new int[8];

            WriteLine("Enter numbers to fill the array");

            for(int i = 0; i < 8; i++)
            {
                WriteLine("Enter number " + i);
                arr[i] = Convert.ToInt32(ReadLine());
            }

            while(input != 999)
            {
                WriteLine("Enter 1 to display numbers in forward order, 2 to display them in reverse, and 3 to pick a specific location");
                input = Convert.ToInt32(ReadLine());

                if (input == 1)
                {
                    for(int j = 1; j < 9; j++)
                    {
                        WriteLine(arr[j]);
                    }
                }

                else if(input == 2)
                {
                    for (int k = 7; k >= 0; k--)
                    {
                        WriteLine(arr[k]);
                    }
                }

                else if(input == 3)
                {
                    WriteLine("Enter location you want displayed");
                    location = Convert.ToInt32(ReadLine());

                    WriteLine(arr[location - 1]);
                }
                  

            }
        }
    }
}

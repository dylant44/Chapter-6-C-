using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SavingIntoAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            WriteLine("\n\nRead and Print elements of an array: \n");
            WriteLine("------------------------------------------");
            WriteLine("input 10 elements in the array");

            for(int i = 1; i < 11; i++)
            {
                WriteLine("Enter number - " + i);
                arr[i] = Convert.ToInt32(ReadLine());
            }

            for(int j = 0; j < arr.Length; j++)
            {
                WriteLine("Numbers entered were " + arr[j]);
            }
        }
    }
}

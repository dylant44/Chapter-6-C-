using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CheckZips
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zipCode = {52801, 52801, 52803, 52804, 52805, 52806, 52807, 52808, 52809, 52810 };
            int userZip = 0;
            int result = 0;

            WriteLine("Enter you zip code to see if we deliver to your area");
            userZip = Convert.ToInt32(ReadLine());

            for(int i = 0; i < 10; i++)
            {
                if(zipCode[i] == userZip)
                {
                    WriteLine("Yes we deliver to your area");
                    result = 1;
                }
            }

            if (result != 1)
            {
                WriteLine("No we do not deliver to your area");
            }
        }
    }
}

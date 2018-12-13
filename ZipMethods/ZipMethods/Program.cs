using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ZipMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string entryZip;
            Write("Enter a ZIP code for delivery");
            entryZip = ReadLine();
            displayZips(entryZip);
        }
        static void displayZips(string entryZip)
    }
}

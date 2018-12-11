using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ScoresComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[4];
            int prevScore = 0;
            int improvement = 0;

            WriteLine("Enter Test Scores Between 0 and 100");
            WriteLine("----------------------------");
            for(int i = 0; i < 4; i++)
            {
                WriteLine("Test #" + (i + 1));
                scores[i] = Convert.ToInt32(ReadLine());

                if (scores[i] > prevScore)
                {
                    improvement = improvement + 1;
                }
                else if(scores[i] < prevScore)
                {
                    improvement = improvement + 2;
                }
                else if(scores[i] == prevScore)
                {
                    improvement = improvement + 1;
                }
                prevScore = scores[i];
            }

            WriteLine("");

            if (improvement == 4)
            {
                for (int j = 0; j < 4; j++)
                {
                    WriteLine(scores[j]);
                }
                WriteLine("Congrats! You improved every time!");
            }
            else 
            {
                for (int j = 0; j < 4; j++)
                {
                    WriteLine(scores[j]);
                }

                WriteLine("You didn't improve consistently! Your scores should have been in this order:");

                for (int j = 3; j >= 0; j--)
                {
                    WriteLine(scores[j]);
                }
            }
        }
    }
}

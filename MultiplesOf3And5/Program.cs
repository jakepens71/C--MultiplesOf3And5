using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesOf3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            int maxNumber = 1000;

            for (int i = 0; i < maxNumber; i++)
            {
                if (i % 3 == 0)
                {
                    numbers.Add(i);
                }
            }

            for (int y = 0; y < maxNumber; y++)
            {
                if (y % 5 == 0)
                {
                    numbers.Add(y);
                }
            }

            int total = (from number in numbers where number < maxNumber select number).Distinct().Sum();

            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}

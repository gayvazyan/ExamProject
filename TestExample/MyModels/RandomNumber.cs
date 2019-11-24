using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestExample.MyModels
{
    public static class RandomNumber
    {
        public static List<int> GetRandomNumbers(int count)
        {
            Random random = new Random();
            List<int> randomNumbers = new List<int>();

            for (int i = 0; i < count; i++)
            {
                int number;

                do number = random.Next(1,6);
                while (randomNumbers.Contains(number));

                randomNumbers.Add(number);
            }

            return randomNumbers;
        }
    }
}

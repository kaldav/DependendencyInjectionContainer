using LotteryWinnerGenerator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormalWinnerGenerator
{
    public class NormalWinnerGenerator : INumberGeneration
    {
        public IEnumerable<int> GetNumbers()
        {
            Random r = new Random();
            List<int> numbers = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                numbers.Add(r.Next(1, 100));
            }
            return numbers;
        }
    }
}

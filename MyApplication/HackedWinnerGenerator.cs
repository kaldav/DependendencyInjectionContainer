using LotteryWinnerGenerator.Interfaces;
using System.Collections.Generic;

namespace MyApplication
{
    public class HackedWinnerGenerator : INumberGeneration
    {
        public IEnumerable<int> GetNumbers()
        {
            return new List<int> { 1, 2, 3, 4, 5 };
        }
    }
}

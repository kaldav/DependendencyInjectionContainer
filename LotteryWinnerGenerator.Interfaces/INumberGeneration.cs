using System.Collections.Generic;

namespace LotteryWinnerGenerator.Interfaces
{
    public interface INumberGeneration
    {
        IEnumerable<int> GetNumbers();
    }
}

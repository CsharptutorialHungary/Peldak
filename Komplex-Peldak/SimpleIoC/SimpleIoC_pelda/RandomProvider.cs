using System;

namespace SimpleIoC_pelda
{
    public interface IRandomProvider
    {
        Random Random { get; }
    }

    public class RandomProvider : IRandomProvider
    {
        public RandomProvider()
        {
            Random = new Random();
        }

        public Random Random { get; }
    }
}

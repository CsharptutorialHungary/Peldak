namespace SimpleIoC_pelda
{
    public interface IRandomInstance
    {
        void Print();
    }

    public class RandomInstance : IRandomInstance
    {
        private readonly ILog _log;
        private readonly int _number;

        public RandomInstance(ILog log, IRandomProvider randomProvider)
        {
            _log = log;
            _number = randomProvider.Random.Next(0, 100);
        }

        public void Print()
        {
            _log.Write("Instance created. Random number: {0}", _number);
        }
    }
}

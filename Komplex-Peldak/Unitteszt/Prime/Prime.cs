using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Tests")]

namespace Prime
{
    internal class PrimeTools
    {
        public bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;

            for (int i = 2; i < (number / 2); i++)
            {
                if (number % 2 == 0) return false;
            }
            return true;
        }
    }
}
using System.Collections;

namespace pelda_yield
{
    class SzuperCsapat : IEnumerable
    {
        public SzuperCsapat() { }

        public IEnumerator GetEnumerator()
        {
            for (int i=0; i<4; i++)
            {
                switch (i)
                {
                    case 0:
                        yield return "Hannibal";
                        break;
                    case 1:
                        yield return "Szépfiú";
                        break;
                    case 2:
                        yield return "Murdock";
                        break;
                    case 3:
                        yield return "Rosszfiú";
                        break;
                    default:
                        yield return null;
                        break;
                }
            }
        }
    }
}

using System.Collections;

namespace pelda_ienumerable_jobb
{
    class SzuperCsapat : IEnumerable
    {
        private string[] _tagok;

        public SzuperCsapat()
        {
            _tagok = new string[] { "Hannibal", "Szépfiú", "Murdock", "Rosszfiú" };
        }

        public IEnumerator GetEnumerator()
        {
            return _tagok.GetEnumerator();
        }
    }
}

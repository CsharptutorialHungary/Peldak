namespace pelda_reflection
{
    public class Class1
    {
        public const int Konstans = 42;

        public int Tulajdonsag
        {
            get;
            set;
        }

        public Class1()
        {
            Tulajdonsag = 33;
            PrivateTulajdonsag = 44;
        }

        public void Metodus()
        {
            Tulajdonsag++;
        }

        public int Metodus2(int x)
        {
            return Tulajdonsag % x;
        }

        private int PrivateTulajdonsag { get; set; }

    }
}

namespace pelda_delegate2
{
    class Program
    {
        public delegate void Foo();
        public delegate void Bar();

        public static void Valami() { }

        static void Main(string[] args)
        {
            Foo x = Valami;
            //Hibát fog eredményezni:
            //Bar y = x;

        }
    }
}

using System;

namespace pelda_tervminta_strategy
{
    public interface IMuvelet
    {
        int Elvegez(int a, int b);
        char Jel { get; }
    }

    public class Muveletvegzo
    {
        public IMuvelet MuveletiContext { get; set; }

        public void Szamol(int a, int b)
        {
            int eredmeny = MuveletiContext.Elvegez(a, b);
            Console.WriteLine("{0} {1} {2} = {3}", a, MuveletiContext.Jel, b, eredmeny);
        }
    }

    public class Osszead : IMuvelet
    {
        public char Jel
        {
            get { return '+'; }
        }

        public int Elvegez(int a, int b)
        {
            return a + b;
        }
    }

    public class Kivonas : IMuvelet
    {
        public char Jel
        {
            get { return '-'; }
        }

        public int Elvegez(int a, int b)
        {
            return a - b;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Muveletvegzo muveletvegzo = new Muveletvegzo();
            muveletvegzo.MuveletiContext = new Osszead();
            muveletvegzo.Szamol(5, 9);
            muveletvegzo.MuveletiContext = new Kivonas();
            muveletvegzo.Szamol(5, 9);
            Console.ReadKey();
        }
    }
}

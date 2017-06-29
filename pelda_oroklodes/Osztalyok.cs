using System;

namespace pelda_oroklodes
{
    //absztrakt ősosztály. A többi objektum őse
    public abstract class Ososztaly
    {
        //x és y kooridnáták, tulajdonságok, amiket csak olvasni lehet
        //viszont az ősosztály írhatja is őket
        public int X { get; private set; }
        public int Y { get; private set; }

        //absztrakt rajzoló függvény, minden leszármazott osztálynak meg kell valósítania
        public abstract void Rajzol();

        //konstruktor x és y koordináták beállítására
        public Ososztaly(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    //teglalap, ami az ősosztályból származik.
    //definiálja a Rajzol metódust, illetve két új tulajdonságot is
    public class Teglalap : Ososztaly
    {
        //Téglalap méretetét beállító tulajdonságok
        public int Szelesseg { get; private set; }
        public int Magassag { get; private set; }

        //konstruktor, ami az ősosztály konstruktorát is hívja
        public Teglalap(int x, int y, int szele, int magassag) : base(x, y)
        {
            Szelesseg = szele;
            Magassag = magassag;
        }

        //Rajzol függvény megvalósítása
        public override void Rajzol()
        {
            Console.SetCursorPosition(X, Y);
            for (int i = 0; i < Magassag; i++)
            {
                for (int j = 0; j < Szelesseg; j++)
                {
                    if (i == 0 || i == Magassag-1) Console.Write("-");
                    else
                    {
                        if (j == 0 || j==Szelesseg-1) Console.Write("|");
                        else Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

    //A négyzet megvalósítása
    public sealed class Negyzet: Teglalap
    {
        public Negyzet(int x, int y, int meret) : base(x, y, meret, meret) { }
    }
}

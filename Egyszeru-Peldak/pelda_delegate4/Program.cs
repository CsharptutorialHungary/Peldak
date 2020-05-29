namespace pelda_delegate4
{
    class Allat { }

    class Novenyevo : Allat { }

    class Husevo : Allat { }

    delegate void DoHusevoStuff(Husevo husevo);

    class Program
    {
        static void DoAllatStuff(Allat allat) { }

        static void Main(string[] args)
        {
            //megengedett kontravariáns viselkedés
            DoHusevoStuff d = DoAllatStuff;
        }
    }
}

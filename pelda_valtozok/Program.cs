namespace pelda_valtozok
{
    class Program
    {
        static void Main(string[] args)
        {
            //10-es szamrendszerben megadott egesz
            int egesz_szam = 42;

            //az f jelzés jelöli a fordító számára
            //hogy ez egy float típus
            float lebegopontos = 3.14f;

            //double esetén nem kell külön jelölni
            double d = 1124.333;

            //egész szám hexadecimális formában
            int hexa = 0xff;

            //hosszú egész oktális formátumban
            long okta = 07123235;

            //decimal típus esetén m betű jelzi, hogy a szám egy decimal típus 
            decimal penz = 1224.3m;

            //A fordító a változó típusának string-et fog adni.
            var valtozo = "Ez egy szöveg";

            //futtatás közben fog eldőlni a típus.
            //az eredmény típus szöveg lesz. A 44 szöveggé fog konvertálódni
            dynamic dinamikus = "Ez egy " + 44;
        }
    }
}
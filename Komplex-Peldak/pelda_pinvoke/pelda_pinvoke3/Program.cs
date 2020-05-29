using System;
using System.Runtime.InteropServices;

namespace pelda_pinvoke3
{
    [StructLayout(LayoutKind.Sequential)]
    struct Pont
    {
        public float X;
        public float Y;
    }

    //Alternatívc explicit leírása ugyan annak a struktúrának
    //A Pack = 8 azt mondja ki, hogy a struktúra 8 byte méretű
    //float = 32 bit => 4 byte
    [StructLayout(LayoutKind.Explicit, Pack = 8)]
    struct PontExplicit
    {
        //0. byte-tól kezdődően
        [FieldOffset(0)]
        public float X;
        //4. byte-tól kezdődően
        [FieldOffset(4)]
        public float Y;
    }

    class Program
    {

        [DllImport("PELDAPINVOKENATIVE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void GetStruct(out Pont pont);

        static void Main(string[] args)
        {
            Pont p = new Pont();
            GetStruct(out p);
            Console.WriteLine("x: {0}; y: {1}", p.X, p.Y);
            Console.ReadKey();

        }
    }
}

using System;

namespace pelda_unsafe3
{
    class Program
    {
        static unsafe void Main()
        {
            int x = 10;
            short y = -1;
            byte y2 = 4;
            double z = 1.5;
            int* pX = &x;
            short* pY = &y;
            double* pZ = &z;

            Console.WriteLine("x Címe: 0x{0:X}, Mérete: {1}, Értéke: {2}", (uint)&x, sizeof(int), x);
            Console.WriteLine("y Címe: 0x{0:X}, Mérete: {1}, Értéke: {2}", (uint)&y, sizeof(short), y);
            Console.WriteLine("y2 Címe: 0x{0:X}, Mérete: {1}, Értéke: {2}", (uint)&y2, sizeof(byte), y2);
            Console.WriteLine("z Címe: 0x{0:X}, Mérete: {1}, Értéke: {2}", (uint)&z, sizeof(double), z);
            Console.WriteLine("pX=&x Címe: 0x{0:X}, Mérete: {1}, Értéke: 0x{2:X}", (uint)&pX, sizeof(int*), (uint)pX);
            Console.WriteLine("pY=&y Címe: 0x{0:X}, Mérete: {1}, Értéke: 0x{2:X}", (uint)&pY, sizeof(short*), (uint)pY);
            Console.WriteLine( "pZ=&z Címe: 0x{0:X}, Mérete: {1}, Értéke: 0x{2:X}",  (uint)&pZ, sizeof(double*), (uint)pZ);

            *pX = 20;
            Console.WriteLine("*pX, x = {0} után", x);
            Console.WriteLine("*pX = {0}", *pX);

            pZ = (double*)pX;
            Console.WriteLine("x, mint double típus = {0}", *pZ);

            Console.ReadLine();
        }
    }
}

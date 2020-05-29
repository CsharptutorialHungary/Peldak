using System;
using System.Runtime.InteropServices;

namespace pelda_pinvoke
{
    class Program
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, int options);

        static void Main(string[] args)
        {
            MessageBox(IntPtr.Zero, "Pinvoke Minta", "Pinvoke", 0);
            Console.ReadKey();
        }
    }
}

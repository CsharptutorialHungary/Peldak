using System.Runtime.InteropServices;
using System.Text;

namespace pelda_pinvoke2
{
    internal static class Native
    {
        [DllImport("PELDAPINVOKENATIVE.dll", CallingConvention = CallingConvention.StdCall, CharSet =CharSet.Unicode)]
        public static extern long GetString(StringBuilder output, long size);

        [DllImport("PELDAPINVOKENATIVE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern uint InitFibonacci([MarshalAs(UnmanagedType.U4)]uint limit);

        [DllImport("PELDAPINVOKENATIVE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void DeleteFibonacci();

        [DllImport("PELDAPINVOKENATIVE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern long GetFibonacci([MarshalAs(UnmanagedType.U4)]uint limit);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteropTest10
{
    public delegate void FPtr(int value);
     
    internal static class NativeMethods
    {
        // Declares a managed prototype for unmanaged function.
        [DllImport("..\\..\\..\\Debug\\InteropDll1.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int TestInt(int myint);

        [DllImport("..\\..\\..\\Debug\\InteropDll1.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool RegisterFPtr(FPtr MyFunc);

        [DllImport("..\\..\\..\\Debug\\InteropDll1.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void RegisterAndInvokeFPtr(FPtr MyFunc, int myint);


        [DllImport("..\\..\\..\\Debug\\InteropDll1.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr CreateTestClass();

        [DllImport("..\\..\\..\\Debug\\InteropDll1.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void DoSomethingOnTestClass(IntPtr instance);

        [DllImport("..\\..\\..\\Debug\\InteropDll1.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void DeleteTestClass(IntPtr instance);

    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteropTest10
{
    // Declares a managed structure for each unmanaged structure.
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MyPerson
    {
        public string first;
        public string last;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MyPerson2
    {
        public IntPtr person;
        public int age;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MyPerson3
    {
        public MyPerson person;
        public int age;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MyArrayStruct
    {
        public bool flag;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public int[] vals;
    }

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


        // Declares a managed prototype for unmanaged function.
        [DllImport("..\\..\\..\\Debug\\InteropDll1.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int TestStructInStruct(ref MyPerson2 person2);

        [DllImport("..\\..\\..\\Debug\\InteropDll1.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int TestStructInStruct3(MyPerson3 person3);

        [DllImport("..\\..\\..\\Debug\\InteropDll1.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int TestArrayInStruct(ref MyArrayStruct myStruct);

        // Declares a managed prototype for an array of integers by reference.
        // The array size can change, but the array is not copied back
        // automatically because the marshaler does not know the resulting size.
        // The copy must be performed manually.
        [DllImport("..\\..\\..\\Debug\\InteropDll1.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int TestRefArrayOfInts(
            ref IntPtr array, ref int size);
    }

    // Declares a class member for each structure element.
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public class MyStruct
    {
        public String buffer;
        public int size;
    }
    // Declares a structure with a pointer.
    [StructLayout(LayoutKind.Sequential)]
    public struct MyUnsafeStruct
    {
        public IntPtr buffer;
        public int size;
    }

    // Declares a class member for each structure element.
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public class MYSTRSTRUCT2safe
    {
        public String buffer;
        public uint size;
    }
    // Declares a structure with a pointer.
    [StructLayout(LayoutKind.Sequential)]
    public struct MYSTRSTRUCT2
    {
        public IntPtr buffer;
        public int size;
    }


    public unsafe class LibWrap
    {
        // Declares managed prototypes for the unmanaged function.
        [DllImport("..\\..\\..\\Debug\\InteropDll1.dll")]
        public static extern void TestOutArrayOfStructs(out int size,
            out IntPtr outArray);

        [DllImport("..\\..\\..\\Debug\\InteropDll1.dll")]
        public static extern void TestOutArrayOfStructs(out int size,
            MYSTRSTRUCT2** outArray); // MyUnsafeStruct** outArray);
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

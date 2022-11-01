using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteropTest10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = NativeMethods.TestInt(int.Parse(textBox1.Text)).ToString();
        }

        public void MyCallBack(int value)
        {
            // Console.WriteLine($"\nCallback called with param: {value}");

            this.label1.Text = value.ToString();
        }
        public void MyCallBack2(int value)
        {
            // Console.WriteLine($"\nCallback called with param: {value}");

            this.label2.Text = value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NativeMethods.RegisterFPtr(MyCallBack);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NativeMethods.RegisterAndInvokeFPtr(MyCallBack,
                int.Parse(textBox1.Text));
            // this.label2.Text = value.ToString();
        }

        IntPtr myCTestClass = IntPtr.Zero;
        private void button4_Click(object sender, EventArgs e)
        {
            myCTestClass = NativeMethods.CreateTestClass();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            NativeMethods.DoSomethingOnTestClass(myCTestClass);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            NativeMethods.DeleteTestClass(myCTestClass);
            myCTestClass = IntPtr.Zero;
        }

        private void button7_struct_demo_Click(object sender, EventArgs e)
        {
            // Structure with a pointer to another structure.
            MyPerson personName;
            personName.first = "Mark";
            personName.last = "Lee";

            MyPerson2 personAll;
            personAll.age = 30;

            IntPtr buffer = Marshal.AllocCoTaskMem(Marshal.SizeOf(personName));
            Marshal.StructureToPtr(personName, buffer, false);

            personAll.person = buffer;

            Console.WriteLine("\nPerson before call:");
            Console.WriteLine("first = {0}, last = {1}, age = {2}",
                personName.first, personName.last, personAll.age);

            int res = NativeMethods.TestStructInStruct(ref personAll);

            MyPerson personRes =
                (MyPerson)Marshal.PtrToStructure(personAll.person,
                typeof(MyPerson));

            Marshal.FreeCoTaskMem(buffer);

            Console.WriteLine("Person after call:");
            Console.WriteLine("first = {0}, last = {1}, age = {2}",
                personRes.first, personRes.last, personAll.age);

            // Structure with an embedded structure.
            MyPerson3 person3 = new MyPerson3();
            person3.person.first = "John";
            person3.person.last = "Evans";
            person3.age = 27;
            NativeMethods.TestStructInStruct3(person3);

            // Structure with an embedded array.
            MyArrayStruct myStruct = new MyArrayStruct();

            myStruct.flag = false;
            myStruct.vals = new int[3];
            myStruct.vals[0] = 1;
            myStruct.vals[1] = 4;
            myStruct.vals[2] = 9;

            Console.WriteLine("\nStructure with array before call:");
            Console.WriteLine(myStruct.flag);
            Console.WriteLine("{0} {1} {2}", myStruct.vals[0],
                myStruct.vals[1], myStruct.vals[2]);

            NativeMethods.TestArrayInStruct(ref myStruct);
            Console.WriteLine("\nStructure with array after call:");
            Console.WriteLine(myStruct.flag);
            Console.WriteLine("{0} {1} {2}", myStruct.vals[0],
                myStruct.vals[1], myStruct.vals[2]);
        }

        private void button_test_array_ints_Click(object sender, EventArgs e)
        {
            // array ByRef
            int[] array2 = new int[10];
            int size = array2.Length;
            Console.WriteLine("\n\nInteger array passed ByRef before call:");
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = i;
                Console.Write(" " + array2[i]);
            }
            Console.Write("\n");

            IntPtr buffer = Marshal.AllocCoTaskMem(Marshal.SizeOf(size)
                                                   * array2.Length);
            Marshal.Copy(array2, 0, buffer, array2.Length);

            int sum2 = NativeMethods.TestRefArrayOfInts(ref buffer, ref size);
            Console.WriteLine("\nSum of elements:" + sum2 +"\n");
            if (size > 0)
            {
                int[] arrayRes = new int[size];
                Marshal.Copy(buffer, arrayRes, 0, size);
                Marshal.FreeCoTaskMem(buffer);
                Console.WriteLine("\nInteger array passed ByRef after call:\n");
                foreach (int i in arrayRes)
                {
                    Console.Write(" " + i);
                }
                Console.Write("\n");
            }
            else
            {
                Console.WriteLine("\nArray after call is empty\n");
            }
        }



        public static void UsingMarshal()
        {
            int size;
            IntPtr outArray;
            LibWrap.TestOutArrayOfStructs(out size, out outArray);
            MyStruct[] manArray = new MyStruct[size];
            IntPtr current = outArray;
            for (int i = 0; i < size; i++)
            {
                manArray[i] = new MyStruct();
                Marshal.PtrToStructure(current, manArray[i]);

                //Marshal.FreeCoTaskMem( (IntPtr)Marshal.ReadInt32( current ));
                Marshal.DestroyStructure(current, typeof(MyStruct));
                current = (IntPtr)((long)current +
                                   Marshal.SizeOf(manArray[i]));

                Console.WriteLine("Element {0}: {1} {2}", i,
                    manArray[i].buffer, manArray[i].size);
            }
            Marshal.FreeCoTaskMem(outArray);
        }

        public static unsafe void UsingUnsafe()
        {
            int size = 0;
            //MyUnsafeStruct* pResult;
            MYSTRSTRUCT2* pResult = null;

            try
            {
                LibWrap.TestOutArrayOfStructs(out size, &pResult);
            }
            catch
            {

            }
            //MyUnsafeStruct* pCurrent = pResult;
            MYSTRSTRUCT2* pCurrent = pResult;
            for (int i = 0; i < size; i++, pCurrent++)
            {
                Console.WriteLine("Element {0}: {1} {2}", i,
                    Marshal.PtrToStringAnsi(pCurrent->buffer), pCurrent->size);
                Marshal.FreeCoTaskMem(pCurrent->buffer);
            }
            Marshal.FreeCoTaskMem((IntPtr)pResult);
        }

        private void button_array_of_structs_Click(object sender, EventArgs e)
        {
            //UsingMarshal();
            UsingUnsafe();
        }
    }
}

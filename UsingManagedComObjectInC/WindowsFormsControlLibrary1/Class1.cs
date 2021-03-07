using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsControlLibrary1
{
    //class Class1
    //{
    //}
    [Guid("599AD473-B0A9-4A6E-B260-CF6FDEBF151B"), InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IClass1
    {
        void AddNumbers(byte[] array);
    }
    [Guid("62FBC3A9-E2C0-4B53-9BF3-FDE22AA0CFF2"), ClassInterface(ClassInterfaceType.None)]
    public class Class1 : IClass1
    {

        public void AddNumbers(byte[] array)
        {
            ulong number = 0;
            foreach (var item in array)
            {
                number += item;
            }
            
            System.Console.WriteLine("The sum of the numbers is {0}", number);

            System.Windows.Forms.MessageBox.Show("GUi works");

        }
    }
}

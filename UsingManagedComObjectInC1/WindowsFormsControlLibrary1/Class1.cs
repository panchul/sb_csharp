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
    [Guid("d2867616-fe2c-42b4-8599-01d9937ea46e"), InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IClass1
    {
        void AddNumbers(byte[] array);
    }
    [Guid("64be7ce7-b3a0-40f5-bbe6-49914f868f05"), ClassInterface(ClassInterfaceType.None)]
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
            System.Windows.Forms.MessageBox.Show(String.Format("The sum of the numbers is {0}", number));
        }
    }
}

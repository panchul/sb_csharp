using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
    }
}

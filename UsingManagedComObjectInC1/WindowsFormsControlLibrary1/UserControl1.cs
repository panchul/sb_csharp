using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class UserControl1: UserControl
    {
        public String m_myTextBox1;

        public UserControl1()
        {
            InitializeComponent();
            label_status.Text = "";
        }

        public System.Windows.Forms.Button GetButton1()
        {
            return this.button1;
        }
        public System.Windows.Forms.TextBox GetTextBox1()
        {
            return this.textBox1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label_status.Text = "Copying UI text to internal C# member variable...";
            m_myTextBox1 = this.textBox1.Text;
            this.textBox2.Text = m_myTextBox1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label_status.Text = "Copying UI text to internal C++ member variable...";


            System.Windows.Forms.MessageBox.Show(String.Format("Under construction! UI text \"{0}\"", this.textBox1.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label_status.Text = "Copying C++ data to internal C# member variable...";

            System.Windows.Forms.MessageBox.Show(String.Format("Under construction!"));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label_status.Text = "Copying C# data to internal C++ member variable...";

            System.Windows.Forms.MessageBox.Show(String.Format("Under construction!"));
        }
    }
}

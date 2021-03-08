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
        public UserControl1()
        {
            InitializeComponent();
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
            this.textBox2.Text = this.textBox1.Text;
        }
    }
}

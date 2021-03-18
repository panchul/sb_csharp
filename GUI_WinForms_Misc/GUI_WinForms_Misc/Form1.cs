using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_WinForms_Misc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("button1_Click()");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("button2_Click()");
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("toolStrip1_ItemClicked()");
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("menuStrip2_ItemClicked()");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("menuStrip1_ItemClicked()");
        }
    }
}

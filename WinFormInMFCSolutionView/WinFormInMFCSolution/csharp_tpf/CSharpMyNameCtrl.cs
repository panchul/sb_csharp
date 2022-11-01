using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_tpf
{
    public partial class CSharpMyNameCtrl : UserControl
    {
        public CSharpMyNameCtrl()
        {
            InitializeComponent();
        }

        public System.Windows.Forms.TextBox GetNameTextBox()
        {
            return this.NameTextBox;
        }

        public System.Windows.Forms.Button GetButtonOkay()
        {
            return this.ButtonOkay;
        }

        private void ButtonOkay_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Button click event handler in c#");
        }
    }
}

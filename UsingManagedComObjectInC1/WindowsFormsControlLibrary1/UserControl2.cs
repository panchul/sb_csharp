using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;

namespace WindowsFormsControlLibrary1
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();

            // Set the view to show details.
            listView1.View = View.Details;
            // Allow the user to edit item text.
            listView1.LabelEdit = true;
            // Allow the user to rearrange columns.
            listView1.AllowColumnReorder = true;
            // Display check boxes.
            listView1.CheckBoxes = true;
            // Select the item and subitems when selection is made.
            listView1.FullRowSelect = true;
            // Display grid lines.
            listView1.GridLines = true;
            // Sort the items in the list in ascending order.
            listView1.Sorting = SortOrder.Ascending;

            this.listView1.Items.Clear();

            // Create three items and three sets of subitems for each item.
            ListViewItem item1 = new ListViewItem("item1", 0);
            // Place a check mark next to the item.
            item1.Checked = true;
            item1.SubItems.Add("1");
            item1.SubItems.Add("2");
            item1.SubItems.Add("3");
            ListViewItem item2 = new ListViewItem("item2", 1);
            item2.SubItems.Add("4");
            item2.SubItems.Add("5");
            item2.SubItems.Add("6");
            ListViewItem item3 = new ListViewItem("item3", 0);
            // Place a check mark next to the item.
            item3.Checked = true;
            item3.SubItems.Add("7");
            item3.SubItems.Add("8");
            item3.SubItems.Add("9");

            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            listView1.Columns.Clear();
            listView1.Columns.Add("Tag", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Load", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Length", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Material", -2, HorizontalAlignment.Center);

            //Add the items to the ListView.
            listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3 });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // System.Windows.Forms.MessageBox.Show("Button1 pressed, no action yet.");
            
            ListViewItem item1 = new ListViewItem(String.Format("item{0}", this.listView1.Items.Count), 0);
            // Place a check mark next to the item.
            item1.Checked = true;
            item1.SubItems.Add(String.Format("aaa{0}",this.listView1.Items.Count));
            item1.SubItems.Add("2");
            item1.SubItems.Add("3");

            listView1.Items.Add(item1);
        }

        public System.Windows.Forms.ListView GetListView1()
        {
            return this.listView1;
        }
    }
}

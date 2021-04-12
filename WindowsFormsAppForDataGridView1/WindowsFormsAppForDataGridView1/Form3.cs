using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppForDataGridView1
{
    public partial class Form3 : Form
    {
        public List<Person> People { get; set; }
        public Form3()
        {
            People = GetPeople();
            InitializeComponent();
        }

        public List<Person> GetPeople()
        {
            var list = new List<Person>();
            list.Add(new Person()
                {
                    PersonId = 1,
                    Name = "person1",
                    Surname = "somesurname",
                    Profession = "someprofession"
                }
            );
            list.Add(new Person()
                {
                    PersonId = 2,
                    Name = "person2",
                    Surname = "somesurname",
                    Profession = "someprofession"
                }
            );
            list.Add(new Person()
                {
                    PersonId = 3,
                    Name = "person3",
                    Surname = "somesurname",
                    Profession = "someprofession"
                }
            );
            return list;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var people = this.People;

            dataGridView1.DataSource = people;
            dataGridView1.Columns["PersonId"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectedRow = dataGridView1.SelectedRows[0].DataBoundItem as Person;
                textBoxPersonId.Text = selectedRow.PersonId.ToString();
                textBoxFirstName.Text = selectedRow.Name;
                textBoxLastName.Text = selectedRow.Surname;
                textBoxProfession.Text = selectedRow.Profession;
            }
            catch (Exception ex)
            {
                MessageBox.Show("some error: " + ex.Message + ex.Source);
            }
        }
    }
}

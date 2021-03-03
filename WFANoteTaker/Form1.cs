using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFANoteTaker
{
    public partial class Form1 : Form
    {
        DataTable table;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Message", typeof(String));

            dataGridView1.DataSource = table;

            dataGridView1.Columns["Message"].Visible = false;
            dataGridView1.Columns["Title"].Width = 180;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            titleText.Clear();
            messageText.Clear();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(titleText.Text, messageText.Text);

            titleText.Clear();
            messageText.Clear();
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1)
            {
                titleText.Text = table.Rows[index].ItemArray[0].ToString();
                messageText.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            table.Rows[index].Delete();
        }
    }
}

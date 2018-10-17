using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QueryCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                SelectData(textBox1.Text);
            }
        }
        private void SelectData(String selectCommandText)
        {
            try
            {
                string selectConnection = @"Data Source = LAPTOP-CC6\SQLEXPRESS; Initial Catalog = Northwind; Integrated Security = True";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommandText, selectConnection);

                DataTable table = new DataTable();

                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

using System;
using System.Data;
namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet data = new DataSet("office");
            DataTable table = new DataTable("employee");
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name");
            table.Columns.Add("Designation");
            table.Rows.Add(1, "Jhon", "Manager");
            table.Rows.Add(2, "Manu", "Senior developer");
            data.Tables.Add(table);
            dataGridView1.DataSource = data.Tables[0];

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }
    }
}
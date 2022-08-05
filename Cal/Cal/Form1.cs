using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace Cal
{
    public partial class Form1 : Form
    {
        Test c = new Test();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                int i = c.add(int.Parse(tb1.Text);
                int j = c.add(int.Parse(tb2.Text);
                tb3.Text=i.ToString();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

            }

        }
    }
}

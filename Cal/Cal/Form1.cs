using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLibrary1a;



namespace Cal
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        Class1 c = new Class1();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                int i = c.add(int.Parse(tb1.Text), int.Parse(tb2.Text));
               
                tb3.Text=i.ToString();
            }
            catch(Exception ed)
            {
                Console.WriteLine(ed.Message);

            }

        }
    }
}

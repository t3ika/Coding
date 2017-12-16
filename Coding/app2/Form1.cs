using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace app2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 winAjout = new Form2();
            winAjout.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] tableau = new string[5];

            tableau[0] = "TEST";
            tableau[1] = "TEST";
            tableau[2] = "TEST";
            tableau[3] = "TEST";
            tableau[4] = "TEST";

            dataGridView1.DataSource = tableau;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] tableau = new string[5];
            DataGridView1.Rows(i).Cells(j).Value = Tableau(i, j)


        }
    }
}

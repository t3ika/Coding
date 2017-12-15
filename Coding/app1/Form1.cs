using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace app1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //static async void WriteTextAsync(string text)
        //{
        //    // Set a variable to the My Documents path.
        //    string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        //    // Write the text asynchronously to a new file named "WriteTextAsync.txt".
        //    using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\WriteTextAsync.txt"))
        //    {
        //        await outputFile.WriteAsync(text);
        //    }
        //}
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true && checkBox1.Checked == true)
            {
                    var p = "simple";
                    var l = "double";
                System.IO.File.AppendAllText(@"C:/lol/Test.txt", Environment.NewLine + comboBox1.SelectedItem + " " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + p + " " + l);
                return;

            }
            if (checkBox1.Checked == true)
            {

                    var a = "simple";
                System.IO.File.AppendAllText(@"C:/lol/Test.txt", Environment.NewLine + comboBox1.SelectedItem + " " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + a);

            }
          else if (checkBox2.Checked == true)
            {
                var b = "double";
                System.IO.File.AppendAllText(@"C:/lol/Test.txt", Environment.NewLine+ comboBox1.SelectedItem + " " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text+" " +b);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox1.DataSource = File.ReadAllLines("C:/lol/Test.txt");
            object[] varObjet = new object[listBox1.Items.Count];
            listBox1.Items.CopyTo(varObjet, 0);
            listBox1.DataSource = null;
            listBox1.Items.AddRange(varObjet);

            //StreamReader sr = null;
            //sr = new StreamReader(@"C:/lol/Test.txt");
            //string line = sr.ReadLine();
            //while (line != null)
            //{
            //    this.listBox1.Items.Add(line);
            //    line = sr.ReadLine();
            //}
            //Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textbox9 = new System.Windows.Forms.TextBox();
            textbox9.Text = listBox1.SelectedItem.ToString();
            //MessageBox.Show(textbox9.Text);
            string p = textbox9.Text;
            string s2 = "simple";
            bool b = p.Contains(s2);


            if (b)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox1.ClearSelected();
            }

            else
            {
                MessageBox.Show(" Impossible d'ajouter cette utilisateur à cette catégorie");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textbox9 = new System.Windows.Forms.TextBox();
            textbox9.Text = listBox1.SelectedItem.ToString();
            //MessageBox.Show(textbox9.Text);
            string p = textbox9.Text;
            string s2 = "simple";
            string s3 = "double";
            bool b = p.Contains(s3);
            //bool z = p.Contains(s2 + s3);

            if (b)
                {
                listBox3.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox1.ClearSelected();
            }
            //if (z)
            //{
            //    listBox3.Items.Add(listBox1.SelectedItem);
            //    listBox1.Items.Remove(listBox1.SelectedItem);
            //    listBox1.ClearSelected();
            //}

            else
            {
                MessageBox.Show(" Impossible d'ajouter cette utilisateur à cette catégorie");
            }
        }
    }
}

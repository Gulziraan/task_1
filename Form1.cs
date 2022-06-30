using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool c = true;
            if (textBox1.Text == "")
            {
                label11.Visible = true;
                c = false;
            }
            if (textBox9.Text == "")
            { label12.Visible = true; c = false; }
                if (textBox5.Text == "")
            { label14.Visible = true; c = false; }
            if (textBox4.Text == "")
            { label13.Visible = true; c = false; }
            if (textBox8.Text == "")
            { label15.Visible = true; c = false; }
            if (textBox6.Text == "")
            { label16.Visible = true; c = false; }
            if (textBox3.Text == "")
            { label17.Visible = true; c = false; }
            if (c==false) label10.Visible = true;
            else
            {
                SaveFileDialog savefile = new SaveFileDialog();
                //savefile.FileName = " .bat";
                savefile.Filter = "(*.bat)|*.bat";
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    using (Stream s = File.Open(savefile.FileName, FileMode.CreateNew))
                    using (StreamWriter sw = new StreamWriter(s))
                    {
                        sw.Write(textBox1.Text + " ");
                        sw.Write(textBox9.Text + " ");
                        sw.Write(textBox4.Text + " ");
                        sw.Write(textBox5.Text + " ");
                        sw.Write(textBox8.Text + " ");
                        sw.Write("1" + " ");
                        sw.Write(textBox7.Text + " ");
                        sw.Write(textBox6.Text + " ");
                        sw.Write(textBox3.Text + " ");
                        sw.Write("1" + " ");
                        sw.Write(textBox2.Text + " ");
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

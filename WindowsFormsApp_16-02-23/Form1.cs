using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_16_02_23
{
    public partial class Form1 : Form
    {
        Contac X = new Contac();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            X.Name = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            X.Telephone = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            X.Birthdate = DateTime.Parse("2004/05/22");
            textBox3.Text = X.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {}
    }
}

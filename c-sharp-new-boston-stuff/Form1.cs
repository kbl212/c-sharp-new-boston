using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_sharp_new_boston_stuff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Kyle")
            {
                MessageBox.Show("Hello. You typed my name!");
            }
            button1.Height = 60;
            button1.Enabled = false;
            button1.Text = "You just toggled the button!";
            //objects can hold the value of any data type...string, number, bool?
            object myObj = true;
            string name = "Kyle";
            int myNumber = 5;
            bool redHair = false;
            MessageBox.Show("Hello there " + name + ", nice to meet you!", "My message");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

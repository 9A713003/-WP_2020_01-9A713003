using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_2020_01_9A713003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }
        int i;
        
        public int randomNum = new Random().Next(1,3); //0-100
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
         

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            randomNum = new Random().Next(1, 3); //0-100
            i = 1;
            if (i == randomNum)
            {
                richTextBox1.Text = "平手";
            }
            else if (i < randomNum)
            {
                richTextBox1.Text = "負";
            }
            else if (i > randomNum)
            {
                richTextBox1.Text = "勝";
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            randomNum = new Random().Next(1, 3); //0-100
            i = 2;
            if(i== randomNum)
            {
                richTextBox1.Text = "平手";
            }
            else if (i < randomNum)
            {
                richTextBox1.Text = "負";
            }
            else if (i > randomNum)
            {
                richTextBox1.Text = "勝";
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            randomNum = new Random().Next(1, 3); //0-100
            i = 3;
            if (i == randomNum)
            {
                richTextBox1.Text = "平手";
            }
            else if(i < randomNum)
            {
                richTextBox1.Text = "負";
            }
           else if (i > randomNum)
            {
                richTextBox1.Text = "勝";
            }
           
        }
    }
}

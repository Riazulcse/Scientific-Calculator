using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application1
{
    public partial class Form1 : Form
    {
        string num, first_input, second_input;
        char comp;
        float result;

        public bool inputsta;
        
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button11_Click(object sender, EventArgs e)
        {

            
            int n = textBox1.TextLength;
            textBox1.Text = textBox1.Text.Substring(0, n - 1);
            num = string.Empty;
        }

        private void button12_Click(object sender, EventArgs e)
        {
           
            textBox1.Clear();
            num = string.Empty;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            second_input = num;
            float a, b;
            float.TryParse(second_input, out b);
            float.TryParse(first_input, out a);

            if (comp == '+')
            {
                result = a + b;
                textBox1.Text = Convert.ToString(result);
            
            }


            if (comp == '-')
            {
                result = a - b;
                textBox1.Text = Convert.ToString(result);

            }


            if (comp == '*')
            {
                result = a * b;
                textBox1.Text = Convert.ToString(result);

            }

            if (comp == '/')
            {
                result = a / b;
                textBox1.Text = Convert.ToString(result);

            }


            if (comp == '%')
            {
                result = a % b;
                textBox1.Text = Convert.ToString(result);

            }

            

            num = string.Empty;
        
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            num += "7";
            this.textBox1.Text += num;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            num += "8";
            this.textBox1.Text += num;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            num += "9";
            this.textBox1.Text += num;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            num += "4";
            this.textBox1.Text += num;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            num += "5";
            this.textBox1.Text += num;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            num += "6";
            this.textBox1.Text += num;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            num += "1";
            this.textBox1.Text += num;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            num += "2";
            this.textBox1.Text += num;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            num += "3";
            this.textBox1.Text += num;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            num += "0";
            this.textBox1.Text += num;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            num += ".";
            this.textBox1.Text += num;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            first_input = num;
            comp = '+';
            num = string.Empty;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            first_input = num;
            comp = '-';
            num = string.Empty;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            first_input = num;
            comp = '*';
            num = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            first_input = num;
            comp = '/';
            num = string.Empty;
        }

        private void button20_Click(object sender, EventArgs e)
        {

            first_input = num;
            comp = '%';
            num = string.Empty;
        }

        private void button23_Click(object sender, EventArgs e)
        {
           
            textBox1.Text = Convert.ToString(System.Math.Sin((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));
            //inputsta = false;
            num = string.Empty;
        
        }

        private void button21_Click(object sender, EventArgs e)
        {

           
            textBox1.Text = Convert.ToString(System.Math.Cos((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));
           // inputsta = false;
            num = string.Empty;
        
        }

        private void button22_Click(object sender, EventArgs e)
        {

         
            textBox1.Text = Convert.ToString(System.Math.Tan((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));
            //inputsta = false;
            num = string.Empty;
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            first_input = num;
            int a = Convert.ToUInt16(first_input);
            int fact = 1;
            comp = '!';
            for (int i = 1; i <= a; i++)
            { fact = fact * i; }
            textBox1.Text = Convert.ToString(fact);
            num = string.Empty;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button21.Hide();
            button22.Hide();
            button23.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button21.Show();
            button22.Show();
            button23.Show();
        }
    
         
    
    
    
    }
}

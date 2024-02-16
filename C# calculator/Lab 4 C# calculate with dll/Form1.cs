using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLLMathsFuncs;
using System.Net;

namespace Lab2_calculator_in_C_sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private float number;

        private double Total = 0;
        private bool Firstop = true;
        private char previousop = '+';
        private void button1_Click(object sender, EventArgs e)
        {
            if (Firstop)
            {
                textBox1.Text = "0";
                Firstop = false;
            }
            else
                textBox1.Text += "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Firstop)
            {
                textBox1.Text = "1";
                Firstop = false;
            }
            else
                textBox1.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Firstop)
            {
                textBox1.Text = "2";
                Firstop = false;
            }
            else
                textBox1.Text += "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Firstop)
            {
                textBox1.Text = "3";
                Firstop = false;
            }
            else
                textBox1.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Firstop)
            {
                textBox1.Text = "4";
                Firstop = false;
            }
            else
                textBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Firstop)
            {
                textBox1.Text = "5";
                Firstop = false;
            }
            else
                textBox1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Firstop)
            {
                textBox1.Text = "6";
                Firstop = false;
            }
            else
                textBox1.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Firstop)
            {
                textBox1.Text = "7";
                Firstop = false;
            }
            else
                textBox1.Text += "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Firstop)
            {
                textBox1.Text = "8";
                Firstop = false;
            }
            else
                textBox1.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Firstop)
            {
                textBox1.Text = "9";
                Firstop = false;
            }
            else
                textBox1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Firstop)
            {
                textBox1.Text = ".";
                Firstop = false;
            }
            else
                textBox1.Text += ".";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            number = Convert.ToSingle(this.textBox1.Text); /// get the number from the textbox and store into the the number
            switch (previousop)
            {
                case '+':
                    Total += number;
                    break;
                case '-':
                    Total -= number;
                    break;
                case '/':
                    Total /= number;
                    break;
                case '*':
                    Total *= number;
                    break;
            }
            previousop = '+';
            textBox1.Text = Convert.ToString(Total);
            Firstop = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            number = Convert.ToSingle(this.textBox1.Text); /// get the number from the textbox and store into the the number
            switch (previousop)
            {
                case '+':
                    Total += number;
                    break;
                case '-':
                    Total -= number;
                    break;
                case '/':
                    Total /= number;
                    break;
                case '*':
                    Total *= number;
                    break;
            }
            previousop = '-';
            textBox1.Text = Convert.ToString(Total);
            Firstop = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            number = Convert.ToSingle(this.textBox1.Text); /// get the number from the textbox and store into the the number
            switch (previousop)
            {
                case '+':
                    Total += number;
                    break;
                case '-':
                    Total -= number;
                    break;
                case '/':
                    Total /= number;
                    break;
                case '*':
                    Total *= number;
                    break;
            }
            previousop = '*';
            textBox1.Text = Convert.ToString(Total);
            Firstop = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            number = Convert.ToSingle(this.textBox1.Text); /// get the number from the textbox and store into the the number
            switch (previousop)
            {
                case '+':
                    Total += number;
                    break;
                case '-':
                    Total -= number;
                    break;
                case '/':
                    Total /= number;
                    break;
                case '*':
                    Total *= number;
                    break;
            }
            previousop = '/';
            textBox1.Text = Convert.ToString(Total);
            Firstop = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            Total = 0;
            previousop = '+';
            Firstop = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            number = Convert.ToSingle(this.textBox1.Text); /// get the number from the textbox and store into the the number
            switch (previousop)
            {
                case '+':
                    Total += number;
                    break;
                case '-':
                    Total -= number;
                    break;
                case '/':
                    Total /= number;
                    break;
                case '*':
                    Total *= number;
                    break;
            }
            previousop = '+';
            textBox1.Text = Convert.ToString(Total);
            Total = 0;
            Firstop = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Class1 obj1 = new Class1();
            number = Convert.ToSingle(this.textBox1.Text); /// get the number from the textbox and store into the the number
            switch (previousop)
            {
                case '+':
                    Total += number;
                    break;
                case '-':
                    Total -= number;
                    break;
                case '/':
                    Total /= number;
                    break;
                case '*':
                    Total *= number;
                    break;
                case 'P':
                    Total = obj1.percent(number);
                    break;
            }
            previousop = 'P';
            textBox1.Text = Convert.ToString(Total);
            Firstop = true;
            
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            using (WebClient myClient = new WebClient()) //to talk to the REST service you need to create
                                                         // a WebClient object and call theDownloadString
                                                         // method of the object
            {
                String REST;
                textBox1.Text = Convert.ToString(Total);
                number = Convert.ToSingle(this.textBox1.Text);
                REST = Convert.ToString(number);
                var response = myClient.DownloadString("http://localhost:59132/Service1.svc/sqr/"+ REST);
                textBox1.Text = response;
            }
        }
    }
}

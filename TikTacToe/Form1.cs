using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TikTacToe
{
    public partial class Form1 : Form
    {
        int pointer =1;
        Boolean b1 = false;
        Boolean b2 = false;
        Boolean b3 = false;
        Boolean b4 = false;
        Boolean b5 = false;
        Boolean b6 = false;
        Boolean b7 = false;
        Boolean b8 = false;
        Boolean b9 = false;





        public Form1()
        {
            InitializeComponent();
            label3.Text = (pointer).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        public void winner()
        {
            if (pointer == 10)
            {
                label4.Text = "No one wins";
                Form4 f4 = new Form4();
                this.Hide();
                f4.ShowDialog();
                this.Close();
            }
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X" ||
               button1.Text == "X" && button4.Text == "X" && button7.Text == "X" ||
               button4.Text == "X" && button5.Text == "X" && button6.Text == "X" ||
               button2.Text == "X" && button5.Text == "X" && button8.Text == "X" ||
               button7.Text == "X" && button8.Text == "X" && button9.Text == "X" ||
               button3.Text == "X" && button6.Text == "X" && button9.Text == "X" ||
               button1.Text == "X" && button5.Text == "X" && button9.Text == "X" ||
               button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                label4.Text = "Player 1 Wins";
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
                this.Close();
            }
            else if (button1.Text == "0" && button2.Text == "0" && button3.Text == "0" ||
                button1.Text == "0" && button4.Text == "0" && button7.Text == "0" ||
                button4.Text == "0" && button5.Text == "0" && button6.Text == "0" ||
                button2.Text == "0" && button5.Text == "0" && button8.Text == "0" ||
                button7.Text == "0" && button8.Text == "0" && button9.Text == "0" ||
                button3.Text == "0" && button6.Text == "0" && button9.Text == "0" ||
                button1.Text == "0" && button5.Text == "0" && button9.Text == "0" ||
                button3.Text == "0" && button5.Text == "0" && button7.Text == "0")
            {
                label4.Text = "Player 2 Wins";
                this.Hide();
                Form3 f3 = new Form3();
                f3.ShowDialog();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(b1)
            {
                
            }
            else if (pointer % 2 == 0)
            {
                    b1 = true;
                button1.Text = "0";
                pointer++;
                label3.Text = (pointer).ToString();
                winner();
            }
            else
            {
                    b1 = true;
                    button1.Text = "X";
                pointer++;
                label3.Text = (pointer).ToString();
                winner();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            if(b2)
            {

            }
            else if (pointer % 2 == 0)
            {
                b2 = true;
                button2.Text = "0";
                pointer++;
                label3.Text = (pointer).ToString();
                winner();
            }
            else
            {
                b2 = true;
                button2.Text = "X";
                pointer++;
                label3.Text = (pointer).ToString();
                winner();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if(b3)
            {

            }
            else if (pointer % 2 == 0)
            {
                b3 = true;
                button3.Text = "0";
                pointer++;
                label3.Text = (pointer).ToString();
                winner();
            }
            else
            {
                b3 = true;
                button3.Text = "X";
                pointer++;
                label3.Text = (pointer).ToString();
                winner();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if(b4)
            {

            }
            else if (pointer % 2 == 0)
            {
                b4 = true;
                button4.Text = "0";
                pointer++;
                label3.Text = (pointer).ToString();
                winner();
            }
            else
            {
                b4 = true;
                button4.Text = "X";
                pointer++;
                label3.Text = (pointer).ToString();
                winner();
            }
          

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if(b5)
            {

            }
            else if (pointer % 2 == 0)
            {
                b5 = true;
                button5.Text = "0";
                pointer++;
                label3.Text = (pointer).ToString();
                winner();
            }
            else
            {
                b5 = true;
                button5.Text = "X";
                pointer++;
                label3.Text = (pointer).ToString();
                winner();
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            if(b6)
            {

            }
            else if (pointer % 2 == 0)
            {
                b6 = true;
                button6.Text = "0";
                pointer++;
                label3.Text = (pointer).ToString();
                winner();
            }
            else
            {
                b6 = true;
                button6.Text = "X";
                pointer++;
                label3.Text = (pointer).ToString();
                winner();
            }
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            if(b7)
            {

            }
            else if (pointer % 2 == 0)
            {
                b7 = true;
                button7.Text = "0";
                pointer++;
                label3.Text = (pointer).ToString();
                winner();
            }
            else
            {
                b8 = true;
                button7.Text = "X";
                pointer++;
                label3.Text = (pointer).ToString();
                winner();
            }
       
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(b8)
            {

            }
            else if (pointer % 2 == 0)
            {
                b8 = true;
                button8.Text = "0";
                pointer++;
                label3.Text = (pointer).ToString();
                winner();
            }
            else
            {
                b8 = true;
                button8.Text = "X";
                pointer++;
                label3.Text = (pointer).ToString();
                winner();
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {

            
            if(b9)
            {

            }
            else if (pointer % 2 == 0)
            {
                b9 = true;
                button9.Text = "0";
                pointer++;
                label3.Text = (pointer).ToString();
                winner();
            }
            else
            {
                b9 = true;
                button9.Text = "X";
                pointer++;
                label3.Text = (pointer).ToString();
                winner();
            }
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}

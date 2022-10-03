using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormCalculator : Form
    {
        string temp = "";
        
        public FormCalculator()
        {
            InitializeComponent();
        }

    

       

      
        private void btn1_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "1";


            }
            else
            {

                TextBox.Text = TextBox.Text + "1";

            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "2";


            }
            else
            {

                TextBox.Text = TextBox.Text + "2";

            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "3";


            }
            else
            {

                TextBox.Text = TextBox.Text + "3";

            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "4";


            }
            else
            {

                TextBox.Text = TextBox.Text + "4";

            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "5";


            }
            else
            {

                TextBox.Text = TextBox.Text + "5";

            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "6";


            }
            else
            {

                TextBox.Text = TextBox.Text + "6";

            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "9";


            }
            else
            {

                TextBox.Text = TextBox.Text + "9";

            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "8";


            }
            else
            {

                TextBox.Text = TextBox.Text + "8";

            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "7";


            }
            else
            {

                TextBox.Text = TextBox.Text + "7";

            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            int dotCount = 0;
            for (int i = 0; i < TextBox.Text.Length; i++)
            {
                if (TextBox.Text[i] == '.')
                {
                    dotCount++;
                }
            }

            if (TextBox.Text == "0")
            {
                TextBox.Text = "0.";


            }
            else if (dotCount == 0)
            {

                TextBox.Text = TextBox.Text + ".";

            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int dotCount = 0;
            for (int i = 0; i < TextBox.Text.Length; i++)
            {
                if (TextBox.Text[i] == '-')
                {
                    dotCount++;
                }
            }

            if (TextBox.Text == "0")
            {
                TextBox.Text = "0-";


            }
            else if (dotCount == 0)
            {

                TextBox.Text = TextBox.Text + "-";

            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int dotCount = 0;
            for (int i = 0; i < TextBox.Text.Length; i++)
            {
                if (TextBox.Text[i] == '+')
                {
                    dotCount++;
                }
            }

            if (TextBox.Text == "0")
            {
                TextBox.Text = "0+";


            }
            else if (dotCount == 0)
            {

                TextBox.Text = TextBox.Text + "+";

            }
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            int dotCount = 0;
            for (int i = 0; i < TextBox.Text.Length; i++)
            {
                if (TextBox.Text[i] == '*')
                {
                    dotCount++;
                }
            }

            if (TextBox.Text == "0")
            {
                TextBox.Text = "0*";


            }
            else if (dotCount == 0)
            {

                TextBox.Text = TextBox.Text + "*";

            }
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Length != 0)
            {
                double number = double.Parse(TextBox.Text);
                double result = number * number;
                TextBox.Text = result.ToString();
            }
        }

        private void btnFraction_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Length != 0)
            {
                TextBox.Text = "1/" + TextBox.Text;
            }
           
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int dotCount = 0;
            for (int i = 0; i < TextBox.Text.Length; i++)
            {
                if (TextBox.Text[i] == '/')
                {
                    dotCount++;
                }
            }

            if (TextBox.Text == "0")
            {
                TextBox.Text = "0/";


            }
            else if (dotCount == 0)
            {

                TextBox.Text = TextBox.Text + "/";

            }
        }

        private void btnToOpposite_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Length != 0)
            {

               double result =  double.Parse(TextBox.Text);

                result = result * -1;

                TextBox.Text = result.ToString();


            }
        }

        private void btnDeleteAllDigit_Click(object sender, EventArgs e)
        {
            TextBox.Clear();
            TextBox.Text = "0";
        }

        private void btnOfRoot_Click(object sender, EventArgs e)
        {
            if(TextBox.Text == "0")
            {
                TextBox.Clear();

                TextBox.Text = TextBox.Text + "√";

            }
            else
            {
                TextBox.Text = TextBox.Text + "√";
            }
          
            
        }

        private void btnDeleteLastNum_Click(object sender, EventArgs e)
        {

            TextBox.Clear();
            TextBox.Text = "0";
        }

        private void btnDeleteLastDigit_Click(object sender, EventArgs e)
        {
            if(TextBox.Text.Length != 0)
            {
                TextBox.Text = TextBox.Text.Remove(TextBox.Text.Length - 1, 1);
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            
            if(TextBox.Text.IndexOf("+")>0)
            {
               
                string[] substrings = TextBox.Text.Split('+');
                double firstNum = double.Parse(substrings[0]);
                double secondNum = double.Parse(substrings[1]);

                TextBox.Text = (firstNum + secondNum).ToString();
            }
            else if(TextBox.Text.IndexOf("-") > 0)
            {
             
                string[] substrings = TextBox.Text.Split('-');
                double firstNum = double.Parse(substrings[0]);
                double secondNum = double.Parse(substrings[1]);

                TextBox.Text = (firstNum - secondNum).ToString();
            }
            else if (TextBox.Text.IndexOf("*") > 0)
            {
                
                string[] substrings = TextBox.Text.Split('*');
                double firstNum = double.Parse(substrings[0]);
                double secondNum = double.Parse(substrings[1]);

                TextBox.Text = (firstNum * secondNum).ToString();
            }
            else if (TextBox.Text.IndexOf("/") > 0)
            {
              
                string[] substrings = TextBox.Text.Split('/');
                double firstNum = double.Parse(substrings[0]);
                double secondNum = double.Parse(substrings[1]);

                TextBox.Text = (firstNum / secondNum).ToString();
            }
            else if (TextBox.Text.IndexOf("√") >= 0)
            {
                
             
            if(TextBox.Text[0] == '√')
                {
                    double result = double.Parse(TextBox.Text.Substring(1));
                    TextBox.Text = Math.Pow(result,0.5).ToString();
                }
                else
                {
                    string[] substrings = TextBox.Text.Split('√');
                    double firstNum = double.Parse(substrings[0]);
                    double secondNum = double.Parse(substrings[1]);
                    double result = firstNum * Math.Pow(secondNum, 0.5);

                    TextBox.Text = result.ToString();
                }
              
            }
        }

        private void CopyStrip_Click(object sender, EventArgs e)
        {
            temp = TextBox.Text;

        }

        private void PasteStrip_Click(object sender, EventArgs e)
        {
            TextBox.Text = TextBox.Text + temp;
        }

        private void AboutStrip_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}
using System;
using System.Windows.Forms;

namespace Calculator_Final_Project
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
        private double addition(double num1, double num2)
        {


            return (num1 + num2);

        }
        private double multiplication(double num1, double num2)
        {


            return (num1 * num2);
        }
        private double division(double num1, double num2)
        {
            if (num1 == 0)
            {
                num1 = 1;
            }
            if (num2 == 0)
            { num2 = 1; }

            return (num1 / num2);
        }
        private double subtraction(double num1, double num2)
        {
            double total = (num1 - num2 * -1);
            if (temp == 0) { Answer.Text += +total; }
            Answer.Text = "";
            Answer.Text += total;
            Answer.Select(Answer.Text.Length, 0);
            return total;


        }
        public void Calculat()
        {
            double num1 = 0;
            double num2 = 0;
            double total = 0;
            if (Answer.Text != (""))
            {
                if (temp == 1)
                {
                    temp = 0;
                    Answer.Text = "";


                }
                else
                {
                    num2 = double.Parse(Answer.Text);
                    if (History.Text != "") { num1 = double.Parse(History.Text); };
                    temp = 1;


                }
            }
            if (count == 1)
            {
                total = multiplication(num1, num2);

            }
            if (count == 2)
            {
                total = division(num1, num2);

            }

            if (count == 3)
            {
                total = addition(num1, num2);

            }
            if (count == 4)
            {
                total = subtraction(num1, num2);

            }
            if (temp == 0) { Answer.Text += +total; }
            Answer.Text = "";
            Answer.Text += total;
            Answer.Select(Answer.Text.Length, 0);

        }
        private void Answer_TextChanged(object sender, EventArgs e)
        {

            Answer.Select(Answer.Text.Length, 0);
            if (Answer.Text.Contains('+') || Answer.Text.Contains('*') || Answer.Text.Contains('/'))
            {
                temp = 1;
                if (Answer.Text.Contains('+'))
                { count = 3; };
                if (Answer.Text.Contains('-'))
                { count = 4; }
                if (Answer.Text.Contains('*'))
                { count = 1; }
                if (Answer.Text.Contains('/'))
                { count = 2; }


                Answer.Text = Answer.Text.Remove(Answer.Text.Length - 1);
                History.Text = Answer.Text;

                if (Answer.Text.Contains('-'))
                { count = 4; }
                Calculat();
                Answer.Text = "";

            }

            if (Answer.Text != ("") && (Answer.Text.Contains('\n') || Answer.Text.Contains('=')))
            {
                temp = 0;
                if (Answer.Text.Contains('=')) { Answer.Text = Answer.Text.Remove(Answer.Text.Length - 1); }
                if (Answer.Text.Contains('\n')) { Answer.Text = Answer.Text.Remove(Answer.Text.Length - 1); }
                if (Answer.Text.Contains('\r')) { Answer.Text = Answer.Text.Remove(Answer.Text.Length - 1); }
                Calculat();
            }

        }
        public int temp = 0;
        public int count = 0;


        private void Equals_Click(object sender, EventArgs e)
        {
            Answer.Text += "=";
        }

        private void History_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addition_Click(object sender, EventArgs e)
        {
            Answer.Text += "+";
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            Answer.Text += "-";
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            Answer.Text += "*";
        }

        private void Division_Click(object sender, EventArgs e)
        {
            Answer.Text += "/";
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            Answer.Text += "0";
        }

        private void One_Click(object sender, EventArgs e)
        {
            Answer.Text += "1";
        }

        private void Two_Click(object sender, EventArgs e)
        {
            Answer.Text += "2";
        }

        private void Three_Click(object sender, EventArgs e)
        {
            Answer.Text += "3";
        }

        private void Four_Click(object sender, EventArgs e)
        {
            Answer.Text += "4";
        }

        private void Five_Click(object sender, EventArgs e)
        {
            Answer.Text += "5";
        }

        private void Six_Click(object sender, EventArgs e)
        {
            Answer.Text += "6";
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            Answer.Text += "7";
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            Answer.Text += "8";
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            Answer.Text += "9";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Answer.Text = "";
            History.Text = "";
        }

        private void test_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pie_Click(object sender, EventArgs e)
        {
            Answer.Text = Math.PI.ToString();
        }

        private void e_Click(object sender, EventArgs e)
        {
            Answer.Text = Math.E.ToString();
        }

        private void ln_Click(object sender, EventArgs e)
        {
            double ln = double.Parse(Answer.Text);
            ln = Math.Log(ln);
            Answer.Text = ln.ToString();
        }

        private void log10_Click(object sender, EventArgs e)
        {

            double ln = double.Parse(Answer.Text);
            ln = Math.Log10(ln);
            Answer.Text = ln.ToString();


        }

        private void EtotheX_Click(object sender, EventArgs e)
        {
            double ln = double.Parse(Answer.Text);
            double temp = Math.E;
            for (int i = 1; i < ln; i++)
            {
                temp *= temp;
            }
            Answer.Text = temp.ToString();

        }

        private void Precent_Click(object sender, EventArgs e)
        {
            double precent = double.Parse(Answer.Text);
            precent /= 100;
            Answer.Text = precent.ToString();
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            Answer.Text += ".";
        }

        private void Twotothex_Click(object sender, EventArgs e)
        {
            double exp = double.Parse(Answer.Text);
            for (int i = 1; i < 2; i++) { exp *= exp; }
            Answer.Text = exp.ToString();
        }

        private void TentotheX_Click(object sender, EventArgs e)
        {
            double exp = double.Parse(Answer.Text);
            double exp2 = exp;
            for (int i = 1; i < 10; i++) { exp *= exp2; }
            Answer.Text = exp.ToString();
        }

        private void xTotheThird_Click(object sender, EventArgs e)
        {
            double exp = double.Parse(Answer.Text);
            double exp2 = exp;
            for (int i = 1; i < 3; i++) { exp *= exp2; }
            Answer.Text = exp.ToString();
        }

        private void xToThey_Click(object sender, EventArgs e)
        {
            if (History.Text == "")
            {
                History.Text = Answer.Text;
                Answer.Text = "";
            }
            else
            {
                double exp1 = double.Parse(History.Text);
                double exp2 = double.Parse(Answer.Text);
                double exp3 = exp1;
                for (int i = 1; i < exp2; i++) { exp1 *= exp3; }
                Answer.Text = exp1.ToString();
            }

        }

        private void radical_Click(object sender, EventArgs e)
        {
            double rad = double.Parse(Answer.Text);
            int increment = 1;
            for (int i = 0; i <= rad; i++) { increment *= i; }
            Answer.Text = increment.ToString();
        }

        private void log2_Click(object sender, EventArgs e)
        {
            double ln = double.Parse(Answer.Text);
            ln = Math.Log2(ln);
            Answer.Text = ln.ToString();
        }

        private void Logy_Click(object sender, EventArgs e)
        {
            if (History.Text == "")
            {
                History.Text = Answer.Text;
                Answer.Text = "";
            }
            else
            {
                double y = double.Parse(Answer.Text);
                double exp = y;
                double exp2 = 10;
                double exp3 = exp2;
                for (int i = 1; i < y; i++) { exp2 *= exp3; }
                Answer.Text = exp2.ToString();
            }
        }

        private void SqrX_Click(object sender, EventArgs e)
        {
            double x = Math.Sqrt(double.Parse(Answer.Text));
            Answer.Text = x.ToString();
        }

        private void CubedRootX_Click(object sender, EventArgs e)
        {
            double x = Math.Cbrt(double.Parse(Answer.Text));
            Answer.Text = x.ToString();
        }

        private void fourSquarootx_Click(object sender, EventArgs e)
        {
            double x = Math.Sqrt(Math.Sqrt(double.Parse(Answer.Text)));
            Answer.Text = x.ToString();
        }

        private void ySqrx_Click(object sender, EventArgs e)
        {
            if (History.Text == "")
            {
                History.Text = Answer.Text;
                Answer.Text = "";
            }
            else
            {


                double x = double.Parse(Answer.Text);
                for (int i = 1; i < x; i++)
                {
                    x = Math.Sqrt(x);
                }
                Answer.Text += x.ToString();
            }
        }// if (Answer.Text.Contains('=')) { Answer.Text = Answer.Text.Remove(Answer.Text.Length - 1); }

        private void OneOverX_Click(object sender, EventArgs e)
        {
            double x = double.Parse(Answer.Text);
            x = 1 / x;
            Answer.Text += x.ToString();

        }

        private void Sin_Click(object sender, EventArgs e)
        {
            double x = double.Parse(Answer.Text);
            Math.Sin(x);
            Answer.Text += x.ToString();
        }

        private void Cos_Click(object sender, EventArgs e)
        {
            double x = double.Parse(Answer.Text);
            Math.Cos(x);
            Answer.Text += x.ToString();
        }

        private void Tan_Click(object sender, EventArgs e)
        {
            double x = double.Parse(Answer.Text);
            Math.Tan(x);
            Answer.Text += x.ToString();
        }

        private void Tanh_Click(object sender, EventArgs e)
        {
            double x = double.Parse(Answer.Text);
            Math.Tanh(x);
            Answer.Text += x.ToString();
        }

        private void Cosh_Click(object sender, EventArgs e)
        {
            double x = double.Parse(Answer.Text);
            Math.Cosh(x);
            Answer.Text += x.ToString();
        }

        private void Sinh_Click(object sender, EventArgs e)
        {
            double x = double.Parse(Answer.Text);
            Math.Sinh(x);
            Answer.Text += x.ToString();
        }
    }
}


/* for (int i = 0; i != Answer.Text.Length; i++)
 {ghgygnf b                                                                                              

     if (Answer.Text[i] == '+' || Answer.Text[i] == '-' || Answer.Text[i] == '*' || Answer.Text[i] == '/')
     {
         if (Answer.Text[0] == '+' || Answer.Text[0] == '*' || Answer.Text[0] == '/') { Answer.Text = "0"; return; }
         if (Answer.Text.Length < 1)
         {
             if (Answer.Text[i] == Answer.Text[i + 1]) { Answer.Text = ""; History.Text = "ERROR TO MANY OPERATORS"; return; }
         }

         if (Answer.Text.Length - 1 == i && (Answer.Text[i] == '+' || Answer.Text[i] == '-' || Answer.Text[i] == '*' || Answer.Text[i] == '/'))
         {
             {

                 Answer.Text = Answer.Text.Remove(Answer.Text.Length - 1);

                 i--;

             }

         }
     }
 }*/
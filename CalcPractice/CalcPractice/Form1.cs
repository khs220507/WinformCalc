using System.Security.Cryptography.X509Certificates;

namespace calcPractice
{
    public partial class Form1 : Form
    {

        private bool opFlag; // 연산자 버튼이 눌리면 true
        private double savedValue;
        private char op;

        public Form1()
        {
            InitializeComponent();
            txtResult.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }



        private void textMain_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            // 1. "0"일때 "01"이 나오면 안됨
            // 2. "12"라는 숫자를 입력한 후 "+"를 누르고 다시 "3"이라고는 숫자를 누르면 결과창에는 "123"이 아닌 "3"이 나와야함
            if (txtResult.Text=="0" || opFlag ==true)
            {
                txtResult.Text = btn.Text;
                opFlag = false; // 
                
            }

            // 위 두가지 경우가 아니면 "12"라는 숫자를 입력한 후 "3"을 입력하면 "123"이 나옴
            else
                txtResult.Text = txtResult.Text + btn.Text;


        }

        private void btnDot_Click_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Contains("."))
                return;
            else
                txtResult.Text += ".";
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            savedValue = Double.Parse(txtResult.Text); 
            txtExp.Text = txtResult.Text + " + "; 
            op = '+';
            opFlag = true;
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            savedValue = Double.Parse(txtResult.Text);
            txtExp.Text = txtResult.Text + " - ";
            op = '-';
            opFlag = true;
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            savedValue = Double.Parse(txtResult.Text);
            txtExp.Text = txtResult.Text + " x ";
            op = '*';
            opFlag = true;
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            savedValue = Double.Parse(txtResult.Text);
            txtExp.Text = txtResult.Text + " / ";
            op = '/';
            opFlag = true;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            Double v = Double.Parse(txtResult.Text); //
            switch (op)
            {
                case '+':
                    txtResult.Text = (savedValue + v).ToString();
                    break;
                case '-':
                    txtResult.Text = (savedValue - v).ToString();
                    break;
                case '*':
                    txtResult.Text = (savedValue * v).ToString();
                    break;
                case '/':
                    txtResult.Text = (savedValue / v).ToString();
                    break;
            }
            txtExp.Text = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtResult.Text ="0";
            txtExp.Text ="";
            savedValue = 0;
            op ='\0';
            opFlag = false;
        }
        
       
       
        
    }
}
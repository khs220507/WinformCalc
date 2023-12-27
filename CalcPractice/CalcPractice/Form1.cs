using System.Security.Cryptography.X509Certificates;

namespace calcPractice
{
    public partial class Form1 : Form
    {

        private bool opFlag; // ������ ��ư�� ������ true
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
            // 1. "0"�϶� "01"�� ������ �ȵ�
            // 2. "12"��� ���ڸ� �Է��� �� "+"�� ������ �ٽ� "3"�̶��� ���ڸ� ������ ���â���� "123"�� �ƴ� "3"�� ���;���
            if (txtResult.Text=="0" || opFlag ==true)
            {
                txtResult.Text = btn.Text;
                opFlag = false; // 
                
            }

            // �� �ΰ��� ��찡 �ƴϸ� "12"��� ���ڸ� �Է��� �� "3"�� �Է��ϸ� "123"�� ����
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
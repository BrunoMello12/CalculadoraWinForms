using System.Globalization;
using System.Windows.Forms;

namespace Calculadora.WinFormsApp
{
    public partial class Form1 : Form
    {
        string tipoOperacao;
        decimal valor1 = 0, valor2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                tipoOperacao = "SOMA";
                lblOperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a soma!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                tipoOperacao = "SUB";
                lblOperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a subtração!");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                tipoOperacao = "MULTI";
                lblOperacao.Text = "X";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a multiplicação!");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                tipoOperacao = "DIV";
                lblOperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a divisão!");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text != "")
            {
                valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                switch (tipoOperacao)
                {
                    case "SOMA": txtResultado.Text = Convert.ToString(valor1 + valor2); break;
                    case "SUB": txtResultado.Text = Convert.ToString(valor1 - valor2); break;
                    case "MULTI": txtResultado.Text = Convert.ToString(valor1 * valor2); break;
                    case "DIV": txtResultado.Text = Convert.ToString(valor1 / valor2); break;
                }
            }
            else
            {
                MessageBox.Show("Para ter um resultado primeiro realize uma operação");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
            valor1 = 0;
            valor2 = 0;
        }
    }
}
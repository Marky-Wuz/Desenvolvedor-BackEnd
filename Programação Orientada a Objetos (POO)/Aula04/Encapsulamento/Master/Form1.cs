using Banco;
using System.CodeDom.Compiler;
namespace Master
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declaração de variaveis
        string nome;
        int numero;
        double saldo;
        ContaBancaria conta1;
        bool error = false;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                nome = textBox1.Text;
                numero = int.Parse(textBox2.Text);
                if (textBox3.Text == "")
                {
                    saldo = 0;
                }
                else
                {
                    saldo = double.Parse(textBox3.Text);
                }


            }
            catch (Exception erro)
            {
                MessageBox.Show($"Dados invalidos, Erro: {erro.Message}");
                error = true;
            }
            if (!error)
            {
                if (saldo > 0)
                {
                    conta1 = new ContaBancaria(nome, numero);
                }
                else
                {
                    conta1 = new ContaBancaria(nome, numero, saldo);
                }
                MessageBox.Show(conta1.ExibirDados());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label5.Visible = Enabled = checkBox1.Checked;
                textBox3.Visible = Enabled = checkBox1.Checked;
            }
            else
            {
                label5.Visible = false;
                textBox3.Visible = false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button1.Visible = Enabled = checkBox1.Checked;
            }
            else
            {
                button1.Visible = false;
            }
        }
    }
}

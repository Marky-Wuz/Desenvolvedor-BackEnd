namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string user = "SENAI";
            const int senha = 123456;
            bool ok1, ok2;
            string usuario = textBox1.Text;
            int password = Convert.ToInt32(textBox2.Text);

            if (user == usuario)
            {
                ok1 = true;
            }
            else
            {
                ok1 = false;
            }

            if (password == senha)
            {
                ok2 = true;
            }
            else
            {
                ok2 = false;
            }

            if (ok1 & ok2)
            {
                MessageBox.Show("Usuario e Senha Corretas! Acesso permitido.");
            }
            else
            {
                MessageBox.Show("Usuario e senha incorretos! Tente novamente.");
            }
        }
    }
}

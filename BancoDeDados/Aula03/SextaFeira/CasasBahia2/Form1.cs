
using CasasBahia2.Classes.Contextos;


namespace CasasBahia2
{
    public partial class Form1 : Form
    {
        //Campo
        Form2 janela1;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var contexto = new LoginsContexto();


            var usuario = contexto.Logins.FirstOrDefault(u => u.Usuario == textBox1.Text);
            var senha = contexto.Logins.FirstOrDefault(s => s.Senha == textBox2.Text);

            bool login = (usuario != null) & (senha != null);

            if (login)
            {
                MessageBox.Show("Login realizado com sucesso!");

                //Abre a Segunda tela
                Form2 Janela1 = new Form2();
                Janela1.Show();
                Hide();
                
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.");


            }
        }
    }
}

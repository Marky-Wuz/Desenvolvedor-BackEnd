using SistemaERP.Classes.Contextos;
using SistemaERP.Classes.Entidades;
using SistemaERP.Telas;

namespace SistemaERP
{
    public partial class Login : Form
    {
        //campos
        bool statusBT;

        //construtor
        public Login()
        {
            ContextoUltimoUsuario usuario = new ContextoUltimoUsuario();
            InitializeComponent();
            statusBT = true;
            var check = usuario.ultimoUsuario.FirstOrDefault(e => e.EsqueceuSenha == true);


            if (check != null)
            {
                checkBox1.Checked = true;
                textBox1.Text = check.Nome;
                textBox2.Text = check.Senha;
            }
            else
            {
                checkBox1.Checked = false;
                textBox1.Text = null;
                textBox2.Text = null;
            }
        }

        // eventos
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Esqueceu a Senha -> Quando clicar
            Hide();
            Esqueceu esqueceu = new Esqueceu();
            esqueceu.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Registro -> Quando clicar
            Hide();
            RegistroDeConta registro = new RegistroDeConta();
            registro.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Login -> Quando clicar
            Hide();
            ERPVendas erp = new ERPVendas();
            erp.Show();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox2_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {


            const string caminhoImagemOlhofechado = @"C:\\Users\\Back\\Documents\\DEVBACKEND\\BancoDeDados\\Aula07\\ERPVendsa\\SistemaERP\\Fotos\\olhos-de-lentes-de-contato.png";
            const string caminhoImagemOlhoAberto = @"C:\Users\Back\Documents\DEVBACKEND\BancoDeDados\Aula07\ERPVendsa\SistemaERP\Fotos\olho.png";

            pictureBox3.ImageLocation = caminhoImagemOlhofechado;

            if (statusBT)
            {
                pictureBox3.ImageLocation = caminhoImagemOlhofechado;
                textBox2.UseSystemPasswordChar = false;
                statusBT = false;
            }
            else
            {
                pictureBox3.ImageLocation = caminhoImagemOlhoAberto;
                textBox2.UseSystemPasswordChar = true;
                statusBT = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ContextoUltimoUsuario ultimocontexto = new ContextoUltimoUsuario();
            string nome = textBox1.Text;
            string senha = textBox2.Text;
            bool check = checkBox1.Checked;

            if (check)
            {
                var usuario = ultimocontexto.ultimoUsuario.FirstOrDefault(i => i.Id == 1);
                if (usuario != null)
                {
                    usuario.Nome = nome;
                    usuario.Senha = senha;
                    usuario.EsqueceuSenha = check;
                    ultimocontexto.SaveChanges();
                }
                else
                {
                    UltimoUser usuario1 = new UltimoUser(nome, senha, check);
                    ultimocontexto.ultimoUsuario.Add(usuario1);
                    ultimocontexto.SaveChanges();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

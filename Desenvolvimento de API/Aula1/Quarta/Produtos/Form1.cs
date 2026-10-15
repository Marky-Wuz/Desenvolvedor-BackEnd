using System.Net.Http.Json;

namespace Produtos
{
    public partial class Form1 : Form
    {
        private readonly HttpClient clienteHttp = new()
        {
            BaseAddress = new Uri("https://localhost:5007")
        };
        public Form1()
        {

            InitializeComponent();
        }
        //Botão para Criar um novo produto
        private void button1_Click(object sender, EventArgs e)
        {
            string mensagem;
            mensagem = clienteHttp.GetStringAsync("Produtos").Result;
            MessageBox.Show(mensagem);
        }
    }
}

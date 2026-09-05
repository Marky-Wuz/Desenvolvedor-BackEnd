using CasasBahia2.Classes.Contextos;
using CasasBahia2.Classes.Entidades;

namespace CasasBahia2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Tab 1 - Botão para cadastrar item
        private void button1_Click(object sender, EventArgs e)
        {
            ProdutosContexto contexto = new ProdutosContexto();
            string cadastroNomeProduto = textBox2.Text;
            int quantidadeDeProduto = int.Parse(textBox1.Text);
            decimal valorDoProduto = decimal.Parse(textBox3.Text);


            Produtos produto = new Produtos(cadastroNomeProduto, quantidadeDeProduto, valorDoProduto);
            contexto.Produtos.Add(produto);
            contexto.SaveChanges();
            MessageBox.Show("Produto cadastrado com sucesso!");
            textBox2.Text = "";
            textBox1.Text = "";
            textBox3.Text = "";
        }

        //Tab 2 - Botão para consultar/pesquisar item
        private void button2_Click(object sender, EventArgs e)
        {
            ProdutosContexto contexto = new ProdutosContexto();
            var produto = contexto.Produtos.FirstOrDefault(p => p.CodigoDoProduto == int.Parse(textBox4.Text));
            if (produto == null)
            {
                MessageBox.Show("Produto não encontrado!");
            }
            else
            {
                MessageBox.Show($"\tProduto encontrado: {produto.NomeDoProduto} \n" +
                    $"\tQuantidade: {produto.QuantidadeDeProduto} \n" +
                    $"\tValor: {produto.ValorDoProduto} \n");

            }
            textBox4.Text = "";
        }

        //Tab 3 - Botão para editar item
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

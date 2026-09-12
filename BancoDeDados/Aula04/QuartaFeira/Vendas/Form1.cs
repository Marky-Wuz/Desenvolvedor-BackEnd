using Microsoft.IdentityModel.Tokens;
using VendasSenai.Classes.Contextos;

namespace Vendas
{
    public partial class Form1 : Form
    {
                VendasContexto vendasContexto = new VendasContexto();
        public Form1()
        {
            VendasContexto vendas1 = new VendasContexto();
            InitializeComponent();
        }

        void CarregarDados(string filtro = "")
        {
            try
            {
                var listaDeVenda = vendasContexto.vendas.ToList();
                switch (filtro)
                {
                    case "Id":
                        //Procurar por Id
                        dataGridView1.DataSource = vendasContexto.vendas.Where(vendasContexto => vendasContexto.Id.ToString().Contains(textBox1.Text)).ToList();
                        break;
                    case "Data":
                        //Procurar por Data
                        dataGridView1.DataSource = vendasContexto.vendas.Where(vendasContexto => vendasContexto.DataCompra.ToString().Contains(textBox1.Text)).ToList();
                        break;
                    case "Tipo":
                        //Procurar por Tipo
                        dataGridView1.DataSource = vendasContexto.vendas.Where(vendasContexto => vendasContexto.Tipo.Contains(textBox1.Text)).ToList();
                        break;
                    case "Marca":
                        //Procurar por Marca
                        dataGridView1.DataSource = vendasContexto.vendas.Where(vendasContexto => vendasContexto.Marca.Contains(textBox1.Text)).ToList();
                        break;
                    default:
                        dataGridView1.DataSource = listaDeVenda;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IsNullOrEmpty())
            {
                CarregarDados();
            }
            else if (radioButton1.Checked)
            {
                CarregarDados("Id");
            }
            else if (radioButton2.Checked)
            {
                CarregarDados("Data");
            }
            else if (radioButton3.Checked)
            {
                CarregarDados("Tipo");
            }
            else if (radioButton4.Checked)
            {
                CarregarDados("Marca");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var linhaselecionada = dataGridView1.SelectedRows[0];
            textBox2.Text = linhaselecionada.Cells["Id"].Value.ToString();
            textBox4.Text = linhaselecionada.Cells["DataCompra"].Value.ToString();
            textBox3.Text = linhaselecionada.Cells["Tipo"].Value.ToString();
            textBox5.Text = linhaselecionada.Cells["Marca"].Value.ToString();
            textBox6.Text = linhaselecionada.Cells["Faturamento"].Value.ToString();
            textBox7.Text = linhaselecionada.Cells["Lucro"].Value.ToString();
            tabControl1.SelectedTab = tabPage2;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox5.ReadOnly = false;
            textBox6.ReadOnly = false;
            textBox7.ReadOnly = false;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}

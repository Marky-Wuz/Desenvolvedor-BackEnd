using Restaurante.Classes.Contextos;
using Microsoft.EntityFrameworkCore;

namespace Restaurante
{
    public partial class Form1 : Form
    {
        //Campos
        new PratosContexto contexto = new PratosContexto();
        Dictionary<string, decimal> carrinho = new Dictionary<string, decimal>();
        //Timer
        System.Windows.Forms.Timer timerPanel = new System.Windows.Forms.Timer();
        //Posição final da side bar
        int posicaoPanelX;
        

        public Form1()
        {
            InitializeComponent();
            timerPanel.Interval = 15;
            timerPanel.Tick += TimerPanel_Tick;
        }

        private void TimerPanel_Tick(object? sender, EventArgs e)
        {
            const int velocidade = 20;

            //move o panel para a direita até alcançar a posição final
            if (panel1.Left < posicaoPanelX)
            {
                panel1.Left += velocidade;
                
                if (panel1.Left >= posicaoPanelX)
                {
                    panel1.Left = posicaoPanelX;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Eventos

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = contexto.Pratos.Select(t => new { t.Id, t.Nome_Do_Prato, Preco = t.Preco.ToString("C") }).ToList();
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Nome do Prato";
            dataGridView1.Columns[2].HeaderText = "Preço";
        }

        private void dataGridView1_MouseHover(object sender, EventArgs e)
        {
            try
            {
                var coordenadasMouse = dataGridView1.PointToClient(Cursor.Position);

                int id = dataGridView1.HitTest(coordenadasMouse.X, coordenadasMouse.Y).RowIndex + 1;

                var comida = contexto.Pratos.FirstOrDefault(e => e.Id == id);

                if (comida != null)
                {
                    pictureBox1.ImageLocation = comida.Foto_Do_Prato;
                }
                else
                {
                    pictureBox1.ImageLocation = null;
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos um item do cardápio");
            }
            else
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                var comidaSelecionada = contexto.Pratos.FirstOrDefault(e => e.Id == id);
                carrinho.Add(comidaSelecionada.Nome_Do_Prato, comidaSelecionada.Preco);
                MessageBox.Show("Item adicionado ao carrinho");



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conteudoCarrinho = "Lista do Carrinho:\n";

            foreach (var item in carrinho)
            {
                conteudoCarrinho += $"Nome do Prato: {item.Key} | Preço; {item.Value:C}\n";
            }

            MessageBox.Show(conteudoCarrinho);

            panel1.Visible = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
         
        }
    }
}

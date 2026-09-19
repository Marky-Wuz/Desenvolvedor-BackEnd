using Cars.Classes.Animation;
using Cars.Classes.Contextos;
using Cars.Classes.Contextos;
using Cars.Classes.Services;

namespace Cars;

public partial class Principal : Form
{
    // Controlador que concentra toda a lógica de animação do panel1.
    private readonly AnimationPanel animacaoPainel;

    public Principal()
    {

        // Inicializa os controles criados pelo Windows Forms Designer.
        InitializeComponent();

        // Cria o controlador e informa qual painel deverá ser animado.
        animacaoPainel = new AnimationPanel(panel1);

        // Associa os botões de navegação ao método que fecha o painel.
        button3.Click += FecharPanel_Click;
        button4.Click += FecharPanel_Click;
        button5.Click += FecharPanel_Click;
    }


    private void button2_Click(object? sender, EventArgs e)
    {
        // Solicita à classe de animação que abra o painel ao clicar em Comprar.
        animacaoPainel.Abrir();
    }

    private void FecharPanel_Click(object? sender, EventArgs e)
    {
        // Solicita à classe de animação que feche o painel.
        animacaoPainel.Fechar();
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {
        var linhaselecionada = dataGridView1.SelectedRows[0];
        textBox2.Text = linhaselecionada.Cells["Modelo"].Value.ToString();
        textBox3.Text = linhaselecionada.Cells["Tipo"].Value.ToString();
        textBox4.Text = linhaselecionada.Cells["Valor"].Value.ToString();
        textBox5.Text = linhaselecionada.Cells["Quantidade"].Value.ToString();
    }

    private void button1_Click(object sender, EventArgs e)
    {

        bool moto = checkBox1.Checked;
        bool carro = checkBox2.Checked;
        string texto = textBox1.Text;
        Pesquisa.Pesquisas(moto, carro, texto, dataGridView1);

    }


    private void textBox1_TextChanged_1(object sender, EventArgs e)
    {
    }


    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {

    }
}

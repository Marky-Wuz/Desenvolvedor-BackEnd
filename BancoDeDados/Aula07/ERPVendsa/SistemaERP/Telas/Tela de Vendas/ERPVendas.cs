using Microsoft.EntityFrameworkCore;
using Microsoft.ReportingServices.Interfaces;
using SistemaERP.Classes.Contexto;
using SistemaERP.Classes.Entidades;
using SistemaERP.Classes.Enumerações;
using SistemaERP.Dados;
using SistemaERP.Telas.Tela_de_Vendas.Compostos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace SistemaERP.Telas
{
    public partial class ERPVendas : Form
    {
        ContextoPessoa pessoa = new ContextoPessoa();
        public ERPVendas()
        {
            InitializeComponent();
        }

        private void ERPVendas_Load(object sender, EventArgs e)
        {
            DateTime hoje = DateTime.Today;
            dataGridView1.DataSource = pessoa.Pessoas.Select(t => new { Status = (StatusUsuario)(t.Status), t.NomeDoUsuario, }).ToList();
            dataGridView1.Columns[0].HeaderText = "Função";
            dataGridView1.Columns[1].HeaderText = "Nome do Usuário";

        }

        private void ERPVendas_FormClosed(object sender, FormClosedEventArgs e)
        {
            TelaLogin.AbrirTela();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private async Task sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

            TelaLogin.AbrirTela();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void aprovaçãoDePdidoDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void aprovaçãoDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aprovacao tela = new Aprovacao();
            tela.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void relátorioDeVendasToolScripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CarregarRelatorio()
        {
            Hide();
            RelatorioVendas relatorio = new RelatorioVendas();
            relatorio.Show();
        }

        private void relátorioDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CarregarRelatorio();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possivel carregar o relatório: Erro {ex.Message}");
            }

        }
    }
}

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
        public ERPVendas()
        {
            InitializeComponent();
        }

        private void ERPVendas_Load(object sender, EventArgs e)
        {

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

     
    }
}

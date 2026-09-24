using SistemaERP.Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaERP.Telas
{
    public partial class Esqueceu : Form
    {
        public Esqueceu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Esqueceu_FormClosed(object sender, FormClosedEventArgs e)
        {
            TelaLogin.AbrirTela();
        }
    }
}

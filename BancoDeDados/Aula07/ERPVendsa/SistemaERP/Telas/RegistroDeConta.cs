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
    public partial class RegistroDeConta : Form
    {
        public RegistroDeConta()
        {
            InitializeComponent();
        }

        private void RegistroDeConta_Load(object sender, EventArgs e)
        {

        }

        private void RegistroDeConta_FormClosed(object sender, FormClosedEventArgs e)
        {
            TelaLogin.AbrirTela();
        }
    }
}

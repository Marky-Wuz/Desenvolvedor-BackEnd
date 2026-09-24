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
    }
}

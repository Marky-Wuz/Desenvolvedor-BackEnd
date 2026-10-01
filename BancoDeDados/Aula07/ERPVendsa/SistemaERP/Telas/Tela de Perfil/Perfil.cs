using SistemaERP.Classes.Contexto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaERP.Telas.Tela_de_Perfil
{
    public partial class Perfil : Form
    {
        ContextoPessoa pessoa = new ContextoPessoa();
        public Perfil()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            {
                try
                {
                    var linhaselecionada = dataGridView1.SelectedRows[0];
                    textBox1.Text = linhaselecionada.Cells["NomeDoUsuario"].Value.ToString();
                    textBox2.Text = linhaselecionada.Cells["DataDeNascimento"].Value.ToString();
                    textBox3.Text = linhaselecionada.Cells["Regra"].Value.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Selecione uma linha da tabela");
                }
            }
        }
    }
}

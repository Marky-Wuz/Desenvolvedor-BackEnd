using SistemaERP.Classes.Contexto;
using SistemaERP.Classes.Entidades;
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

        private void button2_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string sobrenome = textBox2.Text;
            long cpf = long.Parse(textBox4.Text);
            DateTime data = DateTime.SpecifyKind(monthCalendar1.SelectionStart, DateTimeKind.Utc);

            MessageBox.Show($"Nome = {nome}" +
                $"\nSobrenome = {sobrenome}" +
                $"\nCPF = {cpf}" +
                $"\nData = {data}");
            string nomecompleo = nome + " " + sobrenome;
            Pessoa usuario = new Pessoa(nomecompleo, cpf, data,0);
            ContextoPessoa pessoa = new ContextoPessoa();
            pessoa.Pessoas.Add(usuario);
            pessoa.SaveChanges();
        }
    }
}

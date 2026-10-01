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
    public partial class RelatorioVendas : Form
    {
        public RelatorioVendas()
        {
            InitializeComponent();
        }

        private void RelatorioVendas_Load(object sender, EventArgs e)
        {
            var tabela = new VendasDataSet();
            new VendasDataSetTableAdapters.Vendas2TableAdapter().Fill(tabela.Vendas2);

            reportViewer1.RefreshReport();

            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer { Dock = DockStyle.Fill };

            var arquivoRelatorio = File.OpenRead(Path.GetFullPath(@"C:\Users\Back\Documents\DEVBACKEND\BancoDeDados\Aula07\ERPVendsa\SistemaERP\Relatorio\Report1.rdlc"));

            reportViewer1.LocalReport.LoadReportDefinition(arquivoRelatorio);

            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", (System.Data.DataTable)tabela.Vendas2));

            Controls.Clear();
            Controls.Add(reportViewer1);


            WindowState = FormWindowState.Maximized;
        }

        private void RelatorioVendas_FormClosed(object sender, FormClosedEventArgs e)
        {
            ERPVendas janela = new ERPVendas();
            janela.Show();
            Close();
        }
    }
}

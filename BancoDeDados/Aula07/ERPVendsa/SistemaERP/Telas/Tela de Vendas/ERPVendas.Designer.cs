namespace SistemaERP.Telas
{
    partial class ERPVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            sairToolStripMenuItem1 = new ToolStripMenuItem();
            vendasToolStripMenuItem = new ToolStripMenuItem();
            consultaDePedidoDeVendasToolStripMenuItem = new ToolStripMenuItem();
            aprovaçãoDePdidoDeVendasToolStripMenuItem = new ToolStripMenuItem();
            relátorioDeVendasToolStripMenuItem = new ToolStripMenuItem();
            editarPedidoDeVendasToolStripMenuItem = new ToolStripMenuItem();
            criarPedidoDeVendasToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            aprovaçãoDeUsuárioToolStripMenuItem = new ToolStripMenuItem();
            editarUsuárioToolStripMenuItem = new ToolStripMenuItem();
            consultarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            criarUsuárioToolStripMenuItem = new ToolStripMenuItem();
            deletarUsuárioToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, vendasToolStripMenuItem, usuáriosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1084, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem, toolStripSeparator1, sairToolStripMenuItem1 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(89, 29);
            toolStripMenuItem1.Text = "Sistema";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Image = Properties.Resources.olho;
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(127, 30);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(124, 6);
            // 
            // sairToolStripMenuItem1
            // 
            sairToolStripMenuItem1.Image = Properties.Resources.escaneamento_de_rosto;
            sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            sairToolStripMenuItem1.Size = new Size(127, 30);
            sairToolStripMenuItem1.Text = "Perfil";
            sairToolStripMenuItem1.Click += sairToolStripMenuItem1_Click;
            // 
            // vendasToolStripMenuItem
            // 
            vendasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultaDePedidoDeVendasToolStripMenuItem, aprovaçãoDePdidoDeVendasToolStripMenuItem, relátorioDeVendasToolStripMenuItem, editarPedidoDeVendasToolStripMenuItem, criarPedidoDeVendasToolStripMenuItem });
            vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            vendasToolStripMenuItem.Size = new Size(85, 29);
            vendasToolStripMenuItem.Text = "Vendas";
            // 
            // consultaDePedidoDeVendasToolStripMenuItem
            // 
            consultaDePedidoDeVendasToolStripMenuItem.Name = "consultaDePedidoDeVendasToolStripMenuItem";
            consultaDePedidoDeVendasToolStripMenuItem.Size = new Size(354, 30);
            consultaDePedidoDeVendasToolStripMenuItem.Text = "Consulta de Pedido de vendas";
            // 
            // aprovaçãoDePdidoDeVendasToolStripMenuItem
            // 
            aprovaçãoDePdidoDeVendasToolStripMenuItem.Name = "aprovaçãoDePdidoDeVendasToolStripMenuItem";
            aprovaçãoDePdidoDeVendasToolStripMenuItem.Size = new Size(354, 30);
            aprovaçãoDePdidoDeVendasToolStripMenuItem.Text = "Aprovação de pedido de vendas";
            aprovaçãoDePdidoDeVendasToolStripMenuItem.Click += aprovaçãoDePdidoDeVendasToolStripMenuItem_Click;
            // 
            // relátorioDeVendasToolStripMenuItem
            // 
            relátorioDeVendasToolStripMenuItem.Name = "relátorioDeVendasToolStripMenuItem";
            relátorioDeVendasToolStripMenuItem.Size = new Size(354, 30);
            relátorioDeVendasToolStripMenuItem.Text = "Relátorio de vendas";
            // 
            // editarPedidoDeVendasToolStripMenuItem
            // 
            editarPedidoDeVendasToolStripMenuItem.Name = "editarPedidoDeVendasToolStripMenuItem";
            editarPedidoDeVendasToolStripMenuItem.Size = new Size(354, 30);
            editarPedidoDeVendasToolStripMenuItem.Text = "Editar pedido de vendas";
            // 
            // criarPedidoDeVendasToolStripMenuItem
            // 
            criarPedidoDeVendasToolStripMenuItem.Name = "criarPedidoDeVendasToolStripMenuItem";
            criarPedidoDeVendasToolStripMenuItem.Size = new Size(354, 30);
            criarPedidoDeVendasToolStripMenuItem.Text = "Criar pedido de vendas";
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aprovaçãoDeUsuárioToolStripMenuItem, editarUsuárioToolStripMenuItem, consultarUsuarioToolStripMenuItem, criarUsuárioToolStripMenuItem, deletarUsuárioToolStripMenuItem });
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(97, 29);
            usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // aprovaçãoDeUsuárioToolStripMenuItem
            // 
            aprovaçãoDeUsuárioToolStripMenuItem.Name = "aprovaçãoDeUsuárioToolStripMenuItem";
            aprovaçãoDeUsuárioToolStripMenuItem.Size = new Size(268, 30);
            aprovaçãoDeUsuárioToolStripMenuItem.Text = "Aprovação de usuário";
            aprovaçãoDeUsuárioToolStripMenuItem.Click += aprovaçãoDeUsuárioToolStripMenuItem_Click;
            // 
            // editarUsuárioToolStripMenuItem
            // 
            editarUsuárioToolStripMenuItem.Name = "editarUsuárioToolStripMenuItem";
            editarUsuárioToolStripMenuItem.Size = new Size(268, 30);
            editarUsuárioToolStripMenuItem.Text = "Editar Usuário";
            // 
            // consultarUsuarioToolStripMenuItem
            // 
            consultarUsuarioToolStripMenuItem.Name = "consultarUsuarioToolStripMenuItem";
            consultarUsuarioToolStripMenuItem.Size = new Size(268, 30);
            consultarUsuarioToolStripMenuItem.Text = "Consultar Usuario";
            // 
            // criarUsuárioToolStripMenuItem
            // 
            criarUsuárioToolStripMenuItem.Name = "criarUsuárioToolStripMenuItem";
            criarUsuárioToolStripMenuItem.Size = new Size(268, 30);
            criarUsuárioToolStripMenuItem.Text = "Criar Usuário";
            // 
            // deletarUsuárioToolStripMenuItem
            // 
            deletarUsuárioToolStripMenuItem.Name = "deletarUsuárioToolStripMenuItem";
            deletarUsuárioToolStripMenuItem.Size = new Size(268, 30);
            deletarUsuárioToolStripMenuItem.Text = "Deletar Usuário";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(270, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(698, 334);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.InactiveBorder;
            dataGridView1.Location = new Point(12, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 334);
            dataGridView1.TabIndex = 2;
//            dataGridView1.CellContentClick += this.dataGridView1_CellContentClick;
            // 
            // ERPVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 513);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ERPVendas";
            Text = "ERPVendas";
            FormClosed += ERPVendas_FormClosed;
            Load += ERPVendas_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem vendasToolStripMenuItem;
        private ToolStripMenuItem consultaDePedidoDeVendasToolStripMenuItem;
        private ToolStripMenuItem aprovaçãoDePdidoDeVendasToolStripMenuItem;
        private ToolStripMenuItem relátorioDeVendasToolStripMenuItem;
        private ToolStripMenuItem editarPedidoDeVendasToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem aprovaçãoDeUsuárioToolStripMenuItem;
        private ToolStripMenuItem editarUsuárioToolStripMenuItem;
        private ToolStripMenuItem consultarUsuarioToolStripMenuItem;
        private ToolStripMenuItem criarPedidoDeVendasToolStripMenuItem;
        private ToolStripMenuItem criarUsuárioToolStripMenuItem;
        private ToolStripMenuItem deletarUsuárioToolStripMenuItem;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
    }
}
namespace SistemaERP.Telas.Tela_de_Perfil
{
    partial class Perfil
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dataGridView1 = new DataGridView();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-2, -2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(377, 458);
            dataGridView1.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Sitka Banner", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(12, 322);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.ScrollBars = ScrollBars.Vertical;
            textBox4.Size = new Size(349, 124);
            textBox4.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(115, 299);
            label4.Name = "label4";
            label4.Size = new Size(155, 20);
            label4.TabIndex = 17;
            label4.Text = "A Minha Descrição é:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Sitka Banner", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(207, 260);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(154, 26);
            textBox3.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(207, 237);
            label3.Name = "label3";
            label3.Size = new Size(134, 20);
            label3.TabIndex = 15;
            label3.Text = "A Minha Função é";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(40, 237);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 14;
            label2.Text = "A Minha idade é";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Sitka Banner", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(12, 260);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(154, 26);
            textBox2.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(94, 152);
            label1.Name = "label1";
            label1.Size = new Size(193, 30);
            label1.TabIndex = 12;
            label1.Text = "Olá! Meu Nome é";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Sitka Banner", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(40, 183);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(302, 38);
            textBox1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.ImageLocation = "C:\\Users\\Back\\Documents\\DEVBACKEND\\BancoDeDados\\Aula07\\ERPVendsa\\SistemaERP\\Fotos\\cara.png";
            pictureBox1.Location = new Point(94, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Perfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(373, 450);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Name = "Perfil";
            Text = "Perfil";
            Load += Perfil_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView dataGridView1;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
    }
}
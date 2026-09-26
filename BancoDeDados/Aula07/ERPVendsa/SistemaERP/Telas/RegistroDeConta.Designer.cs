namespace SistemaERP.Telas
{
    partial class RegistroDeConta
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
            label1 = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            monthCalendar1 = new MonthCalendar();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.MediumTurquoise;
            label1.Location = new Point(54, 166);
            label1.Name = "label1";
            label1.Size = new Size(67, 26);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 19.75F, FontStyle.Bold | FontStyle.Italic);
            button2.ForeColor = Color.MediumTurquoise;
            button2.Location = new Point(4, 418);
            button2.Name = "button2";
            button2.Size = new Size(159, 45);
            button2.TabIndex = 4;
            button2.Text = "Registrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ImageLocation = "C:\\Users\\Back\\Documents\\DEVBACKEND\\BancoDeDados\\Aula07\\ERPVendsa\\SistemaERP\\Fotos\\escaneamento-de-rosto.gif";
            pictureBox1.Location = new Point(92, -20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 212);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 195);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 23);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 12.25F, FontStyle.Bold);
            label3.ForeColor = Color.MediumTurquoise;
            label3.Location = new Point(187, 225);
            label3.Name = "label3";
            label3.Size = new Size(184, 22);
            label3.TabIndex = 8;
            label3.Text = "Data de Nascimento";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 250);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(133, 23);
            textBox4.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.MediumTurquoise;
            label4.Location = new Point(54, 225);
            label4.Name = "label4";
            label4.Size = new Size(47, 26);
            label4.TabIndex = 10;
            label4.Text = "CPF";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(167, 250);
            monthCalendar1.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            monthCalendar1.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 12;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.ImageLocation = "C:\\Users\\Back\\Documents\\DEVBACKEND\\BancoDeDados\\Aula07\\ERPVendsa\\SistemaERP\\Fotos\\cracha.gif";
            pictureBox2.Location = new Point(-31, 279);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(227, 133);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MediumTurquoise;
            label2.Location = new Point(187, 421);
            label2.Name = "label2";
            label2.Size = new Size(187, 52);
            label2.TabIndex = 14;
            label2.Text = "     Bem Vindo!\r\ná nossa Equipe!";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(214, 195);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 23);
            textBox2.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.MediumTurquoise;
            label5.Location = new Point(256, 166);
            label5.Name = "label5";
            label5.Size = new Size(118, 26);
            label5.TabIndex = 16;
            label5.Text = "Sobrenome";
            // 
            // RegistroDeConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(393, 492);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(monthCalendar1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegistroDeConta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistroDeConta";
            FormClosed += RegistroDeConta_FormClosed;
            Load += RegistroDeConta_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private MonthCalendar monthCalendar1;
        private PictureBox pictureBox2;
        private Label label2;
        private TextBox textBox2;
        private Label label5;
    }
}
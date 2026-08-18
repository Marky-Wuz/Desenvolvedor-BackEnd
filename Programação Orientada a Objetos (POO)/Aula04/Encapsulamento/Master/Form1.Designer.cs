namespace Master
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            label6 = new Label();
            label7 = new Label();
            checkBox2 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(303, -2);
            label1.Name = "label1";
            label1.Size = new Size(177, 46);
            label1.TabIndex = 0;
            label1.Text = "Cadastro ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Gothic", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(264, 44);
            label2.Name = "label2";
            label2.Size = new Size(243, 35);
            label2.TabIndex = 1;
            label2.Text = "Banco master";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MV Boli", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 131);
            label3.Name = "label3";
            label3.Size = new Size(136, 46);
            label3.TabIndex = 2;
            label3.Text = "Titular";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MV Boli", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(37, 209);
            label4.Name = "label4";
            label4.Size = new Size(163, 34);
            label4.TabIndex = 3;
            label4.Text = "ID da conta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MV Boli", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(37, 297);
            label5.Name = "label5";
            label5.Size = new Size(207, 34);
            label5.TabIndex = 4;
            label5.Text = "Saldo da Conta";
            label5.Visible = false;
            label5.Click += label5_Click;
            // 
            // textBox1
            // 
            textBox1.AcceptsReturn = true;
            textBox1.Location = new Point(264, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(317, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.AcceptsReturn = true;
            textBox2.Location = new Point(264, 220);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(317, 23);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.AcceptsReturn = true;
            textBox3.Location = new Point(264, 308);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(317, 23);
            textBox3.TabIndex = 7;
            textBox3.Visible = false;
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(329, 398);
            button1.Name = "button1";
            button1.Size = new Size(178, 40);
            button1.TabIndex = 8;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click_1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackgroundImageLayout = ImageLayout.Center;
            checkBox1.Location = new Point(406, 291);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 9;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(376, 273);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 10;
            label6.Text = "Saldo inicial?";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(303, 354);
            label7.Name = "label7";
            label7.Size = new Size(234, 15);
            label7.TabIndex = 12;
            label7.Text = "Voce concorda com nossos termos de uso?";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackgroundImageLayout = ImageLayout.Center;
            checkBox2.Location = new Point(406, 373);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(15, 14);
            checkBox2.TabIndex = 11;
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(checkBox2);
            Controls.Add(label6);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private CheckBox checkBox1;
        private Label label6;
        private Label label7;
        private CheckBox checkBox2;
    }
}

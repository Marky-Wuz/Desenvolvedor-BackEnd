namespace CasasBahia2
{
    partial class Form2
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            label6 = new Label();
            textBox4 = new TextBox();
            button2 = new Button();
            label5 = new Label();
            tabPage3 = new TabPage();
            label11 = new Label();
            textBox8 = new TextBox();
            label10 = new Label();
            textBox7 = new TextBox();
            label9 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            button3 = new Button();
            textBox5 = new TextBox();
            label7 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.DarkRed;
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastrar Item";
            tabPage1.Click += tabPage1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(280, 345);
            button1.Name = "button1";
            button1.Size = new Size(191, 34);
            button1.TabIndex = 7;
            button1.Text = "Criar Item";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(234, 35);
            label4.Name = "label4";
            label4.Size = new Size(237, 37);
            label4.TabIndex = 6;
            label4.Text = "Cadastro de item";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 189);
            label3.Name = "label3";
            label3.Size = new Size(167, 37);
            label3.TabIndex = 5;
            label3.Text = "Quantidade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 269);
            label2.Name = "label2";
            label2.Size = new Size(90, 37);
            label2.TabIndex = 4;
            label2.Text = "Preço";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 102);
            label1.Name = "label1";
            label1.Size = new Size(249, 37);
            label1.TabIndex = 3;
            label1.Text = "Nome do Produto";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(343, 266);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(383, 43);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(343, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(383, 43);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(343, 189);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(383, 43);
            textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Firebrick;
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consultar Item";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(285, 12);
            label6.Name = "label6";
            label6.Size = new Size(196, 37);
            label6.TabIndex = 3;
            label6.Text = "Consultar Item";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(235, 107);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(300, 23);
            textBox4.TabIndex = 2;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(589, 107);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(36, 98);
            label5.Name = "label5";
            label5.Size = new Size(183, 32);
            label5.TabIndex = 0;
            label5.Text = "Digite o Código";
            label5.Click += label5_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.IndianRed;
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(textBox8);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(textBox7);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(textBox6);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(textBox5);
            tabPage3.Controls.Add(label7);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(768, 398);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Editar Item";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(271, 13);
            label11.Name = "label11";
            label11.Size = new Size(188, 47);
            label11.TabIndex = 12;
            label11.Text = "Editar Item";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(271, 272);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(262, 23);
            textBox8.TabIndex = 11;
            textBox8.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(90, 263);
            label10.Name = "label10";
            label10.Size = new Size(158, 30);
            label10.TabIndex = 10;
            label10.Text = "Digite o Código";
            label10.Visible = false;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(271, 227);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(262, 23);
            textBox7.TabIndex = 9;
            textBox7.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(90, 218);
            label9.Name = "label9";
            label9.Size = new Size(158, 30);
            label9.TabIndex = 8;
            label9.Text = "Digite o Código";
            label9.Visible = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(271, 185);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(262, 23);
            textBox6.TabIndex = 7;
            textBox6.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(90, 176);
            label8.Name = "label8";
            label8.Size = new Size(158, 30);
            label8.TabIndex = 6;
            label8.Text = "Digite o Código";
            label8.Visible = false;
            // 
            // button3
            // 
            button3.Location = new Point(595, 114);
            button3.Name = "button3";
            button3.Size = new Size(111, 22);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(260, 114);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(300, 23);
            textBox5.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(71, 105);
            label7.Name = "label7";
            label7.Size = new Size(183, 32);
            label7.TabIndex = 3;
            label7.Text = "Digite o Código";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form2";
            Text = "janela1";
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox textBox4;
        private Button button2;
        private Label label5;
        private Label label6;
        private TextBox textBox8;
        private Label label10;
        private TextBox textBox7;
        private Label label9;
        private TextBox textBox6;
        private Label label8;
        private Button button3;
        private TextBox textBox5;
        private Label label7;
        private Label label11;
    }
}
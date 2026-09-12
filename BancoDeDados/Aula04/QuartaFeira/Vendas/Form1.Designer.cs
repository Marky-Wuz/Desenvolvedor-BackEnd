namespace Vendas
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            button2 = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(8, 1);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(668, 258);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(radioButton4);
            tabPage1.Controls.Add(radioButton3);
            tabPage1.Controls.Add(radioButton2);
            tabPage1.Controls.Add(radioButton1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(660, 230);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Consulta";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(318, 33);
            radioButton4.Margin = new Padding(2);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(58, 19);
            radioButton4.TabIndex = 8;
            radioButton4.TabStop = true;
            radioButton4.Text = "Marca";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(264, 33);
            radioButton3.Margin = new Padding(2);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(49, 19);
            radioButton3.TabIndex = 7;
            radioButton3.TabStop = true;
            radioButton3.Text = "Tipo";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(137, 33);
            radioButton2.Margin = new Padding(2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(109, 19);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Data de compra";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(96, 33);
            radioButton1.Margin = new Padding(2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(35, 19);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Id";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 97);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(640, 135);
            dataGridView1.TabIndex = 4;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // button1
            // 
            button1.Location = new Point(297, 59);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(123, 20);
            button1.TabIndex = 3;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseClick += button1_MouseClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 59);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 34);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "Buscar por:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 21);
            label1.TabIndex = 0;
            label1.Text = "Filtros de pesquisa";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(textBox7);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(660, 230);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Detalhes do Item";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(527, 95);
            button2.Name = "button2";
            button2.Size = new Size(111, 41);
            button2.TabIndex = 12;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Display", 14.2499981F, FontStyle.Bold);
            label8.Location = new Point(55, 167);
            label8.Name = "label8";
            label8.Size = new Size(58, 28);
            label8.TabIndex = 11;
            label8.Text = "Lucro";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Display", 14.2499981F, FontStyle.Bold);
            label7.Location = new Point(31, 138);
            label7.Name = "label7";
            label7.Size = new Size(115, 28);
            label7.TabIndex = 10;
            label7.Text = "Faturamento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Display", 14.2499981F, FontStyle.Bold);
            label6.Location = new Point(55, 108);
            label6.Name = "label6";
            label6.Size = new Size(62, 28);
            label6.TabIndex = 9;
            label6.Text = "Marca";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Display", 14.2499981F, FontStyle.Bold);
            label5.Location = new Point(55, 80);
            label5.Name = "label5";
            label5.Size = new Size(48, 28);
            label5.TabIndex = 8;
            label5.Text = "Tipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Display", 14.2499981F, FontStyle.Bold);
            label4.Location = new Point(13, 50);
            label4.Name = "label4";
            label4.Size = new Size(141, 28);
            label4.TabIndex = 7;
            label4.Text = "Data de Compra";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Display", 14.2499981F, FontStyle.Bold);
            label3.Location = new Point(65, 22);
            label3.Name = "label3";
            label3.Size = new Size(28, 28);
            label3.TabIndex = 6;
            label3.Text = "Id";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(154, 174);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(330, 23);
            textBox7.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(154, 145);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(330, 23);
            textBox6.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(154, 116);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(330, 23);
            textBox5.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(154, 58);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(330, 23);
            textBox4.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(154, 87);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(330, 23);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(154, 29);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(330, 23);
            textBox2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(685, 266);
            Controls.Add(tabControl1);
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pedidos de vendas";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button2;
    }
}

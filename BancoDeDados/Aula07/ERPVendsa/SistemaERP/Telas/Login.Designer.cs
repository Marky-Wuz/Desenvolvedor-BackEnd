namespace SistemaERP
{
    partial class Login
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            checkBox1 = new CheckBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Siemens AD Mono", 20.25F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.MediumTurquoise;
            label1.Location = new Point(179, 250);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 31);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Siemens AD Mono", 20.25F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.MediumTurquoise;
            label2.Location = new Point(179, 331);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 31);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            label2.UseWaitCursor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Cursor = Cursors.Hand;
            textBox1.Font = new Font("Sylfaen", 15.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(-3, 284);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(467, 35);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.UseWaitCursor = true;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Window;
            textBox2.Font = new Font("Sylfaen", 15.75F, FontStyle.Bold | FontStyle.Italic);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(-3, 365);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(467, 35);
            textBox2.TabIndex = 3;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.UseSystemPasswordChar = true;
            textBox2.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Sylfaen", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.MediumTurquoise;
            button1.Location = new Point(168, 430);
            button1.Name = "button1";
            button1.Size = new Size(116, 38);
            button1.TabIndex = 4;
            button1.Text = "Entrar";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "C:\\Users\\Back\\Documents\\DEVBACKEND\\BancoDeDados\\Aula07\\ERPVendsa\\SistemaERP\\Fotos\\trancar.gif";
            pictureBox1.Location = new Point(192, 474);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.ImageLocation = "C:\\Users\\Back\\Documents\\DEVBACKEND\\BancoDeDados\\Aula07\\ERPVendsa\\SistemaERP\\Fotos\\cracha.gif";
            pictureBox2.Location = new Point(111, 52);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(228, 185);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.UseWaitCursor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold);
            linkLabel1.LinkColor = Color.MediumTurquoise;
            linkLabel1.Location = new Point(10, 501);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(146, 20);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Esqueceu a Senha?";
            linkLabel1.UseWaitCursor = true;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold);
            linkLabel2.LinkColor = Color.MediumTurquoise;
            linkLabel2.Location = new Point(362, 501);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(75, 20);
            linkLabel2.TabIndex = 8;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Registrar";
            linkLabel2.UseWaitCursor = true;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Sylfaen", 10.75F, FontStyle.Bold | FontStyle.Italic);
            checkBox1.Location = new Point(10, 406);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(113, 23);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Lembrar-me";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.UseWaitCursor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.olho;
            pictureBox3.ImageLocation = "C:\\Users\\Back\\Documents\\DEVBACKEND\\BancoDeDados\\Aula07\\ERPVendsa\\SistemaERP\\Fotos\\olho.png";
            pictureBox3.Location = new Point(421, 373);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 18);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            pictureBox3.UseWaitCursor = true;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(463, 530);
            Controls.Add(pictureBox3);
            Controls.Add(checkBox1);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Sylfaen", 15.75F, FontStyle.Bold | FontStyle.Italic);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private CheckBox checkBox1;
        private PictureBox pictureBox3;
    }
}

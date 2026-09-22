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
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            textBox1.ForeColor = SystemColors.InactiveCaptionText;
            textBox1.Location = new Point(104, 284);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 35);
            textBox1.TabIndex = 2;
            textBox1.UseWaitCursor = true;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Sylfaen", 15.75F, FontStyle.Bold | FontStyle.Italic);
            textBox2.Location = new Point(104, 365);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(242, 35);
            textBox2.TabIndex = 3;
            textBox2.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Sylfaen", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.MediumTurquoise;
            button1.Location = new Point(163, 434);
            button1.Name = "button1";
            button1.Size = new Size(116, 38);
            button1.TabIndex = 4;
            button1.Text = "Entrar";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "C:\\Users\\Back\\Documents\\DEVBACKEND\\BancoDeDados\\Aula07\\ERPVendsa\\SistemaERP\\Fotos\\trancar.gif";
            pictureBox1.Location = new Point(12, 301);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.ImageLocation = "C:\\Users\\Back\\Documents\\DEVBACKEND\\BancoDeDados\\Aula07\\ERPVendsa\\SistemaERP\\Fotos\\cracha.gif";
            pictureBox2.Location = new Point(104, 52);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(228, 185);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.UseWaitCursor = true;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.MediumTurquoise;
            progressBar1.ForeColor = Color.MediumTurquoise;
            progressBar1.Location = new Point(-1, 417);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(471, 10);
            progressBar1.TabIndex = 7;
            progressBar1.UseWaitCursor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(463, 530);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Sylfaen", 15.75F, FontStyle.Bold | FontStyle.Italic);
            Margin = new Padding(5);
            Name = "Login";
            Text = "Login";
            UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private ProgressBar progressBar1;
    }
}

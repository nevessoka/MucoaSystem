namespace MucoaSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            label4 = new Label();
            X = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            tbpwd = new TextBox();
            button1 = new Button();
            showpwd = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 66, 34);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 606);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(54, 269);
            label5.Name = "label5";
            label5.Size = new Size(263, 25);
            label5.TabIndex = 3;
            label5.Text = "Mucoa Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(120, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(254, 91, 74);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(31, 546);
            button2.Name = "button2";
            button2.Size = new Size(312, 36);
            button2.TabIndex = 1;
            button2.Text = "SIGNUP";
            button2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(78, 506);
            label4.Name = "label4";
            label4.Size = new Size(203, 25);
            label4.TabIndex = 0;
            label4.Text = "Register your Account";
            // 
            // X
            // 
            X.AutoSize = true;
            X.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            X.Location = new Point(801, 9);
            X.Name = "X";
            X.Size = new Size(26, 30);
            X.TabIndex = 1;
            X.Text = "X";
            X.Click += X_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(509, 91);
            label1.Name = "label1";
            label1.Size = new Size(194, 26);
            label1.TabIndex = 2;
            label1.Text = "Register Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(410, 219);
            label2.Name = "label2";
            label2.Size = new Size(119, 26);
            label2.TabIndex = 3;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(407, 313);
            label3.Name = "label3";
            label3.Size = new Size(114, 26);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(410, 255);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(374, 39);
            textBox1.TabIndex = 5;
            // 
            // tbpwd
            // 
            tbpwd.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tbpwd.Location = new Point(410, 346);
            tbpwd.Multiline = true;
            tbpwd.Name = "tbpwd";
            tbpwd.PasswordChar = '*';
            tbpwd.Size = new Size(374, 38);
            tbpwd.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 67, 34);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(410, 465);
            button1.Name = "button1";
            button1.Size = new Size(153, 46);
            button1.TabIndex = 7;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // showpwd
            // 
            showpwd.AutoSize = true;
            showpwd.Location = new Point(622, 404);
            showpwd.Name = "showpwd";
            showpwd.Size = new Size(162, 29);
            showpwd.TabIndex = 8;
            showpwd.Text = "Show Password";
            showpwd.UseVisualStyleBackColor = true;
            showpwd.CheckedChanged += showpwd_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(835, 606);
            ControlBox = false;
            Controls.Add(showpwd);
            Controls.Add(button1);
            Controls.Add(tbpwd);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(X);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private PictureBox pictureBox1;
        private Button button2;
        private Label label4;
        private Label X;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox tbpwd;
        private Button button1;
        private CheckBox showpwd;
    }
}
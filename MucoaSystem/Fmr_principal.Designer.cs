using System.Windows.Forms;

namespace MucoaSystem
{
    partial class Fmr_principal
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
            LogPanel = new Panel();
            dataGridView2 = new DataGridView();
            EnncoPanel = new Panel();
            groupBox2 = new GroupBox();
            btnAddEncomenda = new Button();
            btnRemover = new Button();
            btnAlterar = new Button();
            txbValorPago = new TextBox();
            txbValorTotal = new TextBox();
            cbxEstado = new ComboBox();
            txtLocal = new TextBox();
            upDownQuant = new DomainUpDown();
            cbxMenu = new ComboBox();
            dtEntrega = new DateTimePicker();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            dtEncom = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            btnClearCliente = new Button();
            btnAdicionarCliente = new Button();
            dtNasc = new DateTimePicker();
            txtEmail = new TextBox();
            txtMorada = new TextBox();
            txtContato = new TextBox();
            txtNome = new TextBox();
            label1 = new Label();
            lbDataNasc = new Label();
            label2 = new Label();
            lbEmail = new Label();
            lbContato = new Label();
            tabelaPanel = new Panel();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            LogPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            EnncoPanel.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabelaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LogPanel
            // 
            LogPanel.Controls.Add(dataGridView2);
            LogPanel.Location = new Point(8, 484);
            LogPanel.Margin = new Padding(2);
            LogPanel.Name = "LogPanel";
            LogPanel.Size = new Size(1258, 129);
            LogPanel.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(3, 2);
            dataGridView2.Margin = new Padding(2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(1255, 125);
            dataGridView2.TabIndex = 0;
            // 
            // EnncoPanel
            // 
            EnncoPanel.Controls.Add(groupBox2);
            EnncoPanel.Controls.Add(groupBox1);
            EnncoPanel.Location = new Point(8, 27);
            EnncoPanel.Margin = new Padding(2);
            EnncoPanel.Name = "EnncoPanel";
            EnncoPanel.Size = new Size(403, 451);
            EnncoPanel.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAddEncomenda);
            groupBox2.Controls.Add(btnRemover);
            groupBox2.Controls.Add(btnAlterar);
            groupBox2.Controls.Add(txbValorPago);
            groupBox2.Controls.Add(txbValorTotal);
            groupBox2.Controls.Add(cbxEstado);
            groupBox2.Controls.Add(txtLocal);
            groupBox2.Controls.Add(upDownQuant);
            groupBox2.Controls.Add(cbxMenu);
            groupBox2.Controls.Add(dtEntrega);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(dtEncom);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(16, 207);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(368, 242);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados Encomenda";
            // 
            // btnAddEncomenda
            // 
            btnAddEncomenda.BackColor = Color.Transparent;
            btnAddEncomenda.ForeColor = SystemColors.ActiveCaptionText;
            btnAddEncomenda.Location = new Point(119, 190);
            btnAddEncomenda.Margin = new Padding(2);
            btnAddEncomenda.Name = "btnAddEncomenda";
            btnAddEncomenda.Size = new Size(73, 38);
            btnAddEncomenda.TabIndex = 21;
            btnAddEncomenda.Text = "Adicionar";
            btnAddEncomenda.UseVisualStyleBackColor = false;
            btnAddEncomenda.Click += btnAddEncomenda_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(272, 190);
            btnRemover.Margin = new Padding(2);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(68, 38);
            btnRemover.TabIndex = 20;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(196, 190);
            btnAlterar.Margin = new Padding(2);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(66, 38);
            btnAlterar.TabIndex = 19;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // txbValorPago
            // 
            txbValorPago.Location = new Point(93, 127);
            txbValorPago.Margin = new Padding(2);
            txbValorPago.Name = "txbValorPago";
            txbValorPago.Size = new Size(72, 24);
            txbValorPago.TabIndex = 18;
            // 
            // txbValorTotal
            // 
            txbValorTotal.Location = new Point(270, 69);
            txbValorTotal.Margin = new Padding(2);
            txbValorTotal.Name = "txbValorTotal";
            txbValorTotal.Size = new Size(70, 24);
            txbValorTotal.TabIndex = 17;
            // 
            // cbxEstado
            // 
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Items.AddRange(new object[] { "Pendente", "Entregue", "Pago 50%" });
            cbxEstado.Location = new Point(241, 125);
            cbxEstado.Margin = new Padding(2);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(99, 23);
            cbxEstado.TabIndex = 16;
            // 
            // txtLocal
            // 
            txtLocal.Location = new Point(168, 98);
            txtLocal.Margin = new Padding(2);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(172, 24);
            txtLocal.TabIndex = 12;
            // 
            // upDownQuant
            // 
            upDownQuant.Location = new Point(281, 42);
            upDownQuant.Margin = new Padding(2);
            upDownQuant.Name = "upDownQuant";
            upDownQuant.Size = new Size(58, 24);
            upDownQuant.Sorted = true;
            upDownQuant.TabIndex = 15;
            upDownQuant.Text = "1";
            // 
            // cbxMenu
            // 
            cbxMenu.FormattingEnabled = true;
            cbxMenu.Items.AddRange(new object[] { "Menu 1", "Menu 2", "Menu 3" });
            cbxMenu.Location = new Point(64, 40);
            cbxMenu.Margin = new Padding(2);
            cbxMenu.Name = "cbxMenu";
            cbxMenu.Size = new Size(124, 23);
            cbxMenu.TabIndex = 14;
            // 
            // dtEntrega
            // 
            dtEntrega.Format = DateTimePickerFormat.Short;
            dtEntrega.Location = new Point(211, 156);
            dtEntrega.Margin = new Padding(2);
            dtEntrega.Name = "dtEntrega";
            dtEntrega.Size = new Size(129, 24);
            dtEntrega.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 127);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(72, 17);
            label10.TabIndex = 12;
            label10.Text = "Valor Pago:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(179, 130);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(53, 17);
            label9.TabIndex = 11;
            label9.Text = "Estado :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(198, 72);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(72, 17);
            label8.TabIndex = 10;
            label8.Text = "Valor Total:";
            // 
            // dtEncom
            // 
            dtEncom.Format = DateTimePickerFormat.Short;
            dtEncom.Location = new Point(99, 70);
            dtEncom.Margin = new Padding(2);
            dtEncom.Name = "dtEncom";
            dtEncom.Size = new Size(89, 24);
            dtEncom.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 45);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 17);
            label3.TabIndex = 0;
            label3.Text = "Menu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 98);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(106, 17);
            label4.TabIndex = 4;
            label4.Text = "Local da Entrega:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(196, 45);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 17);
            label5.TabIndex = 1;
            label5.Text = "Quantidade:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 159);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(105, 17);
            label6.TabIndex = 3;
            label6.Text = "Data da Entrega:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 73);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(80, 17);
            label7.TabIndex = 2;
            label7.Text = "Data da Enc:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClearCliente);
            groupBox1.Controls.Add(btnAdicionarCliente);
            groupBox1.Controls.Add(dtNasc);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtMorada);
            groupBox1.Controls.Add(txtContato);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lbDataNasc);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lbEmail);
            groupBox1.Controls.Add(lbContato);
            groupBox1.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(16, 8);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(368, 188);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Cliente";
            // 
            // btnClearCliente
            // 
            btnClearCliente.Location = new Point(273, 142);
            btnClearCliente.Margin = new Padding(2);
            btnClearCliente.Name = "btnClearCliente";
            btnClearCliente.Size = new Size(67, 38);
            btnClearCliente.TabIndex = 11;
            btnClearCliente.Text = "Clear";
            btnClearCliente.UseVisualStyleBackColor = true;
            btnClearCliente.Click += button4_Click;
            // 
            // btnAdicionarCliente
            // 
            btnAdicionarCliente.Location = new Point(183, 142);
            btnAdicionarCliente.Margin = new Padding(2);
            btnAdicionarCliente.Name = "btnAdicionarCliente";
            btnAdicionarCliente.Size = new Size(79, 38);
            btnAdicionarCliente.TabIndex = 10;
            btnAdicionarCliente.Text = "Adicionar";
            btnAdicionarCliente.UseVisualStyleBackColor = true;
            btnAdicionarCliente.Click += btnAdicionarCliente_Click;
            // 
            // dtNasc
            // 
            dtNasc.Format = DateTimePickerFormat.Short;
            dtNasc.Location = new Point(251, 75);
            dtNasc.Margin = new Padding(2);
            dtNasc.Name = "dtNasc";
            dtNasc.Size = new Size(89, 24);
            dtNasc.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(82, 107);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(257, 24);
            txtEmail.TabIndex = 8;
            // 
            // txtMorada
            // 
            txtMorada.Location = new Point(82, 44);
            txtMorada.Margin = new Padding(2);
            txtMorada.Name = "txtMorada";
            txtMorada.Size = new Size(258, 24);
            txtMorada.TabIndex = 7;
            // 
            // txtContato
            // 
            txtContato.Location = new Point(82, 75);
            txtContato.Margin = new Padding(2);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(96, 24);
            txtContato.TabIndex = 6;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(82, 17);
            txtNome.Margin = new Padding(2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(258, 24);
            txtNome.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 17);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            label1.Click += label1_Click;
            // 
            // lbDataNasc
            // 
            lbDataNasc.AutoSize = true;
            lbDataNasc.Location = new Point(182, 77);
            lbDataNasc.Margin = new Padding(2, 0, 2, 0);
            lbDataNasc.Name = "lbDataNasc";
            lbDataNasc.Size = new Size(70, 17);
            lbDataNasc.TabIndex = 4;
            lbDataNasc.Text = "Data Nasc:";
            lbDataNasc.Click += lbDataNasc_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 45);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 17);
            label2.TabIndex = 1;
            label2.Text = "Morada:";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(20, 107);
            lbEmail.Margin = new Padding(2, 0, 2, 0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(43, 17);
            lbEmail.TabIndex = 3;
            lbEmail.Text = "Email:";
            // 
            // lbContato
            // 
            lbContato.AutoSize = true;
            lbContato.Location = new Point(20, 77);
            lbContato.Margin = new Padding(2, 0, 2, 0);
            lbContato.Name = "lbContato";
            lbContato.Size = new Size(63, 17);
            lbContato.TabIndex = 2;
            lbContato.Text = "Contacto:";
            // 
            // tabelaPanel
            // 
            tabelaPanel.Controls.Add(dataGridView1);
            tabelaPanel.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tabelaPanel.Location = new Point(430, 7);
            tabelaPanel.Margin = new Padding(2);
            tabelaPanel.Name = "tabelaPanel";
            tabelaPanel.Size = new Size(836, 473);
            tabelaPanel.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Menu;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.Window;
            dataGridView1.Location = new Point(2, 35);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(832, 436);
            dataGridView1.StandardTab = true;
            dataGridView1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(1123, 628);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(143, 39);
            button2.TabIndex = 2;
            button2.Text = "Enviar E-mail";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(945, 628);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(150, 39);
            button1.TabIndex = 1;
            button1.Text = "Enviar SMS";
            button1.UseVisualStyleBackColor = true;
            // 
            // Fmr_principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 678);
            Controls.Add(button2);
            Controls.Add(tabelaPanel);
            Controls.Add(EnncoPanel);
            Controls.Add(button1);
            Controls.Add(LogPanel);
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Fmr_principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fmr_principal";
            FormClosed += Fmr_principal_FormClosed;
            Load += Fmr_principal_Load;
            LogPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            EnncoPanel.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabelaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel LogPanel;
        private Panel EnncoPanel;
        private Panel tabelaPanel;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private DateTimePicker dtNasc;
        private System.Windows.Forms.TextBox txtEmail;
        private TextBox txtMorada;
        private TextBox txtContato;
        private TextBox txtNome;
        private Label lbDataNasc;
        private Label lbEmail;
        private Label lbContato;
        private GroupBox groupBox2;
        private DateTimePicker dtEncom;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnClearCliente;
        private Button btnAdicionarCliente;
        private ComboBox cbxMenu;
        private DateTimePicker dtEntrega;
        private Label label10;
        private Label label9;
        private Label label8;
        private DomainUpDown upDownQuant;
        private TextBox txbValorPago;
        private TextBox txbValorTotal;
        private ComboBox cbxEstado;
        private TextBox txtLocal;
        private Button btnAddEncomenda;
        private Button btnRemover;
        private Button btnAlterar;
    }
}
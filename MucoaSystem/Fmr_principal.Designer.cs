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
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            comboBox2 = new ComboBox();
            textBox5 = new TextBox();
            quantidade = new DomainUpDown();
            comboBox1 = new ComboBox();
            dateTimePicker3 = new DateTimePicker();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            btnClearCliente = new Button();
            btnAdicionarCliente = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            lbDataNasc = new Label();
            label2 = new Label();
            lbEmail = new Label();
            lbContato = new Label();
            tabelaPanel = new Panel();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            Select = new DataGridViewCheckBoxColumn();
            DataEntrega = new DataGridViewTextBoxColumn();
            menu = new DataGridViewTextBoxColumn();
            quant = new DataGridViewTextBoxColumn();
            valorEncomenda = new DataGridViewTextBoxColumn();
            estadoEnc = new DataGridViewTextBoxColumn();
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
            LogPanel.Location = new Point(12, 664);
            LogPanel.Name = "LogPanel";
            LogPanel.Size = new Size(1624, 159);
            LogPanel.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(3, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(1622, 153);
            dataGridView2.TabIndex = 0;
            // 
            // EnncoPanel
            // 
            EnncoPanel.Controls.Add(groupBox2);
            EnncoPanel.Controls.Add(groupBox1);
            EnncoPanel.Location = new Point(12, 36);
            EnncoPanel.Name = "EnncoPanel";
            EnncoPanel.Size = new Size(556, 609);
            EnncoPanel.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAddEncomenda);
            groupBox2.Controls.Add(btnRemover);
            groupBox2.Controls.Add(btnAlterar);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(quantidade);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(dateTimePicker3);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(10, 267);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(527, 339);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados Encomenda";
            // 
            // btnAddEncomenda
            // 
            btnAddEncomenda.Location = new Point(168, 286);
            btnAddEncomenda.Name = "btnAddEncomenda";
            btnAddEncomenda.Size = new Size(95, 37);
            btnAddEncomenda.TabIndex = 21;
            btnAddEncomenda.Text = "Adicionar";
            btnAddEncomenda.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(389, 286);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(95, 37);
            btnRemover.TabIndex = 20;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(280, 286);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(95, 37);
            btnAlterar.TabIndex = 19;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(133, 188);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(101, 32);
            textBox7.TabIndex = 18;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(386, 92);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(98, 32);
            textBox6.TabIndex = 17;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(344, 185);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(140, 32);
            comboBox2.TabIndex = 16;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(240, 140);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(244, 32);
            textBox5.TabIndex = 12;
            // 
            // quantidade
            // 
            quantidade.Location = new Point(401, 46);
            quantidade.Name = "quantidade";
            quantidade.Size = new Size(83, 32);
            quantidade.Sorted = true;
            quantidade.TabIndex = 15;
            quantidade.Text = "1";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(92, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(175, 32);
            comboBox1.TabIndex = 14;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(302, 236);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(182, 32);
            dateTimePicker3.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 188);
            label10.Name = "label10";
            label10.Size = new Size(103, 24);
            label10.TabIndex = 12;
            label10.Text = "Valor Pago:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(256, 188);
            label9.Name = "label9";
            label9.Size = new Size(77, 24);
            label9.TabIndex = 11;
            label9.Text = "Estado :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(283, 96);
            label8.Name = "label8";
            label8.Size = new Size(104, 24);
            label8.TabIndex = 10;
            label8.Text = "Valor Total:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(142, 94);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(125, 32);
            dateTimePicker2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 52);
            label3.Name = "label3";
            label3.Size = new Size(64, 24);
            label3.TabIndex = 0;
            label3.Text = "Menu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 140);
            label4.Name = "label4";
            label4.Size = new Size(152, 24);
            label4.TabIndex = 4;
            label4.Text = "Local da Entrega:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(280, 52);
            label5.Name = "label5";
            label5.Size = new Size(113, 24);
            label5.TabIndex = 1;
            label5.Text = "Quantidade:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 242);
            label6.Name = "label6";
            label6.Size = new Size(149, 24);
            label6.TabIndex = 3;
            label6.Text = "Data da Entrega:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 99);
            label7.Name = "label7";
            label7.Size = new Size(114, 24);
            label7.TabIndex = 2;
            label7.Text = "Data da Enc:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClearCliente);
            groupBox1.Controls.Add(btnAdicionarCliente);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lbDataNasc);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lbEmail);
            groupBox1.Controls.Add(lbContato);
            groupBox1.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(10, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(527, 231);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Cliente";
            // 
            // btnClearCliente
            // 
            btnClearCliente.Location = new Point(388, 180);
            btnClearCliente.Name = "btnClearCliente";
            btnClearCliente.Size = new Size(96, 37);
            btnClearCliente.TabIndex = 11;
            btnClearCliente.Text = "Clear";
            btnClearCliente.UseVisualStyleBackColor = true;
            btnClearCliente.Click += button4_Click;
            // 
            // btnAdicionarCliente
            // 
            btnAdicionarCliente.Location = new Point(266, 181);
            btnAdicionarCliente.Name = "btnAdicionarCliente";
            btnAdicionarCliente.Size = new Size(105, 37);
            btnAdicionarCliente.TabIndex = 10;
            btnAdicionarCliente.Text = "Adicionar";
            btnAdicionarCliente.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(359, 100);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(125, 32);
            dateTimePicker1.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(127, 135);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(357, 32);
            textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(127, 65);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(357, 32);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(127, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(136, 32);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(357, 32);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 31);
            label1.Name = "label1";
            label1.Size = new Size(65, 24);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            label1.Click += label1_Click;
            // 
            // lbDataNasc
            // 
            lbDataNasc.AutoSize = true;
            lbDataNasc.Location = new Point(261, 104);
            lbDataNasc.Name = "lbDataNasc";
            lbDataNasc.Size = new Size(98, 24);
            lbDataNasc.TabIndex = 4;
            lbDataNasc.Text = "Data Nasc:";
            lbDataNasc.Click += lbDataNasc_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 67);
            label2.Name = "label2";
            label2.Size = new Size(81, 24);
            label2.TabIndex = 1;
            label2.Text = "Morada:";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(28, 135);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(61, 24);
            lbEmail.TabIndex = 3;
            lbEmail.Text = "Email:";
            // 
            // lbContato
            // 
            lbContato.AutoSize = true;
            lbContato.Location = new Point(28, 103);
            lbContato.Name = "lbContato";
            lbContato.Size = new Size(91, 24);
            lbContato.TabIndex = 2;
            lbContato.Text = "Contacto:";
            // 
            // tabelaPanel
            // 
            tabelaPanel.Controls.Add(button2);
            tabelaPanel.Controls.Add(dataGridView1);
            tabelaPanel.Controls.Add(button1);
            tabelaPanel.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tabelaPanel.Location = new Point(586, 12);
            tabelaPanel.Name = "tabelaPanel";
            tabelaPanel.Size = new Size(1050, 633);
            tabelaPanel.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(836, 10);
            button2.Name = "button2";
            button2.Size = new Size(204, 37);
            button2.TabIndex = 2;
            button2.Text = "Enviar E-mail";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Select, DataEntrega, menu, quant, valorEncomenda, estadoEnc });
            dataGridView1.GridColor = SystemColors.InactiveCaption;
            dataGridView1.Location = new Point(0, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1047, 569);
            dataGridView1.StandardTab = true;
            dataGridView1.TabIndex = 0;
            // 
            // Select
            // 
            Select.HeaderText = "Select";
            Select.MinimumWidth = 8;
            Select.Name = "Select";
            // 
            // DataEntrega
            // 
            DataEntrega.HeaderText = "Data Entrega";
            DataEntrega.MinimumWidth = 8;
            DataEntrega.Name = "DataEntrega";
            DataEntrega.Resizable = DataGridViewTriState.True;
            DataEntrega.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // menu
            // 
            menu.HeaderText = "Menu";
            menu.MinimumWidth = 8;
            menu.Name = "menu";
            // 
            // quant
            // 
            quant.HeaderText = "Quantidade";
            quant.MinimumWidth = 8;
            quant.Name = "quant";
            // 
            // valorEncomenda
            // 
            valorEncomenda.HeaderText = "Total";
            valorEncomenda.MinimumWidth = 8;
            valorEncomenda.Name = "valorEncomenda";
            // 
            // estadoEnc
            // 
            estadoEnc.HeaderText = "Estado";
            estadoEnc.MinimumWidth = 8;
            estadoEnc.Name = "estadoEnc";
            // 
            // button1
            // 
            button1.Location = new Point(587, 10);
            button1.Name = "button1";
            button1.Size = new Size(215, 37);
            button1.TabIndex = 1;
            button1.Text = "Enviar SMS";
            button1.UseVisualStyleBackColor = true;
            // 
            // Fmr_principal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1669, 835);
            Controls.Add(tabelaPanel);
            Controls.Add(EnncoPanel);
            Controls.Add(LogPanel);
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
        private DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lbDataNasc;
        private Label lbEmail;
        private Label lbContato;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnClearCliente;
        private Button btnAdicionarCliente;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker3;
        private Label label10;
        private Label label9;
        private Label label8;
        private DomainUpDown quantidade;
        private TextBox textBox7;
        private TextBox textBox6;
        private ComboBox comboBox2;
        private TextBox textBox5;
        private Button btnAddEncomenda;
        private Button btnRemover;
        private Button btnAlterar;
        private DataGridViewCheckBoxColumn Select;
        private DataGridViewTextBoxColumn DataEntrega;
        private DataGridViewTextBoxColumn menu;
        private DataGridViewTextBoxColumn quant;
        private DataGridViewTextBoxColumn valorEncomenda;
        private DataGridViewTextBoxColumn estadoEnc;
    }
}
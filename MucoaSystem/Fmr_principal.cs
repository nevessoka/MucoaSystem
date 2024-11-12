using MucoaSystem.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MucoaSystem
{
    public partial class Fmr_principal : Form
    {
        public static int contadorIdClienet = 1;
        EncomendaManager encomendaManager = new EncomendaManager();
        public Fmr_principal()
        {
            InitializeComponent();

            ConfigurarGridView(dataGridView1);
            dataGridView1.DataSource = encomendaManager.ListaEncomendas;
        }

        private void Fmr_principal_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbDataNasc_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Fmr_principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            Cliente novoCliente = new Cliente
            {
                Nome = txtNome.Text,
                Morada = txtMorada.Text,
                Contato = txtContato.Text,
                DataNascimento = dtNasc.Value,
                Email = txtEmail.Text,
            };

            // Adiciona o cliente à lista e atualiza o GridView
            ClienteManager clienteManager = new ClienteManager();
            clienteManager.AdicionarCliente(novoCliente);
            //clienteManager.PreencherGridView(gridViewClientes);
        }

        private void btnAddEncomenda_Click(object sender, EventArgs e)
        {
            // Cria uma nova encomenda com dados de exemplo
            
            Encomenda novaEncomenda = new Encomenda()
            {
                IdEncomenda = contadorIdClienet++,
                Cliente = new Cliente { Nome = "João Silva", Contato = "9999-9999" },
                Menu = new Menu { Descricao = cbxMenu.SelectedText, Valor = 35 },
                EnderecoEntrega = txtLocal.Text,
                DataEncomenda = DateTime.Now,
                DataEntrega = DateTime.Now.AddDays(3),
                Status = cbxEstado.Text,
                Quantidade = int.Parse((string)upDownQuant.Text),
                ValorPago = decimal.Parse(txbValorPago.Text),
                ValorTotal = decimal.Parse(txbValorTotal.Text.ToString())
            };

            // Adiciona itens à encomenda
            
            //EncomendaManager encomendaManager = new EncomendaManager();

            // Adiciona a encomenda à lista e atualiza o GridView
            encomendaManager.AdicionarEncomenda(novaEncomenda);
            encomendaManager.PreencherGridView(dataGridView1);
            //AdicionarEncomendaNoGridView(dataGridView1, novaEncomenda);
        }

        public void ConfigurarGridView(DataGridView gridView)
        {
            gridView.AutoGenerateColumns = false; // Desativa a geração automática de colunas

            // Configura as colunas manualmente
            gridView.Columns.Clear();
            gridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "IdEncomenda", HeaderText = "ID Encomenda" });
            gridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Cliente.Nome", HeaderText = "Nome do Cliente" });
            gridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Menu.Descricao", HeaderText = "Menu" });
            gridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "EnderecoEntrega", HeaderText = "Local Entrega" });
            gridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DataEncomenda", HeaderText = "Data da Encomenda" });
            gridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DataEntrega", HeaderText = "Data da Entrega" });
            gridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ValorTotal", HeaderText = "Valor Total" });
            gridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ValorPago", HeaderText = "Valor Pago" });
            gridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantidade", HeaderText = "Quantidade" });
            gridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Status" });

            gridView.DefaultCellStyle.BackColor = Color.Beige;           // Cor de fundo das células
            gridView.DefaultCellStyle.Font = new Font("Arial", 10);      // Fonte das células
            gridView.DefaultCellStyle.ForeColor = Color.DarkSlateGray;   // Cor do texto das células
            gridView.DefaultCellStyle.SelectionBackColor = Color.CadetBlue;  // Cor de fundo da célula selecionada
            gridView.DefaultCellStyle.SelectionForeColor = Color.White;  // Cor do texto da célula selecionada
            gridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Alinhamento do conteúdo

            // Estilo do cabeçalho
            gridView.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;  // Cor de fundo do cabeçalho
            gridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;      // Cor do texto do cabeçalho
            gridView.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10, FontStyle.Bold); // Fonte do cabeçalho
            gridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Alinhamento do cabeçalho

            // Estilo de linhas alternadas
            gridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray; // Cor de fundo para linhas alternadas

            // Bordas e estilo de grade
            gridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal; // Borda da célula
            gridView.GridColor = Color.LightGray;   // Cor da grade
            gridView.EnableHeadersVisualStyles = false; // Permite aplicar estilos personalizados ao cabeçalho

            // Estilo das linhas
            gridView.RowHeadersVisible = false; // Oculta a coluna de cabeçalhos das linhas
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Colunas com largura automática

            // Altura das linhas
            gridView.RowTemplate.Height = 20; // Altura das linhas

            // Configura o DataGridView para leitura apenas, se necessário
            gridView.ReadOnly = true;


            //Color exemplee.Appearance.BackColor = Color.FromArgb(255, 235, 156);
            //e.Appearance.ForeColor = Color.FromArgb(156, 87, 0);

            //e.Appearance.BackColor = Color.FromArgb(0xFE, 0xC0, 0xCD);
            //e.Appearance.ForeColor = Color.DarkRed;

            //e.Appearance.BackColor = Color.FromArgb(0xC6, 0xEF, 0xCE);
            //e.Appearance.ForeColor = Color.DarkGreen;

            //e.Appearance.BackColor = Color.PaleGreen;



        }
        // Método para adicionar uma única encomenda ao GridView
        public void AdicionarEncomendaNoGridView(DataGridView gridView, Encomenda encomenda)
        {
            gridView.Rows.Add(
                encomenda.IdEncomenda,
                encomenda.Cliente.Nome,
                encomenda.Menu.Descricao,
                encomenda.EnderecoEntrega,
                encomenda.DataEncomenda.ToString("dd-MM-yyyy"),
                encomenda.DataEntrega?.ToString("dd-MM-yyyy") ?? "N/A",
                encomenda.ValorTotal.ToString("C"),
                encomenda.ValorPago.ToString("C"),
                encomenda.Quantidade,
                encomenda.Status
            );
        }
    }
}

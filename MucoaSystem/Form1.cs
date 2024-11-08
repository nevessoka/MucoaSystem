namespace MucoaSystem
{
    public partial class Form1 : Form
    {
        // Variáveis para armazenar a posição do mouse
        private bool arrastando = false;
        private Point pontoInicial = new Point(0, 0);
        public Form1()
        {
            InitializeComponent();
        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showpwd_CheckedChanged(object sender, EventArgs e)
        {
            tbpwd.PasswordChar = showpwd.Checked ? '\0' : '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text =="" || tbpwd.Text == "")
            {
                MessageBox.Show(" Preencha os campos", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            }
        }
        
    }
}
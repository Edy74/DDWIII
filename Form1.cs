namespace exemplopoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pessoa pessoa = new pessoa(txtNome.Text, txtRg.Text, txtCPF.Text, txtEmail.Text)


                label1.Text = "Nome " + pessoa.NOME + "E-mail: " + pessoa.EMAIL + " RG " + pessoa.RG + " CPF " + pessoa.CPF; 
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRg_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {pessoa pessoa = new pessoa();
            MessageBox.Show("hello sekai");
            txtNome.Text = caixindtext.Text;
        }
    }
}
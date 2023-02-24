namespace loginWForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClick_Click(object sender, EventArgs e)
        {
            if (buttonClick.Text == "Login")
            {
                if (maskedTextBoxUsuario.Text == "")
                {
                    MessageBox.Show("Digite o nome do usuário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (maskedTextBoxUsuario.Text == "Teste")
                    {
                        if (maskedTextBoxSenha.Text == "")
                            MessageBox.Show("Digite a senha", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            if (maskedTextBoxSenha.Text == "1234")
                            {
                                MessageBox.Show("Usuário logado com sucesso", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                labelLogin.Text = "Logado!";
                                labelLogin.ForeColor = Color.Green;
                                maskedTextBoxUsuario.Text = "";
                                maskedTextBoxSenha.Text = "";
                                buttonClick.Text = "Logout";
                            }
                            else
                            {
                                MessageBox.Show("Senha incorreta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuário incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                labelLogin.Text = "Login";
                labelLogin.ForeColor = Color.Black;
                buttonClick.Text = "Login";
            }
        }
    }
}
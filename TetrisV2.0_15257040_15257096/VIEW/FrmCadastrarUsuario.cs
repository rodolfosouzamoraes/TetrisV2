using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using United_Blocks.CONTROLLER;
using United_Blocks.MODEL;

namespace United_Blocks.VIEW
{
    public partial class FrmCadastrarUsuario : Form
    {
        public FrmCadastrarUsuario(bool Idioma)
        {
            InitializeComponent();
            if (Idioma) //true portugues, false ingles
            {
                lbUsuario.Text = "*Usuário:";
                lbSenha.Text = "*Senha:";
                lbConfSenha.Text = "*Confirme a senha:";
                lbEmail.Text = "*E-mail de recuperação:";
                btnCadastrar.Text = "Cadastrar";
                btnCancelar.Text = "Cancelar";
                Mensagem = "Preencha todos os campos!";
                Mensagem2 = "Usuário já existe!";
                Mensagem3 = "As senhas não coincidem!";
                Mensagem4 = "O E-mail está correto?";
                Mensagem5 = "Seu usuário foi cadastrado, obrigado!";
                Mensagem6 = "Usuários com um máximo de 15 caracteres, apenas letras e números!";
                Mensagem7 = "Senha com um máximo de 8 caracteres!";
                Mensagem8 = "CUIDADO!!! E-mail não pode ser preenchido errado, caso contrário não será possivel resgatar a senha! Máximo de 30 caracteres.";

                Titulo = "Atenção";
            }
            else
            {
                lbUsuario.Text = "*User:";
                lbSenha.Text = "*Password:";
                lbConfSenha.Text = "*Confirm the Password:";
                btnCadastrar.Text = "Sign up";
                btnCancelar.Text = "Cancel";
                lbEmail.Text = "*Recovery email:";
                Mensagem = "Fill in all the blanks!";
                Mensagem2 = "User already exists!";
                Mensagem3 = "Passwords do not match!";
                Mensagem4 = "Is E-mail correct?";
                Mensagem5 = "Your user has been registered, thank you!";
                Mensagem6 = "Users with a maximum of 15 characters, only letters and numbers!";
                Mensagem7 = "Password with a maximum of 8 characters!";
                Mensagem8 = "WARNING!!! E-mail can not be filled in wrong, otherwise it will not be possible to recover the password! Maximum of 30 characters.";
                Titulo = "Attention!";
            }
        }
        public static string Mensagem;
        public static string Mensagem2;
        public static string Mensagem3;
        public static string Mensagem4;
        public static string Mensagem5;
        public static string Mensagem6;
        public static string Mensagem7;
        public static string Mensagem8;
        public static string Titulo;
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            lbContagem.Text = Convert.ToString(txtUsuario.Text.Length);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lbContEmail.Text = Convert.ToString(txtEmail.Text.Length);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(txtConfSenha.Text =="" || txtUsuario.Text =="" || txtSenha.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show(Mensagem, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                NickUsuario oNick = new NickUsuario();
                oNick = CUsuario.AchouUsuarioExistente(txtUsuario.Text);
                if (oNick.USR_Nick != null)
                {
                    MessageBox.Show(Mensagem2, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsuario.Text = "";
                    txtUsuario.Focus();
                }
                else
                {
                    if(txtSenha.Text != txtConfSenha.Text)
                    {
                        MessageBox.Show(Mensagem3, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtSenha.Text = "";
                        txtConfSenha.Text = "";
                        txtSenha.Focus();
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show(txtEmail.Text + ", "+ Mensagem4, Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            tb_Usuario oTb_usuario = new tb_Usuario();
                            oTb_usuario.USR_Nick = txtUsuario.Text;
                            oTb_usuario.USR_Senha = txtSenha.Text;
                            oTb_usuario.USR_Email = txtEmail.Text;
                            oTb_usuario.USR_DataCadastro = System.DateTime.Now;
                            CUsuario.Incluir(oTb_usuario);
                            MessageBox.Show(Mensagem5, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
            }
        }

        private void btnQuestUsu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Mensagem6, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnQuestSenha_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Mensagem7, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnQuestEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Mensagem8, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void FrmCadastrarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}

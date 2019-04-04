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
    public partial class FrmMudarSenha : Form
    {
        public FrmMudarSenha(bool Idioma)
        {
            InitializeComponent();
            if (Idioma)
            {
                lbUsuario.Text = "*Usuário:";
                lbSenha.Text = "*Senha:";
                lbNvSenha.Text = "Nova Senha:";
                lbConfSenha.Text = "Confirmação:";
                btnAlterar.Text = "Alterar";
                btnCancelar.Text = "Cancelar";
                Titulo = "Atenção!";
                Mensagem = "Preencha todos os campos!";
                Mensagem2 = "Usuário não encontrado!";
                Mensagem3 = "Senha está errada!";
                Mensagem4 = "Senhas não coincidem!";
                Mensagem5 = "Senha alterada!";
            }
            else
            {
                lbUsuario.Text = "*User:";
                lbSenha.Text = "*Password:";
                lbNvSenha.Text = "New Password:";
                lbConfSenha.Text = "Confirmation:";
                btnAlterar.Text = "Change";
                btnCancelar.Text = "Cancel";
                Titulo = "Attention!";
                Mensagem = "Fill in all the blanks!";
                Mensagem2 = "User not found!";
                Mensagem3 = "Wrong password!";
                Mensagem4 = "Passwords do not match!";
                Mensagem5 = "Password is changed!";
            }
        }
        public static string Titulo;
        public static string Mensagem;
        public static string Mensagem2;
        public static string Mensagem3;
        public static string Mensagem4;
        public static string Mensagem5;
        private void FrmMudarSenha_Load(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "" || txtSenha.Text == "" || txtNvSenha.Text =="" || txtConfSenha.Text == "")
            {
                MessageBox.Show(Mensagem, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                NickUsuario oUsuario = new NickUsuario();
                oUsuario = CUsuario.AchouUsuarioExistente(txtUsuario.Text);
                if(oUsuario.USR_Nick == null)
                {
                    MessageBox.Show(Mensagem2, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsuario.Text = "";
                    txtUsuario.Focus();
                }
                else
                {
                    tb_Usuario oTbUsuario = CUsuario.AchouUsuario(oUsuario);
                    if (txtSenha.Text != oTbUsuario.USR_Senha)
                    {
                        MessageBox.Show(Mensagem3, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtSenha.Text = "";
                        txtSenha.Focus();
                    }
                    else
                    {
                        if(txtNvSenha.Text != txtConfSenha.Text)
                        {
                            MessageBox.Show(Mensagem4, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtNvSenha.Text = "";
                            txtConfSenha.Text = "";
                            txtNvSenha.Focus();
                        }
                        else
                        {
                            oTbUsuario.USR_Senha = txtNvSenha.Text;
                            CUsuario.Alterar(oTbUsuario);
                            MessageBox.Show(Mensagem5, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtUsuario.Text = "";
                            txtSenha.Text = "";
                            txtNvSenha.Text = "";
                            txtConfSenha.Text = "";
                            this.Close();
                        }
                    }
                }
            }
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

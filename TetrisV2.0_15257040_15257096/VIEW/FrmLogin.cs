using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using United_Blocks.MODEL;
using United_Blocks.CONTROLLER;

namespace United_Blocks.VIEW
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            _Idioma = true;
        }
        public static string Titulo;
        public static string Menssagem;
        public static string Menssagem2;
        public static string Menssagem3;


        public static bool _Idioma;
        public bool Idioma
        { get { return _Idioma; } }

        public static string _Usuario;
        public string Usuario
        { get { return _Usuario; } }

        public static string _Modo;
        public string Modo
        { get { return _Modo; } }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text=="" || txtSenha.Text == "")
            {
                MessageBox.Show(Menssagem,Titulo,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                NickUsuario oUsuario = new NickUsuario();
                oUsuario = CUsuario.AchouUsuarioExistente(txtUsuario.Text);
                if(oUsuario.USR_Nick != null)
                {
                    if(txtSenha.Text == CUsuario.AchouUsuario(oUsuario).USR_Senha)
                    {
                        _Usuario = oUsuario.USR_Nick;
                        _Modo = "Online";
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show(Menssagem3, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtSenha.Text = "";
                        txtSenha.Focus();
                    }
                }
                else
                {
                    MessageBox.Show(Menssagem2, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsuario.Text = "";
                    txtUsuario.Focus();
                }
            }
        }
        public static tb_Usuario oUsuario;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCadastrarUsuario frmCadastrarUsuario = new FrmCadastrarUsuario(Idioma);
            this.Visible = false;
            frmCadastrarUsuario.ShowDialog();
            this.Visible = true;

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            if (Idioma)
            {
                rbPortugues.Checked = true;
                Titulo = "Atenção!";
                Menssagem = "Preencha todos os campos!";
                Menssagem2 = "Usuário não encontrado!";
                Menssagem3 = "Senha está errada!";
            }
            else
            {
                rbEnglish.Checked = true;
                Titulo = "Attention!";
                Menssagem = "Fill in all the blanks!";
                Menssagem2 = "User not found!";
                Menssagem3 = "Wrong password!";
            }
        }

        private void rbPortugues_CheckedChanged(object sender, EventArgs e)
        {
            _Idioma = true;
            Titulo = "Atenção!";
            Menssagem = "Preencha todos os campos!";
            Menssagem2 = "Usuário não encontrado!";
            Menssagem3 = "Senha está errada!";
            lkCadastrar.Text = "Cadastre-se";
            lkOffline.Text = "Jogar Offline";
            lkEsqueceuSenha.Text = "Esqueceu a senha?";
            lkMudarSenha.Text = "Mudar a senha?";
            txtUsuario.Focus();
        }

        private void rbEnglish_CheckedChanged(object sender, EventArgs e)
        {
            _Idioma = false;
            Titulo = "Attention!";
            Menssagem = "Fill in all the blanks!";
            Menssagem2 = "User not found!";
            Menssagem3 = "Wrong password!";
            lkCadastrar.Text = "Sign up";
            lkOffline.Text = "Play Offline";
            lkEsqueceuSenha.Text = "Forgot password?";
            lkMudarSenha.Text = "Change password?";
            txtUsuario.Focus();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmEsqueceuSenha frmEsqueceuSenha = new FrmEsqueceuSenha(Idioma);
            this.Visible = false;
            frmEsqueceuSenha.ShowDialog();
            this.Visible = true;
        }

        private void lkMudarSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmMudarSenha frmMudarSenha = new FrmMudarSenha(Idioma);
            this.Visible = false;
            frmMudarSenha.ShowDialog();
            this.Visible = true;
        }

        private void lkOffline_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _Usuario = "Nenhum";
            _Modo = "offline";
            DialogResult = DialogResult.OK;
        }
    }
}

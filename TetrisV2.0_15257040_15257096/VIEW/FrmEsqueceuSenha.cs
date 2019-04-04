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
using System.IO;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;

namespace United_Blocks.VIEW
{
    public partial class FrmEsqueceuSenha : Form
    {
        public FrmEsqueceuSenha(bool Idioma)
        {
            InitializeComponent();
            if (Idioma)
            {
                lbUsuario.Text = "*Usuário";
                btnEnviar.Text = "Enviar";
                Mensagem = "Preencha o campo usuário!";
                Mensagem2 = "Usuário não encontrado!";
                Mensagem3 = "Recuperação de senha.";
                Mensagem4 = "Sua senha é: ";
                Mensagem5 = "Senha enviada para o E-mail do usuário.";
                Titulo = "Atenção!";
            }
            else
            {
                lbUsuario.Text = "*User";
                btnEnviar.Text = "Send";
                Mensagem = "Fill in the user field!";
                Mensagem2 = "User not found!";
                Mensagem3 = "Password Recovery.";
                Mensagem4 = "Your password is: ";
                Mensagem5 = "Password sent to the user's E-mail.";
                Titulo = "Attention!";
            }
        }
        private MailMessage Email;
        Stopwatch sw = new Stopwatch();
        public static string Titulo;
        public static string Mensagem;
        public static string Mensagem2;
        public static string Mensagem3;
        public static string Mensagem4;
        public static string Mensagem5;

        private void FrmEsqueceuSenha_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show(Mensagem, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                NickUsuario oNick = new NickUsuario();
                oNick = CUsuario.AchouUsuarioExistente(txtUsuario.Text);
                if (oNick.USR_Nick != null)
                {
                    tb_Usuario oUsuario = new tb_Usuario();
                    oUsuario = CUsuario.AchouUsuario(oNick);
                    MailMessage Email = new MailMessage();
                    Email.To.Add(new MailAddress(oUsuario.USR_Email));//Destinario
                    Email.From = new MailAddress("tetrisunitedblocks@gmail.com");//local
                    Email.Subject = Mensagem3; //titulo
                    //Email.IsBodyHtml = true;// habilita html
                    Email.Body = Mensagem4 + oUsuario.USR_Senha;//corpo do email
                    SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587);
                    using (cliente)
                    {
                        cliente.UseDefaultCredentials = false;
                        cliente.Credentials = new System.Net.NetworkCredential("tetrisunitedblocks@gmail.com", "Rod123dolfo321tetris");
                        cliente.EnableSsl = true;
                        cliente.Send(Email);
                    }
                    MessageBox.Show(Mensagem5, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(Mensagem2, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsuario.Text = "";
                    txtUsuario.Focus();
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

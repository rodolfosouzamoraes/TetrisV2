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
using System.Net.Mail;

namespace United_Blocks
{
    public partial class FrmFeedback : Form
    {
        public static string Usuario;
        public static string Titulo;
        public static string Menssagem;
        public static string Menssagem2;
        public FrmFeedback(bool idioma)
        {
            InitializeComponent();
            if (idioma)
            {
                lbUser.Text = "*Nome";
                lbTitulo.Text = "*Título";
                lbComment.Text = "*Comentário";
                Titulo = "Atenção";
                Menssagem = "Preencha todos os campos!";
                Menssagem2 = "Muito obrigado pelo comentário, será de grande ajuda no futuro.";
            }
            else
            {
                lbUser.Text = "*Name";
                lbTitulo.Text = "*Title";
                lbComment.Text = "*Feedback";
                Titulo = "Attention";
                Menssagem = "Fill in all the blanks!";
                Menssagem2 = "Thank you very much for the comment, it will be of great help in the future.";
            }
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmFeedback_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text !="" && txtComent.Text != "" && txtTitulo.Text != "")
            {
                //tb_Feedback oTbFeedback = new tb_Feedback();
                //oTbFeedback.FDB_Nickname = txtNome.Text;
                //oTbFeedback.FDB_feedback = txtComent.Text;
                //oTbFeedback.FDB_DateFeedback = System.DateTime.Now;
                //CInserirFeedback.Incluir(oTbFeedback);
                //txtComent.Text = "";

                MailMessage Email = new MailMessage();
                Email.IsBodyHtml = true;
                Email.To.Add(new MailAddress("rod_s23@hotmail.com"));//De onde vem
                Email.From = new MailAddress("tetrisunitedblocks@gmail.com");//para
                Email.Subject = txtTitulo.Text; //titulo
                                           //Email.IsBodyHtml = true;// habilita html
                Email.Body = "<html><body><b>" + txtNome.Text + "</b><br /><br />" + txtComent.Text+"</body></html>";//corpo do email
                SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587);
                using (cliente)
                {
                    cliente.UseDefaultCredentials = false;
                    cliente.Credentials = new System.Net.NetworkCredential("tetrisunitedblocks@gmail.com", "Rod123dolfo321tetris");
                    cliente.EnableSsl = true;
                    cliente.Send(Email);
                }

                MessageBox.Show(Menssagem2, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(Menssagem, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtComent_TextChanged(object sender, EventArgs e)
        {
            lbContagem.Text = Convert.ToString(txtComent.Text.Length);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtComent.Text = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;//Biblioteca para salvar o arquivo

/*
    Marcos 16:16
    "Quem crer e for batizado sera salvo; quem, porem não crer será condenado."   
*/

namespace United_Blocks
{
    public partial class TelaPrincipal : Form
    {
        public static string User;
        public static string Mode;
        static public bool Idioma;
        public TelaPrincipal(bool IdiomaFormAnterior, string Usuario, string Modo)
        {
            InitializeComponent();
            User = Usuario;
            Mode = Modo;
            Idioma = IdiomaFormAnterior;
            //if(Modo == "offline")
            //{
            //    btnFeedback.Enabled = false;
            //}
            MudaIdioma();
        }

        public void MudaIdioma()
        {
            if (Idioma)
            {
                btnNovoJogo.Text = "Novo Jogo";
                btnFeedback.Text = "Comentário";
                btnPlacar.Text = "Placar e Jogadores";
                btnSair.Text = "Sair";
            }
            else
            {
                btnNovoJogo.Text = "New Game";
                btnFeedback.Text = "Feedback";
                btnPlacar.Text = "Scoreboard";
                btnSair.Text = "Exit";
            }
        }
        
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            FrmJogador oFrmJogador = new FrmJogador(Idioma);
            this.Visible = false;
            oFrmJogador.ShowDialog();
            if(oFrmJogador.Valida1 != 0)
            {
                Stream str;
                Random rdn = new Random();
                int NumeroAleatorio = rdn.Next(0, 6);
                switch (NumeroAleatorio)
                {
                    case 0:
                        str = Properties.Resources.Song1;
                        break;
                    case 1:
                        str = Properties.Resources.Song2;
                        break;
                    case 2:
                        str = Properties.Resources.Song3;
                        break;
                    case 3:
                        str = Properties.Resources.Song4;
                        break;
                    case 4:
                        str = Properties.Resources.Song5;
                        break;
                    case 5:
                        str = Properties.Resources.Song6;
                        break;
                    default: str = Properties.Resources.Song1;
                        break; ;
                }

                
                SoundPlayer snd = new SoundPlayer(str);
                snd.PlayLooping();
                FrmPrincipalTetris Tetris = new FrmPrincipalTetris(oFrmJogador.Nome, Idioma, oFrmJogador.Valida1,Mode);
                Tetris.ShowDialog();
                Tetris.Close();
                snd.Stop();
                snd.Dispose();
            }
            this.Visible = true;
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            rbPortugues.Checked = true;
        }

        private void btnIntrucoes_Click(object sender, EventArgs e)
        {
            FrmInstrucoes ofrm = new FrmInstrucoes(Idioma);
            ofrm.ShowDialog();
        }

        private void btnPlacar_Click(object sender, EventArgs e)
        {
            if(Mode == "offline")
            {
                FrmPlacar ofrm = new FrmPlacar(Idioma);
                this.Visible = false;
                ofrm.ShowDialog();
                this.Visible = true;
            }
            //else
            //{
            //    FrmPlacarOnline ofrm = new FrmPlacarOnline();
            //    this.Visible = false;
            //    ofrm.ShowDialog();
            //    this.Visible = true;
            //}
            
        }
        

        private void btnNovoJogo_MouseEnter(object sender, EventArgs e)
        {
            btnNovoJogo.ForeColor = Color.White;
        }

        private void btnNovoJogo_MouseLeave(object sender, EventArgs e)
        {
            btnNovoJogo.ForeColor = Color.Black;
        }

        private void btnIntrucoes_MouseEnter(object sender, EventArgs e)
        {
            btnFeedback.ForeColor = Color.White;
        }

        private void btnIntrucoes_MouseLeave(object sender, EventArgs e)
        {
            btnFeedback.ForeColor = Color.Black;
        }

        private void btnPlacar_MouseEnter(object sender, EventArgs e)
        {
            btnPlacar.ForeColor = Color.White;
        }

        private void btnPlacar_MouseLeave(object sender, EventArgs e)
        {
            btnPlacar.ForeColor = Color.Black;
        }

        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            btnSair.ForeColor = Color.White;
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            btnSair.ForeColor = Color.Black;
        }

        private void btnSobre_MouseEnter(object sender, EventArgs e)
        {
            btnInst.ForeColor = Color.White;
        }

        private void btnSobre_MouseLeave(object sender, EventArgs e)
        {
            btnInst.ForeColor = Color.Black;
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            FrmFeedback ofrmFeedback = new FrmFeedback(Idioma);
            this.Visible = false;
            ofrmFeedback.ShowDialog();
            this.Visible = true;
        }

        private void btnQuemSou_Click(object sender, EventArgs e)
        {
            FrmSobre ofrm = new FrmSobre(Idioma);
            this.Visible = false;
            ofrm.ShowDialog();
            this.Visible = true;
        }

        private void btnInst_Click(object sender, EventArgs e)
        {
            FrmInstrucoes ofrm = new FrmInstrucoes(Idioma);
            ofrm.Show();
        }

        private void rbPortugues_CheckedChanged(object sender, EventArgs e)
        {
            Idioma = true;
            MudaIdioma();
        }

        private void rbEnglish_CheckedChanged(object sender, EventArgs e)
        {
            Idioma = false;
            MudaIdioma();
        }
    }
}

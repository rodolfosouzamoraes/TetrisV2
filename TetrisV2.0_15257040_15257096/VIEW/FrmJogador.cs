using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace United_Blocks
{
    public partial class FrmJogador : Form
    {
        public static string User;
        public static string Mode;
        public static string Titulo;
        static public bool Idiomas;

        private int _Valida1 = 0;
        public int Valida1
        { get { return _Valida1; } }

        private string _Nome;
        public string Nome
        { get { return _Nome; } }

        public FrmJogador()
        {
            InitializeComponent();
        }
        public FrmJogador(bool Idioma)
        {
            InitializeComponent();
            Idiomas = Idioma;
        }
        
        private void FrmJogador_Load(object sender, EventArgs e)
        {
            lbModo.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtBoxNome.Text!="")
            {
                _Valida1 = 1;
                _Nome = txtBoxNome.Text;
                this.Close();
            }
            else
            {
                switch (Idiomas)
                {
                    case true:
                        MessageBox.Show("Preencha o nome corretamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case false:
                        MessageBox.Show("Fill in the name correctly!", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBoxNome.Text != "")
            {
                _Valida1 = 2;
                _Nome = txtBoxNome.Text;
                this.Close();
            }
            else
            {
                switch (Idiomas)
                {
                    case true:
                        MessageBox.Show("Preencha o nome corretamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case false:
                        MessageBox.Show("Fill in the name correctly!", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtBoxNome.Text != "")
            {
                _Valida1 = 4;
                _Nome = txtBoxNome.Text;
                this.Close();
            }
            else
            {
                switch (Idiomas)
                {
                    case true:
                        MessageBox.Show("Preencha o nome corretamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case false:
                        MessageBox.Show("Fill in the name correctly!", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                }
            }
        }

        private void btnFacil_Click(object sender, EventArgs e)
        {
            if (txtBoxNome.Text != "")
            {
                _Valida1 = 5;
                _Nome = txtBoxNome.Text;
                this.Close();
            }
            else
            {
                switch (Idiomas)
                {
                    case true:
                        MessageBox.Show("Preencha o nome corretamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case false:
                        MessageBox.Show("Fill in the name correctly!", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                }
            }
        }

        private void btnDificil_Click(object sender, EventArgs e)
        {
            if (txtBoxNome.Text != "")
            {
                _Valida1 = 3;
                _Nome = txtBoxNome.Text;
                this.Close();
            }
            else
            {
                switch (Idiomas)
                {
                    case true:
                        MessageBox.Show("Preencha o nome corretamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case false:
                        MessageBox.Show("Fill in the name correctly!", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                }
            }
        }

        private void btnSalvar_MouseEnter(object sender, EventArgs e)
        {
            lbModo.Text = "Arcade";
        }

        private void btnSalvar_MouseLeave(object sender, EventArgs e)
        {
            lbModo.Text = "";
        }

        private void btnFacil_MouseEnter(object sender, EventArgs e)
        {
            switch (Idiomas)
            {
                case true:
                    lbModo.Text = "Fácil";
                    break;
                case false:
                    lbModo.Text = "Easy";
                    break;
            }
        }

        private void btnFacil_MouseLeave(object sender, EventArgs e)
        {
            lbModo.Text = "";
        }

        private void btnMedio_MouseEnter(object sender, EventArgs e)
        {
            lbModo.Text = "Normal";
        }

        private void btnMedio_MouseLeave(object sender, EventArgs e)
        {
            lbModo.Text = "";
        }

        private void btnDificil_MouseEnter(object sender, EventArgs e)
        {
            switch (Idiomas)
            {
                case true:
                    lbModo.Text = "Difícil";
                    break;
                case false:
                    lbModo.Text = "Hard";
                    break;
            }
        }

        private void btnDificil_MouseLeave(object sender, EventArgs e)
        {
            lbModo.Text = "";
        }

        private void btnJEDI_MouseEnter(object sender, EventArgs e)
        {
            lbModo.Text = "Jedi";
        }

        private void btnJEDI_MouseLeave(object sender, EventArgs e)
        {
            lbModo.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            switch (Idiomas)
            {
                case true:
                    lbModo.Text = "Sair";
                    break;
                case false:
                    lbModo.Text = "Exit";
                    break;
            }
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            lbModo.Text = "";
        }
    }
}

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
    public partial class FrmSobre : Form
    {
        public FrmSobre()
        {
            InitializeComponent();
        }
        public FrmSobre(bool Idioma)
        {
            InitializeComponent();
            switch(Idioma)
            {
                case true:
                    this.Text = "Sobre";
                    lbDesenvolvido.Text = "Desenvolvido em C#";
                    lbDesenvolvedor.Text = "By Rodolfo Moraes";
                    break;
                case false:
                    this.Text = "About";
                    lbDesenvolvido.Text = "Developed in C#";
                    lbDesenvolvedor.Text = "By Rodolfo Moraes";
                    break;
            }
        }
        private void FrmSobre_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

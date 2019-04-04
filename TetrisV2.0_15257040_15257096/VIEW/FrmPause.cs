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
    public partial class FrmPause : Form
    {
        public FrmPause()
        {
            InitializeComponent();
        }
        public FrmPause(bool Idiomas)
        {
            InitializeComponent();
            switch (Idiomas)
            {
                case true:
                    lbPause.Text = "Jogo Pausado!";
                    btnContinue.Text = "Continue";
                    break;
                case false:
                    lbPause.Text = "Stop!";
                    btnContinue.Text = "Continue";
                    break;
            }
        }
        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPause_Load(object sender, EventArgs e)
        {

        }
    }
}

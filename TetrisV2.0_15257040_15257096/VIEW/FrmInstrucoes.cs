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
    public partial class FrmInstrucoes : Form
    {
        public FrmInstrucoes()
        {
            InitializeComponent();
        }
        public FrmInstrucoes(bool Idioma)
        {
            InitializeComponent();
            switch(Idioma)
            {
                case true:
                    this.Text = "Instruções";
                    lbRotaciona.Text = "Rotaciona";
                    lbAPeca.Text = "a peça";
                    lbMovimentaPara.Text = "Movimenta para";
                    lbADireita.Text = "direita";
                    lbMovimentaParaE.Text = lbMovimentaPara.Text;
                    MovimentaPara.Text = lbMovimentaPara.Text;
                    lbbaixo.Text = "Baixo";
                    lbAEsquerda.Text = "esquerda";
                    break;
                case false:
                    this.Text = "Instructions";
                    lbRotaciona.Text = "   Rotate";
                    lbAPeca.Text = "the block";
                    lbMovimentaPara.Text = "Move block to the right";
                    lbADireita.Text = "";
                    lbMovimentaParaE.Text = "Move block to the left";
                    lbAEsquerda.Text = "";
                    MovimentaPara.Text = "Move block to the down";
                    lbbaixo.Text = "";
                    break;
            }
            
        }
        private void FrmInstrucoes_Load(object sender, EventArgs e)
        {

        }
    }
}

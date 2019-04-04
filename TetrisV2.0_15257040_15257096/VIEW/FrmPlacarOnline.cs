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

namespace United_Blocks
{
    public partial class FrmPlacarOnline : Form
    {
        public FrmPlacarOnline()
        {
            InitializeComponent();
            HabilitaNormal = true;
            HabilitaHard = true;
            HabilitaJedi = true;
            HabilitaArcade = true;
        }
        public static bool HabilitaNormal;
        public static bool HabilitaHard;
        public static bool HabilitaJedi;
        public static bool HabilitaArcade;
        public static List<tb_Score> ListaEasy;
        public static List<tb_Score> ListaNormal;
        public static List<tb_Score> ListaHard;
        public static List<tb_Score> ListaJedi;
        public static List<tb_Score> ListaArcade;
        private void FrmPlacarOnline_Load(object sender, EventArgs e)
        {
            ListaEasy = CInserirScore.AchouLevelEasy("Easy");
            lbPrimeiro.Text = ListaEasy[0].SCR_Nickname;
            lbSegundo.Text = ListaEasy[1].SCR_Nickname;
            lbTerceiro.Text = ListaEasy[2].SCR_Nickname;
            dgvEasy.DataSource = null;
            dgvEasy.DataSource = ListaEasy;
            dgvEasy.Refresh();
        }

        private void tabEasy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabEasy_Selecting(object sender, TabControlCancelEventArgs e)
        {

        }

        private void tabEasy_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:
                    lbPrimeiro.Text = ListaEasy[0].SCR_Nickname;
                    lbSegundo.Text = ListaEasy[1].SCR_Nickname;
                    lbTerceiro.Text = ListaEasy[2].SCR_Nickname;
                    break;
                case 1:
                    if (HabilitaNormal)
                    {
                        ListaNormal = CInserirScore.AchouLevelNormal("Normal");
                        dgvNormal.DataSource = null;
                        dgvNormal.DataSource = ListaNormal;
                        dgvNormal.Refresh();
                        HabilitaNormal = false;
                    }
                    lbPrimeiro.Text = ListaNormal[0].SCR_Nickname;
                    lbSegundo.Text = ListaNormal[1].SCR_Nickname;
                    lbTerceiro.Text = ListaNormal[2].SCR_Nickname;
                    break;
                case 2:
                    if (HabilitaHard)
                    {
                        ListaHard = CInserirScore.AchouLevelHard("Hard");
                        dgvHard.DataSource = null;
                        dgvHard.DataSource = ListaHard;
                        dgvHard.Refresh();
                        HabilitaHard = false;
                    }
                    lbPrimeiro.Text = ListaHard[0].SCR_Nickname;
                    lbSegundo.Text = ListaHard[1].SCR_Nickname;
                    lbTerceiro.Text = ListaHard[2].SCR_Nickname;
                    break;
                case 3:
                    if (HabilitaJedi)
                    {
                        ListaJedi = CInserirScore.AchouLevelJedi("Jedi");
                        dgvJedi.DataSource = null;
                        dgvJedi.DataSource = ListaJedi;
                        dgvJedi.Refresh();
                        HabilitaJedi = false;
                    }
                    lbPrimeiro.Text = ListaJedi[0].SCR_Nickname;
                    lbSegundo.Text = ListaJedi[1].SCR_Nickname;
                    lbTerceiro.Text = ListaJedi[2].SCR_Nickname;
                    break;
                case 4:
                    if (HabilitaArcade)
                    {
                        ListaArcade = CInserirScore.AchouLevelArcade("Arcade");
                        dgvArcade.DataSource = null;
                        dgvArcade.DataSource = ListaArcade;
                        dgvArcade.Refresh();
                        HabilitaArcade = false;
                    }
                    lbPrimeiro.Text = ListaArcade[0].SCR_Nickname;
                    lbSegundo.Text = ListaArcade[1].SCR_Nickname;
                    lbTerceiro.Text = ListaArcade[2].SCR_Nickname;
                    break;
            }
        }
    }
}

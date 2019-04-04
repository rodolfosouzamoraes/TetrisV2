using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;//Biblioteca para salvar o arquivo
using System.IO; //Biblioteca para salvar o arquivo
using United_Blocks.MODEL;
using United_Blocks.CONTROLLER;

namespace United_Blocks
{
    public partial class FrmPrincipalTetris : Form
    {
        List<Jogador> ListaJogador = new List<Jogador>();
        Jogador oNomeJogador = new Jogador();
        static public string NomeJogador;
        public static string Conecta;
        public FrmPrincipalTetris()
        {
            InitializeComponent();
        }
        static public bool Idiomas;
        public FrmPrincipalTetris(string Nome, bool Idioma, int Modo, string Conectado)
        {
            InitializeComponent();
            NomeJogador = Nome;
            ModoJogo = Modo;
            Idiomas = Idioma;
            Conecta = Conectado;
            switch (Idioma)
            {
                case true:
                    //lbPontuacao.Text = "Pontuação";
                    lbLinhas.Text = "Linhas";
                    //btnRecomecar.Text = "Recomeçar";
                    btnPausa.Text = "Pause";
                    btnSair.Text = "Sair";
                    Menssagem = "Verifique sua conexão com a Internet, você está conectado?";
                    Menssagem2 = "O jogo será salvo no computador!";
                    Titulo = "Atenção";
                    break;
                case false:
                    //lbPontuacao.Text = "Score";
                    lbLinhas.Text = "Lines";
                    //btnRecomecar.Text = "Restart";
                    btnPausa.Text = "Pause";
                    btnSair.Text = "Exit";
                    Menssagem = "Check your Internet connection, are you connected?";
                    Menssagem2 = "The game will be saved on your computer!";
                    Titulo = "Attention";
                    break;
            }
            VerificaPastaDoSave();
            BinaryFormatter BF = new BinaryFormatter();
            FileStream _file = File.Open("C:\\United Blocks\\Save\\Save.sub", FileMode.OpenOrCreate); // verifica se o arquivo existe
            if (_file.Length > 0) // verifica se o arquivo não esta vazio
            {
                List<Jogador> _Funcionario = (List<Jogador>)BF.Deserialize(_file); // Vai desconverter o arquivo binario para a lista.
                ListaJogador = _Funcionario;
                _file.Close();
            }
        }
        public static string Menssagem;
        public static string Menssagem2;
        public static string Titulo;
        private void FrmPrincipalTetris_Load(object sender, EventArgs e)
        {
            DataTable DT = new DataTable(); 
            DT.Columns.AddRange(new[]
            {
                new DataColumn("0"), new DataColumn("1"), new DataColumn("2"), new DataColumn("3"), new DataColumn("4"), new DataColumn("5"), new DataColumn("6"), new DataColumn("7"), new DataColumn("8"), new DataColumn("9")
            });
            string[] Espaco = { "", "", "", "", "", "", "", "", "", "" };
            for(int i = 0;i<=27;i++)
            {
                DT.Rows.Add(Espaco);
            }
            ValidaVelocidade = true;
            Velocidade = 250;
            dgvTetris.DataSource = DT; // adiciona a matriz no dataGrid
            IniciaGrid();
            timerPecas.Enabled = true;
            switch(ModoJogo)
            {
                case 1:// Arcade
                    Entrou1000 = false;
                    Entrou2000 = false;
                    Entrou3000 = false;
                    Entrou4000 = false;
                    Entrou5000 = false;
                    Entrou6000 = false;
                    Entrou10000 = false;
                    break;
                case 2: // Jedi
                    Entrou1000 = true;
                    Entrou2000 = true;
                    Entrou3000 = true;
                    Entrou4000 = true;
                    Entrou5000 = true;
                    Entrou6000 = true;
                    Entrou10000 = true;
                    TimerCaindo.Interval = 1;
                    Velocidade = 1;
                    txtBoxPontuacao.ForeColor = Color.White;
                    txtBoxPontuacao.BackColor = Color.Black;
                    break;
                case 3: // Dificil
                    Entrou1000 = true;
                    Entrou2000 = true;
                    Entrou3000 = true;
                    Entrou4000 = true;
                    Entrou5000 = true;
                    Entrou6000 = true;
                    Entrou10000 = true;
                    TimerCaindo.Interval = 100;
                    Velocidade = 100;
                    txtBoxPontuacao.ForeColor = Color.Red;
                    txtBoxPontuacao.BackColor = Color.Black;
                    break;
                case 4: // Medio
                    Entrou1000 = true;
                    Entrou2000 = true;
                    Entrou3000 = true;
                    Entrou4000 = true;
                    Entrou5000 = true;
                    Entrou6000 = true;
                    Entrou10000 = true;
                    TimerCaindo.Interval = 175;
                    Velocidade = 175;
                    txtBoxPontuacao.ForeColor = Color.Yellow;
                    txtBoxPontuacao.BackColor = Color.Black;
                    break;
                case 5: // Facil
                    Entrou1000 = true;
                    Entrou2000 = true;
                    Entrou3000 = true;
                    Entrou4000 = true;
                    Entrou5000 = true;
                    Entrou6000 = true;
                    Entrou10000 = true;
                    TimerCaindo.Interval = 250;
                    Velocidade = 250;
                    txtBoxPontuacao.ForeColor = Color.Green;
                    txtBoxPontuacao.BackColor = Color.Black;
                    break;
            }
            
            //ID_Rotacao = 0;
        }

        private void IniciaGrid()
        {
            pontuacao = 0;
            txtBoxPontuacao.Text = "0";
            txtBoxLinhas.Text = "0";
            ID_Rotacao = 0;
            for (int i = 0; i < 28; i++)// pinta as celulas de preto
            {
                for (int j = 0; j < 10; j++)
                {
                    dgvTetris.Rows[i].Cells[j].Style.BackColor = Color.Black;
                }
            }
        aC =0;
        bL =0;
        bC =0;
        cL =0;
        cC =0;
        dL =0;
        dC =0;
        eL =0;
        eC =0;
        fL =0;
        fC= 0;
        gL =0;
        gC =0;
        hL =0;
        hC =0;
        iL =0;
        iC =0;
        jL =0;
        jC = 0;
    }
        //static public int ContagemCaindo { get; set; } 
        static public int ID_Rotacao { get; set; }
        static public int IDPecaRotacioada { get; set; }

        #region Coordenadas
        static public int aL { get; set; }
        static public int aC { get; set; }
        static public int bL { get; set; }
        static public int bC { get; set; }
        static public int cL { get; set; }
        static public int cC { get; set; }
        static public int dL { get; set; }
        static public int dC { get; set; }
        static public int eL { get; set; }
        static public int eC { get; set; }
        static public int fL { get; set; }
        static public int fC { get; set; }
        static public int gL { get; set; }
        static public int gC { get; set; }
        static public int hL { get; set; }
        static public int hC { get; set; }
        static public int iL { get; set; }
        static public int iC { get; set; }
        static public int jL { get; set; }
        static public int jC { get; set; }
        #endregion

        private void dgvTetris_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        public static int ID { get; set; }
        public static bool Entrou1000;
        public static bool Entrou2000;
        public static bool Entrou3000;
        public static bool Entrou4000;
        public static bool Entrou5000;
        public static bool Entrou6000;
        public static bool Entrou10000;
        public static bool ValidaVelocidade;
        public static int ModoJogo;
        public static int Velocidade;

        private void timerPecas_Tick(object sender, EventArgs e)
        {
            //if (Convert.ToInt32(txtBoxPontuacao.Text) > 500)
            //{
            //    if(Entrou1000 != true)
            //    {
            //        TimerCaindo.Interval = 225;
            //        txtBoxPontuacao.ForeColor = Color.Green;
            //        txtBoxPontuacao.BackColor = Color.Black;
            //        Entrou1000 = true;
            //        Velocidade = 225;
            //    }
            //}
            if (Convert.ToInt32(txtBoxPontuacao.Text) > 1000)
            {
                pbRanking.BackgroundImage = Properties.Resources.rating3;
                if (Entrou2000 != true)
                {
                    TimerCaindo.Interval = 200;
                    txtBoxPontuacao.ForeColor = Color.Green;
                    txtBoxPontuacao.BackColor = Color.Black;
                    Entrou2000 = true;
                    Velocidade = 200;
                }
            }
            if (Convert.ToInt32(txtBoxPontuacao.Text) > 2000)
            {
                pbRanking.BackgroundImage = Properties.Resources.rating2;
                if (Entrou3000 != true)
                {
                    TimerCaindo.Interval = 175;
                    txtBoxPontuacao.ForeColor = Color.Yellow;
                    txtBoxPontuacao.BackColor = Color.Black;
                    Entrou3000 = true;
                    Velocidade = 175;
                }
            }
            if (Convert.ToInt32(txtBoxPontuacao.Text) > 3000)
            {
                pbRanking.BackgroundImage = Properties.Resources.rating1;
                if (Entrou4000 != true)
                {
                    TimerCaindo.Interval = 150;
                    txtBoxPontuacao.ForeColor = Color.Gold;
                    txtBoxPontuacao.BackColor = Color.Black;
                    Entrou4000 = true;
                    Velocidade = 150;
                }
                
            }
            if (Convert.ToInt32(txtBoxPontuacao.Text) > 4000)
            {
                pbRanking.BackgroundImage = Properties.Resources.rating;
                if (Entrou5000 != true)
                {
                    TimerCaindo.Interval = 125;
                    txtBoxPontuacao.ForeColor = Color.Orange;
                    txtBoxPontuacao.BackColor = Color.Black;
                    Entrou5000 = true;
                    Velocidade = 125;
                }
            }
            if (Convert.ToInt32(txtBoxPontuacao.Text) > 5000)
            {
                pbRanking.BackgroundImage = Properties.Resources.rating;
                if (Entrou6000 != true)
                {
                    TimerCaindo.Interval = 100;
                    txtBoxPontuacao.ForeColor = Color.Red;
                    txtBoxPontuacao.BackColor = Color.Black;
                    Entrou6000 = true;
                    Velocidade = 100;
                }
            }
            if (Convert.ToInt32(txtBoxPontuacao.Text) > 10000)
            {
                pbRanking.BackgroundImage = Properties.Resources.trophy;
                if (Entrou10000 != true)
                {
                    TimerCaindo.Interval = 1;
                    txtBoxPontuacao.ForeColor = Color.Black;
                    txtBoxPontuacao.BackColor = Color.Red;
                    Entrou10000 = true;
                    Velocidade = 1;
                }                
            }
            Random rdn = new Random();
            int NumeroAleatorio = rdn.Next(0, 7);
            switch (NumeroAleatorio)
            {
                case 0:
                    ID = 0; //indentifica a peça
                    IDPecaRotacioada = 0;
                    PecaLE(); //preenche no tabuleiro o formato da peça
                    TimerCaindo.Enabled = true; // peça começa a cair
                    timerPecas.Stop();//peças novas não são criadas
                    BloqueiaMovimento = 1;
                    break;
                case 1:
                    ID = 1;
                    IDPecaRotacioada = 1;
                    PecaRaioE();
                    TimerCaindo.Enabled = true;
                    timerPecas.Stop();
                    BloqueiaMovimento = 1;
                    break;
                case 2:
                    ID = 2;
                    IDPecaRotacioada = 2;
                    PecaLD();
                    TimerCaindo.Enabled = true;
                    timerPecas.Stop();
                    BloqueiaMovimento = 1;
                    break;
                case 3:
                    ID = 3;
                    IDPecaRotacioada = 3;
                    PecaI();
                    TimerCaindo.Enabled = true;
                    timerPecas.Stop();
                    BloqueiaMovimento = 1;
                    break;
                case 4:
                    ID = 4;
                    IDPecaRotacioada = 4;
                    PecaCaixa();
                    TimerCaindo.Enabled = true;
                    timerPecas.Stop();
                    BloqueiaMovimento = 1;
                    break;
                case 5:
                    ID = 5;
                    IDPecaRotacioada = 5;
                    PecaT();
                    TimerCaindo.Enabled = true;
                    timerPecas.Stop();
                    BloqueiaMovimento = 1;
                    break;
                case 6:
                    ID = 6;
                    IDPecaRotacioada = 6;
                    PecaRaioD();
                    TimerCaindo.Enabled = true;
                    timerPecas.Stop();
                    BloqueiaMovimento = 1;
                    break;
                case 7:
                    ID = 6;
                    IDPecaRotacioada = 6;
                    PecaRaioD();
                    TimerCaindo.Enabled = true;
                    timerPecas.Stop();
                    BloqueiaMovimento = 1;
                    break;
            }
            
        }

        #region Peças
        private void PecaRaioD()
        {
            dL = 1;
            dC = 5;
            eL = 1;
            eC = 6;
            fL = 2;
            fC = 4;
            gL = 2;
            gC = 5;
            dgvTetris.Rows[1].Cells[5].Style.BackColor = Color.Purple;
            dgvTetris.Rows[1].Cells[6].Style.BackColor = Color.Purple;
            dgvTetris.Rows[2].Cells[4].Style.BackColor = Color.Purple;
            dgvTetris.Rows[2].Cells[5].Style.BackColor = Color.Purple;
        }
        private void PecaT()
        {
            dL = 1;
            dC = 4;
            eL = 1;
            eC = 5;
            fL = 1;
            fC = 6;
            gL = 2;
            gC = 5;
            dgvTetris.Rows[1].Cells[4].Style.BackColor = Color.Orange;
            dgvTetris.Rows[1].Cells[5].Style.BackColor = Color.Orange;
            dgvTetris.Rows[1].Cells[6].Style.BackColor = Color.Orange;
            dgvTetris.Rows[2].Cells[5].Style.BackColor = Color.Orange;
        }
        private void PecaCaixa()
        {
            cL = 1;
            cC = 4;
            dL = 1;
            dC = 5;
            eL = 2;
            eC = 4;
            fL = 2;
            fC = 5;
            dgvTetris.Rows[1].Cells[4].Style.BackColor = Color.Pink;
            dgvTetris.Rows[1].Cells[5].Style.BackColor = Color.Pink;
            dgvTetris.Rows[2].Cells[4].Style.BackColor = Color.Pink;
            dgvTetris.Rows[2].Cells[5].Style.BackColor = Color.Pink;
        }
        private void PecaI()
        {
            bL = 1;
            bC = 5;
            cL = 2;
            cC = 5;
            dL = 3;
            dC = 5;
            eL = 4;
            eC = 5;
            dgvTetris.Rows[1].Cells[5].Style.BackColor = Color.Green;
            dgvTetris.Rows[2].Cells[5].Style.BackColor = Color.Green;
            dgvTetris.Rows[3].Cells[5].Style.BackColor = Color.Green;
            dgvTetris.Rows[4].Cells[5].Style.BackColor = Color.Green;
        }
        private void PecaLD()
        {
            dL = 2;
            dC = 5;
            eL = 3;
            eC = 5;
            fL = 4;
            fC = 5;
            gL = 4;
            gC = 6;
            dgvTetris.Rows[2].Cells[5].Style.BackColor = Color.Blue;
            dgvTetris.Rows[3].Cells[5].Style.BackColor = Color.Blue;
            dgvTetris.Rows[4].Cells[5].Style.BackColor = Color.Blue;
            dgvTetris.Rows[4].Cells[6].Style.BackColor = Color.Blue;
        }
        private void PecaRaioE()
        {
            dL = 1;
            dC = 4;
            eL = 1;
            eC = 5;
            fL = 2;
            fC = 5;
            gL = 2;
            gC = 6;
            dgvTetris.Rows[dL].Cells[dC].Style.BackColor = Color.Red;
            dgvTetris.Rows[eL].Cells[eC].Style.BackColor = Color.Red;
            dgvTetris.Rows[fL].Cells[fC].Style.BackColor = Color.Red;
            dgvTetris.Rows[gL].Cells[gC].Style.BackColor = Color.Red;
        }
        private void PecaLE()
        {
            cL = 2;
            cC = 5;
            dL = 3;
            dC = 5;
            eL = 4;
            eC = 5;
            gL = 4;
            gC = 4;
            dgvTetris.Rows[cL].Cells[cC].Style.BackColor = Color.Yellow;
            dgvTetris.Rows[dL].Cells[dC].Style.BackColor = Color.Yellow;
            dgvTetris.Rows[eL].Cells[eC].Style.BackColor = Color.Yellow;
            dgvTetris.Rows[gL].Cells[gC].Style.BackColor = Color.Yellow;
        }
        #endregion

        static public int BloqueiaMovimento;
        private void FrmPrincipalTetris_KeyDown(object sender, KeyEventArgs e)
        {
           
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if(BloqueiaMovimento ==1)
                    {
                        MovimentoEsquerdo(); //peça move para esquerda
                    }
                    break;
                case Keys.Right:
                    if (BloqueiaMovimento == 1)
                    {
                        MovimentoDireito();
                    }
                    break;
                case Keys.Up:
                    if (BloqueiaMovimento == 1)
                    {
                        MovimentoRotacao();
                    }
                    break;
                case Keys.Down:
                    dgvTetris.Rows[0].Cells[0].Selected = true;
                    if (ValidaVelocidade != false)
                    {
                        Velocidade = TimerCaindo.Interval;
                        TimerCaindo.Interval = 1; ;// Vai descer mais rapido
                        ValidaVelocidade = false;

                    }
                    break;
            }
        }

        #region Movimentos Direito, Esquerdo e Rotação
        private void MovimentoRotacao()
        {
            switch(IDPecaRotacioada)
            {
                case 0:
                    if(gL!=27 && dC!=9 && dC!=0 && dgvTetris.Rows[cL].Cells[cC-1].Style.BackColor == Color.Black && dgvTetris.Rows[cL].Cells[cC + 1].Style.BackColor == Color.Black && dgvTetris.Rows[dL].Cells[dC - 1].Style.BackColor == Color.Black && dgvTetris.Rows[dL].Cells[dC + 1].Style.BackColor == Color.Black) // impede da peça girar caso chegue no limite do layout
                    {
                        ApagaPecaLE();
                        cL = cL + 1;
                        cC = cC + 1;
                        eL = eL - 1;
                        eC = eC - 1;
                        gL = gL - 2;
                        PecaRotacionadaZero(1,10);
                    }
                    break;
                case 10:
                    if(dL!=27 && dC!=9 && dC!=0 && dgvTetris.Rows[cL-1].Cells[cC].Style.BackColor == Color.Black && dgvTetris.Rows[cL+1].Cells[cC].Style.BackColor == Color.Black && dgvTetris.Rows[dL-1].Cells[dC].Style.BackColor == Color.Black && dgvTetris.Rows[dL+1].Cells[dC].Style.BackColor == Color.Black)
                    {
                        ApagaPecaLE();
                        cL = cL + 1;
                        cC = cC - 1;
                        eL = eL - 1;
                        eC = eC + 1;
                        gC = gC + 2;
                        PecaRotacionadaZero(2,100);
                    }
                    break;
                case 100:
                    if(cL!=27 && dC!=8 && dC!=1 && dC!=0 && dgvTetris.Rows[cL].Cells[cC - 1].Style.BackColor == Color.Black && dgvTetris.Rows[cL].Cells[cC + 1].Style.BackColor == Color.Black && dgvTetris.Rows[dL].Cells[dC - 1].Style.BackColor == Color.Black && dgvTetris.Rows[dL].Cells[dC + 1].Style.BackColor == Color.Black)
                    {
                        ApagaPecaLE();
                        cL = cL - 1;
                        cC = cC - 1;
                        eL = eL + 1;
                        eC = eC + 1;
                        gL = gL + 2;
                        PecaRotacionadaZero(3, 1000);
                    }
                    break;
                case 1000:
                    if(gL!=27 && dgvTetris.Rows[cL-1].Cells[cC].Style.BackColor == Color.Black && dgvTetris.Rows[cL+1].Cells[cC].Style.BackColor == Color.Black && dgvTetris.Rows[dL-1].Cells[dC].Style.BackColor == Color.Black && dgvTetris.Rows[dL+1].Cells[dC].Style.BackColor == Color.Black)
                    {
                        ApagaPecaLE();
                        cL = cL - 1;
                        cC = cC + 1;
                        eL = eL + 1;
                        eC = eC - 1;
                        gC = gC - 2;
                        PecaRotacionadaZero(0, 0);
                    }
                    break;
                case 1:
                    if (gL!=27 && dgvTetris.Rows[dL-1].Cells[dC].Style.BackColor == Color.Black && dgvTetris.Rows[dL - 1].Cells[dC + 1].Style.BackColor == Color.Black && dgvTetris.Rows[dL - 1].Cells[dC + 2].Style.BackColor == Color.Black && dgvTetris.Rows[dL].Cells[dC + 2].Style.BackColor == Color.Black && dgvTetris.Rows[dL + 2].Cells[dC + 1].Style.BackColor == Color.Black && dgvTetris.Rows[dL + 2].Cells[dC + 2].Style.BackColor == Color.Black) // impede da peça girar caso chegue no limite do layout
                    {
                        ApagaPecaRaioEsquerdo();
                        dC = dC + 2;
                        eC = eC + 1;
                        eL = eL + 1;
                        gL = gL + 1;
                        gC = gC - 1;
                        PecaRotacionadaUm(1, 11);
                    }
                    break;
                case 11:
                    if(gL!=27 && fC!=9 && fC!=0 && dgvTetris.Rows[dL + 2].Cells[dC].Style.BackColor == Color.Black && dgvTetris.Rows[dL].Cells[dC-1].Style.BackColor == Color.Black && dgvTetris.Rows[dL].Cells[dC-2].Style.BackColor == Color.Black)
                    {
                        ApagaPecaRaioEsquerdo();
                        dC = dC - 2;
                        eC = eC - 1;
                        eL = eL - 1;
                        gL = gL - 1;
                        gC = gC + 1;
                        PecaRotacionadaUm(0, 1);
                    }
                    break;
                case 2:
                    if (gL!=27 && eC != 9 && eC != 0 && dgvTetris.Rows[dL].Cells[dC+1].Style.BackColor == Color.Black && dgvTetris.Rows[dL + 1].Cells[dC+1].Style.BackColor == Color.Black && dgvTetris.Rows[dL + 1].Cells[dC-1].Style.BackColor == Color.Black && dgvTetris.Rows[dL + 2].Cells[dC-1].Style.BackColor == Color.Black) // impede da peça girar caso chegue no limite do layout
                    {
                        ApagaPecaLD();
                        dL = dL + 1;
                        dC = dC + 1;
                        fL = fL - 1;
                        fC = fC - 1;
                        gC = gC - 2;
                        PecaRotacionadaDois(1, 22);
                    }
                    break;
                case 22:
                    if (gL!= 27 && eC != 9 && dgvTetris.Rows[dL + 1].Cells[dC].Style.BackColor == Color.Black && dgvTetris.Rows[dL + 1].Cells[dC-1].Style.BackColor == Color.Black && dgvTetris.Rows[dL - 1].Cells[dC -1].Style.BackColor == Color.Black && dgvTetris.Rows[dL - 2].Cells[dC].Style.BackColor == Color.Black) // impede da peça girar caso chegue no limite do layout
                    {
                        ApagaPecaLD();
                        dL = dL + 1;
                        dC = dC - 1;
                        fL = fL - 1;
                        fC = fC + 1;
                        gL = gL - 2;
                        PecaRotacionadaDois(2, 222);
                    }
                    break;
                case 222:
                    if (dL!=27 && eC != 9 && eC != 0 && dgvTetris.Rows[dL].Cells[dC-1].Style.BackColor == Color.Black && dgvTetris.Rows[dL - 1].Cells[dC-1].Style.BackColor == Color.Black && dgvTetris.Rows[dL - 1].Cells[dC+1].Style.BackColor == Color.Black && dgvTetris.Rows[dL - 2].Cells[dC+1].Style.BackColor == Color.Black) // impede da peça girar caso chegue no limite do layout
                    {
                        ApagaPecaLD();
                        dL = dL - 1;
                        dC = dC - 1;
                        fL = fL + 1;
                        fC = fC + 1;
                        gC = gC + 2;
                        PecaRotacionadaDois(3, 2222);
                    }
                    break;
                case 2222:
                    if (eL!= 27 && eC != 9 && dgvTetris.Rows[dL - 1].Cells[dC].Style.BackColor == Color.Black && dgvTetris.Rows[dL - 1].Cells[dC+1].Style.BackColor == Color.Black && dgvTetris.Rows[dL + 1].Cells[dC+1].Style.BackColor == Color.Black && dgvTetris.Rows[dL + 1].Cells[dC+2].Style.BackColor == Color.Black) // impede da peça girar caso chegue no limite do layout
                    {
                        ApagaPecaLD();
                        dL = dL - 1;
                        dC = dC + 1;
                        fL = fL + 1;
                        fC = fC - 1;
                        gL = gL + 2;
                        PecaRotacionadaDois(0, 2);
                    }
                    break;
                case 3:
                    if (eL!=27 && cC != 9 && cC != 8 && cC !=0 && cC!= 1 && dgvTetris.Rows[bL].Cells[bC+1].Style.BackColor == Color.Black && dgvTetris.Rows[bL].Cells[bC + 2].Style.BackColor == Color.Black && dgvTetris.Rows[bL +1].Cells[bC + 1].Style.BackColor == Color.Black && dgvTetris.Rows[bL+1].Cells[bC + 2].Style.BackColor == Color.Black && dgvTetris.Rows[bL+2].Cells[bC - 1].Style.BackColor == Color.Black && dgvTetris.Rows[bL+2].Cells[bC -2].Style.BackColor == Color.Black && dgvTetris.Rows[bL+3].Cells[bC - 1].Style.BackColor == Color.Black && dgvTetris.Rows[bL+3].Cells[bC -2].Style.BackColor == Color.Black) // impede da peça girar caso chegue no limite do layout
                    {
                        ApagaPecaI();
                        bL = bL + 1;
                        bC = bC + 2;
                        cC = cC + 1;
                        dL = dL - 1;
                        eL = eL - 2;
                        eC = eC - 1;
                        PecaRotacionadaTres(1, 33);
                    }
                    break;
                case 33:
                    if (bL!=26 && bL!=27 && dgvTetris.Rows[bL-1].Cells[bC].Style.BackColor == Color.Black && dgvTetris.Rows[bL-2].Cells[bC].Style.BackColor == Color.Black && dgvTetris.Rows[bL-1].Cells[bC - 1].Style.BackColor == Color.Black && dgvTetris.Rows[bL-2].Cells[bC - 1].Style.BackColor == Color.Black && dgvTetris.Rows[bL-1].Cells[bC -2].Style.BackColor == Color.Black && dgvTetris.Rows[bL-2].Cells[bC -2].Style.BackColor == Color.Black && dgvTetris.Rows[bL+1].Cells[bC -2].Style.BackColor == Color.Black && dgvTetris.Rows[bL+2].Cells[bC -2].Style.BackColor == Color.Black && dgvTetris.Rows[bL+1].Cells[bC -3].Style.BackColor == Color.Black && dgvTetris.Rows[bL+2].Cells[bC - 3].Style.BackColor == Color.Black)
                    {
                        ApagaPecaI();
                        bL = bL - 1;
                        bC = bC - 2;
                        cC = cC - 1;
                        dL = dL + 1;
                        eL = eL + 2;
                        eC = eC + 1;
                        PecaRotacionadaTres(0, 3);
                    }
                    break;
                case 5:// T
                    if (gL!=27 && dgvTetris.Rows[dL+1].Cells[dC].Style.BackColor == Color.Black && dgvTetris.Rows[dL-1].Cells[dC].Style.BackColor == Color.Black && dgvTetris.Rows[dL-1].Cells[dC+1].Style.BackColor == Color.Black && dgvTetris.Rows[dL+1].Cells[dC+2].Style.BackColor == Color.Black) // impede da peça girar caso chegue no limite do layout
                    {
                        ApagaPecaT();
                        dL = dL -1;
                        dC = dC +1;
                        fL = fL +1;
                        fC = fC -1;
                        gL = gL -1;
                        gC = gC -1;
                        PecaRotacionadaCinco(1, 55);
                    }
                    break;
                case 55:
                    if (fL!=27 && eC!=9 && dgvTetris.Rows[dL].Cells[dC-1].Style.BackColor == Color.Black && dgvTetris.Rows[dL].Cells[dC+1].Style.BackColor == Color.Black && dgvTetris.Rows[dL+1].Cells[dC+1].Style.BackColor == Color.Black && dgvTetris.Rows[dL+2].Cells[dC-1].Style.BackColor == Color.Black)
                    {
                        ApagaPecaT();
                        dL = dL + 1;
                        dC = dC + 1;
                        fL = fL - 1;
                        fC = fC - 1;
                        gL = gL - 1;
                        gC = gC + 1;
                        PecaRotacionadaCinco(2, 555);
                    }
                    break;
                case 555:
                    if (eL!=26 && eL!=27 && dgvTetris.Rows[dL-1].Cells[dC].Style.BackColor == Color.Black && dgvTetris.Rows[dL+1].Cells[dC].Style.BackColor == Color.Black && dgvTetris.Rows[dL+1].Cells[dC-1].Style.BackColor == Color.Black && dgvTetris.Rows[dL-1].Cells[dC-2].Style.BackColor == Color.Black)
                    {
                        ApagaPecaT();
                        dL = dL + 1;
                        dC = dC - 1;
                        fL = fL - 1;
                        fC = fC + 1;
                        gL = gL + 1;
                        gC = gC + 1;
                        PecaRotacionadaCinco(3, 5555);
                    }
                    break;
                case 5555:
                    if(dL!=27 && eC!=0 && dgvTetris.Rows[dL].Cells[dC+1].Style.BackColor == Color.Black && dgvTetris.Rows[dL].Cells[dC-1].Style.BackColor == Color.Black && dgvTetris.Rows[dL-1].Cells[dC-1].Style.BackColor == Color.Black && dgvTetris.Rows[dL-2].Cells[dC+1].Style.BackColor == Color.Black)
                    {
                        ApagaPecaT();
                        dL = dL - 1;
                        dC = dC - 1;
                        fL = fL + 1;
                        fC = fC + 1;
                        gL = gL + 1;
                        gC = gC - 1;
                        PecaRotacionadaCinco(0, 5);
                    }
                    break;
                case 6:
                    if (gL!=27 && dgvTetris.Rows[dL-1].Cells[dC+1].Style.BackColor == Color.Black && dgvTetris.Rows[dL-1].Cells[dC].Style.BackColor == Color.Black && dgvTetris.Rows[dL-1].Cells[dC-1].Style.BackColor == Color.Black && dgvTetris.Rows[dL].Cells[dC-1].Style.BackColor == Color.Black && dgvTetris.Rows[dL-2].Cells[dC].Style.BackColor == Color.Black && dgvTetris.Rows[dL-2].Cells[dC-1].Style.BackColor == Color.Black) // impede da peça girar caso chegue no limite do layout
                    {
                        ApagaPecaRaioDireito();
                        eC = eC - 2;
                        dC = dC - 1;
                        dL = dL + 1;
                        fC = fC + 1;
                        fL = fL + 1;
                        PecaRotacionadaSeis(1, 66);
                    }
                    break;
                case 66:
                    if (fL!= 27 && gC != 9 && dgvTetris.Rows[dL-1].Cells[dC+1].Style.BackColor == Color.Black && dgvTetris.Rows[dL-1].Cells[dC+2].Style.BackColor == Color.Black && dgvTetris.Rows[dL+1].Cells[dC].Style.BackColor == Color.Black)
                    {
                        ApagaPecaRaioDireito();
                        eC = eC + 2;
                        dC = dC + 1;
                        dL = dL - 1;
                        fC = fC - 1;
                        fL = fL - 1;
                        PecaRotacionadaSeis(0, 6);
                    }
                    break;
            }
        }

        #region Funções Movimento Rotação
        private void PecaRotacionadaSeis(int v1, int v2)
        {
            PecaRaioDPlano();
            ID_Rotacao = v1;
            IDPecaRotacioada = v2;
        }

        private void PecaRotacionadaCinco(int v1, int v2)
        {
            PecaTPlano();
            ID_Rotacao = v1;
            IDPecaRotacioada = v2;
        }

        private void PecaRotacionadaTres(int v1, int v2)
        {
            PecaIPlano();
            ID_Rotacao = v1;
            IDPecaRotacioada = v2;
        }

        private void PecaRotacionadaDois(int v1, int v2)
        {
            PecaLDPlano();
            ID_Rotacao = v1;
            IDPecaRotacioada = v2;
        }

        private void PecaRotacionadaUm(int v1, int v2)
        {
            PecaRaioEPlano();
            ID_Rotacao = v1;
            IDPecaRotacioada = v2;
        }

        private void PecaRotacionadaZero(int v1, int v2)
        {
            PecaLEPlano();
            ID_Rotacao = v1;
            IDPecaRotacioada = v2;
        }
        #endregion

        private void MovimentoDireito()
        {
            int h, i, j, l;
            switch(ID) // identifica qual peça está para se movimentar
            {
                case 0: // LE
                    switch (IDPecaRotacioada) // verifica se é possivel movimentar para a esquerda
                    {
                        case 0:
                            j = cC;
                            j++;
                            h = dC;
                            h++;
                            l = eC;
                            l++;
                            if(j!=10 && h!=10 && l!=10) // verifica se ja chegou na ultima coluna
                            {
                                if (dgvTetris.Rows[cL].Cells[j].Style.BackColor == Color.Black && dgvTetris.Rows[dL].Cells[h].Style.BackColor == Color.Black && dgvTetris.Rows[eL].Cells[l].Style.BackColor == Color.Black) // Verifica se a coluna da direita é livre
                                {
                                    ApagaPecaLE();
                                    if (dC != 9)
                                    {
                                        MovimentoDireitoPecaZero();
                                    }
                                    PecaLEPlano();
                                }
                            }
                            break;
                        case 10:
                            i = cC;
                            i++;
                            j = gC;
                            j++;
                            if(i!=10)
                            {
                                if(dgvTetris.Rows[cL].Cells[i].Style.BackColor == Color.Black && dgvTetris.Rows[gL].Cells[j].Style.BackColor == Color.Black)
                                {
                                    ApagaPecaLE();
                                    if (dC != 8)
                                    {
                                        MovimentoDireitoPecaZero();
                                    }
                                    PecaLEPlano();
                                }
                            }
                            break;
                        case 100:
                            j = cC;
                            j++;
                            h = dC;
                            h++;
                            l = gC;
                            l++;
                            if(l!=10)
                            {
                                if(dgvTetris.Rows[cL].Cells[j].Style.BackColor == Color.Black && dgvTetris.Rows[dL].Cells[h].Style.BackColor == Color.Black && dgvTetris.Rows[gL].Cells[l].Style.BackColor == Color.Black)
                                {
                                    FuncaoPecaZeroMovimentoDireito();
                                }
                            }
                            break;
                        case 1000:
                            i = eC;
                            i++;
                            j = gC;
                            j++;
                            if(i!=10)
                            {
                                if (dgvTetris.Rows[eL].Cells[i].Style.BackColor == Color.Black && dgvTetris.Rows[gL].Cells[j].Style.BackColor == Color.Black)
                                {
                                    FuncaoPecaZeroMovimentoDireito();
                                }
                            }
                            break;

                    }
                    break;
                case 1: //RE
                    switch (IDPecaRotacioada)
                    {
                        case 1:
                            i = eC;
                            i++;
                            j = gC;
                            j++;
                            if (j != 10)
                            {
                                if (dgvTetris.Rows[eL].Cells[i].Style.BackColor == Color.Black && dgvTetris.Rows[gL].Cells[j].Style.BackColor == Color.Black) // Verifica se a coluna da direita é livre
                                {
                                    FuncaoPecaUmMovimentoDireito();
                                }
                            }
                            break;
                        case 11:
                            i = dC;
                            i++;
                            j = eC;
                            j++;
                            h = gC;
                            h++;
                            if (j != 10)
                            {
                                if (dgvTetris.Rows[dL].Cells[i].Style.BackColor == Color.Black && dgvTetris.Rows[eL].Cells[j].Style.BackColor == Color.Black && dgvTetris.Rows[gL].Cells[h].Style.BackColor == Color.Black) // Verifica se a coluna da direita é livre
                                {
                                    FuncaoPecaUmMovimentoDireito();
                                }
                            }
                            break;
                    }
                    break;
                case 2://LD
                    switch (IDPecaRotacioada)
                    {
                        case 2:
                            j = dC;
                            j++;
                            h = eC;
                            h++;
                            l = gC;
                            l++;
                            if (j != 9 && h != 9 && l != 10)
                            {
                                if (dgvTetris.Rows[dL].Cells[j].Style.BackColor == Color.Black && dgvTetris.Rows[eL].Cells[h].Style.BackColor == Color.Black && dgvTetris.Rows[gL].Cells[l].Style.BackColor == Color.Black) // Verifica se a coluna da direita é livre
                                {
                                    FuncaoPecaDoisMovimentoDireito(8);
                                }
                            }
                            break;
                        case 22:
                            i = dC;
                            i++;
                            j = gC;
                            j++;
                            if (i != 10)
                            {
                                if (dgvTetris.Rows[dL].Cells[i].Style.BackColor == Color.Black && dgvTetris.Rows[gL].Cells[j].Style.BackColor == Color.Black)
                                {
                                    FuncaoPecaDoisMovimentoDireito(8);
                                }
                            }
                            break;
                        case 222:
                            j = dC;
                            j++;
                            h = eC;
                            h++;
                            l = fC;
                            l++;
                            if (l != 10)
                            {
                                if (dgvTetris.Rows[dL].Cells[j].Style.BackColor == Color.Black && dgvTetris.Rows[eL].Cells[h].Style.BackColor == Color.Black && dgvTetris.Rows[fL].Cells[l].Style.BackColor == Color.Black)
                                {
                                    FuncaoPecaDoisMovimentoDireito(9);
                                }
                            }
                            break;
                        case 2222:
                            i = gC;
                            i++;
                            j = fC;
                            j++;
                            if (i != 10)
                            {
                                if (dgvTetris.Rows[gL].Cells[i].Style.BackColor == Color.Black && dgvTetris.Rows[fL].Cells[j].Style.BackColor == Color.Black)
                                {
                                    FuncaoPecaDoisMovimentoDireito(8);
                                }
                            }
                            break;
                    }
                    break;
                case 3: //I
                    switch (IDPecaRotacioada)
                    {
                        case 3:
                            i = bC;
                            i++;
                            j = cC;
                            j++;
                            h = dC;
                            h++;
                            l = eC;
                            l++;
                            if (j != 10)
                            {
                                if (dgvTetris.Rows[bL].Cells[i].Style.BackColor == Color.Black && dgvTetris.Rows[cL].Cells[j].Style.BackColor == Color.Black && dgvTetris.Rows[dL].Cells[h].Style.BackColor == Color.Black && dgvTetris.Rows[eL].Cells[l].Style.BackColor == Color.Black) // Verifica se a coluna da direita é livre
                                {
                                    FuncaoPecaTresMovimentoDireito();
                                }
                            }
                            break;
                        case 33:
                            i = bC;
                            i++;
                            if (i != 10)
                            {
                                if (dgvTetris.Rows[bL].Cells[i].Style.BackColor == Color.Black)
                                {
                                    FuncaoPecaTresMovimentoDireito();
                                }
                            }
                            break;
                    }
                    break;
                case 4: // Caixa
                    i = dC;
                    i++;
                    j = fC;
                    j++;
                    if (i != 10)
                    {
                        if (dgvTetris.Rows[dL].Cells[i].Style.BackColor == Color.Black && dgvTetris.Rows[fL].Cells[j].Style.BackColor == Color.Black)
                        {
                            ApagaPecaCaixa();
                            if (dC != 9)
                            {
                                cC++;
                                dC++;
                                eC++;
                                fC++;
                            }
                            PecaCaixaPlano();
                        }
                    }
                    break;
                case 5: // LE
                    switch (IDPecaRotacioada)
                    {
                        case 5:
                            i = fC;
                            i++;
                            j = gC;
                            j++;
                            if (i != 10 && j != 9)
                            {
                                if (dgvTetris.Rows[fL].Cells[i].Style.BackColor == Color.Black && dgvTetris.Rows[gL].Cells[j].Style.BackColor == Color.Black) // Verifica se a coluna da direita é livre
                                {
                                    FuncaoPecaCincoMovimentoDireito(8);
                                }
                            }
                            break;
                        case 55:
                            i = dC;
                            i++;
                            j = eC;
                            j++;
                            h = fC;
                            h++; 
                            if (j != 10)
                            {
                                if (dgvTetris.Rows[dL].Cells[i].Style.BackColor == Color.Black && dgvTetris.Rows[eL].Cells[j].Style.BackColor == Color.Black && dgvTetris.Rows[fL].Cells[h].Style.BackColor == Color.Black)
                                {
                                    FuncaoPecaCincoMovimentoDireito(9);
                                }
                            }
                            break;
                        case 555:
                            i = gC;
                            i++;
                            j = dC;
                            j++;
                            if (j != 10)
                            {
                                if (dgvTetris.Rows[gL].Cells[i].Style.BackColor == Color.Black && dgvTetris.Rows[dL].Cells[j].Style.BackColor == Color.Black)
                                {
                                    FuncaoPecaCincoMovimentoDireito(8);
                                }
                            }
                            break;
                        case 5555:
                            i = fC;
                            i++;
                            j = gC;
                            j++;
                            h = dC;
                            h++;
                            if (j != 10)
                            {
                                if (dgvTetris.Rows[fL].Cells[i].Style.BackColor == Color.Black && dgvTetris.Rows[gL].Cells[j].Style.BackColor == Color.Black && dgvTetris.Rows[dL].Cells[h].Style.BackColor == Color.Black)
                                {
                                    FuncaoPecaCincoMovimentoDireito(8);
                                }
                            }
                            break;
                    }
                    break;
                case 6:
                    switch (IDPecaRotacioada)
                    {
                        case 6:
                            i = eC;
                            i++;
                            j = gC;
                            j++;
                            if (i != 10)
                            {
                                if (dgvTetris.Rows[eL].Cells[i].Style.BackColor == Color.Black && dgvTetris.Rows[gL].Cells[j].Style.BackColor == Color.Black) // Verifica se a coluna da direita é livre
                                {
                                    FuncaoPecaSeisMovimentoDireito();
                                }
                            }
                            break;
                        case 66:
                            i = eC;
                            i++;
                            j = gC;
                            j++;
                            h = fC;
                            h++;
                            if (j != 10)
                            {
                                if (dgvTetris.Rows[eL].Cells[i].Style.BackColor == Color.Black && dgvTetris.Rows[gL].Cells[j].Style.BackColor == Color.Black && dgvTetris.Rows[fL].Cells[h].Style.BackColor == Color.Black) // Verifica se a coluna da direita é livre
                                {
                                    FuncaoPecaSeisMovimentoDireito();
                                }
                            }
                            break;
                    }
                  break;
            }
        }

        #region Funções Movimento Direito
        private void FuncaoPecaSeisMovimentoDireito()
        {
            ApagaPecaRaioDireito();
            if (eC != 9)
            {
                MovimentoDiretoPecaUmDoisCincoSeis();
            }
            PecaRaioDPlano();
        }
        private void FuncaoPecaCincoMovimentoDireito(int v)
        {
            ApagaPecaT();
            if (eC != v)
            {
                MovimentoDiretoPecaUmDoisCincoSeis();
            }
            PecaTPlano();
        }
        private void FuncaoPecaTresMovimentoDireito()
        {
            ApagaPecaI();
            if (cC != 9)
            {
                MovimentoDireitoPecaTres();
            }
            PecaIPlano();
        }
        private void FuncaoPecaDoisMovimentoDireito(int v)
        {
            ApagaPecaLD();
            if (eC != v)
            {
                MovimentoDiretoPecaUmDoisCincoSeis();
            }
            PecaLDPlano();
        }
        private void FuncaoPecaUmMovimentoDireito()
        {
            ApagaPecaRaioEsquerdo();
            if (fC != 9)
            {
                MovimentoDiretoPecaUmDoisCincoSeis();
            }
            PecaRaioEPlano();
        }
        private void FuncaoPecaZeroMovimentoDireito()
        {
            ApagaPecaLE();
            if (dC != 8)
            {
                MovimentoDireitoPecaZero();
            }
            PecaLEPlano();
        }
        private void MovimentoDireitoPecaTres()
        {
            bC++;
            cC++;
            dC++;
            eC++;
        }
        private void MovimentoDiretoPecaUmDoisCincoSeis()
        {
            dC++;
            eC++;
            fC++;
            gC++;
        }
        private void MovimentoDireitoPecaZero()
        {
            cC++;
            dC++;
            eC++;
            gC++;
        }
        #endregion

        private void MovimentoEsquerdo()
        {
            int h, i, j, l;
            switch (ID)
            {
                case 0://LE
                    switch (IDPecaRotacioada)
                    {
                        case 0:
                            j = cC;
                            j--;
                            h = dC;
                            h--;
                            l = gC;
                            l--;
                            if (l != -1)
                            {
                                if (dgvTetris.Rows[cL].Cells[j].Style.BackColor == Color.Black && dgvTetris.Rows[dL].Cells[h].Style.BackColor == Color.Black && dgvTetris.Rows[gL].Cells[l].Style.BackColor == Color.Black) // Verifica se a coluna da esquerda é livre
                                {
                                    FuncaoPecaZeroMovimentoEsquerdo(1);
                                }
                            }
                            break;
                        case 10:
                            i = eC;
                            i--;
                            j = gC;
                            j--;
                            if (i != -1)
                            {
                                if (dgvTetris.Rows[eL].Cells[i].Style.BackColor == Color.Black && dgvTetris.Rows[gL].Cells[j].Style.BackColor == Color.Black)
                                {
                                    FuncaoPecaZeroMovimentoEsquerdo(1);
                                }
                            }
                            break;
                        case 100:
                            j = cC;
                            j--;
                            h = dC;
                            h--;
                            l = eC;
                            l--;
                            if (l != -1)
                            {
                                if (dgvTetris.Rows[cL].Cells[j].Style.BackColor == Color.Black && dgvTetris.Rows[dL].Cells[h].Style.BackColor == Color.Black && dgvTetris.Rows[eL].Cells[l].Style.BackColor == Color.Black)
                                {
                                    FuncaoPecaZeroMovimentoEsquerdo(0);
                                }
                            }
                            break;
                        case 1000:
                            i = cC;
                            i--;
                            j = gC;
                            j--;
                            if(i!=-1)
                            {
                                if (dgvTetris.Rows[cL].Cells[i].Style.BackColor == Color.Black && dgvTetris.Rows[gL].Cells[j].Style.BackColor == Color.Black)
                                {
                                    FuncaoPecaZeroMovimentoEsquerdo(1);
                                }
                            }
                            break;
                    }
                    break;
                case 1://RE
                    switch (IDPecaRotacioada)
                    {
                        case 1:
                            i = dC;
                            i--;
                            j = fC;
                            j--;
                            if (j != 0)
                            {
                                if (dgvTetris.Rows[eL].Cells[i].Style.BackColor == Color.Black && dgvTetris.Rows[gL].Cells[j].Style.BackColor == Color.Black) // Verifica se a coluna da direita é livre
                                {
                                    FuncaoPecaUmMovimentoEsquerdo();
                                }
                            }
                            break;
                        case 11:
                            i = dC;
                            i--;
                            j = fC;
                            j--;
                            h = gC;
                            h--;
                            if (j != -1)
                            {
                                if (dgvTetris.Rows[dL].Cells[i].Style.BackColor == Color.Black && dgvTetris.Rows[eL].Cells[j].Style.BackColor == Color.Black && dgvTetris.Rows[gL].Cells[h].Style.BackColor == Color.Black) // Verifica se a coluna da direita é livre
                                {
                                    FuncaoPecaUmMovimentoEsquerdo();
                                }
                            }
                            break;
                    }
                    break;
                case 2://LD
                    switch (IDPecaRotacioada)
                    {
                        case 2:
                            j = dC;
                            j--;
                            h = eC;
                            h--;
                            l = fC;
                            l--;
                            if (j != -1 && h != -1 && l != -1)
                            {
                                if (dgvTetris.Rows[dL].Cells[j].Style.BackColor == Color.Black && dgvTetris.Rows[eL].Cells[h].Style.BackColor == Color.Black && dgvTetris.Rows[fL].Cells[l].Style.BackColor == Color.Black) // Verifica se a coluna da direita é livre
                                {
                                    FuncaoPecaDoisMovimentoEsquerdo(-1);
                                }
                            }
                            break;
                        case 22:
                            i = fC;
                            i--;
                            j = gC;
                            j--;
                            if (i != -1)
                            {
                                if (dgvTetris.Rows[fL].Cells[i].Style.BackColor == Color.Black && dgvTetris.Rows[gL].Cells[j].Style.BackColor == Color.Black)
                                {
                                    FuncaoPecaDoisMovimentoEsquerdo(0);
                                }
                            }
                            break;
                        case 222:
                            l = gC;
                            l--;
                            j = eC;
                            j--;
                            h = dC;
                            h--;
                            if (j != 0)
                            {
                                if (dgvTetris.Rows[eL].Cells[j].Style.BackColor == Color.Black && dgvTetris.Rows[dL].Cells[h].Style.BackColor == Color.Black && dgvTetris.Rows[gL].Cells[l].Style.BackColor == Color.Black)
                                {
                                    FuncaoPecaDoisMovimentoEsquerdo(0);
                                }
                            }
                            break;
                        case 2222:
                            i = gC;
                            i--;
                            j = dC;
                            j--;
                            if (j != -1)
                            {
                                if (dgvTetris.Rows[gL].Cells[i].Style.BackColor == Color.Black && dgvTetris.Rows[dL].Cells[j].Style.BackColor == Color.Black)
                                {
                                    FuncaoPecaDoisMovimentoEsquerdo(1);
                                }
                            }
                            break;
                    }
                    break;
                case 3: //I
                    switch (IDPecaRotacioada)
                    {
                        case 3:
                            i = bC;
                            i--;
                            j = cC;
                            j--;
                            h = dC;
                            h--;
                            l = eC;
                            l--;
                            if (j != -1)
                            {
                                if (dgvTetris.Rows[bL].Cells[i].Style.BackColor == Color.Black && dgvTetris.Rows[cL].Cells[j].Style.BackColor == Color.Black && dgvTetris.Rows[dL].Cells[h].Style.BackColor == Color.Black && dgvTetris.Rows[eL].Cells[l].Style.BackColor == Color.Black) // Verifica se a coluna da direita é livre
                                {
                                    ApagaPecaI();
                                    if (cC != 0)
                                    {
                                        MovimentoEsquerdoPecaTres();
                                    }
                                    PecaIPlano();
                                }
                            }
                            break;
                        case 33:
                            i = eC;
                            i--;
                            if (i != -1)
                            {
                                if (dgvTetris.Rows[eL].Cells[i].Style.BackColor == Color.Black)
                                {
                                    ApagaPecaI();
                                    if (eC != 0)
                                    {
                                        MovimentoEsquerdoPecaTres();
                                    }
                                    PecaIPlano();
                                }
                            }
                            break;
                    }
                    break;
                case 4: // Caixa
                    i = cC;
                    i--;
                    j = eC;
                    j--;
                    if (i != -1)
                    {
                        if (dgvTetris.Rows[cL].Cells[i].Style.BackColor == Color.Black && dgvTetris.Rows[eL].Cells[j].Style.BackColor == Color.Black)
                        {
                            ApagaPecaCaixa();
                            if (dC != 0)
                            {
                                cC--;
                                dC--;
                                eC--;
                                fC--;
                            }
                            PecaCaixaPlano();
                        }
                    }
                    break;
                case 5: // LE
                    switch (IDPecaRotacioada)
                    {
                        case 5:
                            i = dC;
                            i--;
                            j = gC;
                            j--;
                            if (i != -1)
                            {
                                if (dgvTetris.Rows[dL].Cells[i].Style.BackColor == Color.Black && dgvTetris.Rows[gL].Cells[j].Style.BackColor == Color.Black) // Verifica se a coluna da direita é livre
                                {
                                    FuncaoPecaCincoMovimentoEsquerdo(1);
                                }
                            }
                            break;
                        case 55:
                            i = dC;
                            i--;
                            j = gC;
                            j--;
                            h = fC;
                            h--;
                            if (j != -1)
                            {
                                if (dgvTetris.Rows[dL].Cells[i].Style.BackColor == Color.Black && dgvTetris.Rows[gL].Cells[j].Style.BackColor == Color.Black && dgvTetris.Rows[fL].Cells[h].Style.BackColor == Color.Black)
                                {
                                    FuncaoPecaCincoMovimentoEsquerdo(1);
                                }
                            }
                            break;
                        case 555:
                            i = fC;
                            i--;
                            j = gC;
                            j--;
                            if (i != -1)
                            {
                                if (dgvTetris.Rows[fL].Cells[i].Style.BackColor == Color.Black && dgvTetris.Rows[gL].Cells[j].Style.BackColor == Color.Black)
                                {
                                    FuncaoPecaCincoMovimentoEsquerdo(1);
                                }
                            }
                            break;
                        case 5555:
                            i = fC;
                            i--;
                            j = eC;
                            j--;
                            h = dC;
                            h--;
                            if (i != -1)
                            {
                                if (dgvTetris.Rows[fL].Cells[i].Style.BackColor == Color.Black && dgvTetris.Rows[eL].Cells[j].Style.BackColor == Color.Black && dgvTetris.Rows[dL].Cells[h].Style.BackColor == Color.Black)
                                {
                                    FuncaoPecaCincoMovimentoEsquerdo(0);
                                }
                            }
                            break;
                    }
                    break;
                case 6:
                    switch (IDPecaRotacioada)
                    {
                        case 6:
                            i = dC;
                            i--;
                            j = fC;
                            j--;
                            if (j != -1)
                            {
                                if (dgvTetris.Rows[dL].Cells[i].Style.BackColor == Color.Black && dgvTetris.Rows[fL].Cells[j].Style.BackColor == Color.Black) // Verifica se a coluna da direita é livre
                                {
                                    ApagaPecaRaioDireito();
                                    if (fC != 0)
                                    {
                                        MovimentoEsquerdoPecaUmDoisCincoSeis();
                                    }
                                    PecaRaioDPlano();
                                }
                            }
                            break;
                        case 66:
                            i = eC;
                            i--;
                            j = dC;
                            j--;
                            h = fC;
                            h--;
                            if (j != -1)
                            {
                                if (dgvTetris.Rows[eL].Cells[i].Style.BackColor == Color.Black && dgvTetris.Rows[dL].Cells[j].Style.BackColor == Color.Black && dgvTetris.Rows[fL].Cells[h].Style.BackColor == Color.Black) // Verifica se a coluna da direita é livre
                                {
                                    ApagaPecaRaioDireito();
                                    if (dC != 0)
                                    {
                                        MovimentoEsquerdoPecaUmDoisCincoSeis();
                                    }
                                    PecaRaioDPlano();
                                }
                            }
                            break;
                    }
                    break;
            }
        }

        #region Funções Movimento Esquerdo
        private void FuncaoPecaCincoMovimentoEsquerdo(int v)
        {
            ApagaPecaT();
            if (eC != v)
            {
                MovimentoEsquerdoPecaUmDoisCincoSeis();
            }
            PecaTPlano();
        }
        private void FuncaoPecaDoisMovimentoEsquerdo(int v)
        {
            ApagaPecaLD();
            if (eC != v)
            {
                MovimentoEsquerdoPecaUmDoisCincoSeis();
            }
            PecaLDPlano();
        }
        private void FuncaoPecaUmMovimentoEsquerdo()
        {
            ApagaPecaRaioEsquerdo();
            if (fC != 0)
            {
                MovimentoEsquerdoPecaUmDoisCincoSeis();
            }
            PecaRaioEPlano();
        }
        private void FuncaoPecaZeroMovimentoEsquerdo(int v)
        {
            ApagaPecaLE();
            if (dC != v)
            {
                MovimentoEsquerdoPecaZero();
            }
            PecaLEPlano();
        }
        private void MovimentoEsquerdoPecaTres()
        {
            bC--;
            cC--;
            dC--;
            eC--;
        }
        private void MovimentoEsquerdoPecaUmDoisCincoSeis()
        {
            dC--;
            eC--;
            fC--;
            gC--;
        }
        private void MovimentoEsquerdoPecaZero()
        {
            cC--;
            dC--;
            eC--;
            gC--;
        }
        #endregion
        #endregion

        #region Peças Setadas
        private void ApagaPecaRaioDireito()
        {
            dgvTetris.Rows[dL].Cells[dC].Style.BackColor = Color.Black;
            dgvTetris.Rows[eL].Cells[eC].Style.BackColor = Color.Black;
            dgvTetris.Rows[fL].Cells[fC].Style.BackColor = Color.Black;
            dgvTetris.Rows[gL].Cells[gC].Style.BackColor = Color.Black;
        }
        private void ApagaPecaT()
        {
            dgvTetris.Rows[dL].Cells[dC].Style.BackColor = Color.Black;
            dgvTetris.Rows[eL].Cells[eC].Style.BackColor = Color.Black;
            dgvTetris.Rows[fL].Cells[fC].Style.BackColor = Color.Black;
            dgvTetris.Rows[gL].Cells[gC].Style.BackColor = Color.Black;
        }
        private void ApagaPecaCaixa()
        {
            dgvTetris.Rows[cL].Cells[cC].Style.BackColor = Color.Black;
            dgvTetris.Rows[dL].Cells[dC].Style.BackColor = Color.Black;
            dgvTetris.Rows[eL].Cells[eC].Style.BackColor = Color.Black;
            dgvTetris.Rows[fL].Cells[fC].Style.BackColor = Color.Black;
        }
        private void ApagaPecaI()
        {
            dgvTetris.Rows[bL].Cells[bC].Style.BackColor = Color.Black;
            dgvTetris.Rows[cL].Cells[cC].Style.BackColor = Color.Black;
            dgvTetris.Rows[dL].Cells[dC].Style.BackColor = Color.Black;
            dgvTetris.Rows[eL].Cells[eC].Style.BackColor = Color.Black;
        }
        private void ApagaPecaLD()
        {
            dgvTetris.Rows[dL].Cells[dC].Style.BackColor = Color.Black;
            dgvTetris.Rows[eL].Cells[eC].Style.BackColor = Color.Black;
            dgvTetris.Rows[fL].Cells[fC].Style.BackColor = Color.Black;
            dgvTetris.Rows[gL].Cells[gC].Style.BackColor = Color.Black;
        }
        private void ApagaPecaRaioEsquerdo()
        {
            dgvTetris.Rows[dL].Cells[dC].Style.BackColor = Color.Black;
            dgvTetris.Rows[eL].Cells[eC].Style.BackColor = Color.Black;
            dgvTetris.Rows[fL].Cells[fC].Style.BackColor = Color.Black;
            dgvTetris.Rows[gL].Cells[gC].Style.BackColor = Color.Black;
        }
        private void ApagaPecaLE()
        {
            dgvTetris.Rows[cL].Cells[cC].Style.BackColor = Color.Black;
            dgvTetris.Rows[dL].Cells[dC].Style.BackColor = Color.Black;
            dgvTetris.Rows[eL].Cells[eC].Style.BackColor = Color.Black;
            dgvTetris.Rows[gL].Cells[gC].Style.BackColor = Color.Black;
        }

        private void PecaRaioDPlano()
        {
            dgvTetris.Rows[dL].Cells[dC].Style.BackColor = Color.Purple;
            dgvTetris.Rows[eL].Cells[eC].Style.BackColor = Color.Purple;
            dgvTetris.Rows[fL].Cells[fC].Style.BackColor = Color.Purple;
            dgvTetris.Rows[gL].Cells[gC].Style.BackColor = Color.Purple;
        }

        private void PecaTPlano()
        {
            dgvTetris.Rows[dL].Cells[dC].Style.BackColor = Color.Orange;
            dgvTetris.Rows[eL].Cells[eC].Style.BackColor = Color.Orange;
            dgvTetris.Rows[fL].Cells[fC].Style.BackColor = Color.Orange;
            dgvTetris.Rows[gL].Cells[gC].Style.BackColor = Color.Orange;
        }

        private void PecaCaixaPlano()
        {
            dgvTetris.Rows[cL].Cells[cC].Style.BackColor = Color.Pink;
            dgvTetris.Rows[dL].Cells[dC].Style.BackColor = Color.Pink;
            dgvTetris.Rows[eL].Cells[eC].Style.BackColor = Color.Pink;
            dgvTetris.Rows[fL].Cells[fC].Style.BackColor = Color.Pink;
        }

        private void PecaIPlano()
        {
            dgvTetris.Rows[bL].Cells[bC].Style.BackColor = Color.Green;
            dgvTetris.Rows[cL].Cells[cC].Style.BackColor = Color.Green;
            dgvTetris.Rows[dL].Cells[dC].Style.BackColor = Color.Green;
            dgvTetris.Rows[eL].Cells[eC].Style.BackColor = Color.Green;
        }

        private void PecaLDPlano()
        {
            dgvTetris.Rows[dL].Cells[dC].Style.BackColor = Color.Blue;
            dgvTetris.Rows[eL].Cells[eC].Style.BackColor = Color.Blue;
            dgvTetris.Rows[fL].Cells[fC].Style.BackColor = Color.Blue;
            dgvTetris.Rows[gL].Cells[gC].Style.BackColor = Color.Blue;
        }

        private void PecaRaioEPlano()
        {
            dgvTetris.Rows[dL].Cells[dC].Style.BackColor = Color.Red;
            dgvTetris.Rows[eL].Cells[eC].Style.BackColor = Color.Red;
            dgvTetris.Rows[fL].Cells[fC].Style.BackColor = Color.Red;
            dgvTetris.Rows[gL].Cells[gC].Style.BackColor = Color.Red;
        }

        private void PecaLEPlano() 
        {
            dgvTetris.Rows[cL].Cells[cC].Style.BackColor = Color.Yellow;
            dgvTetris.Rows[dL].Cells[dC].Style.BackColor = Color.Yellow;
            dgvTetris.Rows[eL].Cells[eC].Style.BackColor = Color.Yellow;
            dgvTetris.Rows[gL].Cells[gC].Style.BackColor = Color.Yellow;
        }
        #endregion

        public static int pontuacao { get; set; }
        private void TimerCaindo_Tick(object sender, EventArgs e) // peça caindo
        {
            int Pontuacao;
            Pontuacao = Convert.ToInt32(txtBoxPontuacao.Text);
            Pontuacao++;
            pontuacao = Pontuacao;
            txtBoxPontuacao.Text = Convert.ToString(Pontuacao);
            int i, j, h, l;
            switch(ID)
            {
                case 0: //LE
                    switch(ID_Rotacao) // vai verificar em qual rotação esta a peça
                    {
                        case 0:
                            i = gL;
                            j = eL;
                            if (gL == 27 || dgvTetris.Rows[i + 1].Cells[gC].Style.BackColor != Color.Black || dgvTetris.Rows[j + 1].Cells[eC].Style.BackColor != Color.Black) // verifica se ja chegou na ultima linha e se o quadrado de baixo é diferente de branco
                            {
                                FuncaoIniciaNovaPeca(0, 0);
                                return;
                            }
                            break;
                        case 1:
                            j = cL;
                            h = dL;
                            l = eL;
                            if (dL == 27 || dgvTetris.Rows[j + 1].Cells[cC].Style.BackColor != Color.Black || dgvTetris.Rows[h + 1].Cells[dC].Style.BackColor != Color.Black || dgvTetris.Rows[l + 1].Cells[eC].Style.BackColor != Color.Black) // verifica se ja chegou na ultima linha e se o quadrado de baixo é diferente de branco
                            {
                                FuncaoIniciaNovaPeca(0, 10);
                                return;
                            }
                            break;
                        case 2:
                            i = cL;
                            j = gL;
                            if (cL == 27 || dgvTetris.Rows[i + 1].Cells[cC].Style.BackColor != Color.Black || dgvTetris.Rows[j + 1].Cells[gC].Style.BackColor != Color.Black) // verifica se ja chegou na ultima linha e se o quadrado de baixo é diferente de branco
                            {
                                FuncaoIniciaNovaPeca(0, 100);
                                return;
                            }
                            break;
                        case 3:
                            j = cL;
                            h = dL;
                            l = gL;
                            if (gL == 27 || dgvTetris.Rows[j + 1].Cells[cC].Style.BackColor != Color.Black || dgvTetris.Rows[h + 1].Cells[dC].Style.BackColor != Color.Black || dgvTetris.Rows[l + 1].Cells[eC].Style.BackColor != Color.Black) // verifica se ja chegou na ultima linha e se o quadrado de baixo é diferente de branco
                            {
                                FuncaoIniciaNovaPeca(0, 1000);
                                return;
                            }
                            break;
                    }
                    ApagaPecaLE();
                    cL++;
                    dL++;
                    eL++;
                    fL++;
                    gL++;
                    PecaLEPlano();
                    break;
                case 1: //RE
                    switch(ID_Rotacao) // primeiro ele verifica se tem algo em baixo para depois cair
                    {
                        case 0:
                            i = dL;
                            j = fL;
                            h = gL;
                            if (gL == 27 || dgvTetris.Rows[i + 1].Cells[dC].Style.BackColor != Color.Black || dgvTetris.Rows[j + 1].Cells[fC].Style.BackColor != Color.Black || dgvTetris.Rows[h + 1].Cells[gC].Style.BackColor != Color.Black)
                            {
                                FuncaoIniciaNovaPeca(0, 1);
                                return; // para funçao
                            }
                            break;
                        case 1:
                            i = eL;
                            j = gL;
                            if (gL == 27 || dgvTetris.Rows[i + 1].Cells[eC].Style.BackColor != Color.Black || dgvTetris.Rows[j + 1].Cells[gC].Style.BackColor != Color.Black)
                            {
                                FuncaoIniciaNovaPeca(0, 11);
                                return;
                            }
                            break;
                    }
                    ApagaPecaRaioEsquerdo();
                    dL++;
                    eL++;
                    fL++;
                    gL++;
                    PecaRaioEPlano();
                    break;
                case 2: // LD
                    switch (ID_Rotacao)
                    {
                        case 0:
                            i = fL;
                            j = gL;
                            if (gL == 27 || dgvTetris.Rows[i + 1].Cells[fC].Style.BackColor != Color.Black || dgvTetris.Rows[j + 1].Cells[gC].Style.BackColor != Color.Black) // verifica se ja chegou na ultima linha e se o quadrado de baixo é diferente de branco
                            {
                                FuncaoIniciaNovaPeca(0, 2);
                                return;
                            }
                            break;
                        case 1:
                            j = dL;
                            h = eL;
                            l = gL;
                            if (gL == 27 || dgvTetris.Rows[j + 1].Cells[dC].Style.BackColor != Color.Black || dgvTetris.Rows[h + 1].Cells[eC].Style.BackColor != Color.Black || dgvTetris.Rows[l + 1].Cells[gC].Style.BackColor != Color.Black) // verifica se ja chegou na ultima linha e se o quadrado de baixo é diferente de branco
                            {
                                FuncaoIniciaNovaPeca(0, 22);
                                return;
                            }
                            break;
                        case 2:
                            i = dL;
                            j = gL;
                            if (dL == 27 || dgvTetris.Rows[i + 1].Cells[dC].Style.BackColor != Color.Black || dgvTetris.Rows[j + 1].Cells[gC].Style.BackColor != Color.Black) // verifica se ja chegou na ultima linha e se o quadrado de baixo é diferente de branco
                            {
                                FuncaoIniciaNovaPeca(0, 222);
                                return;
                            }
                            break;
                        case 3:
                            j = dL;
                            h = eL;
                            l = fL;
                            if (eL == 27 || dgvTetris.Rows[j + 1].Cells[dC].Style.BackColor != Color.Black || dgvTetris.Rows[h + 1].Cells[eC].Style.BackColor != Color.Black || dgvTetris.Rows[l + 1].Cells[fC].Style.BackColor != Color.Black) // verifica se ja chegou na ultima linha e se o quadrado de baixo é diferente de branco
                            {
                                FuncaoIniciaNovaPeca(0, 2222);
                                return;
                            }
                            break;
                    }
                    ApagaPecaLD();
                    dL++;
                    eL++;
                    fL++;
                    gL++;
                    PecaLDPlano();
                    break;
                case 3: //I
                    switch (ID_Rotacao)
                    {
                        case 0:
                            i = eL;
                            if (eL == 27 || dgvTetris.Rows[i + 1].Cells[eC].Style.BackColor != Color.Black)
                            {
                                FuncaoIniciaNovaPeca(0, 3);
                                return;
                            }
                            break;
                        case 1:
                            i = eL;
                            j = dL;
                            h = cL;
                            l = bL;
                            if (eL == 27 || dgvTetris.Rows[i + 1].Cells[eC].Style.BackColor != Color.Black || dgvTetris.Rows[j + 1].Cells[dC].Style.BackColor != Color.Black || dgvTetris.Rows[h + 1].Cells[cC].Style.BackColor != Color.Black || dgvTetris.Rows[l + 1].Cells[bC].Style.BackColor != Color.Black)
                            {
                                FuncaoIniciaNovaPeca(0, 33);
                                return;
                            }
                            break;
                    }
                    ApagaPecaI();
                    bL++;
                    cL++;
                    dL++;
                    eL++;
                    PecaIPlano();
                    break;
                case 4: // Caixa
                    i = eL;
                    j = fL;
                    if (eL == 27 || dgvTetris.Rows[i + 1].Cells[eC].Style.BackColor != Color.Black || dgvTetris.Rows[j + 1].Cells[fC].Style.BackColor != Color.Black)
                    {
                        FuncaoIniciaNovaPeca(0, 4);
                        return;
                    }
                    ApagaPecaCaixa();
                    cL++;
                    dL++;
                    eL++;
                    fL++;
                    PecaCaixaPlano();
                    break;
                case 5://T
                    switch (ID_Rotacao)
                    {
                        case 0:
                            i = dL;
                            j = fL;
                            h = gL;
                            if (gL == 27 || dgvTetris.Rows[i + 1].Cells[dC].Style.BackColor != Color.Black || dgvTetris.Rows[j + 1].Cells[fC].Style.BackColor != Color.Black || dgvTetris.Rows[h + 1].Cells[gC].Style.BackColor != Color.Black) // verifica se ja chegou na ultima linha e se o quadrado de baixo é diferente de branco
                            {
                                FuncaoIniciaNovaPeca(0, 5);
                                return;
                            }
                            break;
                        case 1:
                            i = fL;
                            j = gL;
                            if (fL == 27 || dgvTetris.Rows[i + 1].Cells[fC].Style.BackColor != Color.Black || dgvTetris.Rows[j + 1].Cells[gC].Style.BackColor != Color.Black) // verifica se ja chegou na ultima linha e se o quadrado de baixo é diferente de branco
                            {
                                FuncaoIniciaNovaPeca(0, 55);
                                return;
                            }
                            break;
                        case 2:
                            i = dL;
                            j = eL;
                            h = fL;
                            if (eL == 27 || dgvTetris.Rows[i + 1].Cells[dC].Style.BackColor != Color.Black || dgvTetris.Rows[j + 1].Cells[eC].Style.BackColor != Color.Black || dgvTetris.Rows[h + 1].Cells[fC].Style.BackColor != Color.Black) // verifica se ja chegou na ultima linha e se o quadrado de baixo é diferente de branco
                            {
                                FuncaoIniciaNovaPeca(0, 555);
                                return;
                            }
                            break;
                        case 3:
                            i = dL;
                            j = gL;
                            if (dL == 27 || dgvTetris.Rows[i + 1].Cells[dC].Style.BackColor != Color.Black || dgvTetris.Rows[j + 1].Cells[gC].Style.BackColor != Color.Black) // verifica se ja chegou na ultima linha e se o quadrado de baixo é diferente de branco
                            {
                                FuncaoIniciaNovaPeca(0, 5555);
                                return;
                            }
                            break;
                    }
                    ApagaPecaT();
                    dL++;
                    eL++;
                    fL++;
                    gL++;
                    PecaTPlano();
                    break;
                case 6: //RD
                    switch (ID_Rotacao)
                    {
                        case 0:
                            i = eL;
                            j = gL;
                            h = fL;
                            if (gL == 27 || dgvTetris.Rows[i + 1].Cells[eC].Style.BackColor != Color.Black || dgvTetris.Rows[j + 1].Cells[gC].Style.BackColor != Color.Black || dgvTetris.Rows[h + 1].Cells[fC].Style.BackColor != Color.Black)
                            {
                                FuncaoIniciaNovaPeca(0, 6);
                                return;
                            }
                            break;
                        case 1:
                            i = dL;
                            j = fL;
                            if (fL == 27 || dgvTetris.Rows[i + 1].Cells[dC].Style.BackColor != Color.Black || dgvTetris.Rows[j + 1].Cells[fC].Style.BackColor != Color.Black)
                            {
                                FuncaoIniciaNovaPeca(0, 66);
                                return;
                            }
                            break;
                    }
                    ApagaPecaRaioDireito();
                    eL++;
                    dL++;
                    gL++;
                    fL++;
                    PecaRaioDPlano();
                    break;
            }
        }

        private void FuncaoIniciaNovaPeca(int v1, int v2)
        {
            BloqueiaMovimento = 0;
            ValidaVelocidade = true;
            TimerCaindo.Interval = Velocidade;
            TimerCaindo.Enabled = false; // peça para de cair
            VerificaJogo();
            timerPecas.Start();// insere uma nova peça
            ID_Rotacao = v1;
            IDPecaRotacioada = v2;
        }
        static public int PontoPorLinhas = 0;
        private void VerificaJogo()
        {
            PontoPorLinhas = 0;
            int QuantidadeColorida = 0, Pontuacao=0, Linhas;
            if(dgvTetris.Rows[5].Cells[4].Style.BackColor != Color.Black || dgvTetris.Rows[5].Cells[5].Style.BackColor != Color.Black || dgvTetris.Rows[5].Cells[6].Style.BackColor != Color.Black)
            {
                TimerCaindo.Stop();
                timerPecas.Stop();
                switch (Idiomas)
                {
                    case true:
                        MessageBox.Show("Você Perdeu, aguarde!", "Fim de Jogo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case false:
                        MessageBox.Show("You missed, wait!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                }
                SalvaJogo();
                IniciaGrid();
                ValidaFechamento = 1;

                this.Close();
                
            }
            else
            {
                for (int i = 4; i < 28; i++)// pinta as celulas de preto
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (dgvTetris.Rows[i].Cells[j].Style.BackColor != Color.Black)
                        {
                            QuantidadeColorida++;
                        }
                        if (QuantidadeColorida == 10) // verifica se tem uma linha completa
                        {
                            PontoPorLinhas++;
                            for (int h = i; h >= 5; h--)
                            {
                                for (j = 0; j < 10; j++)
                                {
                                    dgvTetris.Rows[h].Cells[j].Style.BackColor = dgvTetris.Rows[h - 1].Cells[j].Style.BackColor;
                                }
                            }
                            Pontuacao = Convert.ToInt32(txtBoxPontuacao.Text);
                            Pontuacao = Pontuacao + 100*PontoPorLinhas;
                            txtBoxPontuacao.Text = Convert.ToString(Pontuacao);
                            Linhas = Convert.ToInt32(txtBoxLinhas.Text);
                            Linhas++;
                            txtBoxLinhas.Text = Convert.ToString(Linhas); 
                        }
                    }
                    QuantidadeColorida = 0;
                }
            }
        }

        private void SalvaJogo()
        {
            //if (IsConnect.IsConnected() && Conecta == "Online") //Online
            //{
            //    SalvaOnline();
            //}
            //else //offline
            //{
                if(Conecta == "offline")
                {
                    MessageBox.Show(Menssagem2, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Question);
                    SalvaOffline();
                }
                //else
                //{
                //    DialogResult result = MessageBox.Show(Menssagem, Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //    if (result == DialogResult.Yes)
                //    {
                //        SalvaOnline();

                //    }
                //    else
                //    {
                //        MessageBox.Show(Menssagem2, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Question);
                //        SalvaOffline();
                //    }
                //}
            //}
        }

        private void SalvaOffline()
        {
            oNomeJogador.Nome = NomeJogador;
            oNomeJogador.Pontuacao =Convert.ToInt32(txtBoxPontuacao.Text);
            oNomeJogador.Data = System.DateTime.Now;
            switch (ModoJogo)
            {
                case 1:
                    oNomeJogador.Modo = "Arcade";
                    break;
                case 2:
                    oNomeJogador.Modo = "Jedi";
                    break;
                case 3:
                    oNomeJogador.Modo = "Hard";
                    break;
                case 4:
                    oNomeJogador.Modo = "Normal";
                    break;
                case 5:
                    oNomeJogador.Modo = "Easy";
                    break;
            }

            ListaJogador.Add(oNomeJogador);
            VerificaPastaDoSave();
            BinaryFormatter BF = new BinaryFormatter();
            FileStream _file = File.Open("C:\\United Blocks\\Save\\Save.sub", FileMode.OpenOrCreate); // cria o save na pasta desejada
            BF.Serialize(_file, ListaJogador);
            _file.Close();
        }

        //private void SalvaOnline()
        //{
        //    tb_Score otb_Score = new tb_Score();
        //    otb_Score.SCR_Nickname = NomeJogador;
        //    otb_Score.SCR_Score = Convert.ToInt32(txtBoxPontuacao.Text);
        //    otb_Score.SCR_DateGame = System.DateTime.Now;
        //    switch (ModoJogo)
        //    {
        //        case 1:
        //            otb_Score.SCR_Level = "Arcade";
        //            break;
        //        case 2:
        //            otb_Score.SCR_Level = "Jedi";
        //            break;
        //        case 3:
        //            otb_Score.SCR_Level = "Hard";
        //            break;
        //        case 4:
        //            otb_Score.SCR_Level = "Normal";
        //            break;
        //        case 5:
        //            otb_Score.SCR_Level = "Easy";
        //            break;
        //    }
        //    CInserirScore.Incluir(otb_Score);
        //}

        private void VerificaPastaDoSave()
        {
            string folder = @"C:\United Blocks\Save"; //Caminho do diretório criado

            if (!Directory.Exists(folder))//cria a pasta no caminho especificado
            {
                //Criamos um com o nome folder
                Directory.CreateDirectory(folder);

            }
        }

        
        static public int ValidaFechamento = 0; // O usuário quando clicar em sair ele vai salvar apenas uma vez
        private void btnSair_Click(object sender, EventArgs e)
        {
            ValidaFechamento = 1;
            TimerCaindo.Stop();
            timerPecas.Stop();
            SalvaJogo();
            this.Close();
        }

        private void FrmPrincipalTetris_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        private void btnPausa_Click(object sender, EventArgs e)
        {
            if(pontuacao>=1)
            {
                TimerCaindo.Enabled = false;
                timerPecas.Enabled = false;
                FrmPause ofrm = new FrmPause(Idiomas);
                ofrm.ShowDialog();
                TimerCaindo.Enabled = true;
                dgvTetris.Focus();
            }
            
        }

        private void dgvTetris_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvTetris.Rows[0].Cells[0].Selected = true;
        }

        private void btnRecomecar_Click_1(object sender, EventArgs e)
        {
            TimerCaindo.Stop();
            IniciaGrid();
            timerPecas.Start();
            dgvTetris.Focus();
        }

        private void txtBoxPontuacao_MouseClick(object sender, MouseEventArgs e)
        {
            dgvTetris.Focus();
        }

        private void txtBoxLinhas_MouseClick(object sender, MouseEventArgs e)
        {
            dgvTetris.Focus();
        }

        private void dgvTetris_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

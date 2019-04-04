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

namespace United_Blocks
{
    public partial class FrmPlacar : Form
    {
        List<Jogador> ListaJogador = new List<Jogador>();
        List<Jogador> ListaJogadorEasy = new List<Jogador>();
        List<Jogador> ListaJogadorNormal = new List<Jogador>();
        List<Jogador> ListaJogadorHard = new List<Jogador>();
        List<Jogador> ListaJogadorJedi = new List<Jogador>();
        List<Jogador> ListaJogadorArcade = new List<Jogador>();
        List<string> ListaPodium = new List<string>();
        //List<Jogador> ListaJogadorOrdemInversa = new List<Jogador>();
        public FrmPlacar()
        {
            InitializeComponent();
        }

        public FrmPlacar(bool Idioma)
        {
            InitializeComponent();
            switch(Idioma)
            {
                case true:
                    this.Text = "Placar de Jogadores";
                    lbPlacar.Text = "Placar de Jogadores";
                    break;
                case false:
                    this.Text = "Scoreboard";
                    lbPlacar.Text = "Scoreboard";
                    break;
            }
        }
        private void FrmPlacar_Load(object sender, EventArgs e)
        {
            ListaPodium.Add(" ");
            ListaPodium.Add(" ");
            ListaPodium.Add(" ");
            VerificaPastaDoSave();
            BinaryFormatter BF = new BinaryFormatter();
            FileStream _file = File.Open("C:\\United Blocks\\Save\\Save.sub", FileMode.OpenOrCreate); // verifica se o arquivo existe
            if (_file.Length > 0) // verifica se o arquivo não esta vazio
            {
                List<Jogador> _Funcionario = (List<Jogador>)BF.Deserialize(_file); // Vai desconverter o arquivo binario para a lista.
                ListaJogador = _Funcionario;
                _file.Close();
            }

            //ListaJogadorEasy = null;
            //ListaJogadorNormal = null;
            //ListaJogadorHard = null;
            //ListaJogadorJedi = null;
            //ListaJogadorArcade = null;

            Jogador oJogador = new Jogador();
            for (int i = 0; i < ListaJogador.Count; i++)
            {

                if (ListaJogador[i].Modo == "Easy")
                {
                    Jogador oJogadorEasy = new Jogador();
                    oJogadorEasy.Nome = ListaJogador[i].Nome;
                    oJogadorEasy.Pontuacao = ListaJogador[i].Pontuacao;
                    oJogadorEasy.Data = ListaJogador[i].Data;
                    oJogadorEasy.Modo = ListaJogador[i].Modo;
                    ListaJogadorEasy.Add(oJogadorEasy);
                }
                else if(ListaJogador[i].Modo == "Normal")
                {
                    Jogador oJogadorNormal = new Jogador();
                    oJogadorNormal.Nome = ListaJogador[i].Nome;
                    oJogadorNormal.Pontuacao = ListaJogador[i].Pontuacao;
                    oJogadorNormal.Data = ListaJogador[i].Data;
                    oJogadorNormal.Modo = ListaJogador[i].Modo;
                    ListaJogadorNormal.Add(oJogadorNormal);
                }
                else if (ListaJogador[i].Modo == "Hard")
                {
                    Jogador oJogadorHard = new Jogador();
                    oJogadorHard.Nome = ListaJogador[i].Nome;
                    oJogadorHard.Pontuacao = ListaJogador[i].Pontuacao;
                    oJogadorHard.Data = ListaJogador[i].Data;
                    oJogadorHard.Modo = ListaJogador[i].Modo;
                    ListaJogadorHard.Add(oJogadorHard);
                }
                else if (ListaJogador[i].Modo == "Jedi")
                {
                    Jogador oJogadorJedi = new Jogador();
                    oJogadorJedi.Nome = ListaJogador[i].Nome;
                    oJogadorJedi.Pontuacao = ListaJogador[i].Pontuacao;
                    oJogadorJedi.Data = ListaJogador[i].Data;
                    oJogadorJedi.Modo = ListaJogador[i].Modo;
                    ListaJogadorJedi.Add(oJogadorJedi);
                }
                else if (ListaJogador[i].Modo == "Arcade")
                {
                    Jogador oJogadorArcade = new Jogador();
                    oJogadorArcade.Nome = ListaJogador[i].Nome;
                    oJogadorArcade.Pontuacao = ListaJogador[i].Pontuacao;
                    oJogadorArcade.Data = ListaJogador[i].Data;
                    oJogadorArcade.Modo = ListaJogador[i].Modo;
                    ListaJogadorArcade.Add(oJogadorArcade);
                }
            }

            ListaJogadorEasy = ListaJogadorEasy.OrderByDescending(c => c.Pontuacao).ToList();
            ListaJogadorNormal = ListaJogadorNormal.OrderByDescending(c => c.Pontuacao).ToList();
            ListaJogadorHard = ListaJogadorHard.OrderByDescending(c => c.Pontuacao).ToList();
            ListaJogadorJedi = ListaJogadorJedi.OrderByDescending(c => c.Pontuacao).ToList();
            ListaJogadorArcade = ListaJogadorArcade.OrderByDescending(c => c.Pontuacao).ToList();

            dgvPlacar.DataSource = null;
            dgvNormal.DataSource = null;
            dgvHard.DataSource = null;
            dgvJedi.DataSource = null;
            dgvArcade.DataSource = null;

            dgvPlacar.DataSource = ListaJogadorEasy;
            dgvNormal.DataSource = ListaJogadorNormal;
            dgvHard.DataSource = ListaJogadorHard;
            dgvJedi.DataSource = ListaJogadorJedi;
            dgvArcade.DataSource = ListaJogadorArcade;

            OrganizaPodium(ListaJogadorEasy.Count, ListaJogadorEasy);

            dgvPlacar.Refresh();
            dgvNormal.Refresh();
            dgvHard.Refresh();
            dgvJedi.Refresh();
            dgvArcade.Refresh();
        }

        private void VerificaPastaDoSave()
        {
            string folder = @"C:\United Blocks\Save"; //Caminho do diretório criado

            if (!Directory.Exists(folder))//cria a pasta no caminho especificado
            {
                //Criamos um com o nome folder
                Directory.CreateDirectory(folder);

            }
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvPlacar_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:
                    OrganizaPodium(ListaJogadorEasy.Count, ListaJogadorEasy);
                    break;
                case 1:
                    OrganizaPodium(ListaJogadorNormal.Count, ListaJogadorNormal);
                    break;
                case 2:
                    OrganizaPodium(ListaJogadorHard.Count, ListaJogadorHard);
                    break;
                case 3:
                    OrganizaPodium(ListaJogadorJedi.Count, ListaJogadorJedi);
                    break;
                case 4:
                    OrganizaPodium(ListaJogadorArcade.Count, ListaJogadorArcade);
                    break;
            }
        
        }

        private void OrganizaPodium(int totalLista, List<Jogador> jogadores)
        {
            ListaPodium[0] = "";
            ListaPodium[1] = "";
            ListaPodium[2] = "";
            int count = 0;
            for (int i = 0; i < totalLista; i++)
            {
                count++;
                ListaPodium[i] = jogadores[i].Nome;
                if (count == 3)
                {
                    break;
                }
            }
            lbPrimeiro.Text = ListaPodium[0];
            lbSegundo.Text = ListaPodium[1];
            lbTerceiro.Text = ListaPodium[2];
        }
    }
}

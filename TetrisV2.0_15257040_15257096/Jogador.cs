using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace United_Blocks
{
    [Serializable]
    class Jogador
    {
        public string Nome { get; set; }
        public int Pontuacao { get; set; }
        public DateTime Data { get; set; }
        public string Modo { get; set; }
    }
}

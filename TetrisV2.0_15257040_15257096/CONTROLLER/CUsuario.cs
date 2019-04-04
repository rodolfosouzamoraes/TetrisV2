using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using United_Blocks.MODEL;

namespace United_Blocks.CONTROLLER
{
    public class CUsuario
    {
        public static void Incluir(tb_Usuario atb_Usuario)
        {
            tb_Usuario.Incluir(atb_Usuario);
        }
        public static void Alterar(tb_Usuario atb_Usuario)
        {
            tb_Usuario.Alterar(atb_Usuario);
        }
        public static NickUsuario AchouUsuarioExistente(string Nick)
        {
            return tb_Usuario.AchouUsuarioExistente(Nick);
        }
        public static tb_Usuario AchouUsuario(NickUsuario oNick)
        {
            return tb_Usuario.AchouUsuario(oNick);
        }
    }
}

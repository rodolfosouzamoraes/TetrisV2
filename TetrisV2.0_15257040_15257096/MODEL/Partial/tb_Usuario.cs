using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace United_Blocks.MODEL
{
    public partial class tb_Usuario
    {
        public static void Incluir(tb_Usuario atb_Usuario)
        {
            using (United_BDEntities oDB = Helper.DataBaseHelper.getDataContext())
            {
                oDB.tb_Usuario.Add(atb_Usuario);
                oDB.SaveChanges();
            }
        }
        public static void Alterar(tb_Usuario aUsuario)
        {
            using (United_BDEntities oDB = Helper.DataBaseHelper.getDataContext())
            {
                oDB.Entry(aUsuario).State = System.Data.Entity.EntityState.Modified;
                oDB.SaveChanges();
            }
        }
        public static NickUsuario AchouUsuarioExistente(string nick)
        {
            using (United_BDEntities oDB = Helper.DataBaseHelper.getDataContext())
            {
                var Res = from p in oDB.tb_Usuario where p.USR_Nick == nick select p.USR_Nick;
                NickUsuario oNick = new NickUsuario();
                oNick.USR_Nick = Res.FirstOrDefault();
                return oNick;
            }
        }
        public static tb_Usuario AchouUsuario(NickUsuario oUsuario)
        {
            using (United_BDEntities oDB = Helper.DataBaseHelper.getDataContext())
            {
                var Res = from p in oDB.tb_Usuario where p.USR_Nick == oUsuario.USR_Nick select p;
                return Res.FirstOrDefault();
            }
        }
    }
}

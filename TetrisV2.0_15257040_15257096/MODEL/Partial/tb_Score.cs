using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace United_Blocks.MODEL
{
    public partial class tb_Score
    {
        public static void Incluir(tb_Score atb_Score)
        {
            using (United_BDEntities oDB = Helper.DataBaseHelper.getDataContext())
            {
                oDB.tb_Score.Add(atb_Score);
                oDB.SaveChanges();
            }
        }
        public static List<tb_Score> AchouLevelEasy(string Level)
        {
            using (United_BDEntities oDB = Helper.DataBaseHelper.getDataContext())
            {
                var Res = from p in oDB.tb_Score where p.SCR_Level == Level orderby p.SCR_Score descending select p;
                return Res.Take(100).ToList();
            }
        }
        public static List<tb_Score> AchouLevelNormal(string Level)
        {
            using (United_BDEntities oDB = Helper.DataBaseHelper.getDataContext())
            {
                var Res = from p in oDB.tb_Score where p.SCR_Level == Level orderby p.SCR_Score descending select p;
                return Res.Take(100).ToList();
            }
        }
        public static List<tb_Score> AchouLevelHard(string Level)
        {
            using (United_BDEntities oDB = Helper.DataBaseHelper.getDataContext())
            {
                var Res = from p in oDB.tb_Score where p.SCR_Level == Level orderby p.SCR_Score descending select p;
                return Res.Take(100).ToList();
            }
        }
        public static List<tb_Score> AchouLevelJedi(string Level)
        {
            using (United_BDEntities oDB = Helper.DataBaseHelper.getDataContext())
            {
                var Res = from p in oDB.tb_Score where p.SCR_Level == Level orderby p.SCR_Score descending select p;
                return Res.Take(100).ToList();
            }
        }
        public static List<tb_Score> AchouLevelArcade(string Level)
        {
            using (United_BDEntities oDB = Helper.DataBaseHelper.getDataContext())
            {
                var Res = from p in oDB.tb_Score where p.SCR_Level == Level orderby p.SCR_Score descending select p;
                return Res.Take(100).ToList();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using United_Blocks.MODEL;

namespace United_Blocks.CONTROLLER
{
    public class CInserirScore
    {
        public static void Incluir(tb_Score atb_Score)
        {
            tb_Score.Incluir(atb_Score);
        }
        public static List<tb_Score> AchouLevelEasy(string Level)
        {
            return tb_Score.AchouLevelEasy(Level);
        }
        public static List<tb_Score> AchouLevelNormal(string Level)
        {
            return tb_Score.AchouLevelNormal(Level);
        }
        public static List<tb_Score> AchouLevelHard(string Level)
        {
            return tb_Score.AchouLevelHard(Level);
        }
        public static List<tb_Score> AchouLevelArcade(string Level)
        {
            return tb_Score.AchouLevelArcade(Level);
        }
        public static List<tb_Score> AchouLevelJedi(string Level)
        {
            return tb_Score.AchouLevelJedi(Level);
        }
    }
}

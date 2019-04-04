using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace United_Blocks.MODEL
{
    public partial class tb_Feedback
    {
        public static void Incluir(tb_Feedback atb_Feedback)
        {
            using (United_BDEntities oDB = Helper.DataBaseHelper.getDataContext())
            {
                oDB.tb_Feedback.Add(atb_Feedback);
                oDB.SaveChanges();
            }
        }
    }
}

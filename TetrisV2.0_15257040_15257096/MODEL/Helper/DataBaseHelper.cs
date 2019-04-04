using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace United_Blocks.MODEL.Helper
{
    public class DataBaseHelper
    {
        public static United_BDEntities getDataContext()
        {
            //SAESEntities oDB = new SAESEntities();
            //return oDB;

            United_BDEntities Result = new United_BDEntities();
            //Result.Database.CommandTimeout = 30;
            Result.Configuration.ProxyCreationEnabled = false;
            return Result;

        }
    }
}

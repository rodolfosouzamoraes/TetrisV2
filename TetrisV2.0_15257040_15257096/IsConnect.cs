using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace United_Blocks
{
    public class IsConnect
    {
        public static bool IsConnected()
        {
            bool fail;

            System.Uri Url = new System.Uri("http://www.microsoft.com"); //é sempre bom por um site que costuma estar sempre on, para n haver problemas

            System.Net.WebRequest WebReq;
            System.Net.WebResponse Resp;
            WebReq = System.Net.WebRequest.Create(Url);

            try
            {
                Resp = WebReq.GetResponse();
                Resp.Close();
                WebReq = null;
                fail = true; //consegue conexão à internet
                return fail;
            }

            catch
            {
                MessageBox.Show("Você não está conectado a internet!", "Atenção", MessageBoxButtons.OK);
                WebReq = null;
                fail = false; //falhou a conexão à internet
                return fail;
            }
        }
    }
}

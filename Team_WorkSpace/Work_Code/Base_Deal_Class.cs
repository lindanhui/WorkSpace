using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_Hander_Test
{
    class Base_Deal_Class
    {
        public static void Message_Alert(Label In_Label,string Message)
        {
            In_Label.Text = Message;
        }
    }
}

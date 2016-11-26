using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WddWeChat.Common;

namespace API_Hander_Test
{
    class Request_Deal_Class
    {
        public static string Deal_Get_Request(string Request_URL)
        {
            string Return_String = string.Empty;

            Return_String = UrlRequest.HttpGet(Request_URL);

            return Return_String;
        }
        public static string All_Deal_Request(string Request_URL,string Type="",string Request_Data = "",string Encode = "")
        {
            string Return_String = string.Empty;
            if(Type=="GET"&&Request_Data==""&&Encode=="")
            {
                Return_String = Deal_Get_Request(Request_URL);
            }

            return Return_String;
        }
    }
}

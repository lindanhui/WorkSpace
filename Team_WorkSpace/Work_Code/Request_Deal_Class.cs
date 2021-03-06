﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WddWeChat.Common;

namespace API_Hander_Test
{
    class Request_Deal_Class
    {
        private static string Deal_Get_Request(string Request_URL)
        {
            string Return_String = string.Empty;

            Return_String = UrlRequest.HttpGet(Request_URL);

            return Return_String;
        }
        private static string Deal_POST_Request(string Request_URL,string Encode)
        {
            string Return_String = string.Empty; 
                    
            switch (Encode)
            {
                case "UTF-8":
                    Return_String = UrlRequest.HttpPost(Request_URL, "", Encoding.UTF8);
                    break;
                case "Unicode":
                    Return_String = UrlRequest.HttpPost(Request_URL, "", Encoding.Unicode);
                    break;
                case "BigEndianUnicode":
                    Return_String = UrlRequest.HttpPost(Request_URL, "", Encoding.BigEndianUnicode);
                    break;
                case "ASCII":
                    Return_String = UrlRequest.HttpPost(Request_URL, "", Encoding.ASCII);
                    break;
            }
            

            return Return_String;
        }

        public static string All_Deal_Request(string Request_URL,string Type="",string Request_Data = "",string Encode = "")
        {
            string Return_String = string.Empty;

            //GET的URL带参请求
            if(Type=="GET"&&Request_Data==""&&Encode=="")
            {
                Return_String = Deal_Get_Request(Request_URL);
            }
            if(Type=="POST"&&Request_Data=="")
            {
                Return_String = Deal_POST_Request(Request_URL,Encode);
            }

            return Return_String;
        }
    }
}

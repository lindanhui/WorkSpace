using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary_Mei
{
    class Login_Class
    {
        #region 数据库初始定义
        private static SqlConnection SQL_Connection = new SqlConnection();
        private static SqlCommand SQL_Command = new SqlCommand();
        const string SQL_URL = "SERVER=120.77.147.210,1433;DATABASE=lindatabase;PWD=sql@123456;UID=wgx;";
        #endregion
        //
        #region 打开数据库
        /// <summary>
        /// 打开数据库链接
        /// </summary>
        public static void Open_Connection()//打开数据库
        {
            if (SQL_Connection.State == ConnectionState.Closed)
            {
                SQL_Connection.ConnectionString = SQL_URL;
                SQL_Connection.Open();
            }
        }
        #endregion
        //
        #region 关闭数据库
        /// <summary>
        /// 关闭数据库链接
        /// </summary>
        public static void Close_Connection()
        {
            if (SQL_Connection.State == ConnectionState.Open)
            {
                SQL_Connection.Close();
            }
        }

        #endregion
        //
        /// <summary>
        /// 检测一条数据是否存在
        /// </summary>
        /// <param name="SQL_String"></param>
        /// <returns></returns>
        public static int Check_SQL(String SQL_String)//1为存在，0是不存在
        {
            if (SQL_Connection.State == ConnectionState.Closed)
            {
                Open_Connection();
            }
            SQL_Command.Connection = SQL_Connection;
            SQL_Command.CommandText = SQL_String;
            SqlDataReader SQL_DataReader = SQL_Command.ExecuteReader();
            SQL_DataReader.Read();
            if (SQL_DataReader.HasRows)
            {
                SQL_DataReader.Close();
                Close_Connection();
                return 1;
            }
            else
            {
                SQL_DataReader.Close();
                Close_Connection();
                return 0;
            }
        }
    }
}

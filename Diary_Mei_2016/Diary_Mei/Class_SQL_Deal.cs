using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Diary_Mei
{
    /// <summary>
    /// 数据库处理类
    /// </summary>
    class Class_SQL_Deal
    {
        #region 数据库初始定义
        private static OleDbConnection SQL_Connection = new OleDbConnection();
        private static OleDbCommand SQL_Command = new OleDbCommand();
        const string SQL_URL = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = DataFile\Data.accdb";
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
        #region 检测数据是否存在
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
            OleDbDataReader SQL_DataReader = SQL_Command.ExecuteReader();
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
        #endregion
        //
        #region 更新一条数据记录
        /// <summary>
        /// 更新一条数据记录
        /// </summary>
        /// <param name="SQL"></param>
        /// <returns></returns>
        public static int Update_SQL(String SQL)//更新一条数据库语句，成功则返回1
        {
            SQL_Command.Connection = SQL_Connection;
            SQL_Command.CommandText = SQL;
            return SQL_Command.ExecuteNonQuery();
        }
        #endregion
        //

        #region 插入一条记录
        /// <summary>
        /// 插入一条记录 1代表插入成功
        /// </summary>
        /// <param name="SQL"></param>
        /// <returns></returns>
        public static int Insert_SQL(String SQL)
        {
            if (SQL_Connection.State == ConnectionState.Closed)
            {
                Open_Connection();
            }
            SQL_Command.Connection = SQL_Connection;
            SQL_Command.CommandText = SQL;
            return SQL_Command.ExecuteNonQuery();
        }
        #endregion
        //

        #region 执行查询语句，并返回DataTable

        /// <summary>
        /// 执行查询语句，并返回DataTable
        /// </summary>
        /// <param name="SQL"></param>
        /// <returns></returns>
        public static DataTable DataTable_Query(String SQL, String Table_Name, int StartRows, int PrintRows)
        {
            Open_Connection();
            DataSet SQL_DataSet = new DataSet();
            OleDbDataAdapter SQL_DataAdapter = new OleDbDataAdapter(SQL, SQL_Connection);
            SQL_DataAdapter.Fill(SQL_DataSet, StartRows, PrintRows, Table_Name);
            Close_Connection();
            SQL_DataAdapter.Dispose();
            return SQL_DataSet.Tables[0];
        }
        #endregion
        //

        #region 对数据库信息进行统计，并返回行数
        /// <summary>
        /// 进行SQL查询，并返回(TableName 是所需要查询的表名， where 是条件)
        /// </summary>
        /// <param name="SQL"></param>
        /// <returns></returns>
        public static int Query_AllRows(String Table_Name, String Where)
        {
            Open_Connection();

            SQL_Command.Connection = SQL_Connection;

            SQL_Command.CommandText = "SELECT COUNT(*) FROM " + Table_Name + " WHERE " + Where + "";

            return (int)SQL_Command.ExecuteScalar();
        }

        #endregion
        //



        public static int Export_EXCEL(string SQL_Query)
        {
            Open_Connection();
            SQL_Command.Connection = SQL_Connection;
            SQL_Command.CommandText = SQL_Query;
            return SQL_Command.ExecuteNonQuery();
        }



        //


        /// <summary>
        /// 执行SQL并返回DataTable
        /// </summary>
        /// <param name="SQL"></param>
        /// <returns></returns>
        public static DataTable DataTable_Get(String SQL)
        {
            Open_Connection();
            DataSet SQL_DataSet = new DataSet();
            OleDbDataAdapter SQL_DataAdapter = new OleDbDataAdapter(SQL, SQL_Connection);
            SQL_DataAdapter.Fill(SQL_DataSet);
            Close_Connection();
            SQL_DataAdapter.Dispose();
            return SQL_DataSet.Tables[0];
        }
        //

        /// <summary>
        /// 删除一条数据，返回1代表成功
        /// </summary>
        /// <param name="SQL"></param>
        /// <returns></returns>
        public static int Delete_SQL(String SQL)
        {
            if (SQL_Connection.State == ConnectionState.Closed)
            {
                Open_Connection();
            }
            SQL_Command.Connection = SQL_Connection;
            SQL_Command.CommandText = SQL;
            return SQL_Command.ExecuteNonQuery();
        }

        //


    }
}

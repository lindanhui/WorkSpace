using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Diary_Mei
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

            //
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            //#region 打开数据库链接
            //try
            //{
            //    Class_SQL_Deal.Open_Connection();
            //}
            //catch
            //{
            //    MessageBox.Show("数据库链接异常，请联系管理员！");
            //}
            //#endregion

            Login_Class.Open_Connection();

            //String SQL = "Select * FROM Login_Table WHERE Login_Password = '"+Name_TextBox.Text.Trim()+"'";

            string sql = "select * from a_admin where user_name = '"+Name_TextBox.Text.Trim()+"' and user_password = '"+textBox_Password.Text.Trim()+"'";


            if(Name_TextBox.Text.Trim()=="")
            {
                MessageBox.Show("请输入密码？","Tips",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if(Login_Class.Check_SQL(sql) == 0)
            {
                MessageBox.Show("用户名或者密码错误！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Login_Class.Check_SQL(sql) == 1)
            {
                this.Hide();
                Form Diary_Main = new Diary_Main();
                Diary_Main.ShowDialog();
                this.Close();
            }
        }
    }
}

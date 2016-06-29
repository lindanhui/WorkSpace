using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary_Mei
{
    public partial class Login : Form
    {
        Class_SQL_Deal Login_SQL = new Class_SQL_Deal();//建立数据库连接类
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
            #region 打开数据库链接
            try
            {
                Class_SQL_Deal.Open_Connection();
            }
            catch
            {
                MessageBox.Show("数据库链接异常，请联系管理员！");
            }
            #endregion
            String SQL = "Select * FROM Login_Table WHERE Login_Password = '"+Name_TextBox.Text.Trim()+"'";
            if(Name_TextBox.Text.Trim()=="")
            {
                MessageBox.Show("Where Is The Password？","Tips",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if(Class_SQL_Deal.Check_SQL(SQL) == 0)
            {
                MessageBox.Show("Could Think Of Me！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Class_SQL_Deal.Check_SQL(SQL) == 1)
            {
                this.Hide();
                Form Diary_Main = new Diary_Main();
                Diary_Main.ShowDialog();
                this.Close();
            }
            Class_SQL_Deal.Close_Connection();
        }
    }
}

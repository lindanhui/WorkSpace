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
    public partial class Diary_Main : Form
    {
        int StartRows = 0;
        int PrintRows = 10;
        int JudgeElse = 0;
        int Now_Pages = 1;
        int All_Pages = 0;
        int All_Rows = 0;
        private static String Windows_State = String.Empty;
        private static string TableName = "Archive_Table";
        string SQL_Query = "SELECT Real_Name, Phone, Address, Now_Company FROM Archive_Table WHERE ";
        string Count_Where = string.Empty;
        public Diary_Main()
        {
            InitializeComponent();
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {

        }

        private void Button_Submit_Click(object sender, EventArgs e)
        {

        }

        private void Diary_Password_Click(object sender, EventArgs e)
        {
            Form Diary_Password = new Diary_Change_Password();
            Diary_Password.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void Button_Add_Click(object sender, EventArgs e)
        //{

        //}

        private void Diary_Main_Load(object sender, EventArgs e)
        {
            Class_State.Windows_State = String.Empty;//重置静态变量
            Timer_Print_Date.Start();
        }

        private void Button_Client_Click(object sender, EventArgs e)
        {
            this.Text = "客户档案";
            Class_State.Windows_State = "Archive";
            Panel_Welcome.Visible = false;
            Panel_Client_Friend.Visible = true;

        }

        private void Button_Friend_Click(object sender, EventArgs e)
        {
            this.Text = "朋友档案";
            Class_State.Windows_State = "Friend";
            Panel_Welcome.Visible = false;
            Panel_Client_Friend.Visible = true;
        }

        private void Button_Diary_Click(object sender, EventArgs e)
        {
            this.Text = "日记本";
            Class_State.Windows_State = "Diary";
        }

        private void Button_Record_Click(object sender, EventArgs e)
        {
            this.Text = "录音";
            Class_State.Windows_State = "Record";
        }

        private void Button_Picture_Click(object sender, EventArgs e)
        {
            this.Text = "图片";
            Class_State.Windows_State = "Picture";
        }

        private void Timer_Print_Date_Tick(object sender, EventArgs e)
        {
            Label_Date.Text = "Today Is " + DateTime.Now.ToString() + " !";
        }

        //private void Button_Editor_Click(object sender, EventArgs e)
        //{
        //    State_Class.Editor_State = "Editor";
        //}

        //private void Button_Delete_Click(object sender, EventArgs e)
        //{

        //}

        private void Button_Add_Click(object sender, EventArgs e)
        {
            Class_State.Editor_State = "Add";
            //MessageBox.Show(State_Class.Windows_State);
            //MessageBox.Show(State_Class.Editor_State);
            Form Editor_Contact = new Editor_Contact();
            Editor_Contact.ShowDialog();
        }
        //



        /// <summary>
        /// 查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Search_Click(object sender, EventArgs e)
        {
            //
            SQL_Query = "SELECT Real_Name, Phone, Address, Now_Company FROM Archive_Table WHERE ";
            #region 全部查询的时候触发的SQL

            if (ComboBox_Type.SelectedItem.ToString() == "全部查询")
            {
                switch (Class_State.Windows_State)
                {
                    case "Friend":
                        if (ComboBox_Level.SelectedItem.ToString() == "All")
                        {
                            SQL_Query += "Archive_Type = 'Friend' ";
                            Count_Where = " Archive_Type = 'Friend' ";
                        }
                        else
                        {
                            SQL_Query += " Archive_Type = 'Friend'  AND Level_Type = '" + ComboBox_Level.SelectedItem.ToString() + "'";
                            Count_Where = " Archive_Type = 'Friend'  AND Level_Type = '" + ComboBox_Type.SelectedItem.ToString() + "'";
                        }
                        break;
                    case "Archive":
                        if (ComboBox_Level.SelectedItem.ToString() == "All")
                        {
                            SQL_Query += " Archive_Type = 'Archive' ";
                            Count_Where = " Archive_Type = 'Archive' ";
                        }
                        else
                        {
                            SQL_Query += " Archive_Type = 'Archive'  AND Level_Type = '" + ComboBox_Level.SelectedItem.ToString() + "'";
                            Count_Where = " Archive_Type = 'Archive'  AND Level_Type = '" + ComboBox_Level.SelectedItem.ToString() + "'";
                        }
                        break;
                }
                //MessageBox.Show(SQL_Query);
            }

            #endregion
            //          
            #region 当不为全部查询的时候触发SQL

            else
            {
                switch (Class_State.Windows_State)
                {
                    case "Friend":
                        if (Class_State.Combox_Field(ComboBox_Type).ToString() == "Birth")
                        {
                            if (ComboBox_Level.SelectedItem.ToString() == "All")
                            {
                                SQL_Query += " Archive_Type = 'Friend' AND " + Class_State.Combox_Field(ComboBox_Type).ToString() + " = '" + BirthTimePicker.Value.ToShortDateString() + "'";
                                Count_Where = " Archive_Type = 'Friend'  AND " + Class_State.Combox_Field(ComboBox_Type).ToString() + " = '" + BirthTimePicker.Value.ToShortDateString() + "'";
                            }
                            else
                            {
                                SQL_Query += " Archive_Type = 'Friend' AND Level_Type = '" + ComboBox_Level.SelectedItem.ToString() + "' AND " + Class_State.Combox_Field(ComboBox_Type).ToString() + " = '" + BirthTimePicker.Value.ToShortDateString() + "'";
                                Count_Where = " Archive_Type = 'Friend' AND Level_Type = " + ComboBox_Level.SelectedItem.ToString() + " AND " + Class_State.Combox_Field(ComboBox_Type).ToString() + " = '" + BirthTimePicker.Value.ToShortDateString() + "'";
                            }
                        }
                        else
                        {
                            if (ComboBox_Level.SelectedItem.ToString() == "All")
                            {
                                SQL_Query += " Archive_Type = 'Friend' AND " + Class_State.Combox_Field(ComboBox_Type).ToString() + " LIKE '%" + TextBox_Keyword.Text.Trim() + "%'";
                                Count_Where = " Archive_Type = 'Friend' AND " + Class_State.Combox_Field(ComboBox_Type).ToString() + " LIKE '%" + TextBox_Keyword.Text.Trim() + "%'";
                            }
                            else
                            {
                                SQL_Query += " Archive_Type = 'Friend' AND Level_Type = '" + ComboBox_Level.SelectedItem.ToString() + "' AND " + Class_State.Combox_Field(ComboBox_Type).ToString() + " LIKE '%" + TextBox_Keyword.Text.Trim() + "%'";
                                Count_Where = " Archive_Type = 'Friend' AND Level_Type = '" + ComboBox_Level.SelectedItem.ToString() + "' AND " + Class_State.Combox_Field(ComboBox_Type).ToString() + " LIKE '%" + TextBox_Keyword.Text.Trim() + "%'";
                            }
                        }
                        break;
                    case "Archive":
                        if (Class_State.Combox_Field(ComboBox_Type).ToString() == "Birth")
                        {
                            if (ComboBox_Level.SelectedItem.ToString() == "All")
                            {
                                SQL_Query += " Archive_Type = 'Archive' AND " + Class_State.Combox_Field(ComboBox_Type).ToString() + " = '" + BirthTimePicker.Value.ToShortDateString() + "'";
                                Count_Where = " Archive_Type = 'Archive' AND " + Class_State.Combox_Field(ComboBox_Type).ToString() + " = '" + BirthTimePicker.Value.ToShortDateString() + "'";
                            }
                            else
                            {
                                SQL_Query += " Archive_Type = 'Archive' AND Level_Type = '" + ComboBox_Level.SelectedItem.ToString() + "' AND " + Class_State.Combox_Field(ComboBox_Type).ToString() + " = '" + BirthTimePicker.Value.ToShortDateString() + "'";
                                Count_Where = " Archive_Type = 'Archive' AND Level_Type = " + ComboBox_Level.SelectedItem.ToString() + " AND " + Class_State.Combox_Field(ComboBox_Type).ToString() + " = '" + BirthTimePicker.Value.ToShortDateString() + "'";
                            }
                        }
                        else
                        {
                            if (ComboBox_Level.SelectedItem.ToString() == "All")
                            {
                                SQL_Query += " Archive_Type = 'Archive' AND " + Class_State.Combox_Field(ComboBox_Type).ToString() + " LIKE '%" + TextBox_Keyword.Text.Trim() + "%'";
                                Count_Where = " Archive_Type = 'Archive' AND " + Class_State.Combox_Field(ComboBox_Type).ToString() + " LIKE '%" + TextBox_Keyword.Text.Trim() + "%'";
                            }
                            else
                            {
                                SQL_Query += " Archive_Type = 'Archive' AND Level_Type = '" + ComboBox_Level.SelectedItem.ToString() + "' AND " + Class_State.Combox_Field(ComboBox_Type).ToString() + " LIKE '%" + TextBox_Keyword.Text.Trim() + "%'";
                                Count_Where = " Archive_Type = 'Archive' AND Level_Type = '" + ComboBox_Level.SelectedItem.ToString() + "' AND " + Class_State.Combox_Field(ComboBox_Type).ToString() + " LIKE '%" + TextBox_Keyword.Text.Trim() + "%'";//like '%" + SearchContent + "%'
                            }
                        }
                        break;
                }
            }

            #endregion

            //

            PrintDatas(dataGridView_Archive_Print, Count_Where, SQL_Query, TableName);


        }

        #region 当按查询是对数据库进行查询操作
        /// <summary>
        /// 查询Tables
        /// </summary>
        private void PrintDatas(DataGridView Get_DataGridView, string AllRows_SQL, string Query_SQL, string TableName)
        {
            Set_Page_Button(0);
            Class_SQL_Deal.Open_Connection();
            //
            All_Rows = Class_SQL_Deal.Query_AllRows("Archive_Table", AllRows_SQL);
            //
            if (All_Rows == 0)//只有一页
            {
                Get_DataGridView.DataSource = null;
                TSLPagesPrint.Text = "0";
                return;
            }
            else if (All_Rows > 0 && All_Rows <= PrintRows)
            {
                Get_DataGridView.DataSource = Class_SQL_Deal.DataTable_Query(Query_SQL, TableName, StartRows, PrintRows);
                TSLPagesPrint.Text = "1";
                return;
            }
            else
            {
                JudgeElse = All_Rows % PrintRows;//整页
                if (JudgeElse == 0)
                {
                    Set_Page_Button(1);
                    All_Pages = All_Rows / PrintRows;
                    Get_DataGridView.DataSource = Class_SQL_Deal.DataTable_Query(Query_SQL, TableName, StartRows, PrintRows);
                    TSLPagesPrint.Text = Convert.ToString(All_Pages);
                }
                else//一页半的情况
                {
                    Set_Page_Button(1);
                    All_Pages = All_Rows / PrintRows + 1;
                    Get_DataGridView.DataSource = Class_SQL_Deal.DataTable_Query(Query_SQL, TableName, StartRows, PrintRows);
                    TSLPagesPrint.Text = Convert.ToString(All_Pages);
                }
            }
        }


        #endregion




        private void Button_Editor_Click(object sender, EventArgs e)
        {
            Class_State.Editor_State = "Editor";
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            Class_State.Editor_State = "Delete";
        }

        private void button_Clear_Click_1(object sender, EventArgs e)
        {
            ComboBox_Level.Text = "All";
            ComboBox_Type.Text = "全部查询";
            TextBox_Keyword.Text = string.Empty;
            BirthTimePicker.Text = DateTime.Now.ToShortDateString();
        }

        private void TSBFirstPage_Click(object sender, EventArgs e)
        {
            dataGridView_Archive_Print.DataSource = Class_SQL_Deal.DataTable_Query(SQL_Query, TableName, 0, PrintRows);
            StartRows = 0;
            Now_Pages = 1;
        }

        private void TSBPreviousPage_Click(object sender, EventArgs e)
        {
            if(Now_Pages > 1)
            {
                Now_Pages--;
                StartRows -= PrintRows;
                dataGridView_Archive_Print.DataSource = Class_SQL_Deal.DataTable_Query(SQL_Query, TableName, StartRows, PrintRows);
            }
        }

        private void TSBNextPage_Click(object sender, EventArgs e)
        {
            if(Now_Pages < All_Pages)
            {
                Now_Pages++;
                StartRows += PrintRows;
                dataGridView_Archive_Print.DataSource = Class_SQL_Deal.DataTable_Query(SQL_Query, TableName, StartRows, PrintRows);
            }
        }

        private void TSBLastPage_Click(object sender, EventArgs e)
        {
            if(All_Pages > 0)
            {
                Now_Pages = All_Pages;
                StartRows = (All_Pages - 1) * PrintRows;
                dataGridView_Archive_Print.DataSource = Class_SQL_Deal.DataTable_Query(SQL_Query, TableName, StartRows, PrintRows);
            }
        }




        #region 设定分页安妮的可操作性
        /// <summary>
        /// 设定分页按钮的可操作性 0为关闭， 1为打开
        /// </summary>
        /// <param name="Set_Value"></param>
        private void Set_Page_Button(int Set_Value)
        {
            if(Set_Value == 1)
            {
                Class_Control_Deal.Set_Button_True(TSBFirstPage);
                Class_Control_Deal.Set_Button_True(TSBNextPage);
                Class_Control_Deal.Set_Button_True(TSBPreviousPage);
                Class_Control_Deal.Set_Button_True(TSBLastPage);
            }
            if(Set_Value == 0)
            {
                Class_Control_Deal.Set_Button_False(TSBFirstPage);
                Class_Control_Deal.Set_Button_False(TSBNextPage);
                Class_Control_Deal.Set_Button_False(TSBPreviousPage);
                Class_Control_Deal.Set_Button_False(TSBLastPage);
            }
        }

        #endregion

    }
}

﻿using System;
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
        int Get_RowClick = -1;
        private static String Windows_State = String.Empty;
        private static string TableName = "Archive_Table";
        string SQL_Query = "SELECT Real_Name, Phone, Address, Now_Company FROM Archive_Table WHERE ";
        string Count_Where = string.Empty;
        public Diary_Main()
        {
            InitializeComponent();
        }
        private void Choose_Panel(string Panel_Type)
        {
            switch (Panel_Type)
            {
                case "Archive":
                    Panel_Client_Friend.Visible = true;
                    panel_Diary.Visible = false;
                    Panel_Welcome.Visible = false;
                    break;
                case "Friend":
                    Panel_Client_Friend.Visible = true;
                    panel_Diary.Visible = false;
                    panel_Record.Visible = false;
                    break;
                case "Diary":
                    panel_Diary.Visible = true;
                    Panel_Client_Friend.Visible = false;
                    panel_Record.Visible = false;
                    break;
                case "Record":
                    panel_Record.Visible = true;
                    panel_Diary.Visible = false;
                    Panel_Client_Friend.Visible = false;
                    break;
                case "Picture":
                    break;
            }
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
            label_Visit_Count.Text = Get_Visit_Count() + " 人";
            label_Birth_Count.Text = Convert.ToString(Class_SQL_Deal.Query_AllRows("Archive_Table", " DateDiff('d', DATE(), Birth) > 31")) + " 人";
        }

        private void Button_Client_Click(object sender, EventArgs e)
        {
            this.Text = "客户档案";
            Class_State.Windows_State = "Archive";
            Choose_Panel("Archive");
            dataGridView_Archive_Print.DataSource = null;
            Get_RowClick = -1;

        }

        private void Button_Friend_Click(object sender, EventArgs e)
        {
            this.Text = "朋友档案";
            Class_State.Windows_State = "Friend";
            Choose_Panel("Friend");
            dataGridView_Archive_Print.DataSource = null;
            Get_RowClick = -1;

        }

        private void Button_Diary_Click(object sender, EventArgs e)
        {
            this.Text = "日记本";
            Class_State.Windows_State = "Diary";
            Choose_Panel("Diary");
        }

        private void Button_Record_Click(object sender, EventArgs e)
        {
            this.Text = "录音";
            Class_State.Windows_State = "Record";
            Choose_Panel("Record");
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
            StartRows = 0;
            JudgeElse = 0;
            Now_Pages = 1;
            All_Pages = 0;
            All_Rows = 0;
            Get_RowClick = -1;
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
            Get_DataGridView.DataSource = null;
            //
            Get_DataGridView.Columns.Clear();
            Get_DataGridView.Rows.Clear();
            //
            All_Rows = Class_SQL_Deal.Query_AllRows("Archive_Table", AllRows_SQL);
            //
            if (All_Rows == 0)//只有一页
            {

                #region 查不到信息时提示信息

                Get_DataGridView.Columns.Add("Message", "");
                Get_DataGridView.Rows.Add("亲，查询不到信息哦！");

                #endregion

                TSLPagesPrint.Text = "0";

                TStripLabel_Count.Text = "0";

                return;
            }
            else if (All_Rows > 0 && All_Rows <= PrintRows)
            {
                Get_DataGridView.DataSource = Class_SQL_Deal.DataTable_Query(Query_SQL, TableName, StartRows, PrintRows);
                TSLPagesPrint.Text = "1";
                TStripLabel_Count.Text = Convert.ToString(Now_Pages);
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
                    TStripLabel_Count.Text = Convert.ToString(Now_Pages);
                }
                else//一页半的情况
                {
                    Set_Page_Button(1);
                    All_Pages = All_Rows / PrintRows + 1;
                    Get_DataGridView.DataSource = Class_SQL_Deal.DataTable_Query(Query_SQL, TableName, StartRows, PrintRows);
                    TSLPagesPrint.Text = Convert.ToString(All_Pages);
                    TStripLabel_Count.Text = Convert.ToString(Now_Pages);
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
            if(Get_RowClick == -1)
            {
                MessageBox.Show("请选择您要删除联系人！","Tips", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("您即将删除联系人"+Class_State.Get_Name+"，删除请点击确认！", "Tips", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    //AND Phone = '" + Class_State.Get_Phone + "'
                    string SQL_Delete = "Delete * FROM Archive_Table WHERE Real_Name = '" + Class_State.Get_Name + "'  AND Archive_Type = '" + Class_State.Windows_State + "' ";
                    string SQL_Delete_Visit = "Delete * FROM Visit_Table WHERE  Real_Name = '" + Class_State.Get_Name + "'  AND  Visit_Type = '" + Class_State.Windows_State + "' ";
                    if(Class_State.Get_Phone != "")
                    {
                        SQL_Delete += " AND Phone = '" + Class_State.Get_Phone + "'";
                        SQL_Delete_Visit += " AND Phone = '" + Class_State.Get_Phone + "'";
                    }
                    Class_SQL_Deal.Delete_SQL(SQL_Delete_Visit);
                    Class_SQL_Deal.Delete_SQL(SQL_Delete);
                    Button_Search_Click(null,null);
                }

            }
        }

        private void button_Clear_Click_1(object sender, EventArgs e)
        {
            ComboBox_Level.Text = "All";
            ComboBox_Type.Text = "全部查询";
            TextBox_Keyword.Text = string.Empty;
            BirthTimePicker.Text = DateTime.Now.ToShortDateString();
            Set_Page_Button(0);                              //关闭分页按钮
            TSLPagesPrint.Text = "0";                        //将总页数置0
            dataGridView_Archive_Print.DataSource = null;    //清空DataSource
            TStripLabel_Count.Text = "0";
        }

        private void TSBFirstPage_Click(object sender, EventArgs e)
        {
            dataGridView_Archive_Print.DataSource = Class_SQL_Deal.DataTable_Query(SQL_Query, TableName, 0, PrintRows);
            StartRows = 0;
            Now_Pages = 1;
            Get_RowClick = -1;
            TStripLabel_Count.Text = Convert.ToString(Now_Pages);
        }

        private void TSBPreviousPage_Click(object sender, EventArgs e)
        {
            if (Now_Pages > 1)
            {
                Get_RowClick = -1;
                Now_Pages--;
                StartRows -= PrintRows;
                dataGridView_Archive_Print.DataSource = Class_SQL_Deal.DataTable_Query(SQL_Query, TableName, StartRows, PrintRows);
                TStripLabel_Count.Text = Convert.ToString(Now_Pages);
            }
        }

        private void TSBNextPage_Click(object sender, EventArgs e)
        {
            if (Now_Pages < All_Pages)
            {
                Get_RowClick = -1;
                Now_Pages++;
                StartRows += PrintRows;
                dataGridView_Archive_Print.DataSource = Class_SQL_Deal.DataTable_Query(SQL_Query, TableName, StartRows, PrintRows);
                TStripLabel_Count.Text = Convert.ToString(Now_Pages);
            }
        }

        private void TSBLastPage_Click(object sender, EventArgs e)
        {
            if (All_Pages > 0)
            {
                Get_RowClick = -1;
                Now_Pages = All_Pages;
                StartRows = (All_Pages - 1) * PrintRows;
                dataGridView_Archive_Print.DataSource = Class_SQL_Deal.DataTable_Query(SQL_Query, TableName, StartRows, PrintRows);
                TStripLabel_Count.Text = Convert.ToString(Now_Pages);
            }
        }




        #region 设定分页安妮的可操作性
        /// <summary>
        /// 设定分页按钮的可操作性 0为关闭， 1为打开
        /// </summary>
        /// <param name="Set_Value"></param>
        private void Set_Page_Button(int Set_Value)
        {
            if (Set_Value == 1)
            {
                Class_Control_Deal.Set_Button_True(TSBFirstPage);
                Class_Control_Deal.Set_Button_True(TSBNextPage);
                Class_Control_Deal.Set_Button_True(TSBPreviousPage);
                Class_Control_Deal.Set_Button_True(TSBLastPage);
            }
            if (Set_Value == 0)
            {
                Class_Control_Deal.Set_Button_False(TSBFirstPage);
                Class_Control_Deal.Set_Button_False(TSBNextPage);
                Class_Control_Deal.Set_Button_False(TSBPreviousPage);
                Class_Control_Deal.Set_Button_False(TSBLastPage);
            }
        }

        #endregion

        private void dataGridView_Archive_Print_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView_Archive_Print.DataSource != null)
            {
                Get_RowClick = dataGridView_Archive_Print.CurrentCell.RowIndex;
                Class_State.Get_Name = dataGridView_Archive_Print.Rows[Get_RowClick].Cells[0].Value.ToString();
                Class_State.Get_Phone = dataGridView_Archive_Print.Rows[Get_RowClick].Cells[1].Value.ToString();
            }
        }

        private void Button_Export_Click(object sender, EventArgs e)
        {
            if (dataGridView_Archive_Print.DataSource == null)
            {
                MessageBox.Show("请查询出您要导出的数据！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SaveFileDialog Export_Dialog = new SaveFileDialog();
                Export_Dialog.Filter = "*.xls(Excel表格文件)|*.xls";
                string Get_Date = "(" + DateTime.Now.ToShortDateString().Replace("/", "-") + ")";
                Export_Dialog.FileName = "联系人信息" + Get_Date;
                if(Export_Dialog.ShowDialog() == DialogResult.OK)
                {
                    if (System.IO.File.Exists(Export_Dialog.FileName))
                    {
                        if (MessageBox.Show("您即将覆盖原有EXCEL表格，若覆盖，请点击确认！", "Tips", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            System.IO.File.Delete(Export_Dialog.FileName);//如果文件存在删除文件。 
                        }
                        else
                        {
                            return ;
                        }
                        //              
                    }
                        string Export_Where = SQL_Query.Replace("SELECT Real_Name, Phone, Address, Now_Company FROM Archive_Table WHERE ", string.Empty);
                        //MessageBox.Show(SQL_Query);
                        //
                        string Export_SQL = string.Empty;
                        //
                        Export_SQL += "SELECT top 65535 Real_Name AS 姓名, Phone AS 电话, Address AS 住址, Now_Company AS 现任公司, Passed_Company AS 曾任公司, Skills AS 技能, Birth AS 出生日期, ";
                        Export_SQL += "Qualifications AS 学历, Graduate_School AS 毕业学校, Skilled_Sport AS 擅长的运动, Marriage_State AS 婚姻状态, Spouse_Name AS 配偶姓名, ";
                        Export_SQL += "Now_Work AS 现任职务, Passed_Work AS 曾任职务, Now_Live AS 现居住地, ";
                        Export_SQL += "Spouse_Birth AS 配偶生日, Father_Name AS 父亲姓名, Father_Birth AS 父亲生日, Monther_Name AS 母亲姓名, Monther_Birth AS 母亲生日, Sister_Brother_State AS 兄弟姐妹情况, ";
                        Export_SQL += "Son_Daughter_State AS 儿女情况, Best_Friend AS 最好的朋友, Long_Carrer AS 长期事业目标, Short_Carrer AS 短期事业目标, Like_Dish AS 喜欢的菜系, Like_Travel AS 喜欢的旅游, ";
                        Export_SQL += "Like_Sport AS 喜欢的运动, Like_Car AS 喜欢的汽车, Like_Topic AS 喜欢的话题, Is_Train AS 是否参加培训, Like_Lecturer AS 喜欢的讲师, Is_Reader AS 是否有阅读习惯, ";
                        Export_SQL += "Like_Book_Type AS 喜欢的书籍类型, Is_Movie AS 是否有看电影的习惯, Like_Movie_Type AS 喜欢的电影类型, Like_Friend_Type AS 喜欢的朋友类型, The_3_Effect_People AS 影响最大的三个人, ";
                        Export_SQL += "Pride_Thing AS 最为骄傲的事情, Level_Type AS 类别属性, Notes AS 备注 ";
                        Export_SQL += "into   [Excel 8.0;database=" + Export_Dialog.FileName + "].[Real_Name] from Archive_Table Where ";//  into   [Excel 8.0;database=" + ExportSFDialog.FileName + "].[ReaderID] from ReaderTable";
                        Export_SQL += Export_Where;
                        if (Class_SQL_Deal.Export_EXCEL(Export_SQL) != 0)
                        {
                            MessageBox.Show("成功导出联系人信息！","Tips", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                }
            }
        }
        //
        private string Get_Visit_Count()
        {
            //string SQL_Count = "SELECT * FROM Visit_Table WHERE DATE() > Visit_Date";
            return Convert.ToString(Class_SQL_Deal.Query_AllRows("Visit_Table", "DATE() < Visit_Date"));
        }

        //
        private void button_Invite_Click(object sender, EventArgs e)
        {
            if(Get_RowClick == -1)
            {
                MessageBox.Show("请选择您要访问的人！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Form Visit = new Visit_Form();
                Visit.ShowDialog();
            }
        }

        private void label_Check_Click(object sender, EventArgs e)
        {
            Form Get_VisitInfo = new VisitInfo_Form();
            Get_VisitInfo.ShowDialog();
        }

        private void label_Check_MouseEnter(object sender, EventArgs e)
        {
            this.label_Check.ForeColor = System.Drawing.Color.Black;
        }

        private void label_Check_MouseLeave(object sender, EventArgs e)
        {
            this.label_Check.ForeColor = System.Drawing.Color.Silver;
        }

        private void label_Birth_Check_Click(object sender, EventArgs e)
        {
            Form Birth = new Birth_Form();
            Birth.ShowDialog();
        }

        private void label_Birth_Check_MouseEnter(object sender, EventArgs e)
        {
            this.label_Birth_Check.ForeColor = System.Drawing.Color.Black;
        }

        private void label_Birth_Check_MouseLeave(object sender, EventArgs e)
        {
            this.label_Birth_Check.ForeColor = System.Drawing.Color.Silver;
        }

        private void dataGridView_Archive_Print_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView_Archive_Print.DataSource != null)
            {
                Form Edit = new Edit_Form();
                Edit.ShowDialog();
                Button_Search_Click(null, null);
            }
        }

        private void button_View_Click(object sender, EventArgs e)
        {
            if(richTextBox_Diary.Text != "")
            {
                if (MessageBox.Show("您还有未保存的日记，若跳转请点击确认！", "Tips", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    groupBox_Title.Visible = false;
                    richTextBox_Diary.Visible = false;
                    groupBox_View.Visible = true;
                    dataGridView_Diary.Visible = true;
                    dataGridView_Diary.DataSource = Class_SQL_Deal.DataTable_Get("SELECT  Diary_Title,Diary_Text, Diary_Date FROM Diary_Table ");//加载日记数据
                }
            }
            else
            {
                groupBox_Title.Visible = false;
                richTextBox_Diary.Visible = false;
                groupBox_View.Visible = true;
                dataGridView_Diary.Visible = true;
                dataGridView_Diary.DataSource = Class_SQL_Deal.DataTable_Get("SELECT  Diary_Title,Diary_Text, Diary_Date FROM Diary_Table ");//加载日记数据

            }
        }

        private void button_ReturnEdit_Click(object sender, EventArgs e)
        {
            groupBox_Title.Visible = true;
            richTextBox_Diary.Visible = true;
            groupBox_View.Visible = false;
            dataGridView_Diary.Visible = false;
        }

        private void button_ClearText_Click(object sender, EventArgs e)
        {
            if(richTextBox_Diary.Text != string.Empty || textBox_Title.Text != string.Empty)
            {
                if (MessageBox.Show("您即将清空编辑内容，若清空请点击确认！", "Tips", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    richTextBox_Diary.Text = string.Empty;
                    textBox_Title.Text = string.Empty;
                }
            }
        }

        private void button_SaveDiary_Click(object sender, EventArgs e)
        {
            if(richTextBox_Diary.Text==string.Empty&&textBox_Title.Text==string.Empty)
            {
                MessageBox.Show("请编辑您要保存的日记！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string SQL_Insert = string.Empty;
                SQL_Insert += "INSERT INTO Diary_Table (Diary_Title, Diary_Text, Diary_Date)  VALUES ";
                SQL_Insert += "('"+textBox_Title.Text+"', '"+richTextBox_Diary.Text+"', '"+dateTimePicker_Diary.Value.ToShortDateString()+"')";
                if(Class_SQL_Deal.Insert_SQL(SQL_Insert) == 1)
                {
                    MessageBox.Show("保存成功！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_Title.Text = string.Empty;
                    richTextBox_Diary.Text = string.Empty;
                }
            }
        }

        private void button_SearchDiary_Click(object sender, EventArgs e)
        {
            string SQL_Query_Diary = string.Empty;
            SQL_Query_Diary = "SELECT  Diary_Title,Diary_Text, Diary_Date FROM Diary_Table ";
            SQL_Query_Diary += "WHERE Diary_Date BETWEEN #"+dateTimePicker_StartTime.Value.ToShortDateString()+"# AND #"+dateTimePicker_EndTime.Value.ToShortDateString()+"#";
            dataGridView_Diary.DataSource = Class_SQL_Deal.DataTable_Get(SQL_Query_Diary);
            
        }

        private void dataGridView_Diary_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Class_State.Get_DiaryTitle = dataGridView_Diary.Rows[dataGridView_Diary.CurrentCell.RowIndex].Cells[0].Value.ToString();
            Class_State.Get_DiaryContent = dataGridView_Diary.Rows[dataGridView_Diary.CurrentCell.RowIndex].Cells[1].Value.ToString();
            Form View_Diary = new View_Diary();
            View_Diary.ShowDialog();
            Class_State.Get_DiaryContent = string.Empty;
            //Class_State.Get_DiaryTitle = string.Empty;
        }
    }
}

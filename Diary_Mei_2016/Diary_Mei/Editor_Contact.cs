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
    public partial class Editor_Contact : Form
    {
        String Archive_Type = String.Empty;
        private void Clear_Text_Form(Control The_Control)//清除窗体所有文本框内容
        {
            foreach (Control Text_Box in The_Control.Controls)
            {
                if (Text_Box is TextBox)
                {
                    Text_Box.Text = "";
                }
            }
            foreach (Control Rich_Text in The_Control.Controls)
            {
                if(Rich_Text is RichTextBox)
                {
                    Rich_Text.Text = "";
                }
            }
        }

        private void Clear_Text_Box(GroupBox The_Control)//清除GroupBox所有文本框内容
        {
            foreach (Control Text_Box in The_Control.Controls)
            {
                if (Text_Box is TextBox)
                {
                    Text_Box.Text = "";
                }
            }
            foreach (Control Rich_Text in The_Control.Controls)
            {
                if (Rich_Text is RichTextBox)
                {
                    Rich_Text.Text = "";
                }
            }
        }




        public Editor_Contact()
        {
            InitializeComponent();
        }

        private void Panel_Client_Add_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            Clear_Text_Box(groupBox_Family);
            Clear_Text_Box(groupBox_Hobby);
            Clear_Text_Box(groupBox_PersonalInfo);
            Clear_Text_Box(groupBox_Profession);
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            if(Class_Control_Deal.Check_TextBox_Null(textBox_Name) == 0)
            {
                MessageBox.Show("姓名不能为空！","Tips",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                #region 数据库添加操作
                Class_SQL_Deal.Open_Connection();
                //
                String SQL_Checked = String.Empty;
                SQL_Checked += "Select * From Archive_Table Where Real_Name = '" + textBox_Name.Text.Trim() + "' AND Archive_Type = '" + Archive_Type + "'  AND Phone = '" + textBox_Phone.Text.Trim() + "'";
                //
                if (Class_SQL_Deal.Check_SQL(SQL_Checked) == 1)
                {
                    MessageBox.Show("您要存入的记录已经存在，无法添加！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SQL_Checked = String.Empty;
                }
                else
                {

                    String SQL_Insert = String.Empty;
                    SQL_Insert += "INSERT INTO Archive_Table ";
                    SQL_Insert += " (Real_Name, Phone, Address, Now_Company, Passed_Company, Skills, Birth, Qualifications, Graduate_School, Skilled_Sport, Marriage_State, Spouse_Name, Spouse_Birth, Father_Name, Father_Birth, Monther_Name, Monther_Birth, Sister_Brother_State, Son_Daughter_State, Best_Friend, Long_Carrer, Short_Carrer, Like_Dish, Like_Travel, Like_Sport, Like_Car, Like_Topic, Is_Train, Like_Lecturer, Is_Reader, Like_Book_Type, Is_Movie, Like_Movie_Type, Like_Friend_Type, The_3_Effect_People, Pride_Thing, Level_Type, Notes, Archive_Type, Now_Work, Passed_Work, Now_Live)";
                    SQL_Insert += " VALUES ('" + textBox_Name.Text.Trim() + "', '" + textBox_Phone.Text.Trim() + "', '" + textBox_Home_Address.Text.Trim() + "', '" + textBox_Now_Company.Text.Trim() + "', '" + textBox_Passed_Company.Text.Trim() + "', '" + textBox_Skills.Text.Trim() + "', '" + dateTimePicker_Birth.Value.ToShortDateString() + "', '" + textBox_Qualifications.Text.Trim() + "', '" + textBox_Graduate_School.Text.Trim() + "', '" + textBox_Good_Sports.Text.Trim() + "', '" + textBox_Marriage_State.Text.Trim() + "', '" + textBox_Spouse_Name.Text.Trim() + "', '" + dateTimePicker_Spouse.Value.ToShortDateString() + "', '" + textBox_Father_Name.Text.Trim() + "','" + dateTimePicker_Farther.Value.ToShortDateString() + "', '" + textBox_Mother_Name.Text.Trim() + "', '" + dateTimePicker_Monther.Value.ToShortDateString() + "', '" + richTextBox_Sister_Brother_State.Text.Trim() + "', '" + richTextBox_Son_Daughter_State.Text.Trim() + "', '" + textBox_Best_Friend.Text.Trim() + "', '" + richTextBox_Long_Carrer.Text.Trim() + "', '" + richTextBox_Short_Carrer.Text.Trim() + "', '" + textBox_Like_Dish.Text.Trim() + "', '" + textBox_Like_Travel.Text.Trim() + "', '" + textBox_Like_Sports.Text.Trim() + "', '" + textBox_Like_Car.Text.Trim() + "', '" + textBox_Like_Topic.Text.Trim() + "', '" + textBox_Is_Train.Text.Trim() + "', '" + textBox_Like_Teacher.Text.Trim() + "', '" + textBox_Is_Reading.Text.Trim() + "', '" + textBox_Like_Booktype.Text.Trim() + "', '" + textBox_Is_Movie.Text.Trim() + "', '" + textBox_Like_Movie.Text.Trim() + "', '" + textBox_Like_Friendtype.Text.Trim() + "', '" + textBox_Effect_People.Text.Trim() + "', '" + textBox_Pride_Thing.Text.Trim() + "', '" + comboBox_Level_Type.Text.Trim() + "', '" + richTextBox_Notes.Text.Trim() + "', '" + Archive_Type + "', '" + textBox_Now_Work.Text.Trim() + "', '" + textBox_Passed_Work.Text.Trim() + "', '" + textBox_Now_Address.Text.Trim() + "')";
                    if (Class_SQL_Deal.Insert_SQL(SQL_Insert) == 1)
                    {
                        MessageBox.Show("添加记录成功！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    SQL_Insert = String.Empty;
                }
                //
                Class_SQL_Deal.Close_Connection();
                //
                #endregion
            }
        }

        private void Editor_Contact_Load(object sender, EventArgs e)
        {
            #region 读取当前载入状态
            switch (Class_State.Windows_State)
            {
                case "Archive":
                    Archive_Type = "Archive";
                    switch (Class_State.Editor_State)
                    {
                        case "Add":
                            this.Text = "客户信息添加";
                            break;
                        case "Editor":
                            this.Text = "客户信息编辑";
                            break;
                    }
                    break;
                case "Friend":
                    Archive_Type = "Friend";
                    switch (Class_State.Editor_State)
                    {
                        case "Add":
                            this.Text = "朋友信息添加";
                            break;
                        case "Editor":
                            this.Text = "朋友信息编辑";
                            break;
                    }
                    break;
            }
            #endregion
        }
    }
}

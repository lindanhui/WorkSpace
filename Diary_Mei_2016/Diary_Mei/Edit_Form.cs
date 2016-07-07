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
    public partial class Edit_Form : Form
    {
        public Edit_Form()
        {
            InitializeComponent();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_Form_Load(object sender, EventArgs e)
        {
            #region 加载窗体名称
            SetForm_Name();
            #endregion
            //
            string WHERE = " Archive_Type = '" + Class_State.Windows_State + "' AND Real_Name = '" + Class_State.Get_Name + "' AND Phone = '" + Class_State.Get_Phone + "'";
            string TableName = "Archive_Table";
            //
            #region 加载个人信息数据
            textBox_Name.Text = Class_State.Get_Name;
            //
            textBox_Phone.Text = Class_State.Get_Phone;
            //
            textBox_NowLive.Text = Class_SQL_Deal.GetString(WHERE, "Address", TableName);
            //
            textBox_NowCompany.Text = Class_SQL_Deal.GetString(WHERE, "Now_Company", TableName);
            //
            textBox_PassedCompany.Text = Class_SQL_Deal.GetString(WHERE, "Passed_Company", TableName);
            //
            textBox_Skills.Text = Class_SQL_Deal.GetString(WHERE, "Skills", TableName);
            //
            dateTimePicker_Birth.Text = Class_SQL_Deal.GetString(WHERE, "Birth", TableName);
            //
            textBox_Degree.Text = Class_SQL_Deal.GetString(WHERE, "Qualifications", TableName);
            //
            textBox_GraduateSchool.Text = Class_SQL_Deal.GetString(WHERE, "Graduate_School", TableName);
            //
            textBox_GoodSports.Text = Class_SQL_Deal.GetString(WHERE, "Skilled_Sport", TableName);
            //
            textBox_MarryState.Text = Class_SQL_Deal.GetString(WHERE, "Marriage_State", TableName);
            //
            textBox_SpouseName.Text = Class_SQL_Deal.GetString(WHERE, "Spouse_Name", TableName);
            //
            dateTimePicker_SpouseBirth.Text = Class_SQL_Deal.GetString(WHERE, "Spouse_Birth", TableName);
            //
            textBox_FartherName.Text = Class_SQL_Deal.GetString(WHERE, "Father_Name", TableName);
            //
            dateTimePicker_FartherBirth.Text = Class_SQL_Deal.GetString(WHERE, "Father_Birth", TableName);
            //
            textBox_MontherName.Text = Class_SQL_Deal.GetString(WHERE, "Monther_Name", TableName);
            //
            dateTimePicker_MontherBirth.Text = Class_SQL_Deal.GetString(WHERE, "Monther_Birth", TableName);
            //
            richTextBox_BrotherSister.Text = Class_SQL_Deal.GetString(WHERE, "Sister_Brother_State", TableName);
            //
            textBox_SonSister.Text = Class_SQL_Deal.GetString(WHERE, "Son_Daughter_State", TableName);
            //
            richTextBox_BestFriend.Text = Class_SQL_Deal.GetString(WHERE, "Best_Friend", TableName);
            //
            richTextBox_LongCarrer.Text = Class_SQL_Deal.GetString(WHERE, "Long_Carrer", TableName);
            //
            richTextBox_ShortCarrer.Text = Class_SQL_Deal.GetString(WHERE, "Short_Carrer", TableName);
            //
            textBox_LikeDish.Text = Class_SQL_Deal.GetString(WHERE, "Like_Dish", TableName);
            //
            textBox_LikeTravel.Text = Class_SQL_Deal.GetString(WHERE, "Like_Travel", TableName);
            //
            textBox_LikeSport.Text = Class_SQL_Deal.GetString(WHERE, "Like_Sport", TableName);
            //
            textBox_LikeCar.Text = Class_SQL_Deal.GetString(WHERE, "Like_Car", TableName);
            //
            textBox_LikeTopic.Text = Class_SQL_Deal.GetString(WHERE, "Like_Topic", TableName);
            //
            textBox_IsTrained.Text = Class_SQL_Deal.GetString(WHERE, "Is_Train", TableName);
            //
            textBox_LikeTeacher.Text = Class_SQL_Deal.GetString(WHERE, "Like_Lecturer", TableName);
            //
            textBox_IsReader.Text = Class_SQL_Deal.GetString(WHERE, "Is_Reader", TableName);
            //
            textBox_LikeBooks.Text = Class_SQL_Deal.GetString(WHERE, "Like_Book_Type", TableName);
            //
            textBox_IsMovie.Text = Class_SQL_Deal.GetString(WHERE, "Is_Movie", TableName);
            //
            textBox_LikeMovie.Text = Class_SQL_Deal.GetString(WHERE, "Like_Movie_Type", TableName);
            //
            textBox_LikeFriend.Text = Class_SQL_Deal.GetString(WHERE, "Like_Friend_Type", TableName);
            //
            richTextBox_EffectPeople.Text = Class_SQL_Deal.GetString(WHERE, "The_3_Effect_People", TableName);
            //
            richTextBox_PrideThing.Text = Class_SQL_Deal.GetString(WHERE, "Pride_Thing", TableName);
            //
            textBox_Type.Text = Class_SQL_Deal.GetString(WHERE, "Level_Type", TableName);
            //
            richTextBox_Remark.Text = Class_SQL_Deal.GetString(WHERE, "Notes", TableName);
            //
            textBox_NowWork.Text = Class_SQL_Deal.GetString(WHERE, "Now_Work", TableName);
            //
            textBox_PassedWork.Text = Class_SQL_Deal.GetString(WHERE, "Passed_Work", TableName);
            //
            textBox_FamilyAddress.Text = Class_SQL_Deal.GetString(WHERE, "Now_Live", TableName);
            #endregion
        }
        #region 设定窗体名称
        /// <summary>
        /// 设定窗体名称
        /// </summary>
        protected void SetForm_Name()
        {
            this.Text = Class_State.Get_Name + ">信息修改";
        }
        #endregion

        private void textBox_Name_DoubleClick(object sender, EventArgs e)
        {
            Class_Control_Deal.Set_Readonly(textBox_Name);
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            string SQL_Update = string.Empty;
            string WHERE = "WHERE Real_Name = '"+Class_State.Get_Name+ "' AND Level_Type = '"+textBox_Type.Text+ "' AND Archive_Type = '"+Class_State.Windows_State+"'";
            SQL_Update += "UPDATE Archive_Table SET ";
            SQL_Update += " Phone = '"+textBox_Phone.Text+ "' , Address = '"+textBox_NowLive.Text+ "', Now_Company = '"+textBox_NowCompany.Text+"', ";
            SQL_Update += " Passed_Company = '"+textBox_PassedCompany.Text+ "', Skills = '"+textBox_Skills.Text+ "', Birth = '"+dateTimePicker_Birth.Value.ToShortDateString()+"', ";
            SQL_Update += " Qualifications = '"+textBox_Degree.Text+ "', Graduate_School = '"+textBox_GraduateSchool.Text+ "', Skilled_Sport = '"+textBox_GoodSports.Text+"', ";
            SQL_Update += " Marriage_State = '"+textBox_MarryState.Text+ "', Spouse_Name = '"+textBox_SpouseName.Text+ "', Spouse_Birth = '"+dateTimePicker_SpouseBirth.Value.ToShortDateString()+"', ";
            SQL_Update += " Father_Name = '"+textBox_FartherName.Text+ "', Father_Birth = '"+dateTimePicker_FartherBirth.Value.ToShortDateString()+"', ";
            SQL_Update += " Monther_Name = '"+textBox_MontherName.Text+ "', Monther_Birth = '"+dateTimePicker_MontherBirth.Value.ToShortDateString()+"', ";
            SQL_Update += " Sister_Brother_State = '"+richTextBox_BrotherSister.Text+ "', Son_Daughter_State = '"+textBox_SonSister.Text+"', ";
            SQL_Update += " Best_Friend = '"+richTextBox_BestFriend.Text+ "', Long_Carrer = '"+richTextBox_LongCarrer.Text+ "', Short_Carrer = '"+richTextBox_ShortCarrer.Text+"', ";
            SQL_Update += " Like_Dish = '"+textBox_LikeDish.Text+ "', Like_Travel = '"+textBox_LikeTravel.Text+ "', Like_Sport = '"+textBox_LikeTravel.Text+"', ";
            SQL_Update += " Like_Car = '"+textBox_LikeCar.Text+ "', Like_Topic = '"+textBox_LikeTopic.Text+ "', Is_Train = '"+textBox_IsTrained.Text+"', ";
            SQL_Update += " Like_Lecturer = '"+textBox_LikeTeacher.Text+ "', Is_Reader = '"+textBox_IsReader.Text+ "', Like_Book_Type = '"+textBox_LikeBooks.Text+"', ";
            SQL_Update += " Is_Movie = '"+textBox_IsMovie.Text+ "', Like_Movie_Type = '"+textBox_LikeMovie.Text+ "', Like_Friend_Type = '"+textBox_LikeFriend.Text+"', ";
            SQL_Update += " The_3_Effect_People = '"+richTextBox_EffectPeople.Text+ "', Pride_Thing = '"+richTextBox_PrideThing.Text+"', ";
            SQL_Update += " Notes = '"+richTextBox_Remark.Text+ "', Now_Work = '"+textBox_NowWork.Text+ "', Passed_Work = '"+textBox_PassedWork.Text+"', ";
            SQL_Update += " Now_Live = '"+textBox_NowWork.Text+"'";
            if(Class_SQL_Deal.Update_SQL(SQL_Update+WHERE) == 1)
            {
                MessageBox.Show("更新信息成功！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}

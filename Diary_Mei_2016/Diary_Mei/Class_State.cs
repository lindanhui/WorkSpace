using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary_Mei
{
    class Class_State
    {

        #region 系统状态存储
        /// <summary>
        /// 系统状态的存储
        /// </summary>

        public static String Windows_State = String.Empty;//Archive, Friend
        public static String Editor_State = String.Empty;

        #endregion
        //
         
        public static String Combox_Field(ComboBox Combox_Value)
        {
            String Return_String = String.Empty;

            switch (Combox_Value.SelectedItem.ToString())
            {
                case "姓名":
                    Return_String = "Real_Name";
                    break;
                case "家庭住址":
                    Return_String = "Address";
                    break;
                case "现居住地":
                    Return_String = "Now_Live";
                    break;
                case "现任职公司":
                    Return_String = "Now_Company";
                    break;
                case "曾任职公司":
                    Return_String = "Passed_Company";
                    break;
                case "现任职职务":
                    Return_String = "Now_Work";
                    break;
                case "曾任职职务":
                    Return_String = "Passed_Work";
                    break;
                case "技能":
                    Return_String = "Skills";
                    break;
                case "出生日期":
                    Return_String = "Birth";
                    break;
                case "学历":
                    Return_String = "Qualifications";
                    break;
                case "毕业学校":
                    Return_String = "Graduate_School";
                    break;
                case "擅长的运动":
                    Return_String = "Skilled_Sport";
                    break;
                case "婚姻状况":
                    Return_String = "Marriage_State";
                    break;
                case "配偶姓名":
                    Return_String = "Spouse_Name";
                    break;
                case "配偶生日":
                    Return_String = "Spouse_Birth";
                    break;
                case "父亲姓名":
                    Return_String = "Father_Name";
                    break;
                case "父亲生日":
                    Return_String = "Address";
                    break;
                case "母亲姓名":
                    Return_String = "Address";
                    break;
                case "母亲生日":
                    Return_String = "Address";
                    break;
                case "兄弟姐妹状况":
                    Return_String = "Address";
                    break;
                case "子女状况":
                    Return_String = "Address";
                    break;
                case "最重要的好朋友":
                    Return_String = "Address";
                    break;
                case "长期的事业目标":
                    Return_String = "Address";
                    break;
                case "短期的事业目标":
                    Return_String = "Address";
                    break;
                case "最偏好的菜式":
                    Return_String = "Address";
                    break;
                case "最喜欢的度假方式":
                    Return_String = "Address";
                    break;
                case "最喜欢参加的运动":
                    Return_String = "Address";
                    break;
                case "喜欢的车子":
                    Return_String = "Address";
                    break;
                case "喜欢的话题":
                    Return_String = "Address";
                    break;
                case "是否参加过培训":
                    Return_String = "Address";
                    break;
                case "喜欢的讲师":
                    Return_String = "Address";
                    break;
                case "是否有看书的习惯":
                    Return_String = "Address";
                    break;
                case "喜欢书的类型":
                    Return_String = "Address";
                    break;
                case "是否常看电影":
                    Return_String = "Address";
                    break;
                case "喜欢的电影类型":
                    Return_String = "Address";
                    break;
                case "喜欢的朋友类型":
                    Return_String = "Address";
                    break;
                case "除父母外，影响最大的三个人":
                    Return_String = "Address";
                    break;
                case "最让自己骄傲的事":
                    Return_String = "Address";
                    break;
                case "备注":
                    Return_String = "Address";
                    break;
            }

            return Return_String;
        }

        /// <summary>
        /// 存储DataGrid点击的值
        /// </summary>
        public static string Get_Name = string.Empty;
        public static string Get_Phone = string.Empty;

    }
}

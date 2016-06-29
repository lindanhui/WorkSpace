using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary_Mei
{
    /// <summary>
    /// 控件检测类
    /// </summary>
    class Class_Control_Check
    {
        #region 检测文本框是否为空
        /// <summary>
        /// 检测文本框是否为空，0代表空，1代表不为空
        /// </summary>
        /// <param name="Check_TextBox"></param>
        /// <returns></returns>
        public static int Check_TextBox_Null(TextBox Check_TextBox)
        {
            if(Check_TextBox.Text.Trim() == "" || Check_TextBox.Text.Trim() == null)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        #endregion
    }
}

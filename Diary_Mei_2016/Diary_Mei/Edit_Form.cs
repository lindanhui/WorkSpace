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
            #region
            #endregion
        }
        /// <summary>
        /// 设定窗体名称
        /// </summary>
        protected void SetForm_Name()
        {
            switch (Class_State.Windows_State)
            {
                case "Archive":
                    this.Text = "客户信息修改";
                    break;
                case "Friend":
                    this.Text = "朋友信息修改";
                    break;
            }
        }
    }
}

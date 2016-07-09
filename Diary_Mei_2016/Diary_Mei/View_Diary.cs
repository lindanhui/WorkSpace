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
    public partial class View_Diary : Form
    {
        public View_Diary()
        {
            InitializeComponent();
        }

        private void View_Diary_Load(object sender, EventArgs e)
        {
            //label_Title.Text = Class_State.Get_DiaryTitle;
            richTextBox1.Text = Class_State.Get_DiaryContent;
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

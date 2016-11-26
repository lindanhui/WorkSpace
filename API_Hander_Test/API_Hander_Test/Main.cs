using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_Hander_Test
{
    public partial class APIDeal : Form
    {
        public APIDeal()
        {
            InitializeComponent();
        }

        private void textBox_MID_Click(object sender, EventArgs e)
        {
            if(textBox_MID.Text=="请输入MID")
            {
                textBox_MID.Clear();
            }
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            if(richTextBox_URL.Text=="")
            {
                label_Message_Print.Text = "";
                label_Message_Print.Text = "请输入您的URL请求地址！";
            }
            else
            {
                string Request_URL = richTextBox_URL.Text.Trim();
                string Request_Data = richTextBox_Submit_Data.Text;
                string Request_Type = comboBox_Submit_Type.Text.Trim();

                try
                {
                    richTextBox_Return_Data.Text = Request_Deal_Class.All_Deal_Request(Request_URL, Request_Type);
                }
                catch(Exception ex_string)
                {
                    label_Message_Print.Text = ex_string.ToString();
                }
                
            }
        }

        private void APIDeal_Load(object sender, EventArgs e)
        {
        }
    }
}

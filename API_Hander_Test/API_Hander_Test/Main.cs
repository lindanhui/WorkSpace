using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
                Base_Deal_Class.Message_Alert(label_Message_Print, "请输入您的URL请求地址！");
            }
            else
            {
                label_Message_Print.Text = "";
                string Request_URL = richTextBox_URL.Text.Trim();
                string Request_Data = richTextBox_Submit_Data.Text;
                string Request_Type = comboBox_Submit_Type.Text.Trim();

                try
                {
                    richTextBox_Return_Data.Text = Request_Deal_Class.All_Deal_Request(Request_URL, Request_Type);
                    Base_Deal_Class.Message_Alert(label_Message_Print, "请求成功！");
                }
                catch (Exception ex_string)
                {
                    label_Message_Print.Text = ex_string.ToString();
                }
                
            }
        }

        private void APIDeal_Load(object sender, EventArgs e)
        {
        }

        private void button_Transform_Click(object sender, EventArgs e)
        {
            richTextBox_URL.Text =  richTextBox_URL.Text.Replace("api.", "sl.api.").Replace("token", textBox_token.Text.Trim());
        }

        private void button_Export_Txt_Click(object sender, EventArgs e)
        {
            if (richTextBox_Return_Data.Text.ToString().Trim() != "")
            {
                string Serial_Number = string.Empty;
                System.Random Random_Number = new Random();
                string Time_Code = DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace(" ", "");
                string Code = Random_Number.Next(1000, 9999).ToString();

                SaveFileDialog Get_File_Name = new SaveFileDialog();
                Get_File_Name.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
                Get_File_Name.FilterIndex = 1;
                Get_File_Name.FileName = "API_Data_" + Time_Code + Code;
                if (Get_File_Name.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(Get_File_Name.FileName, true);
                    //向创建的文件中写入内容
                    sw.Write(richTextBox_Return_Data.Text.ToString());
                    //关闭当前文件写入流
                    sw.Close();
                    Base_Deal_Class.Message_Alert(label_Message_Print, "导出成功！");
                }
            }
            else
            {
                Base_Deal_Class.Message_Alert(label_Message_Print, "导出失败，当前返回数据为空！");
            }
        }
    }
}

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
    public partial class Visit_Form : Form
    {
        public Visit_Form()
        {
            InitializeComponent();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Visit_Form_Load(object sender, EventArgs e)
        {
            textBox_Name.Text = Class_State.Get_Name;
            textBox_Phone.Text = Class_State.Get_Phone;
            if (Class_State.Windows_State == "Friend")
            {
                textBox_Type.Text = "朋友";
            }
            else if (Class_State.Windows_State == "Archive")
            {
                textBox_Type.Text = "客户";
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            string SQL_Insert = "INSERT INTO Visit_Table (Real_Name, Phone, Visit_Date, Visit_Reamrk, Visit_Place, Visit_Type) VALUES ('" + textBox_Name.Text.Trim() + "', '" + textBox_Phone.Text.Trim() + "', '" + dateTimePicker_Visit.Value.ToShortDateString() + "', '" + richTextBox_Remark.Text.Trim() + "','"+richTextBox_Place.Text.Trim()+"', '" + Class_State.Windows_State + "')";
            //
            string SQL_Check = "SELECT * FROM Visit_Table WHERE Real_Name = '" + textBox_Name.Text.Trim() + "'  AND Visit_Type = '" + Class_State.Windows_State + "' AND Visit_Date LIKE '"+dateTimePicker_Visit.Value.ToShortDateString()+"'";
            //
            if(Class_SQL_Deal.Check_SQL(SQL_Check) != 0)
            {
                MessageBox.Show("您要保存的记录已经存在！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(Class_SQL_Deal.Insert_SQL(SQL_Insert) == 1)
                {
                    MessageBox.Show("记录保存成功！","Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }
    }
}

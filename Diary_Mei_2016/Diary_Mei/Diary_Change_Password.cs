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
    public partial class Diary_Change_Password : Form
    {
        public Diary_Change_Password()
        {
            InitializeComponent();
        }

        private void Button_Submit_Click(object sender, EventArgs e)
        {
            if (TextBox_Password_0.Text.Trim() != TextBox_Password_1.Text.Trim())
            {
                MessageBox.Show("Your Passwords Do Not Match，Please Check It！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (TextBox_Password_0.Text.Trim() == "" || TextBox_Password_1.Text.Trim() == "")
            {
                MessageBox.Show("Password Cannot Be Empty！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Class_SQL_Deal.Open_Connection();
                String SQL_String = "UPDATE Login_Table Set Login_Password = '" + TextBox_Password_0.Text.Trim() + "' WHERE Index = 0";
                if (Class_SQL_Deal.Update_SQL(SQL_String) == 1)
                {
                    MessageBox.Show("Password Successfully Changed！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password Change Failed！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Class_SQL_Deal.Close_Connection();
            }
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            TextBox_Password_0.Text = "";
            TextBox_Password_1.Text = "";
        }
    }
}

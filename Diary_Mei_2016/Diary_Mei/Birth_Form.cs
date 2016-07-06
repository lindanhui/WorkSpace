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
    public partial class Birth_Form : Form
    {
        public Birth_Form()
        {
            InitializeComponent();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Birth_Form_Load(object sender, EventArgs e)
        {
            string SQL_Query = "SELECT Real_Name, Phone, Birth, Now_Company, Now_Live, ";
            SQL_Query += " SWITCH(Archive_Type = 'Archive', '客户', Archive_Type = 'Friend', '朋友') AS Type ";
            SQL_Query += "FROM Archive_Table WHERE DateDiff('d', DATE(), Birth) > 31";
            dataGridView_Info.DataSource = Class_SQL_Deal.DataTable_Get(SQL_Query);
        }
    }
}

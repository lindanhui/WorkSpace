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
    public partial class VisitInfo_Form : Form
    {
        public VisitInfo_Form()
        {
            InitializeComponent();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void VisitInfo_Form_Load(object sender, EventArgs e)
        {
            string SQL_Query = "SELECT Real_Name, Phone, Visit_Date, Visit_Reamrk, Visit_Place, ";
            SQL_Query += " SWITCH(Visit_Type = 'Archive', '客户', Visit_Type = 'Friend', '朋友') AS Type ";
            SQL_Query += "FROM Visit_Table WHERE DATE() < Visit_Date";
            dataGridView_Info.DataSource = Class_SQL_Deal.DataTable_Get(SQL_Query);
        }
    }
}

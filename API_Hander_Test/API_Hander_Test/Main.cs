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
    }
}

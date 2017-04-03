using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Cfg;

namespace WindowsForm_ORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Configuration cfg = new Configuration();
            cfg.Configure();
            ISessionFactory factory = cfg.BuildSessionFactory();
            ISession session = factory.OpenSession();
            ITransaction trans = session.BeginTransaction();
            Employee ee = new Employee();
            ee.age = 31;
            ee.name = "lindanhui";
            ee.email = "158395018@qq.com";
            ee.phonenum = "1358111111";
            ee.gender = "男";
            session.Save(ee);
            trans.Commit();
            session.Close();
            factory.Close();
            this.textBox1.AppendText("the record is add !");
        }
    }
}

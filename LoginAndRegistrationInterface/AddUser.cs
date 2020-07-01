using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LoginAndRegistrationInterface.Components;

namespace LoginAndRegistrationInterface
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlstr = "insert into Logins(userInfo,password) values('" + textBox1.Text + "','" + textBox2.Text + "')";

            DBHelper.update(sqlstr);
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}

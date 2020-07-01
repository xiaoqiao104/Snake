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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox_PassWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox_UserName.Text == "用户名不可为空")
            {
                textBox_UserName.Text = "";
                textBox_UserName.ForeColor = Color.Black;
            }
            //当当前控件得到焦点时，设置背景颜色
            textBox_UserName.BackColor = Color.Beige;

        }

        private void textBox_UserName_Leave(object sender, EventArgs e)
        {
            if (textBox_UserName.Text == "")
            {
                textBox_UserName.Text = "用户名不可为空";
                textBox_PassWord.ForeColor = Color.Gray;
            }
            //当当前控件失去焦点时，设置背景颜色为白色
            textBox_UserName.BackColor = Color.White;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql= "select userInfo,password from Logins where userInfo='" + textBox_UserName.Text + "' and password='" + textBox_PassWord.Text + "'";
            
            SqlDataReader sqlDataReader = DBHelper.ExecuteReader(sql);
            while (sqlDataReader.Read())
            {


                if (sqlDataReader["userInfo"].ToString() != null && sqlDataReader["password"].ToString() != null)
                {


                    //if (textBox2.Text == sqlDataReader["password"].ToString())
                    //{
                    MessageBox.Show("登录成功！");

                    this.Hide();
                    BeginGame beginGame = new BeginGame();
                    beginGame.Show();

                    //}


                }
                else
                {
                    MessageBox.Show("用户名或密码错误，请重新输入！");
                }

            }
            sqlDataReader.Close();
            DBHelper.close();

        }



        //private void button_Cancel_Click_1(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show("确认关闭？", "想清楚咯!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
        //    {
        //        this.Close();
        //        // Environment.Exit(0);
        //    }
        //}

        private void textBox_PassWord_Enter(object sender, EventArgs e)
        {
           
        }

        private void textBox_PassWord_Leave(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUser addUser = new AddUser();
            //Form1_FormClosing(null, null);
            addUser.Show();
            //Registration registration = new Registration();
            //registration.Show();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //this.Opacity = 100;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {


            // Application.Exit();
            Close();
        }
    }
}

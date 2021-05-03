using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace construction_materials_management
{
    public partial class Form_Login : Form
    {

        public string CONST_MESSAGE_LOGIN_FAIL = "Tên đăng nhập hoặc mật khẩu không đúng . Vui lòng nhập lại";
        public Form_Login()
        {
            InitializeComponent();

            txt_Password.UseSystemPasswordChar = true;
            txt_Password.PasswordChar = '•';
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string userName = txt_UserName.Text;
            /*string*/
            string password = Common.MD5Hash(txt_Password.Text);

            string query = "SELECT * FROM material.user where username = \'" + userName + "\' and password = \'" + password + "\'";

            DataTable dt = ConnectionDatabase.GetData(query);


            if (dt.Rows.Count > 0) 
            {
                string id = dt.Rows[0]["id"].ToString();
                Form_Main formMain = new Form_Main(id);
                formMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(CONST_MESSAGE_LOGIN_FAIL , "Thông báo");
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

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
    public partial class Form_UserInfor : Form
    {
        public enum ENUM_SEX
        {
            MALE = 0,
            FE_MALE = 1,
        }

        public string fullName = "";
        public string phone = "";
        public string email = "";
        public string address = "";
        public string birthDay = "";
        public int sex = 0; // 0: male    1:female

        public DataRow dr;
        public Form_Dashboard formDashboard;

        public Form_UserInfor(Form_Dashboard form)
        {
            InitializeComponent();

            dr = form.dr;
            formDashboard = form;

            InitialData();

            InitialContext();
        }

        public void InitialData()
        {
            fullName = dr["fullname"].ToString();
            phone = dr["phone"].ToString();
            email = dr["email"].ToString();
            address = dr["address"].ToString();
            birthDay = dr["birthday"].ToString();
            sex = (int)dr["sex"];
        }
        public void InitialContext()
        {
            txt_FullName.Text = fullName;
            txt_Phone.Text = phone;
            txt_Email.Text = email;
            rtb_Address.Text = address;
            dtp_BirthDay.Text = birthDay;

            if (sex == (int)ENUM_SEX.MALE)
            {
                rdb_Male.Checked = true;
            }
            else
            {
                rdb_FeMale.Checked = true;

            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            fullName = txt_FullName.Text;

            if (fullName == "")
            {
                MessageBox.Show("Bạn chưa họ tên", "Cảnh báo");
                txt_FullName.Focus();
                return;
            } 
            if(fullName.Length > 20)
            {
                MessageBox.Show("Chỉ được tối đa 20 kí tự", "Cảnh báo");
                txt_FullName.Focus();
                return;
            }

            email = txt_Email.Text;
            if (email != "" && !Common.IsEmail(email))
            {
                MessageBox.Show("Không phải định dạng email", "Cảnh báo");
                txt_Email.Focus();
                return;
            }

            string query = "";
            phone = txt_Phone.Text;
            address = rtb_Address.Text;
            birthDay = dtp_BirthDay.Text;
            if (rdb_Male.Checked == true)
            {
                sex = (int)ENUM_SEX.MALE;
            }
            else
            {
                sex = (int)ENUM_SEX.FE_MALE;
            }
            
            string updatePass = "";
            string id = dr["id"].ToString();
            if (txt_OldPass.Text != "")
            {
                string pass = Common.MD5Hash(txt_OldPass.Text);
                query = "SELECT * FROM material.user where id = \'" + id + "\' and password = \'" + pass + "\'";

                DataTable dt = ConnectionDatabase.GetData(query);

                if (dt.Rows.Count > 0)
                {
                    if(txt_NewPass.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu mới", "Cảnh báo");
                        txt_NewPass.Focus();
                        return;
                    }  
                    if(txt_ConfirmPass.Text == "")
                    {
                        MessageBox.Show("Bạn chưa xác nhận mật khẩu", "Cảnh báo");
                        txt_ConfirmPass.Focus();
                        return;
                    }  
                    if(txt_ConfirmPass.Text != txt_NewPass.Text)
                    {
                        MessageBox.Show("Mật khẩu mới không giống nhau", "Cảnh báo");
                        txt_ConfirmPass.Focus();

                        return;
                    }

                    pass = Common.MD5Hash(txt_NewPass.Text);
                    updatePass = ",password = \'" + pass + "\' ";
                }
                else
                {
                    MessageBox.Show("Mật khẩu không đúng", "Cảnh báo");
                    txt_OldPass.Focus();
                    return;
                }
            }

            query = "UPDATE material.user " +
                "SET " +
                "fullname = \'" + fullName + "\' ," +
                "phone = \'" + phone + "\' ," +
                "address = \'" + address + "\' ," +
                "birthday = \'" + birthDay + "\' ," +
                "sex = \'" + sex + "\' " +
                updatePass +
                "WHERE id = \'" + dr["id"].ToString() + "\'";

            ConnectionDatabase.QueryData(query);

            MessageBox.Show("Thay đổi thông tin cá nhân thành công", "Thông báo");

            this.Hide();

            formDashboard.InitialData();
            formDashboard.InitialContext();

        }
    }
}

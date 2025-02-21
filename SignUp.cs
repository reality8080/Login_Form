using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form
{
    public partial class SignUp : Form
    {
        private static String connectString = @"Data Source=(localdb)\localThienPhu;Initial Catalog=WindowForm;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public SignUp()
        {
            InitializeComponent();
        }

        #region SQL
        private static void DangKi(String userName, String passWord, String email)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("insertLogin", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@userName", userName);
                    cmd.Parameters.AddWithValue("@passWord", passWord);
                    cmd.Parameters.AddWithValue("@Time", DateTime.Now);
                    cmd.Parameters.AddWithValue("@email", email);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Dang ki thanh cong");
                    }
                    else
                    {
                        MessageBox.Show("Fail", "Canh Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }
                connection.Close();
            }
        }
        #endregion

        #region Event
        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        //private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    //var result = MessageBox.Show("Ban dang thoat", "Canh Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //    //if (result == DialogResult.No)
        //    //{
        //    //    e.Cancel = true;
        //    //}
        //    //else
        //    //{
        //    //    loginForm f = new loginForm();
        //    //    f.Show();
        //    //}
        //}

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(userTxt.Text) && String.IsNullOrEmpty(passTxt.Text) && String.IsNullOrEmpty(emailTxt.Text))
                {
                    MessageBox.Show("userName, Passwork khong hop le", "Canh Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    return;
                }
                DangKi(userTxt.Text, passTxt.Text, emailTxt.Text);
                userTxt.Clear();
                passTxt.Clear();
                emailTxt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Canh Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Close();
            loginForm f = new loginForm();
            f.Show();
        }
        #endregion
    }
}

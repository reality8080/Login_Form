using Microsoft.Data.SqlClient;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;

namespace Login_Form
{
    public partial class loginForm : Form
    {
        private static String connectString = @"Data Source=(localdb)\localThienPhu;Initial Catalog=WindowForm;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public static string ConnectString { get => connectString; set => connectString = value; }

        public loginForm()
        {
            InitializeComponent();
        }

        #region SQL 
        private static Boolean getEqual(String userName, String passWord)
        {
            Boolean isValid;
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("CHECKLOGIN", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@userName", userName);
                    cmd.Parameters.AddWithValue("@passWord", passWord);

                    SqlParameter isValidParam = new SqlParameter("@IsValid", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(isValidParam);
                    cmd.ExecuteNonQuery();
                    isValid = (Boolean)isValidParam.Value;
                    if (isValid)
                    {
                        MessageBox.Show("Dang nhap thanh cong", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show("Dang nhap khong thanh", "Failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }
                ;

                connection.Close();
            }
            return isValid;
        }
        #endregion

        #region Event
        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {

            try
            {
                String? userName = userTxt.Text;
                String? passWord = passTxt.Text;
                if (String.IsNullOrEmpty(userName) && String.IsNullOrEmpty(passWord))
                {
                    MessageBox.Show("user, password khong hop le", "Canh Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                Boolean result = getEqual(userName, passWord);
                if (result)
                {
                    userTxt.Clear();
                    passTxt.Clear();
                    mainForm f = new mainForm();
                    f.Show();
                    Hide();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Canh bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void signUpLLB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp form = new SignUp();
            form.Show();
            this.Hide();
        }

        private void forgotPassLLB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotPass f = new forgotPass();
            f.ShowDialog();
        }

        private void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        //private void loginForm_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    var result = MessageBox.Show("Ban dang thoat", "Canh Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //    if (result == DialogResult.No)
        //    {
        //        e.Cancel = true;
        //    }
        //}
    }
}

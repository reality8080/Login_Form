using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form
{
    public partial class forgotPass : Form
    {
        private static String connectString = "Data Source=(localdb)\\localThienPhu;Initial Catalog=WindowForm;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        private String? result = null;

        public forgotPass()
        {
            InitializeComponent();
        }

        #region Methods
        private static string forgotMethod(String email)
        {
            String? result;
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("checkEmail", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@email", email);

                    SqlParameter serialNumber = new SqlParameter("@Result", SqlDbType.NVarChar,10)
                    {
                        Direction = ParameterDirection.Output
                    };

                    cmd.Parameters.Add(serialNumber);
                    cmd.ExecuteNonQuery();
                    result = (String)serialNumber.Value;
                }
                connection.Close();
            }
            return result;
        }
        #endregion

        #region Event
        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                result = forgotMethod(emailTxt.Text);
                resultLb.Text = $"Ket qua: {result}";
                resultLb.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Canh Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
        #endregion

        private void forgotPass_Load(object sender, EventArgs e)
        {

        }
    }
}

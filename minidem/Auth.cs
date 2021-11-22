using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minidem
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string pass = txtPass.Text;
            SqlConnection conn = DB.DBConnect();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Staff WHERE Login = '" + login + "'";
            if (Convert.ToInt32(cmd.ExecuteScalar()) == 1)
            {
                cmd.CommandText = "SELECT Id FROM Staff WHERE Login = '" + login + "' AND Password = '" + pass + "'";
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    CurrentUser.id = reader.GetInt32(0);
                    EmployeeForm employeeForm = new EmployeeForm();
                    employeeForm.Show();
                    Hide();
                }
            }
            conn.Close();
        }
    }
}

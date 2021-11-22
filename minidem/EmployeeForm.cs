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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            SqlConnection conn = DB.DBConnect();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Surname, Name, Patronymic FROM Staff WHERE Id = " + CurrentUser.id;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string surname = reader.GetString(0);
                string name = reader.GetString(1);
                string patronymic = reader.GetString(2);
                Text = surname + " " + name[0] + "." + patronymic[0] + "." + " - \"Постирушки\"";
            }
            conn.Close();
        }

        /*private void btnActiveWashes_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DB.DBConnect();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Id FROM  + CurrentUser.id;
            conn.Close();
        }*/
    }
}

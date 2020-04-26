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

namespace User_Registration
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=DESKTOP-GJF4KSU; Initial Catalog=UserRegistrationDB; Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }


       

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon= new SqlConnection(connectionString)) 
            sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand("UserAdd,sqlcon");
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@FirstName",FirstName.Text.Trim);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}

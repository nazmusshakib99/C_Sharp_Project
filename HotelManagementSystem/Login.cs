using Microsoft.Data.SqlClient;
using OOP2FinalClassProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;
//using static System.Runtime.InteropServices.JavaScript.JSTyp

namespace HotelManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = txtPassword.PasswordChar == '*' ? '\0' : '*';
        }

        private void button2_Click(object sender, EventArgs e)  //Login
        {
            var id = txtID.Text;
            var password = txtPassword.Text;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Error: ID and Password required");
                return;
            }

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-J6UI3P3\\SQLEXPRESS;Initial Catalog=FinalProjectDb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();

            var query = "select * from UserInfo Where ID=" + id + " and Password=" + password;

            SqlDataAdapter adp = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            var data = ds.Tables[0];
            con.Close();

            if (data.Rows.Count != 1)
            {
                MessageBox.Show("Invalid ID or Password");
                return;
            }

         
            LoginUserInfo.ID = Convert.ToInt32(data.Rows[0]["ID"]);
            LoginUserInfo.Name = data.Rows[0]["Name"].ToString();
            LoginUserInfo.Role = data.Rows[0]["Role"].ToString();

            if (LoginUserInfo.Role == "Admin")
            {
                Admin adminForm = new Admin();
                adminForm.Show();
            }
            else if (LoginUserInfo.Role == "Receptionist")
            {
                Receptionist receptionistForm = new Receptionist();
                receptionistForm.Show();
            }
            else
            {
                MessageBox.Show("Unknown user role: " + LoginUserInfo.Role);
                return;
            }

            this.Hide(); 

        }

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtID.Clear();
            this.txtPassword.Clear();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //if (this.Owner != null)
            //    this.Owner.Hide();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Welcome form = new Welcome();
            form.Show();
        }
    }
}

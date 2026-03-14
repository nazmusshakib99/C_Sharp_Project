using Microsoft.VisualBasic.ApplicationServices;
using OOP2FinalClassProject;
//using Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HotelManagementSystem
{
    public partial class Admin : Form
    {
        
        public Admin()
        {
            InitializeComponent();
        }


     
        private void LoaduserInfoData()
        {
            string query;

            query = "SELECT * from UserInfo";



            var result = DbHelper.GetQueryData(query);

            if (result.HasError)
            {
                MessageBox.Show(result.Message);
                return;
            }

            dgvUserInfo.AutoGenerateColumns = true;
            dgvUserInfo.DataSource = result.Data;
            dgvUserInfo.Refresh();
            dgvUserInfo.ClearSelection();

        }
        private void Admin_Load(object sender, EventArgs e)
        {
            this.LoaduserInfoData();
            this.txtWelcomeMessage.Text = " Welcome " + LoginUserInfo.Name;
          
        }



        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvUserInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }



        private void btnManageUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageUser form = new ManageUser();
            form.Show();
            


        }

        //private void btnEmployee_Click(object sender, EventArgs e)
        //{
        //    Employees form1 = new Employees();
        //    form1.Show();
        //}

        private void btnEmployee_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            Employees form = new Employees();
            form.Show();
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            this.Hide();
            Login login = new Login();
            login.Show();
            
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            ARoom from = new ARoom();
            from.Show();
            
        }
    }
}

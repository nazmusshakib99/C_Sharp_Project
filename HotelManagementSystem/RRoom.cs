using OOP2FinalClassProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class RRoom : Form
    {
        public RRoom()
        {
            InitializeComponent();
        }

        private void LoadUserInfoData(string searchValue = "")
        {
            try
            {


                string query;

                if (!string.IsNullOrWhiteSpace(searchValue))
                {
                    query = "SELECT * FROM Room WHERE RID='" + searchValue + "' OR RName LIKE '%" + searchValue + "%'";
                }
                else
                {
                    query = "SELECT * FROM Room";
                }

                var result = DbHelper.GetQueryData(query);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                var dt = result.Data;

                this.dgvUserInfo.AutoGenerateColumns = true;
                this.dgvUserInfo.DataSource = dt;
                this.dgvUserInfo.Refresh();
                this.dgvUserInfo.ClearSelection();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            this.LoadUserInfoData(txtSearch.Text);
        }

        private void RRoom_Load(object sender, EventArgs e)
        {
            this.LoadUserInfoData();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            this.LoadUserInfoData();
        }

        private void RRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Receptionist form = new Receptionist();
            form.Show();
        }
    }
}

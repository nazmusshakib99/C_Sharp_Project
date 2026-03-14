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
    public partial class CheckOut : Form
    {
        public CheckOut()
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
                    query = "SELECT * FROM CheckIn WHERE CID='" + searchValue + "' OR CName LIKE '%" + searchValue + "%'";
                }
                else
                {
                    query = "SELECT * FROM CheckIn";
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

        private void CheckOut_Load(object sender, EventArgs e)
        {
            this.LoadUserInfoData();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment form = new Payment();
            form.Show();
        }

        private void CheckOut_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Receptionist form = new Receptionist();
            form.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            Receptionist form = new Receptionist();
            form.Show();
            
        }
    }
}

using OOP2FinalClassProject;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
        }

        private void ResetForm()
        {
            txtUserId.Text = "";
            txtUserName.Text = txtPassword.Text = txtSearch.Text = "";
            rbAdmin.Checked = rbReceptionist.Checked = false;



        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            this.LoadUserInfoData();

         
        }

        private void txtSearchById_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadUserInfoData(string searchValue = "")
        {
            try
            {
                string query;
                if (string.IsNullOrWhiteSpace(searchValue))
                {
                    query = "Select * from UserInfo";
                }
                else
                {
                    int id;
                    if (int.TryParse(txtSearch.Text, out id))
                    {
                        query = "Select * from UserInfo where ID=" + txtSearch.Text + " or Name LIKE '%" + txtSearch.Text + "%'";
                    }
                    else
                    {
                        query = "Select * from UserInfo where Name LIKE '%" + txtSearch.Text + "%'";
                    }
                }

                var result = DbHelper.GetQueryData(query);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                var dt = result.Data;

                this.dgvUserInfo.AutoGenerateColumns = false;
                this.dgvUserInfo.DataSource = dt;
                this.dgvUserInfo.Refresh();
                this.dgvUserInfo.ClearSelection();
                this.ResetForm();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            var id = txtUserId.Text;
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Error:User Id is required");
                return;
            }
            var fullName = txtUserName.Text;
            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Error:User Name is required");
                return;
            }

            var password = txtPassword.Text;
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Error: Password is required");
                return;
            }

            string role;
            if (rbAdmin.Checked)
            {
                role = "Admin";
            }
            else if (rbReceptionist.Checked)
            {
                role = "Receptionist";
            }
            else
            {
                MessageBox.Show("Error: Role is required");
                return;
            }

            try
            {
                if (string.IsNullOrWhiteSpace(txtUserId.Text))
                {
                    MessageBox.Show("User ID is required.");
                    return;
                }

                var checkQuery = "SELECT COUNT(*) FROM UserInfo WHERE ID='" + id + "'";
                var checkResult = DbHelper.GetQueryData(checkQuery);

                if (checkResult.HasError)
                {
                    MessageBox.Show(checkResult.Message);
                    return;
                }

                int count = Convert.ToInt32(checkResult.Data.Rows[0][0]);

                string query;

                if (count == 0)
                {

                    query = "INSERT INTO UserInfo VALUES ('" + id + "','" + fullName + "','" + password + "','" + role + "')";
                }
                else
                {

                    query = "UPDATE UserInfo SET Name='" + fullName +
                            "', Password='" + password +
                            "', Role='" + role +
                            "' WHERE ID='" + id + "'";
                }

                var result = DbHelper.ExecuteNonResultQuery(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                if (count == 0)
                {
                    MessageBox.Show("User Added successfully.");
                }
                else
                {
                    MessageBox.Show("User Updated successfully.");
                }
                this.LoadUserInfoData();
                this.ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvUserInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ResetForm();


            var id = dgvUserInfo.Rows[e.RowIndex].Cells[0].Value?.ToString();
            txtUserId.Text = id;
            var query = "select *from UserInfo where ID=" + id;

            var result = DbHelper.GetQueryData(query);

            if (result.HasError)
            {
                MessageBox.Show(result.Message);
                return;
            }


            var name = result.Data.Rows[0]["Name"].ToString();
            txtUserName.Text = name;

            var password = result.Data.Rows[0]["Password"].ToString();
            txtPassword.Text = password;

            var role = result.Data.Rows[0]["Role"].ToString();

            if (role == rbAdmin.Text)
            {
                rbAdmin.Checked = true;
            }
            else
            {
                rbReceptionist.Checked = true;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(txtUserId.Text))
                {
                    MessageBox.Show("Error: Please select a row first");
                    return;
                }


                var query = "Delete From UserInfo Where ID=" + txtUserId.Text;

                var result = DbHelper.ExecuteNonResultQuery(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                MessageBox.Show("Delete");
                this.LoadUserInfoData();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            this.ResetForm();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtUserId.Clear();
            this.txtUserName.Clear();
            this.txtPassword.Clear();
            this.rbReceptionist.Checked = false;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.LoadUserInfoData(txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.LoadUserInfoData();
        }

        private void ManageUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Admin form = new Admin();
            form.Show();
        }
    }
}
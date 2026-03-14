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
    public partial class ARoom : Form
    {
        public ARoom()
        {
            InitializeComponent();
        }


        private void ResetForm()
        {
            txtRno.Text = "";
            txtRname.Text = txtRtype.Text = txtRstatus.Text = "";

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
                this.ResetForm();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void ARoom_Load(object sender, EventArgs e)
        {
            this.LoadUserInfoData();

            
        }

        private void dgvUserInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ResetForm();


            var id = dgvUserInfo.Rows[e.RowIndex].Cells[0].Value?.ToString();
            txtRno.Text = id;

            var query = "SELECT * FROM Room WHERE RID = '" + id + "'";
            var result = DbHelper.GetQueryData(query);

            if (result.HasError)
            {
                MessageBox.Show(result.Message);
                return;
            }

            var dt = result.Data;

            txtRname.Text = dt.Rows[0]["RName"].ToString();

            txtRstatus.Text = dt.Rows[0]["RStatus"].ToString();
            txtRtype.Text = dt.Rows[0]["RType"].ToString();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.LoadUserInfoData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var id = txtRno.Text;
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Error:Room Number is required");
                return;
            }
            var fullName = txtRname.Text;
            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Error:Room Name is required");
                return;
            }





            var type = txtRtype.Text;
            if (string.IsNullOrWhiteSpace(type))
            {
                MessageBox.Show("Error:Room Type is required");
                return;
            }
            var status = txtRstatus.Text;
            if (string.IsNullOrWhiteSpace(status))
            {
                MessageBox.Show("Error:Room Status is required");
                return;
            }






            try
            {
                if (string.IsNullOrWhiteSpace(txtRno.Text))
                {
                    MessageBox.Show("Room Number is required.");
                    return;
                }

                var checkQuery = "SELECT COUNT(*) FROM Room WHERE RID='" + id + "'";
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

                    query = "INSERT INTO Room (RID, RName, RType, RStatus) VALUES ('" +
                            id + "','" + fullName + "','" + type + "','" +
                            status + "')";
                }
                else
                {

                    query = "UPDATE Room SET RName='" + fullName +
                            "', RType='" + type +
                            "', RStatus='" + status +
                            "' WHERE RID='" + id + "'";
                }

                var result = DbHelper.ExecuteNonResultQuery(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                if (count == 0)
                {
                    MessageBox.Show("Room Added successfully.");
                }
                else
                {
                    MessageBox.Show("Room Updated successfully.");
                }
                this.LoadUserInfoData();
                this.ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtRno.Text))
                {
                    MessageBox.Show("Error: Please select a row first");
                    return;
                }

                string id = txtRno.Text.Trim();
                var query = "DELETE FROM Room WHERE RID='" + id + "'";

                var result = DbHelper.ExecuteNonResultQuery(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                MessageBox.Show("Deleted successfully");
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
            this.ResetForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.LoadUserInfoData(txtSearch.Text);
        }

        private void ARoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Admin Form = new Admin();
            Form.Show();
        }
    }
}

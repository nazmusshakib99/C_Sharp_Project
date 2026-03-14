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
    public partial class CheckIn : Form
    {
        public CheckIn()
        {
            InitializeComponent();
        }

        private void ResetForm()
        {

            txtCid.Text = txtCname.Text = txtCaddress.Text = txtCpn.Text = txtCrn.Text = txtCrt.Text = "";


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
                this.ResetForm();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void CheckIn_Load(object sender, EventArgs e)
        {
            this.LoadUserInfoData();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.LoadUserInfoData();
        }

        private void dgvUserInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ResetForm();


            var id = dgvUserInfo.Rows[e.RowIndex].Cells[0].Value?.ToString();
            txtCid.Text = id;

            var query = "SELECT * FROM CheckIn WHERE CID = '" + id + "'";
            var result = DbHelper.GetQueryData(query);

            if (result.HasError)
            {
                MessageBox.Show(result.Message);
                return;
            }

            var dt = result.Data;

            txtCname.Text = dt.Rows[0]["CName"].ToString();


            var dob = dgvUserInfo.Rows[e.RowIndex].Cells["CDate"].Value?.ToString();
            DateTime dtDob = Convert.ToDateTime(dob);
            this.dtpDob.Value = dtDob;

            txtCaddress.Text = dt.Rows[0]["CAddress"].ToString();
            txtCpn.Text = dt.Rows[0]["CPhone"].ToString();
            txtCrn.Text = dt.Rows[0]["RID"].ToString();
            txtCrt.Text = dt.Rows[0]["RType"].ToString();

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }


        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            var id = txtCid.Text;
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Error:Customer ID is required");
                return;
            }
            var fullName = txtCname.Text;
            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Error:Customer Name is required");
                return;
            }



            var address = txtCaddress.Text;
            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Error:Address is required");
                return;
            }
            var pn = txtCpn.Text;
            if (string.IsNullOrWhiteSpace(pn))
            {
                MessageBox.Show("Error:Phone Number is required");
                return;
            }

            var rn = txtCrn.Text;
            if (string.IsNullOrWhiteSpace(rn))
            {
                MessageBox.Show("Error:Room Number is required");
                return;
            }

            var rt = txtCrt.Text;
            if (string.IsNullOrWhiteSpace(rt))
            {
                MessageBox.Show("Error:Room Number is required");
                return;
            }




            DateTime dob = dtpDob.Value;

            if (dob == DateTime.MinValue || dob == DateTime.MaxValue)
            {
                MessageBox.Show("Error: Check In Date is required");
                return;
            }

            string dobString = dob.ToString("yyyy-MM-dd");


            try
            {
                if (string.IsNullOrWhiteSpace(txtCid.Text))
                {
                    MessageBox.Show("Customer ID is required.");
                    return;
                }

                var checkQuery = "SELECT COUNT(*) FROM CheckIn WHERE CID='" + id + "'";
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

                    query = "INSERT INTO CheckIn (CID, CName,CPhone,CAddress,RID,RType,CDate ) VALUES ('" +
                            id + "','" + fullName + "','" + pn + "','" +
                            address + "','" + rn + "','" + rt + "','" + dobString + "')";
                }
                else
                {

                    query = "UPDATE CheckIn  SET CName='" + fullName +
                            "', CPhone='" + pn +

                            "', CAddress='" + address +
                            "', RID='" + rn +
                             "', RType='" + rt +
                            "', CDate='" + dobString +

                            "' WHERE CID='" + id + "'";
                }

                var result = DbHelper.ExecuteNonResultQuery(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                if (count == 0)
                {
                    MessageBox.Show("Check In success.");
                }
                else
                {
                    MessageBox.Show("Check In Information Updated successfully.");
                }
                this.LoadUserInfoData();
                this.ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCid.Text))
                {
                    MessageBox.Show("Error: Please select a row first");
                    return;
                }

                string id = txtCid.Text.Trim();
                var query = "DELETE FROM CheckIn WHERE CID='" + id + "'";

                var result = DbHelper.ExecuteNonResultQuery(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                MessageBox.Show("Check In Information Canceled");
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

        private void CheckIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Receptionist form = new Receptionist();
            form.Show();
        }

        private void dgvUserInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

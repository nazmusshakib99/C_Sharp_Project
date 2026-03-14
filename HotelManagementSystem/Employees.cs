using OOP2FinalClassProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void ResetForm()
        {

            txtEmpId.Text = txtEmpName.Text = txtSalary.Text = txtPn.Text = "";
            rbMale.Checked = rbFemale.Checked = false;
            cbRole.SelectedItem = null;


        }

        private void LoadUserInfoData(string searchValue = "")
        {
            try
            {


                string query;

                if (!string.IsNullOrWhiteSpace(searchValue))
                {
                    query = "SELECT * FROM Employee WHERE ID='" + searchValue + "' OR Name LIKE '%" + searchValue + "%'";
                }
                else
                {
                    query = "SELECT * FROM Employee";
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

        private void Employees_Load(object sender, EventArgs e)
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
            txtEmpId.Text = id;

            var query = "SELECT * FROM Employee WHERE ID = '" + id + "'";
            var result = DbHelper.GetQueryData(query);

            if (result.HasError)
            {
                MessageBox.Show(result.Message);
                return;
            }

            var dt = result.Data;

            txtEmpName.Text = dt.Rows[0]["Name"].ToString();
            cbRole.SelectedItem = dt.Rows[0]["Role"].ToString();



            var gender = dgvUserInfo.Rows[e.RowIndex].Cells["Gender"].Value?.ToString();

            if (gender == rbMale.Text)
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }

            var dob = dgvUserInfo.Rows[e.RowIndex].Cells["DOB"].Value?.ToString(); //DOB
            DateTime dtDob = Convert.ToDateTime(dob);
            this.dtpDob.Value = dtDob;

            txtSalary.Text = dt.Rows[0]["Salary"].ToString();
            txtPn.Text = dt.Rows[0]["Phone"].ToString();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var id = txtEmpId.Text;
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Error:User Id is required");
                return;
            }
            var fullName = txtEmpName.Text;
            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Error:User Name is required");
                return;
            }

            string gender;
            if (rbMale.Checked)
            {
                gender = "Male";
            }
            else if (rbFemale.Checked)
            {
                gender = "Female";
            }
            else
            {
                MessageBox.Show("Error: Gender is required");
                return;
            }
            if (cbRole.SelectedItem == null)
            {
                MessageBox.Show("Error: Role is required.");
                return;
            }

            var role = cbRole.Text;



            var salary = txtSalary.Text;
            if (string.IsNullOrWhiteSpace(salary))
            {
                MessageBox.Show("Error:Salary is required");
                return;
            }
            var pn = txtPn.Text;
            if (string.IsNullOrWhiteSpace(pn))
            {
                MessageBox.Show("Error:Phone Number is required");
                return;
            }




            DateTime dob = dtpDob.Value;

            if (dob == DateTime.MinValue || dob == DateTime.MaxValue)
            {
                MessageBox.Show("Error: Date of Birth is required");
                return;
            }

            string dobString = dob.ToString("yyyy-MM-dd");


            try
            {
                if (string.IsNullOrWhiteSpace(txtEmpId.Text))
                {
                    MessageBox.Show("Employee ID is required.");
                    return;
                }

                var checkQuery = "SELECT COUNT(*) FROM Employee WHERE ID='" + id + "'";
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

                    query = "INSERT INTO Employee (ID, Name, Role, DOB, Gender, Salary, Phone) VALUES ('" +
                            id + "','" + fullName + "','" + role + "','" +
                            dobString + "','" + gender + "','" + salary + "','" + pn + "')";
                }
                else
                {

                    query = "UPDATE Employee SET Name='" + fullName +
                            "', Role='" + role +
                            "', DOB='" + dobString +
                            "', Gender='" + gender +
                            "', Salary='" + salary +
                            "', Phone='" + pn +
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
                    MessageBox.Show("Employee Added successfully.");
                }
                else
                {
                    MessageBox.Show("Employee Updated successfully.");
                }
                this.LoadUserInfoData();
                this.ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void brnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(txtEmpId.Text))
                {
                    MessageBox.Show("Error: Please select a row first");
                    return;
                }

                string id = txtEmpId.Text.Trim();
                var query = "DELETE FROM Employee WHERE ID='" + id + "'";

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
            this.ResetForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.LoadUserInfoData(txtSearch.Text);
        }

        private void Employees_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Admin form = new Admin();
            form.Show();
        }
    }
}


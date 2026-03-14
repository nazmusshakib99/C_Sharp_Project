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
    public partial class Receptionist : Form
    {
        public Receptionist()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void Receptionist_Load(object sender, EventArgs e)
        {
            this.txtWelcome.Text = " Welcome " + LoginUserInfo.Name;
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            RRoom form = new RRoom();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckIn form = new CheckIn();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckOut form = new CheckOut();
            form.Show();
        }
    }
}

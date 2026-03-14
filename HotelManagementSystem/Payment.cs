using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("'Payment Complete' Thankyou For Vising Us");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("'Payment Complete' Thankyou For Vising Us");
        }

        private void Bank_Click(object sender, EventArgs e)
        {
            MessageBox.Show("'Payment Complete' Thankyou For Vising Us");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("'Payment Complete' Thankyou For Vising Us");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckOut form = new CheckOut();
            form.Show();
        }
    }
}

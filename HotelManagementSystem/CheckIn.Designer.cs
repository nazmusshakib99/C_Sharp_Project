namespace HotelManagementSystem
{
    partial class CheckIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtCid = new TextBox();
            txtCname = new TextBox();
            txtCpn = new TextBox();
            txtCrn = new TextBox();
            txtCrt = new TextBox();
            dtpDob = new DateTimePicker();
            txtCaddress = new RichTextBox();
            panel1 = new Panel();
            dgvUserInfo = new DataGridView();
            btnConfirm = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnShow = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserInfo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(179, 126);
            label1.Name = "label1";
            label1.Size = new Size(108, 21);
            label1.TabIndex = 0;
            label1.Text = "Customer ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(423, 9);
            label2.Name = "label2";
            label2.Size = new Size(128, 32);
            label2.TabIndex = 1;
            label2.Text = "CHECK-IN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 43);
            label3.Name = "label3";
            label3.Size = new Size(135, 32);
            label3.TabIndex = 2;
            label3.Text = "Guest Info";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(150, 170);
            label4.Name = "label4";
            label4.Size = new Size(137, 21);
            label4.TabIndex = 3;
            label4.Text = "Customer Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(156, 213);
            label5.Name = "label5";
            label5.Size = new Size(131, 21);
            label5.TabIndex = 4;
            label5.Text = "Phone Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(213, 270);
            label6.Name = "label6";
            label6.Size = new Size(74, 21);
            label6.TabIndex = 5;
            label6.Text = "Address:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(556, 117);
            label7.Name = "label7";
            label7.Size = new Size(127, 21);
            label7.TabIndex = 6;
            label7.Text = "Room Number:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(556, 170);
            label8.Name = "label8";
            label8.Size = new Size(99, 21);
            label8.TabIndex = 7;
            label8.Text = "Room Type:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(556, 222);
            label9.Name = "label9";
            label9.Size = new Size(119, 21);
            label9.TabIndex = 8;
            label9.Text = "Check In Date:";
            // 
            // txtCid
            // 
            txtCid.Location = new Point(293, 126);
            txtCid.Multiline = true;
            txtCid.Name = "txtCid";
            txtCid.Size = new Size(196, 32);
            txtCid.TabIndex = 9;
            // 
            // txtCname
            // 
            txtCname.Location = new Point(293, 172);
            txtCname.Multiline = true;
            txtCname.Name = "txtCname";
            txtCname.Size = new Size(196, 32);
            txtCname.TabIndex = 10;
            // 
            // txtCpn
            // 
            txtCpn.Location = new Point(293, 215);
            txtCpn.Multiline = true;
            txtCpn.Name = "txtCpn";
            txtCpn.Size = new Size(196, 28);
            txtCpn.TabIndex = 11;
            // 
            // txtCrn
            // 
            txtCrn.Location = new Point(689, 115);
            txtCrn.Multiline = true;
            txtCrn.Name = "txtCrn";
            txtCrn.Size = new Size(187, 32);
            txtCrn.TabIndex = 13;
            // 
            // txtCrt
            // 
            txtCrt.Location = new Point(689, 170);
            txtCrt.Multiline = true;
            txtCrt.Name = "txtCrt";
            txtCrt.Size = new Size(187, 32);
            txtCrt.TabIndex = 14;
            // 
            // dtpDob
            // 
            dtpDob.Format = DateTimePickerFormat.Custom;
            dtpDob.Location = new Point(689, 220);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(192, 23);
            dtpDob.TabIndex = 15;
            // 
            // txtCaddress
            // 
            txtCaddress.Location = new Point(293, 259);
            txtCaddress.Name = "txtCaddress";
            txtCaddress.Size = new Size(196, 56);
            txtCaddress.TabIndex = 16;
            txtCaddress.Text = "";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvUserInfo);
            panel1.Location = new Point(150, 389);
            panel1.Name = "panel1";
            panel1.Size = new Size(840, 268);
            panel1.TabIndex = 17;
            // 
            // dgvUserInfo
            // 
            dgvUserInfo.AllowUserToAddRows = false;
            dgvUserInfo.AllowUserToDeleteRows = false;
            dgvUserInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserInfo.Location = new Point(3, 3);
            dgvUserInfo.Name = "dgvUserInfo";
            dgvUserInfo.ReadOnly = true;
            dgvUserInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUserInfo.Size = new Size(835, 262);
            dgvUserInfo.TabIndex = 0;
            dgvUserInfo.CellContentClick += dgvUserInfo_CellContentClick;
            dgvUserInfo.CellDoubleClick += dgvUserInfo_CellDoubleClick;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Aquamarine;
            btnConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(631, 280);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(83, 35);
            btnConfirm.TabIndex = 18;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(798, 280);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(83, 35);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Cancel";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Honeydew;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(714, 331);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(83, 35);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.Aquamarine;
            btnShow.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShow.Location = new Point(946, 348);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(83, 35);
            btnShow.TabIndex = 21;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(189, 348);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(126, 32);
            txtSearch.TabIndex = 22;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Aquamarine;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(336, 348);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(83, 35);
            btnSearch.TabIndex = 23;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // CheckIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1118, 686);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnShow);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnConfirm);
            Controls.Add(panel1);
            Controls.Add(txtCaddress);
            Controls.Add(dtpDob);
            Controls.Add(txtCrt);
            Controls.Add(txtCrn);
            Controls.Add(txtCpn);
            Controls.Add(txtCname);
            Controls.Add(txtCid);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CheckIn";
            Text = "CheckIn";
            FormClosed += CheckIn_FormClosed;
            Load += CheckIn_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUserInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtCid;
        private TextBox txtCname;
        private TextBox txtCpn;
        private TextBox txtCrn;
        private TextBox txtCrt;
        private DateTimePicker dtpDob;
        private RichTextBox txtCaddress;
        private Panel panel1;
        private Button btnConfirm;
        private Button btnDelete;
        private Button btnClear;
        private Button btnShow;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dgvUserInfo;
    }
}
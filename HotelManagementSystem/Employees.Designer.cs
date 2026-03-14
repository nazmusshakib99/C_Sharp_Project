namespace HotelManagementSystem
{
    partial class Employees
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
            txtEmpId = new TextBox();
            txtEmpName = new TextBox();
            txtSalary = new TextBox();
            txtPn = new TextBox();
            cbRole = new ComboBox();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            btnAdd = new Button();
            brnDelete = new Button();
            btnClear = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dgvUserInfo = new DataGridView();
            btnShow = new Button();
            label8 = new Label();
            dtpDob = new DateTimePicker();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserInfo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(185, 117);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 0;
            label1.Text = "Employee ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(156, 154);
            label2.Name = "label2";
            label2.Size = new Size(140, 21);
            label2.TabIndex = 1;
            label2.Text = "Employee Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(248, 189);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 2;
            label3.Text = "Role:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(226, 262);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 3;
            label4.Text = "Gender:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(226, 297);
            label5.Name = "label5";
            label5.Size = new Size(62, 21);
            label5.TabIndex = 4;
            label5.Text = "Salary:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(165, 332);
            label6.Name = "label6";
            label6.Size = new Size(131, 21);
            label6.TabIndex = 5;
            label6.Text = "Phone Number:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(57, 30);
            label7.Name = "label7";
            label7.Size = new Size(201, 30);
            label7.TabIndex = 6;
            label7.Text = "Manage Employee";
            // 
            // txtEmpId
            // 
            txtEmpId.Location = new Point(302, 117);
            txtEmpId.Multiline = true;
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(182, 25);
            txtEmpId.TabIndex = 7;
            // 
            // txtEmpName
            // 
            txtEmpName.Location = new Point(302, 154);
            txtEmpName.Multiline = true;
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(182, 25);
            txtEmpName.TabIndex = 8;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(302, 293);
            txtSalary.Multiline = true;
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(182, 25);
            txtSalary.TabIndex = 9;
            // 
            // txtPn
            // 
            txtPn.Location = new Point(302, 334);
            txtPn.Multiline = true;
            txtPn.Name = "txtPn";
            txtPn.Size = new Size(182, 25);
            txtPn.TabIndex = 10;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Accountant", "Chef", "Room Service", "Secruity Guard", "Cleaner" });
            cbRole.Location = new Point(302, 191);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(182, 23);
            cbRole.TabIndex = 11;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbMale.Location = new Point(311, 266);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(55, 21);
            rbMale.TabIndex = 12;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbFemale.Location = new Point(372, 266);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(69, 21);
            rbFemale.TabIndex = 13;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Cyan;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(582, 180);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 30);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // brnDelete
            // 
            brnDelete.BackColor = Color.Crimson;
            brnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brnDelete.Location = new Point(759, 180);
            brnDelete.Name = "brnDelete";
            brnDelete.Size = new Size(75, 30);
            brnDelete.TabIndex = 15;
            brnDelete.Text = "Delete";
            brnDelete.UseVisualStyleBackColor = false;
            brnDelete.Click += brnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(667, 253);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 30);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.MediumAquamarine;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(311, 387);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(87, 30);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(176, 387);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 30);
            txtSearch.TabIndex = 18;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(dgvUserInfo);
            flowLayoutPanel1.Location = new Point(209, 423);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(729, 293);
            flowLayoutPanel1.TabIndex = 19;
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
            dgvUserInfo.Size = new Size(725, 290);
            dgvUserInfo.TabIndex = 0;
            dgvUserInfo.CellDoubleClick += dgvUserInfo_CellDoubleClick;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.PowderBlue;
            btnShow.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShow.Location = new Point(908, 387);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(87, 30);
            btnShow.TabIndex = 20;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(183, 231);
            label8.Name = "label8";
            label8.Size = new Size(113, 21);
            label8.TabIndex = 21;
            label8.Text = "Date Of Birth:";
            // 
            // dtpDob
            // 
            dtpDob.Format = DateTimePickerFormat.Custom;
            dtpDob.Location = new Point(302, 231);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(182, 23);
            dtpDob.TabIndex = 22;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1117, 742);
            Controls.Add(dtpDob);
            Controls.Add(label8);
            Controls.Add(btnShow);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(brnDelete);
            Controls.Add(btnAdd);
            Controls.Add(rbFemale);
            Controls.Add(rbMale);
            Controls.Add(cbRole);
            Controls.Add(txtPn);
            Controls.Add(txtSalary);
            Controls.Add(txtEmpName);
            Controls.Add(txtEmpId);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Employees";
            Text = "Employees";
            FormClosed += Employees_FormClosed;
            Load += Employees_Load;
            flowLayoutPanel1.ResumeLayout(false);
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
        private TextBox txtEmpId;
        private TextBox txtEmpName;
        private TextBox txtSalary;
        private TextBox txtPn;
        private ComboBox cbRole;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private Button btnAdd;
        private Button brnDelete;
        private Button btnClear;
        private Button btnSearch;
        private TextBox txtSearch;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dgvUserInfo;
        private Button btnShow;
        private Label label8;
        private DateTimePicker dtpDob;
    }
}
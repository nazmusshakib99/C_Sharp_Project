namespace HotelManagementSystem
{
    partial class ManageUser
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
            txtUserId = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            rbAdmin = new RadioButton();
            rbReceptionist = new RadioButton();
            btnSave = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dgvUserInfo = new DataGridView();
            dgvId = new DataGridViewTextBoxColumn();
            dgvName = new DataGridViewTextBoxColumn();
            dgvPassword = new DataGridViewTextBoxColumn();
            dgvRole = new DataGridViewTextBoxColumn();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnShow = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserInfo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, 97);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 0;
            label1.Text = "User ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(65, 160);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 1;
            label2.Text = "User Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(77, 222);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 2;
            label3.Text = "Password :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(123, 286);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 3;
            label4.Text = "Role :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(46, 30);
            label5.Name = "label5";
            label5.Size = new Size(125, 25);
            label5.TabIndex = 4;
            label5.Text = "Manage User";
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(190, 97);
            txtUserId.Multiline = true;
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(239, 33);
            txtUserId.TabIndex = 5;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(190, 160);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(239, 33);
            txtUserName.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(190, 227);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(239, 33);
            txtPassword.TabIndex = 7;
            // 
            // rbAdmin
            // 
            rbAdmin.AutoSize = true;
            rbAdmin.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbAdmin.Location = new Point(197, 293);
            rbAdmin.Name = "rbAdmin";
            rbAdmin.Size = new Size(66, 21);
            rbAdmin.TabIndex = 8;
            rbAdmin.TabStop = true;
            rbAdmin.Text = "Admin";
            rbAdmin.UseVisualStyleBackColor = true;
            // 
            // rbReceptionist
            // 
            rbReceptionist.AutoSize = true;
            rbReceptionist.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbReceptionist.Location = new Point(305, 293);
            rbReceptionist.Name = "rbReceptionist";
            rbReceptionist.Size = new Size(100, 21);
            rbReceptionist.TabIndex = 9;
            rbReceptionist.TabStop = true;
            rbReceptionist.Text = "Receptionist";
            rbReceptionist.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Turquoise;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(512, 97);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(79, 46);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(708, 97);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(79, 46);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Honeydew;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(616, 201);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(79, 46);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(dgvUserInfo);
            flowLayoutPanel1.Location = new Point(97, 396);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(764, 220);
            flowLayoutPanel1.TabIndex = 13;
            // 
            // dgvUserInfo
            // 
            dgvUserInfo.AllowUserToAddRows = false;
            dgvUserInfo.AllowUserToDeleteRows = false;
            dgvUserInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserInfo.Columns.AddRange(new DataGridViewColumn[] { dgvId, dgvName, dgvPassword, dgvRole });
            dgvUserInfo.Location = new Point(3, 3);
            dgvUserInfo.Name = "dgvUserInfo";
            dgvUserInfo.ReadOnly = true;
            dgvUserInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUserInfo.Size = new Size(761, 208);
            dgvUserInfo.TabIndex = 0;
            dgvUserInfo.CellDoubleClick += dgvUserInfo_CellDoubleClick;
            // 
            // dgvId
            // 
            dgvId.DataPropertyName = "ID";
            dgvId.HeaderText = "User ID";
            dgvId.Name = "dgvId";
            dgvId.ReadOnly = true;
            dgvId.Width = 120;
            // 
            // dgvName
            // 
            dgvName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvName.DataPropertyName = "Name";
            dgvName.HeaderText = "User Name";
            dgvName.Name = "dgvName";
            dgvName.ReadOnly = true;
            // 
            // dgvPassword
            // 
            dgvPassword.DataPropertyName = "Password";
            dgvPassword.HeaderText = "Password";
            dgvPassword.Name = "dgvPassword";
            dgvPassword.ReadOnly = true;
            dgvPassword.Width = 120;
            // 
            // dgvRole
            // 
            dgvRole.DataPropertyName = "Role";
            dgvRole.HeaderText = "Role";
            dgvRole.Name = "dgvRole";
            dgvRole.ReadOnly = true;
            dgvRole.Width = 120;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Turquoise;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(272, 353);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 32);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(143, 353);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 27);
            txtSearch.TabIndex = 17;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.Turquoise;
            btnShow.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShow.Location = new Point(770, 362);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(91, 28);
            btnShow.TabIndex = 18;
            btnShow.Text = "Show All";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // ManageUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(944, 628);
            Controls.Add(btnShow);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(rbReceptionist);
            Controls.Add(rbAdmin);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtUserId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "ManageUser";
            Text = "ManageUser";
            FormClosed += ManageUser_FormClosed;
            Load += ManageUser_Load;
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private RadioButton rbAdmin;
        private RadioButton btnReceptionist;
        private Button btnSave;
        private Button btnDelete;
        private Button btnClear;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txtSearchById;
        private TextBox txtSearchByName;
        private Button button1;
        private DataGridView dgvUserInfo;
        private DataGridViewTextBoxColumn dgvId;
        private DataGridViewTextBoxColumn dgvName;
        private DataGridViewTextBoxColumn dgvPassword;
        private DataGridViewTextBoxColumn dgvRole;
        private Button btnSearch;
        private TextBox txtUserId;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private RadioButton rbReceptionist;
        private TextBox txtSearch;
        private Button btnShow;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
    }
}
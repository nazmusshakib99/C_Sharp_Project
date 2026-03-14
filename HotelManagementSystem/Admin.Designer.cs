namespace HotelManagementSystem
{
    partial class Admin
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            pnlGidView = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dgvUserInfo = new DataGridView();
            dgvId = new DataGridViewTextBoxColumn();
            dgvName = new DataGridViewTextBoxColumn();
            dgvPassword = new DataGridViewTextBoxColumn();
            dgvRole = new DataGridViewTextBoxColumn();
            pnlDashboard = new Panel();
            label1 = new Label();
            btnManageUser = new Button();
            btnEmployee = new Button();
            btnRoom = new Button();
            btnLogout = new Button();
            label3 = new Label();
            label2 = new Label();
            txtWelcomeMessage = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            pnlGidView.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserInfo).BeginInit();
            pnlDashboard.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel4, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 376F));
            tableLayoutPanel1.Size = new Size(859, 508);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(pnlGidView);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(853, 502);
            panel4.TabIndex = 3;
            // 
            // pnlGidView
            // 
            pnlGidView.Controls.Add(flowLayoutPanel2);
            pnlGidView.Controls.Add(flowLayoutPanel1);
            pnlGidView.Controls.Add(pnlDashboard);
            pnlGidView.Controls.Add(label3);
            pnlGidView.Controls.Add(txtWelcomeMessage);
            pnlGidView.Dock = DockStyle.Fill;
            pnlGidView.Location = new Point(0, 0);
            pnlGidView.Name = "pnlGidView";
            pnlGidView.Size = new Size(853, 502);
            pnlGidView.TabIndex = 1;
            pnlGidView.Paint += panel5_Paint;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(dgvUserInfo);
            flowLayoutPanel1.Location = new Point(215, 220);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(618, 273);
            flowLayoutPanel1.TabIndex = 8;
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
            dgvUserInfo.Size = new Size(615, 277);
            dgvUserInfo.TabIndex = 1;
            dgvUserInfo.CellContentClick += dgvUserInfo_CellContentClick;
            // 
            // dgvId
            // 
            dgvId.DataPropertyName = "ID";
            dgvId.HeaderText = "ID";
            dgvId.Name = "dgvId";
            dgvId.ReadOnly = true;
            dgvId.Width = 120;
            // 
            // dgvName
            // 
            dgvName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvName.DataPropertyName = "Name";
            dgvName.HeaderText = "Name";
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
            // pnlDashboard
            // 
            pnlDashboard.BackColor = SystemColors.GradientActiveCaption;
            pnlDashboard.Controls.Add(label1);
            pnlDashboard.Controls.Add(btnManageUser);
            pnlDashboard.Controls.Add(btnEmployee);
            pnlDashboard.Controls.Add(btnRoom);
            pnlDashboard.Controls.Add(btnLogout);
            pnlDashboard.Location = new Point(-3, 3);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(212, 496);
            pnlDashboard.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 53);
            label1.Name = "label1";
            label1.Size = new Size(141, 30);
            label1.TabIndex = 0;
            label1.Text = "Admin Panel";
            label1.Click += label1_Click;
            // 
            // btnManageUser
            // 
            btnManageUser.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageUser.Location = new Point(22, 139);
            btnManageUser.Name = "btnManageUser";
            btnManageUser.Size = new Size(153, 40);
            btnManageUser.TabIndex = 7;
            btnManageUser.Text = "Manage User";
            btnManageUser.UseVisualStyleBackColor = true;
            btnManageUser.Click += btnManageUser_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.BackgroundImageLayout = ImageLayout.Zoom;
            btnEmployee.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployee.Location = new Point(22, 217);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(153, 43);
            btnEmployee.TabIndex = 2;
            btnEmployee.Text = "Employees";
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnEmployee_Click_1;
            // 
            // btnRoom
            // 
            btnRoom.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRoom.Location = new Point(22, 308);
            btnRoom.Name = "btnRoom";
            btnRoom.Size = new Size(153, 46);
            btnRoom.TabIndex = 3;
            btnRoom.Text = "Room";
            btnRoom.UseVisualStyleBackColor = true;
            btnRoom.Click += btnRoom_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(22, 400);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(153, 46);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(215, 186);
            label3.Name = "label3";
            label3.Size = new Size(138, 21);
            label3.TabIndex = 0;
            label3.Text = "User Information:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 30);
            label2.TabIndex = 0;
            label2.Text = "DASHBOARD";
            // 
            // txtWelcomeMessage
            // 
            txtWelcomeMessage.AutoSize = true;
            txtWelcomeMessage.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtWelcomeMessage.Location = new Point(215, 102);
            txtWelcomeMessage.Name = "txtWelcomeMessage";
            txtWelcomeMessage.Size = new Size(112, 30);
            txtWelcomeMessage.TabIndex = 1;
            txtWelcomeMessage.Text = "WELCOME";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = SystemColors.ControlDark;
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Location = new Point(215, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(638, 59);
            flowLayoutPanel2.TabIndex = 9;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(859, 508);
            Controls.Add(tableLayoutPanel1);
            Name = "Admin";
            Text = "Admin";
            FormClosed += Admin_FormClosed;
            Load += Admin_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            pnlGidView.ResumeLayout(false);
            pnlGidView.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUserInfo).EndInit();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel4;
        private Panel pnlGidView;
        private Button btnLogout;
        private DataGridView dgvUserInfo;
        private DataGridViewTextBoxColumn dgvId;
        private DataGridViewTextBoxColumn dgvName;
        private DataGridViewTextBoxColumn dgvPassword;
        private DataGridViewTextBoxColumn dgvRole;
        private Button btnProfile;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label txtWelcomeMessage;
        private Button btnRoom;
        private Button btnEmployee;
        private Panel pnlDashboard;
        private Button btnManageUser;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}
namespace HotelManagementSystem
{
    partial class Receptionist
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            pnlGidView = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dgvUserInfo = new DataGridView();
            dgvId = new DataGridViewTextBoxColumn();
            dgvName = new DataGridViewTextBoxColumn();
            dgvPassword = new DataGridViewTextBoxColumn();
            dgvRole = new DataGridViewTextBoxColumn();
            btnManageUser = new Button();
            pnlDashboard = new Panel();
            button2 = new Button();
            button1 = new Button();
            pnlReceptionist = new Label();
            btnRoom = new Button();
            btnLogout = new Button();
            label3 = new Label();
            label2 = new Label();
            txtWelcomeMessage = new Label();
            panel2 = new Panel();
            label4 = new Label();
            panel3 = new Panel();
            txtWelcome = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            pnlGidView.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserInfo).BeginInit();
            pnlDashboard.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(203, 488);
            panel1.TabIndex = 0;
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
            tableLayoutPanel1.Size = new Size(203, 488);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(pnlGidView);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(197, 482);
            panel4.TabIndex = 3;
            // 
            // pnlGidView
            // 
            pnlGidView.Controls.Add(flowLayoutPanel1);
            pnlGidView.Controls.Add(btnManageUser);
            pnlGidView.Controls.Add(pnlDashboard);
            pnlGidView.Controls.Add(label3);
            pnlGidView.Controls.Add(label2);
            pnlGidView.Controls.Add(txtWelcomeMessage);
            pnlGidView.Dock = DockStyle.Fill;
            pnlGidView.Location = new Point(0, 0);
            pnlGidView.Name = "pnlGidView";
            pnlGidView.Size = new Size(197, 482);
            pnlGidView.TabIndex = 1;
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
            // btnManageUser
            // 
            btnManageUser.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageUser.Location = new Point(666, 164);
            btnManageUser.Name = "btnManageUser";
            btnManageUser.Size = new Size(167, 40);
            btnManageUser.TabIndex = 7;
            btnManageUser.Text = "Manage User";
            btnManageUser.UseVisualStyleBackColor = true;
            // 
            // pnlDashboard
            // 
            pnlDashboard.BackColor = SystemColors.GradientActiveCaption;
            pnlDashboard.Controls.Add(button2);
            pnlDashboard.Controls.Add(button1);
            pnlDashboard.Controls.Add(pnlReceptionist);
            pnlDashboard.Controls.Add(btnRoom);
            pnlDashboard.Controls.Add(btnLogout);
            pnlDashboard.Location = new Point(-3, 3);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(212, 496);
            pnlDashboard.TabIndex = 6;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(13, 115);
            button2.Name = "button2";
            button2.Size = new Size(153, 46);
            button2.TabIndex = 7;
            button2.Text = "Check-IN";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 205);
            button1.Name = "button1";
            button1.Size = new Size(153, 46);
            button1.TabIndex = 6;
            button1.Text = "Check-Out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pnlReceptionist
            // 
            pnlReceptionist.AutoSize = true;
            pnlReceptionist.BackColor = SystemColors.ButtonFace;
            pnlReceptionist.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            pnlReceptionist.Location = new Point(13, 49);
            pnlReceptionist.Name = "pnlReceptionist";
            pnlReceptionist.Size = new Size(175, 25);
            pnlReceptionist.TabIndex = 0;
            pnlReceptionist.Text = "Receptionist Panel";
            // 
            // btnRoom
            // 
            btnRoom.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRoom.Location = new Point(12, 302);
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
            btnLogout.Location = new Point(12, 400);
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
            label3.Location = new Point(218, 176);
            label3.Name = "label3";
            label3.Size = new Size(138, 21);
            label3.TabIndex = 0;
            label3.Text = "User Information:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(215, 25);
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
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(label4);
            panel2.Location = new Point(202, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(624, 85);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(7, 28);
            label4.Name = "label4";
            label4.Size = new Size(139, 30);
            label4.TabIndex = 1;
            label4.Text = "DASHBOARD";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.InactiveCaption;
            panel3.Controls.Add(txtWelcome);
            panel3.Location = new Point(204, 87);
            panel3.Name = "panel3";
            panel3.Size = new Size(619, 403);
            panel3.TabIndex = 2;
            // 
            // txtWelcome
            // 
            txtWelcome.AutoSize = true;
            txtWelcome.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtWelcome.Location = new Point(32, 105);
            txtWelcome.Name = "txtWelcome";
            txtWelcome.Size = new Size(112, 30);
            txtWelcome.TabIndex = 2;
            txtWelcome.Text = "WELCOME";
            // 
            // Receptionist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 490);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Receptionist";
            Text = "Receptionist";
            Load += Receptionist_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            pnlGidView.ResumeLayout(false);
            pnlGidView.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUserInfo).EndInit();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel4;
        private Panel pnlGidView;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dgvUserInfo;
        private DataGridViewTextBoxColumn dgvId;
        private DataGridViewTextBoxColumn dgvName;
        private DataGridViewTextBoxColumn dgvPassword;
        private DataGridViewTextBoxColumn dgvRole;
        private Button btnManageUser;
        private Panel pnlDashboard;
        private Label pnlReceptionist;
        private Button btnRoom;
        private Button btnLogout;
        private Button btnProfile;
        private Label label3;
        private Label label2;
        private Label txtWelcomeMessage;
        private Label txtWelcome;
        private Button button2;
        private Button button1;
        private Label label4;
    }
}
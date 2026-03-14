namespace HotelManagementSystem
{
    partial class RRoom
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
            components = new System.ComponentModel.Container();
            toolTip1 = new ToolTip(components);
            panel1 = new Panel();
            dgvUserInfo = new DataGridView();
            dgvRno = new DataGridViewTextBoxColumn();
            dgvRName = new DataGridViewTextBoxColumn();
            dgvRtyp = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            txtSearch = new TextBox();
            btnSearch = new Button();
            label1 = new Label();
            btnShow = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserInfo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvUserInfo);
            panel1.Location = new Point(58, 184);
            panel1.Name = "panel1";
            panel1.Size = new Size(759, 262);
            panel1.TabIndex = 0;
            // 
            // dgvUserInfo
            // 
            dgvUserInfo.AllowUserToAddRows = false;
            dgvUserInfo.AllowUserToDeleteRows = false;
            dgvUserInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserInfo.Columns.AddRange(new DataGridViewColumn[] { dgvRno, dgvRName, dgvRtyp, Column1 });
            dgvUserInfo.Location = new Point(0, 0);
            dgvUserInfo.Name = "dgvUserInfo";
            dgvUserInfo.ReadOnly = true;
            dgvUserInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUserInfo.Size = new Size(759, 259);
            dgvUserInfo.TabIndex = 0;
            // 
            // dgvRno
            // 
            dgvRno.DataPropertyName = "RID";
            dgvRno.HeaderText = "Room Number";
            dgvRno.Name = "dgvRno";
            dgvRno.ReadOnly = true;
            dgvRno.Width = 150;
            // 
            // dgvRName
            // 
            dgvRName.DataPropertyName = "RName";
            dgvRName.HeaderText = "Room Name";
            dgvRName.Name = "dgvRName";
            dgvRName.ReadOnly = true;
            dgvRName.Width = 150;
            // 
            // dgvRtyp
            // 
            dgvRtyp.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRtyp.DataPropertyName = "RType";
            dgvRtyp.HeaderText = "Room Type";
            dgvRtyp.Name = "dgvRtyp";
            dgvRtyp.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "RStatus";
            Column1.HeaderText = "Room Status";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 150;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(245, 88);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(154, 43);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Turquoise;
            btnSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(462, 88);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(136, 43);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(339, 21);
            label1.Name = "label1";
            label1.Size = new Size(211, 32);
            label1.TabIndex = 3;
            label1.Text = "Room Information";
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.Turquoise;
            btnShow.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShow.Location = new Point(681, 135);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(136, 43);
            btnShow.TabIndex = 4;
            btnShow.Text = "Show All";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // RRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(896, 489);
            Controls.Add(btnShow);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(panel1);
            Name = "RRoom";
            Text = "RRoom";
            FormClosed += RRoom_FormClosed;
            Load += RRoom_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUserInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip toolTip1;
        private Panel panel1;
        private DataGridView dgvUserInfo;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label label1;
        private DataGridViewTextBoxColumn dgvRno;
        private DataGridViewTextBoxColumn dgvRName;
        private DataGridViewTextBoxColumn dgvRtyp;
        private DataGridViewTextBoxColumn Column1;
        private Button btnShow;
    }
}
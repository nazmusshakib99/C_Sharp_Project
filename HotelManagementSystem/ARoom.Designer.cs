namespace HotelManagementSystem
{
    partial class ARoom
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            txtRno = new TextBox();
            txtRname = new TextBox();
            txtRtype = new TextBox();
            txtRstatus = new TextBox();
            btnSave = new Button();
            btnRemove = new Button();
            btnClear = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            dgvUserInfo = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            rrf = new DataGridViewTextBoxColumn();
            ttt = new DataGridViewTextBoxColumn();
            Room = new DataGridViewTextBoxColumn();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnShow = new Button();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserInfo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(235, 90);
            label1.Name = "label1";
            label1.Size = new Size(144, 25);
            label1.TabIndex = 0;
            label1.Text = "Room Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(235, 189);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 1;
            label2.Text = "Room Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(245, 274);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 2;
            label3.Text = "Room Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(235, 356);
            label4.Name = "label4";
            label4.Size = new Size(125, 25);
            label4.TabIndex = 3;
            label4.Text = "Room Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(222, 32);
            label5.TabIndex = 4;
            label5.Text = "Room Information";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Location = new Point(383, 23);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(230, 34);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // txtRno
            // 
            txtRno.Location = new Point(227, 136);
            txtRno.Multiline = true;
            txtRno.Name = "txtRno";
            txtRno.Size = new Size(152, 28);
            txtRno.TabIndex = 6;
            // 
            // txtRname
            // 
            txtRname.Location = new Point(227, 229);
            txtRname.Multiline = true;
            txtRname.Name = "txtRname";
            txtRname.Size = new Size(152, 28);
            txtRname.TabIndex = 7;
            // 
            // txtRtype
            // 
            txtRtype.Location = new Point(227, 315);
            txtRtype.Multiline = true;
            txtRtype.Name = "txtRtype";
            txtRtype.Size = new Size(152, 28);
            txtRtype.TabIndex = 8;
            // 
            // txtRstatus
            // 
            txtRstatus.Location = new Point(227, 398);
            txtRstatus.Multiline = true;
            txtRstatus.Name = "txtRstatus";
            txtRstatus.Size = new Size(152, 28);
            txtRstatus.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Aquamarine;
            btnSave.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(569, 136);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(145, 43);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Crimson;
            btnRemove.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(569, 214);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(145, 43);
            btnRemove.TabIndex = 11;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.Window;
            btnClear.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(569, 291);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(145, 43);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(dgvUserInfo);
            flowLayoutPanel2.Location = new Point(254, 486);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(637, 201);
            flowLayoutPanel2.TabIndex = 13;
            // 
            // dgvUserInfo
            // 
            dgvUserInfo.AllowUserToAddRows = false;
            dgvUserInfo.AllowUserToDeleteRows = false;
            dgvUserInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserInfo.Columns.AddRange(new DataGridViewColumn[] { Column1, rrf, ttt, Room });
            dgvUserInfo.Location = new Point(3, 3);
            dgvUserInfo.Name = "dgvUserInfo";
            dgvUserInfo.ReadOnly = true;
            dgvUserInfo.Size = new Size(634, 198);
            dgvUserInfo.TabIndex = 0;
            dgvUserInfo.CellDoubleClick += dgvUserInfo_CellDoubleClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "RID";
            Column1.HeaderText = "Room Number";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 150;
            // 
            // rrf
            // 
            rrf.DataPropertyName = "RName";
            rrf.HeaderText = "Room Name";
            rrf.Name = "rrf";
            rrf.ReadOnly = true;
            rrf.Width = 150;
            // 
            // ttt
            // 
            ttt.DataPropertyName = "RType";
            ttt.HeaderText = "Room Type";
            ttt.Name = "ttt";
            ttt.ReadOnly = true;
            ttt.Width = 150;
            // 
            // Room
            // 
            Room.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Room.DataPropertyName = "RStatus";
            Room.HeaderText = "Room Status";
            Room.Name = "Room";
            Room.ReadOnly = true;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Aquamarine;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(285, 438);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(84, 35);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(395, 445);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(152, 28);
            txtSearch.TabIndex = 15;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.PaleTurquoise;
            btnShow.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShow.Location = new Point(789, 438);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(102, 35);
            btnShow.TabIndex = 16;
            btnShow.Text = "Show All";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // ARoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1101, 736);
            Controls.Add(btnShow);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(btnClear);
            Controls.Add(btnRemove);
            Controls.Add(btnSave);
            Controls.Add(txtRstatus);
            Controls.Add(txtRtype);
            Controls.Add(txtRname);
            Controls.Add(txtRno);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ARoom";
            Text = "ARoom";
            FormClosed += ARoom_FormClosed;
            Load += ARoom_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
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
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txtRno;
        private TextBox txtRname;
        private TextBox txtRtype;
        private TextBox txtRstatus;
        private Button btnSave;
        private Button btnRemove;
        private Button btnClear;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnShow;
        private DataGridView dgvUserInfo;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn rrf;
        private DataGridViewTextBoxColumn ttt;
        private DataGridViewTextBoxColumn Room;
        private PictureBox pictureBox1;
    }
}
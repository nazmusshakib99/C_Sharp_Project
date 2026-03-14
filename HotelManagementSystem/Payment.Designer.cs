namespace HotelManagementSystem
{
    partial class Payment
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
            label2 = new Label();
            btnDelete = new Button();
            button1 = new Button();
            Bank = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(327, 22);
            label2.Name = "label2";
            label2.Size = new Size(276, 32);
            label2.TabIndex = 3;
            label2.Text = "Select Payment Method";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(381, 111);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(182, 47);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Bkash";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 128);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(381, 184);
            button1.Name = "button1";
            button1.Size = new Size(182, 50);
            button1.TabIndex = 27;
            button1.Text = "Nagad";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Bank
            // 
            Bank.BackColor = Color.Aquamarine;
            Bank.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bank.ForeColor = Color.Black;
            Bank.Location = new Point(381, 270);
            Bank.Name = "Bank";
            Bank.Size = new Size(182, 50);
            Bank.TabIndex = 28;
            Bank.Text = "Bank Card";
            Bank.UseVisualStyleBackColor = false;
            Bank.Click += Bank_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LavenderBlush;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(381, 361);
            button3.Name = "button3";
            button3.Size = new Size(182, 44);
            button3.TabIndex = 29;
            button3.Text = "Cash";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(381, 448);
            button4.Name = "button4";
            button4.Size = new Size(182, 50);
            button4.TabIndex = 30;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(975, 572);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(Bank);
            Controls.Add(button1);
            Controls.Add(btnDelete);
            Controls.Add(label2);
            Name = "Payment";
            Text = "Payment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnDelete;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button Bank;
    }
}
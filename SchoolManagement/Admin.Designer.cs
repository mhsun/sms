namespace SchoolManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.studentButton = new System.Windows.Forms.Button();
            this.teacherButton = new System.Windows.Forms.Button();
            this.adminLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentButton
            // 
            this.studentButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.studentButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.studentButton.Location = new System.Drawing.Point(90, 211);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(120, 36);
            this.studentButton.TabIndex = 0;
            this.studentButton.Text = "Student";
            this.studentButton.UseVisualStyleBackColor = false;
            this.studentButton.Click += new System.EventHandler(this.studentButton_Click);
            // 
            // teacherButton
            // 
            this.teacherButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.teacherButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.teacherButton.Location = new System.Drawing.Point(387, 211);
            this.teacherButton.Name = "teacherButton";
            this.teacherButton.Size = new System.Drawing.Size(120, 36);
            this.teacherButton.TabIndex = 3;
            this.teacherButton.Text = "Teacher";
            this.teacherButton.UseVisualStyleBackColor = false;
            this.teacherButton.Click += new System.EventHandler(this.teacherButton_Click);
            // 
            // adminLabel
            // 
            this.adminLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.adminLabel.Image = ((System.Drawing.Image)(resources.GetObject("adminLabel.Image")));
            this.adminLabel.Location = new System.Drawing.Point(57, 288);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(200, 150);
            this.adminLabel.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(90, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "Admin";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(345, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 150);
            this.label1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(387, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Acounts";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(57, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 150);
            this.label2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(345, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 150);
            this.label3.TabIndex = 9;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 534);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.adminLabel);
            this.Controls.Add(this.teacherButton);
            this.Controls.Add(this.studentButton);
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.Text = "WELCOME TO ADMIN PANEL";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button studentButton;
        private System.Windows.Forms.Button teacherButton;
        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
namespace SchoolManagement
{
    partial class TeacherPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherPanel));
            this.label2 = new System.Windows.Forms.Label();
            this.studentButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gradeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(90, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 150);
            this.label2.TabIndex = 10;
            // 
            // studentButton
            // 
            this.studentButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.studentButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.studentButton.Location = new System.Drawing.Point(123, 368);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(120, 36);
            this.studentButton.TabIndex = 9;
            this.studentButton.Text = "Student";
            this.studentButton.UseVisualStyleBackColor = false;
            this.studentButton.Click += new System.EventHandler(this.studentButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(352, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 150);
            this.label1.TabIndex = 11;
            // 
            // gradeButton
            // 
            this.gradeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gradeButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gradeButton.Location = new System.Drawing.Point(385, 368);
            this.gradeButton.Name = "gradeButton";
            this.gradeButton.Size = new System.Drawing.Size(120, 36);
            this.gradeButton.TabIndex = 12;
            this.gradeButton.Text = "Grades";
            this.gradeButton.UseVisualStyleBackColor = false;
            this.gradeButton.Click += new System.EventHandler(this.gradeButton_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(517, 75);
            this.label3.TabIndex = 13;
            this.label3.Text = "WELCOME TO TEACHER\'S PANEL";
            // 
            // TeacherPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 534);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gradeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentButton);
            this.MinimizeBox = false;
            this.Name = "TeacherPanel";
            this.Text = "TeacherPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeacherPanel_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button studentButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gradeButton;
        private System.Windows.Forms.Label label3;
    }
}
namespace SchoolManagement
{
    partial class TeacherFrame
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.uploadButton = new System.Windows.Forms.Button();
            this.textBoxTeacherName = new System.Windows.Forms.TextBox();
            this.textBoxTeacherCell = new System.Windows.Forms.TextBox();
            this.textBoxTeacherEmail = new System.Windows.Forms.TextBox();
            this.textBoxTeacherScale = new System.Windows.Forms.TextBox();
            this.textBoxTeacherId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxTeacher = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(40, 235);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 43;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(431, 33);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(55, 23);
            this.buttonClear.TabIndex = 42;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(375, 32);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(50, 25);
            this.buttonFind.TabIndex = 41;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(1032, 235);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(217, 27);
            this.textBoxSearch.TabIndex = 40;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(747, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(279, 25);
            this.label7.TabIndex = 39;
            this.label7.Text = "Search Your Query Here:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(658, 169);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 36);
            this.buttonDelete.TabIndex = 38;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(532, 169);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 36);
            this.buttonUpdate.TabIndex = 37;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(405, 169);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(100, 36);
            this.buttonInsert.TabIndex = 36;
            this.buttonInsert.Text = "INSERT";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(40, 268);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAdmin.Size = new System.Drawing.Size(1209, 345);
            this.dataGridViewAdmin.TabIndex = 35;
            this.dataGridViewAdmin.Click += new System.EventHandler(this.dataGridViewAdmin_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(916, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 25);
            this.label6.TabIndex = 34;
            this.label6.Text = "Teacher Image:";
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(1108, 194);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(92, 23);
            this.uploadButton.TabIndex = 33;
            this.uploadButton.Text = "Upload Image";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // textBoxTeacherName
            // 
            this.textBoxTeacherName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeacherName.Location = new System.Drawing.Point(189, 80);
            this.textBoxTeacherName.Name = "textBoxTeacherName";
            this.textBoxTeacherName.Size = new System.Drawing.Size(180, 27);
            this.textBoxTeacherName.TabIndex = 31;
            // 
            // textBoxTeacherCell
            // 
            this.textBoxTeacherCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeacherCell.Location = new System.Drawing.Point(710, 27);
            this.textBoxTeacherCell.Name = "textBoxTeacherCell";
            this.textBoxTeacherCell.Size = new System.Drawing.Size(180, 27);
            this.textBoxTeacherCell.TabIndex = 30;
            // 
            // textBoxTeacherEmail
            // 
            this.textBoxTeacherEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeacherEmail.Location = new System.Drawing.Point(710, 116);
            this.textBoxTeacherEmail.Name = "textBoxTeacherEmail";
            this.textBoxTeacherEmail.Size = new System.Drawing.Size(180, 27);
            this.textBoxTeacherEmail.TabIndex = 29;
            // 
            // textBoxTeacherScale
            // 
            this.textBoxTeacherScale.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeacherScale.Location = new System.Drawing.Point(710, 70);
            this.textBoxTeacherScale.Name = "textBoxTeacherScale";
            this.textBoxTeacherScale.Size = new System.Drawing.Size(180, 27);
            this.textBoxTeacherScale.TabIndex = 28;
            // 
            // textBoxTeacherId
            // 
            this.textBoxTeacherId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeacherId.Location = new System.Drawing.Point(189, 30);
            this.textBoxTeacherId.Name = "textBoxTeacherId";
            this.textBoxTeacherId.Size = new System.Drawing.Size(180, 27);
            this.textBoxTeacherId.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Teacher Name:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(551, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Teacher Scale:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(555, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Cell Number:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(548, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Teacher Email:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Teacher ID:";
            // 
            // pictureBoxTeacher
            // 
            this.pictureBoxTeacher.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBoxTeacher.Location = new System.Drawing.Point(1069, 27);
            this.pictureBoxTeacher.Name = "pictureBoxTeacher";
            this.pictureBoxTeacher.Size = new System.Drawing.Size(180, 161);
            this.pictureBoxTeacher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTeacher.TabIndex = 32;
            this.pictureBoxTeacher.TabStop = false;
            // 
            // TeacherFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1284, 641);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.dataGridViewAdmin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.pictureBoxTeacher);
            this.Controls.Add(this.textBoxTeacherName);
            this.Controls.Add(this.textBoxTeacherCell);
            this.Controls.Add(this.textBoxTeacherEmail);
            this.Controls.Add(this.textBoxTeacherScale);
            this.Controls.Add(this.textBoxTeacherId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TeacherFrame";
            this.Text = "WELCOME TO TEACHER PANEL";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeacherFrame_FormClosed);
            this.Load += new System.EventHandler(this.TeacherFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.PictureBox pictureBoxTeacher;
        private System.Windows.Forms.TextBox textBoxTeacherName;
        private System.Windows.Forms.TextBox textBoxTeacherCell;
        private System.Windows.Forms.TextBox textBoxTeacherEmail;
        private System.Windows.Forms.TextBox textBoxTeacherScale;
        private System.Windows.Forms.TextBox textBoxTeacherId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
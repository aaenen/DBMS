namespace 教室信息管理系统
{
    partial class FrmModify
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxClassNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTeacherID = new System.Windows.Forms.TextBox();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.textBoxClassDate = new System.Windows.Forms.TextBox();
            this.textBoxClassroomID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.textBoxSerialNumber);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxClassNumber);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxTeacherID);
            this.panel1.Controls.Add(this.textBoxCourseName);
            this.panel1.Controls.Add(this.textBoxClassDate);
            this.panel1.Controls.Add(this.textBoxClassroomID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonConfirm);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 477);
            this.panel1.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(60)))), ((int)(((byte)(61)))));
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonCancel.Location = new System.Drawing.Point(189, 408);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(118, 39);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "取 消";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(60)))), ((int)(((byte)(61)))));
            this.buttonConfirm.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirm.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.buttonConfirm.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonConfirm.Location = new System.Drawing.Point(30, 408);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(118, 39);
            this.buttonConfirm.TabIndex = 9;
            this.buttonConfirm.Text = "确 认";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelTitle.Location = new System.Drawing.Point(3, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(106, 21);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "修改教室信息";
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(60)))), ((int)(((byte)(61)))));
            this.textBoxSerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSerialNumber.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.textBoxSerialNumber.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxSerialNumber.Location = new System.Drawing.Point(106, 87);
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.ReadOnly = true;
            this.textBoxSerialNumber.Size = new System.Drawing.Size(201, 32);
            this.textBoxSerialNumber.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Location = new System.Drawing.Point(42, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "流水号";
            // 
            // textBoxClassNumber
            // 
            this.textBoxClassNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(60)))), ((int)(((byte)(61)))));
            this.textBoxClassNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxClassNumber.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.textBoxClassNumber.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxClassNumber.Location = new System.Drawing.Point(106, 337);
            this.textBoxClassNumber.Name = "textBoxClassNumber";
            this.textBoxClassNumber.Size = new System.Drawing.Size(201, 32);
            this.textBoxClassNumber.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Location = new System.Drawing.Point(26, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "上课人数";
            // 
            // textBoxTeacherID
            // 
            this.textBoxTeacherID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(60)))), ((int)(((byte)(61)))));
            this.textBoxTeacherID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTeacherID.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.textBoxTeacherID.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxTeacherID.Location = new System.Drawing.Point(106, 237);
            this.textBoxTeacherID.Name = "textBoxTeacherID";
            this.textBoxTeacherID.Size = new System.Drawing.Size(201, 32);
            this.textBoxTeacherID.TabIndex = 25;
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(60)))), ((int)(((byte)(61)))));
            this.textBoxCourseName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCourseName.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.textBoxCourseName.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxCourseName.Location = new System.Drawing.Point(106, 187);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(201, 32);
            this.textBoxCourseName.TabIndex = 24;
            // 
            // textBoxClassDate
            // 
            this.textBoxClassDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(60)))), ((int)(((byte)(61)))));
            this.textBoxClassDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxClassDate.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.textBoxClassDate.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxClassDate.Location = new System.Drawing.Point(106, 287);
            this.textBoxClassDate.Name = "textBoxClassDate";
            this.textBoxClassDate.Size = new System.Drawing.Size(201, 32);
            this.textBoxClassDate.TabIndex = 26;
            // 
            // textBoxClassroomID
            // 
            this.textBoxClassroomID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(60)))), ((int)(((byte)(61)))));
            this.textBoxClassroomID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxClassroomID.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.textBoxClassroomID.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxClassroomID.Location = new System.Drawing.Point(106, 137);
            this.textBoxClassroomID.Name = "textBoxClassroomID";
            this.textBoxClassroomID.Size = new System.Drawing.Size(201, 32);
            this.textBoxClassroomID.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(42, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "教工号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(42, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "课程名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(26, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "上课日期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(26, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "教室编号";
            // 
            // FrmModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(340, 479);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxSerialNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxClassNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTeacherID;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.TextBox textBoxClassDate;
        private System.Windows.Forms.TextBox textBoxClassroomID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
namespace 教室信息管理系统
{
    partial class FrmLogin
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.radioButtonUser = new System.Windows.Forms.RadioButton();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.panelUID = new System.Windows.Forms.Panel();
            this.textBoxUID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRegistered2 = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonRegistered = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonMinimizeTheInterface = new System.Windows.Forms.Button();
            this.buttonCloseTheInterface = new System.Windows.Forms.Button();
            this.labelPassWord = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.pictureBoxAdmin = new System.Windows.Forms.PictureBox();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelUID.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelTitle.Location = new System.Drawing.Point(3, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(138, 21);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "教室信息管理系统";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.panelMain.Controls.Add(this.radioButtonUser);
            this.panelMain.Controls.Add(this.radioButtonAdmin);
            this.panelMain.Controls.Add(this.pictureBoxAdmin);
            this.panelMain.Controls.Add(this.panelUID);
            this.panelMain.Controls.Add(this.buttonRegistered2);
            this.panelMain.Controls.Add(this.buttonReturn);
            this.panelMain.Controls.Add(this.buttonLogin);
            this.panelMain.Controls.Add(this.buttonRegistered);
            this.panelMain.Controls.Add(this.textBoxPassword);
            this.panelMain.Controls.Add(this.textBoxUserName);
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.labelPassWord);
            this.panelMain.Controls.Add(this.labelTitle);
            this.panelMain.Controls.Add(this.labelUserName);
            this.panelMain.Location = new System.Drawing.Point(1, 1);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 486);
            this.panelMain.TabIndex = 10;
            // 
            // radioButtonUser
            // 
            this.radioButtonUser.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonUser.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonUser.FlatAppearance.BorderSize = 0;
            this.radioButtonUser.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack;
            this.radioButtonUser.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.radioButtonUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.radioButtonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonUser.Font = new System.Drawing.Font("微软雅黑", 16.2F);
            this.radioButtonUser.ForeColor = System.Drawing.Color.Aqua;
            this.radioButtonUser.Location = new System.Drawing.Point(0, 424);
            this.radioButtonUser.Name = "radioButtonUser";
            this.radioButtonUser.Size = new System.Drawing.Size(117, 62);
            this.radioButtonUser.TabIndex = 5;
            this.radioButtonUser.Text = "用户";
            this.radioButtonUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonUser.UseVisualStyleBackColor = false;
            this.radioButtonUser.CheckedChanged += new System.EventHandler(this.radioButtonUser_CheckedChanged);
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonAdmin.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonAdmin.Checked = true;
            this.radioButtonAdmin.FlatAppearance.BorderSize = 0;
            this.radioButtonAdmin.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack;
            this.radioButtonAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.radioButtonAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.radioButtonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonAdmin.Font = new System.Drawing.Font("微软雅黑", 16.2F);
            this.radioButtonAdmin.ForeColor = System.Drawing.Color.Aqua;
            this.radioButtonAdmin.Location = new System.Drawing.Point(0, 362);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(117, 62);
            this.radioButtonAdmin.TabIndex = 4;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "管理员";
            this.radioButtonAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonAdmin.UseVisualStyleBackColor = false;
            this.radioButtonAdmin.CheckedChanged += new System.EventHandler(this.radioButtonAdmin_CheckedChanged);
            // 
            // panelUID
            // 
            this.panelUID.Controls.Add(this.textBoxUID);
            this.panelUID.Controls.Add(this.label3);
            this.panelUID.Controls.Add(this.label2);
            this.panelUID.Location = new System.Drawing.Point(199, 286);
            this.panelUID.Name = "panelUID";
            this.panelUID.Size = new System.Drawing.Size(412, 73);
            this.panelUID.TabIndex = 21;
            this.panelUID.Visible = false;
            // 
            // textBoxUID
            // 
            this.textBoxUID.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxUID.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxUID.Location = new System.Drawing.Point(87, 0);
            this.textBoxUID.MaxLength = 16;
            this.textBoxUID.Name = "textBoxUID";
            this.textBoxUID.ReadOnly = true;
            this.textBoxUID.Size = new System.Drawing.Size(262, 29);
            this.textBoxUID.TabIndex = 3;
            this.textBoxUID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(25, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 47);
            this.label3.TabIndex = 11;
            this.label3.Text = "创建账户时，系统会生成一个特有的UID，此UID作为此账号的唯一标识，注册后无法修改";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(25, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "UID";
            // 
            // buttonRegistered2
            // 
            this.buttonRegistered2.BackColor = System.Drawing.Color.Transparent;
            this.buttonRegistered2.FlatAppearance.BorderSize = 0;
            this.buttonRegistered2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonRegistered2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonRegistered2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistered2.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonRegistered2.ForeColor = System.Drawing.Color.Aqua;
            this.buttonRegistered2.Location = new System.Drawing.Point(683, 424);
            this.buttonRegistered2.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRegistered2.Name = "buttonRegistered2";
            this.buttonRegistered2.Size = new System.Drawing.Size(117, 62);
            this.buttonRegistered2.TabIndex = 6;
            this.buttonRegistered2.Text = "注 册";
            this.buttonRegistered2.UseVisualStyleBackColor = false;
            this.buttonRegistered2.Visible = false;
            this.buttonRegistered2.Click += new System.EventHandler(this.buttonRegistered2_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLogin.ForeColor = System.Drawing.Color.Aqua;
            this.buttonLogin.Location = new System.Drawing.Point(683, 424);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(117, 62);
            this.buttonLogin.TabIndex = 18;
            this.buttonLogin.Text = "登 录";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonRegistered
            // 
            this.buttonRegistered.BackColor = System.Drawing.Color.Transparent;
            this.buttonRegistered.FlatAppearance.BorderSize = 0;
            this.buttonRegistered.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonRegistered.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonRegistered.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistered.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonRegistered.ForeColor = System.Drawing.Color.Aqua;
            this.buttonRegistered.Location = new System.Drawing.Point(683, 362);
            this.buttonRegistered.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRegistered.Name = "buttonRegistered";
            this.buttonRegistered.Size = new System.Drawing.Size(117, 62);
            this.buttonRegistered.TabIndex = 7;
            this.buttonRegistered.Text = "注 册";
            this.buttonRegistered.UseVisualStyleBackColor = false;
            this.buttonRegistered.Click += new System.EventHandler(this.buttonRegistered_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxPassword.Location = new System.Drawing.Point(286, 235);
            this.textBoxPassword.MaxLength = 16;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(262, 29);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxUserName.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxUserName.Location = new System.Drawing.Point(286, 183);
            this.textBoxUserName.MaxLength = 16;
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(262, 29);
            this.textBoxUserName.TabIndex = 7;
            this.textBoxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxUserName.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonMinimizeTheInterface);
            this.panel2.Controls.Add(this.buttonCloseTheInterface);
            this.panel2.Location = new System.Drawing.Point(698, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 39);
            this.panel2.TabIndex = 4;
            // 
            // buttonMinimizeTheInterface
            // 
            this.buttonMinimizeTheInterface.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.buttonMinimizeTheInterface.FlatAppearance.BorderSize = 0;
            this.buttonMinimizeTheInterface.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.buttonMinimizeTheInterface.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonMinimizeTheInterface.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimizeTheInterface.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.buttonMinimizeTheInterface.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonMinimizeTheInterface.Location = new System.Drawing.Point(0, 0);
            this.buttonMinimizeTheInterface.Name = "buttonMinimizeTheInterface";
            this.buttonMinimizeTheInterface.Size = new System.Drawing.Size(50, 38);
            this.buttonMinimizeTheInterface.TabIndex = 10;
            this.buttonMinimizeTheInterface.Text = "一";
            this.buttonMinimizeTheInterface.UseVisualStyleBackColor = false;
            this.buttonMinimizeTheInterface.Click += new System.EventHandler(this.buttonMinimizeTheInterface_Click);
            // 
            // buttonCloseTheInterface
            // 
            this.buttonCloseTheInterface.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.buttonCloseTheInterface.FlatAppearance.BorderSize = 0;
            this.buttonCloseTheInterface.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.buttonCloseTheInterface.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonCloseTheInterface.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseTheInterface.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.buttonCloseTheInterface.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonCloseTheInterface.Location = new System.Drawing.Point(50, 0);
            this.buttonCloseTheInterface.Name = "buttonCloseTheInterface";
            this.buttonCloseTheInterface.Size = new System.Drawing.Size(50, 38);
            this.buttonCloseTheInterface.TabIndex = 10;
            this.buttonCloseTheInterface.Text = "×";
            this.buttonCloseTheInterface.UseVisualStyleBackColor = false;
            this.buttonCloseTheInterface.Click += new System.EventHandler(this.buttonCloseTheInterface_Click);
            // 
            // labelPassWord
            // 
            this.labelPassWord.AutoSize = true;
            this.labelPassWord.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelPassWord.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelPassWord.Location = new System.Drawing.Point(221, 238);
            this.labelPassWord.Name = "labelPassWord";
            this.labelPassWord.Size = new System.Drawing.Size(42, 21);
            this.labelPassWord.TabIndex = 6;
            this.labelPassWord.Text = "密码";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelUserName.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelUserName.Location = new System.Drawing.Point(205, 186);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(58, 21);
            this.labelUserName.TabIndex = 5;
            this.labelUserName.Text = "用户名";
            this.labelUserName.Visible = false;
            // 
            // pictureBoxAdmin
            // 
            this.pictureBoxAdmin.BackgroundImage = global::教室信息管理系统.Properties.Resources.管理员__1_;
            this.pictureBoxAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxAdmin.Location = new System.Drawing.Point(304, 56);
            this.pictureBoxAdmin.Name = "pictureBoxAdmin";
            this.pictureBoxAdmin.Size = new System.Drawing.Size(211, 131);
            this.pictureBoxAdmin.TabIndex = 23;
            this.pictureBoxAdmin.TabStop = false;
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.Transparent;
            this.buttonReturn.BackgroundImage = global::教室信息管理系统.Properties.Resources.back_button;
            this.buttonReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonReturn.FlatAppearance.BorderSize = 0;
            this.buttonReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Location = new System.Drawing.Point(2, 0);
            this.buttonReturn.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(50, 38);
            this.buttonReturn.TabIndex = 21;
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Visible = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(802, 488);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLogin_KeyDown);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelUID.ResumeLayout(false);
            this.panelUID.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonCloseTheInterface;
        private System.Windows.Forms.Button buttonMinimizeTheInterface;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelPassWord;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonRegistered;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.TextBox textBoxUID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelUID;
        private System.Windows.Forms.Button buttonRegistered2;
        private System.Windows.Forms.PictureBox pictureBoxAdmin;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
        private System.Windows.Forms.RadioButton radioButtonUser;
    }
}
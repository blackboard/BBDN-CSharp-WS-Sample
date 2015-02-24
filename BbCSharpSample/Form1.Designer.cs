namespace WindowsFormsApplication1
{
    partial class frmGetData
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
            this.grpAuth = new System.Windows.Forms.GroupBox();
            this.txtUserPasswd = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVendorId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtProgramId = new System.Windows.Forms.TextBox();
            this.txtRegPasswd = new System.Windows.Forms.TextBox();
            this.txtSharedSecret = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbRegister = new System.Windows.Forms.CheckBox();
            this.grpLoginType = new System.Windows.Forms.GroupBox();
            this.radioUser = new System.Windows.Forms.RadioButton();
            this.radioTool = new System.Windows.Forms.RadioButton();
            this.txtCourseUser = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCourseList = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpAuth.SuspendLayout();
            this.grpLoginType.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAuth
            // 
            this.grpAuth.Controls.Add(this.txtUserPasswd);
            this.grpAuth.Controls.Add(this.txtUsername);
            this.grpAuth.Controls.Add(this.label6);
            this.grpAuth.Controls.Add(this.label7);
            this.grpAuth.Controls.Add(this.label3);
            this.grpAuth.Controls.Add(this.txtVendorId);
            this.grpAuth.Controls.Add(this.label1);
            this.grpAuth.Controls.Add(this.label2);
            this.grpAuth.Controls.Add(this.txtHost);
            this.grpAuth.Controls.Add(this.txtProgramId);
            this.grpAuth.Controls.Add(this.txtRegPasswd);
            this.grpAuth.Controls.Add(this.txtSharedSecret);
            this.grpAuth.Controls.Add(this.label4);
            this.grpAuth.Controls.Add(this.label5);
            this.grpAuth.Controls.Add(this.cbRegister);
            this.grpAuth.Location = new System.Drawing.Point(12, 73);
            this.grpAuth.Name = "grpAuth";
            this.grpAuth.Size = new System.Drawing.Size(243, 221);
            this.grpAuth.TabIndex = 0;
            this.grpAuth.TabStop = false;
            // 
            // txtUserPasswd
            // 
            this.txtUserPasswd.Enabled = false;
            this.txtUserPasswd.Location = new System.Drawing.Point(131, 193);
            this.txtUserPasswd.Name = "txtUserPasswd";
            this.txtUserPasswd.Size = new System.Drawing.Size(100, 20);
            this.txtUserPasswd.TabIndex = 8;
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(131, 166);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Password:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Username:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Host:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtVendorId
            // 
            this.txtVendorId.Location = new System.Drawing.Point(132, 39);
            this.txtVendorId.Name = "txtVendorId";
            this.txtVendorId.Size = new System.Drawing.Size(100, 20);
            this.txtVendorId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendor Id:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Program Id:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(132, 13);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(100, 20);
            this.txtHost.TabIndex = 1;
            // 
            // txtProgramId
            // 
            this.txtProgramId.Location = new System.Drawing.Point(132, 65);
            this.txtProgramId.Name = "txtProgramId";
            this.txtProgramId.Size = new System.Drawing.Size(100, 20);
            this.txtProgramId.TabIndex = 3;
            // 
            // txtRegPasswd
            // 
            this.txtRegPasswd.Enabled = false;
            this.txtRegPasswd.Location = new System.Drawing.Point(132, 140);
            this.txtRegPasswd.Name = "txtRegPasswd";
            this.txtRegPasswd.Size = new System.Drawing.Size(100, 20);
            this.txtRegPasswd.TabIndex = 6;
            // 
            // txtSharedSecret
            // 
            this.txtSharedSecret.Location = new System.Drawing.Point(132, 91);
            this.txtSharedSecret.Name = "txtSharedSecret";
            this.txtSharedSecret.Size = new System.Drawing.Size(100, 20);
            this.txtSharedSecret.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Registration Password:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Shared Secret:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbRegister
            // 
            this.cbRegister.AutoSize = true;
            this.cbRegister.Location = new System.Drawing.Point(132, 117);
            this.cbRegister.Name = "cbRegister";
            this.cbRegister.Size = new System.Drawing.Size(89, 17);
            this.cbRegister.TabIndex = 5;
            this.cbRegister.Text = "Register Tool";
            this.cbRegister.UseVisualStyleBackColor = true;
            this.cbRegister.CheckedChanged += new System.EventHandler(this.cbRegister_CheckedChanged);
            // 
            // grpLoginType
            // 
            this.grpLoginType.Controls.Add(this.radioUser);
            this.grpLoginType.Controls.Add(this.radioTool);
            this.grpLoginType.Location = new System.Drawing.Point(12, 12);
            this.grpLoginType.Name = "grpLoginType";
            this.grpLoginType.Size = new System.Drawing.Size(243, 55);
            this.grpLoginType.TabIndex = 5;
            this.grpLoginType.TabStop = false;
            this.grpLoginType.Text = "Login Type";
            // 
            // radioUser
            // 
            this.radioUser.AutoSize = true;
            this.radioUser.Location = new System.Drawing.Point(131, 31);
            this.radioUser.Name = "radioUser";
            this.radioUser.Size = new System.Drawing.Size(47, 17);
            this.radioUser.TabIndex = 13;
            this.radioUser.Text = "User";
            this.radioUser.UseVisualStyleBackColor = true;
            this.radioUser.CheckedChanged += new System.EventHandler(this.radioUser_CheckedChanged);
            // 
            // radioTool
            // 
            this.radioTool.AutoSize = true;
            this.radioTool.Checked = true;
            this.radioTool.Location = new System.Drawing.Point(48, 31);
            this.radioTool.Name = "radioTool";
            this.radioTool.Size = new System.Drawing.Size(75, 17);
            this.radioTool.TabIndex = 12;
            this.radioTool.TabStop = true;
            this.radioTool.Text = "Proxy Tool";
            this.radioTool.UseVisualStyleBackColor = true;
            this.radioTool.CheckedChanged += new System.EventHandler(this.radioTool_CheckedChanged);
            // 
            // txtCourseUser
            // 
            this.txtCourseUser.Location = new System.Drawing.Point(611, 42);
            this.txtCourseUser.Name = "txtCourseUser";
            this.txtCourseUser.Size = new System.Drawing.Size(100, 20);
            this.txtCourseUser.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Enter Username toLoad Course List For:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCourseList
            // 
            this.txtCourseList.Enabled = false;
            this.txtCourseList.Location = new System.Drawing.Point(261, 73);
            this.txtCourseList.Multiline = true;
            this.txtCourseList.Name = "txtCourseList";
            this.txtCourseList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCourseList.Size = new System.Drawing.Size(450, 221);
            this.txtCourseList.TabIndex = 30;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(636, 300);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(555, 300);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear &List";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmGetData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 332);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtCourseList);
            this.Controls.Add(this.txtCourseUser);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grpLoginType);
            this.Controls.Add(this.grpAuth);
            this.Name = "frmGetData";
            this.Text = "Get Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAuth.ResumeLayout(false);
            this.grpAuth.PerformLayout();
            this.grpLoginType.ResumeLayout(false);
            this.grpLoginType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAuth;
        private System.Windows.Forms.GroupBox grpLoginType;
        private System.Windows.Forms.RadioButton radioUser;
        private System.Windows.Forms.RadioButton radioTool;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVendorId;
        private System.Windows.Forms.TextBox txtProgramId;
        private System.Windows.Forms.TextBox txtRegPasswd;
        private System.Windows.Forms.TextBox txtSharedSecret;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbRegister;
        private System.Windows.Forms.TextBox txtUserPasswd;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCourseUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCourseList;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
    }
}


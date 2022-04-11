namespace OOP_II_PreLab_2
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.logInTab = new System.Windows.Forms.TabPage();
            this.signInTab = new System.Windows.Forms.TabPage();
            this.registerBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.countryTxt = new System.Windows.Forms.TextBox();
            this.cityTxt = new System.Windows.Forms.TextBox();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.phoneNumberTxt = new System.Windows.Forms.TextBox();
            this.fullnameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.loginUserNameLabel = new System.Windows.Forms.Label();
            this.loginPasswordLabel = new System.Windows.Forms.Label();
            this.loginUsernameTxt = new System.Windows.Forms.TextBox();
            this.loginPasswordTxt = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.logInTab.SuspendLayout();
            this.signInTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.logInTab);
            this.tabControl1.Controls.Add(this.signInTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(532, 521);
            this.tabControl1.TabIndex = 0;
            // 
            // logInTab
            // 
            this.logInTab.Controls.Add(this.loginBtn);
            this.logInTab.Controls.Add(this.loginPasswordTxt);
            this.logInTab.Controls.Add(this.loginUsernameTxt);
            this.logInTab.Controls.Add(this.loginPasswordLabel);
            this.logInTab.Controls.Add(this.loginUserNameLabel);
            this.logInTab.Location = new System.Drawing.Point(4, 22);
            this.logInTab.Name = "logInTab";
            this.logInTab.Padding = new System.Windows.Forms.Padding(3);
            this.logInTab.Size = new System.Drawing.Size(524, 495);
            this.logInTab.TabIndex = 0;
            this.logInTab.Text = "Log In";
            this.logInTab.UseVisualStyleBackColor = true;
            // 
            // signInTab
            // 
            this.signInTab.Controls.Add(this.registerBtn);
            this.signInTab.Controls.Add(this.label8);
            this.signInTab.Controls.Add(this.label7);
            this.signInTab.Controls.Add(this.label6);
            this.signInTab.Controls.Add(this.label5);
            this.signInTab.Controls.Add(this.label4);
            this.signInTab.Controls.Add(this.label3);
            this.signInTab.Controls.Add(this.label2);
            this.signInTab.Controls.Add(this.label1);
            this.signInTab.Controls.Add(this.emailTxt);
            this.signInTab.Controls.Add(this.countryTxt);
            this.signInTab.Controls.Add(this.cityTxt);
            this.signInTab.Controls.Add(this.addressTxt);
            this.signInTab.Controls.Add(this.phoneNumberTxt);
            this.signInTab.Controls.Add(this.fullnameTxt);
            this.signInTab.Controls.Add(this.passwordTxt);
            this.signInTab.Controls.Add(this.usernameTxt);
            this.signInTab.Location = new System.Drawing.Point(4, 22);
            this.signInTab.Name = "signInTab";
            this.signInTab.Padding = new System.Windows.Forms.Padding(3);
            this.signInTab.Size = new System.Drawing.Size(524, 495);
            this.signInTab.TabIndex = 1;
            this.signInTab.Text = "Sign In";
            this.signInTab.UseVisualStyleBackColor = true;
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(172, 406);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(235, 52);
            this.registerBtn.TabIndex = 16;
            this.registerBtn.Text = "Sign In";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "E-mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Country";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fullname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(172, 346);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(235, 20);
            this.emailTxt.TabIndex = 7;
            // 
            // countryTxt
            // 
            this.countryTxt.Location = new System.Drawing.Point(172, 309);
            this.countryTxt.Name = "countryTxt";
            this.countryTxt.Size = new System.Drawing.Size(235, 20);
            this.countryTxt.TabIndex = 6;
            // 
            // cityTxt
            // 
            this.cityTxt.Location = new System.Drawing.Point(172, 273);
            this.cityTxt.Name = "cityTxt";
            this.cityTxt.Size = new System.Drawing.Size(235, 20);
            this.cityTxt.TabIndex = 5;
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(172, 181);
            this.addressTxt.Multiline = true;
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(235, 72);
            this.addressTxt.TabIndex = 4;
            // 
            // phoneNumberTxt
            // 
            this.phoneNumberTxt.Location = new System.Drawing.Point(172, 144);
            this.phoneNumberTxt.Name = "phoneNumberTxt";
            this.phoneNumberTxt.Size = new System.Drawing.Size(235, 20);
            this.phoneNumberTxt.TabIndex = 3;
            // 
            // fullnameTxt
            // 
            this.fullnameTxt.Location = new System.Drawing.Point(172, 109);
            this.fullnameTxt.Name = "fullnameTxt";
            this.fullnameTxt.Size = new System.Drawing.Size(235, 20);
            this.fullnameTxt.TabIndex = 2;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(172, 74);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(235, 20);
            this.passwordTxt.TabIndex = 1;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(172, 38);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(235, 20);
            this.usernameTxt.TabIndex = 0;
            // 
            // loginUserNameLabel
            // 
            this.loginUserNameLabel.AutoSize = true;
            this.loginUserNameLabel.Location = new System.Drawing.Point(115, 165);
            this.loginUserNameLabel.Name = "loginUserNameLabel";
            this.loginUserNameLabel.Size = new System.Drawing.Size(55, 13);
            this.loginUserNameLabel.TabIndex = 0;
            this.loginUserNameLabel.Text = "Username";
            // 
            // loginPasswordLabel
            // 
            this.loginPasswordLabel.AutoSize = true;
            this.loginPasswordLabel.Location = new System.Drawing.Point(117, 220);
            this.loginPasswordLabel.Name = "loginPasswordLabel";
            this.loginPasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.loginPasswordLabel.TabIndex = 1;
            this.loginPasswordLabel.Text = "Password";
            // 
            // loginUsernameTxt
            // 
            this.loginUsernameTxt.Location = new System.Drawing.Point(176, 162);
            this.loginUsernameTxt.Name = "loginUsernameTxt";
            this.loginUsernameTxt.Size = new System.Drawing.Size(206, 20);
            this.loginUsernameTxt.TabIndex = 2;
            // 
            // loginPasswordTxt
            // 
            this.loginPasswordTxt.Location = new System.Drawing.Point(176, 217);
            this.loginPasswordTxt.Name = "loginPasswordTxt";
            this.loginPasswordTxt.PasswordChar = '*';
            this.loginPasswordTxt.Size = new System.Drawing.Size(206, 20);
            this.loginPasswordTxt.TabIndex = 3;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(176, 264);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(206, 51);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Log In";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.loginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 521);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.logInTab.ResumeLayout(false);
            this.logInTab.PerformLayout();
            this.signInTab.ResumeLayout(false);
            this.signInTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage logInTab;
        private System.Windows.Forms.TabPage signInTab;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox countryTxt;
        private System.Windows.Forms.TextBox cityTxt;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.TextBox phoneNumberTxt;
        private System.Windows.Forms.TextBox fullnameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox loginPasswordTxt;
        private System.Windows.Forms.TextBox loginUsernameTxt;
        private System.Windows.Forms.Label loginPasswordLabel;
        private System.Windows.Forms.Label loginUserNameLabel;
    }
}


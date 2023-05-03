namespace PharmacySystem.Client
{
    partial class LoginForm
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
            this.Ender = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.ProductIdTitle = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.EnterPage = new System.Windows.Forms.TabPage();
            this.RegisterPage = new System.Windows.Forms.TabPage();
            this.RegisterResponseInfo = new System.Windows.Forms.Label();
            this.ConfirmPasswordLable = new System.Windows.Forms.Label();
            this.ConfirmPasswordField = new System.Windows.Forms.TextBox();
            this.FullNameLable = new System.Windows.Forms.Label();
            this.NameField = new System.Windows.Forms.TextBox();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.PasswordLable = new System.Windows.Forms.Label();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.EmailLable = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.EnterPage.SuspendLayout();
            this.RegisterPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ender
            // 
            this.Ender.Location = new System.Drawing.Point(281, 204);
            this.Ender.Name = "Ender";
            this.Ender.Size = new System.Drawing.Size(75, 23);
            this.Ender.TabIndex = 0;
            this.Ender.Text = "Enter";
            this.Ender.UseVisualStyleBackColor = true;
            this.Ender.Click += new System.EventHandler(this.Ender_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Пароль";
            // 
            // Password
            // 
            this.Password.AcceptsReturn = true;
            this.Password.Location = new System.Drawing.Point(271, 135);
            this.Password.Name = "Password";
            this.Password.PlaceholderText = "Password";
            this.Password.Size = new System.Drawing.Size(100, 23);
            this.Password.TabIndex = 10;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProductIdTitle
            // 
            this.ProductIdTitle.AutoSize = true;
            this.ProductIdTitle.Location = new System.Drawing.Point(207, 92);
            this.ProductIdTitle.Name = "ProductIdTitle";
            this.ProductIdTitle.Size = new System.Drawing.Size(41, 15);
            this.ProductIdTitle.TabIndex = 9;
            this.ProductIdTitle.Text = "Почта";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(271, 89);
            this.Email.Name = "Email";
            this.Email.PlaceholderText = "Email";
            this.Email.Size = new System.Drawing.Size(100, 23);
            this.Email.TabIndex = 8;
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.EnterPage);
            this.tabControl1.Controls.Add(this.RegisterPage);
            this.tabControl1.Location = new System.Drawing.Point(50, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(648, 347);
            this.tabControl1.TabIndex = 12;
            // 
            // EnterPage
            // 
            this.EnterPage.Controls.Add(this.Email);
            this.EnterPage.Controls.Add(this.Ender);
            this.EnterPage.Controls.Add(this.label1);
            this.EnterPage.Controls.Add(this.Password);
            this.EnterPage.Controls.Add(this.ProductIdTitle);
            this.EnterPage.Location = new System.Drawing.Point(4, 24);
            this.EnterPage.Name = "EnterPage";
            this.EnterPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnterPage.Size = new System.Drawing.Size(640, 319);
            this.EnterPage.TabIndex = 0;
            this.EnterPage.Text = "Вход";
            this.EnterPage.UseVisualStyleBackColor = true;
            // 
            // RegisterPage
            // 
            this.RegisterPage.Controls.Add(this.RegisterResponseInfo);
            this.RegisterPage.Controls.Add(this.ConfirmPasswordLable);
            this.RegisterPage.Controls.Add(this.ConfirmPasswordField);
            this.RegisterPage.Controls.Add(this.FullNameLable);
            this.RegisterPage.Controls.Add(this.NameField);
            this.RegisterPage.Controls.Add(this.EmailField);
            this.RegisterPage.Controls.Add(this.RegisterButton);
            this.RegisterPage.Controls.Add(this.PasswordLable);
            this.RegisterPage.Controls.Add(this.PasswordField);
            this.RegisterPage.Controls.Add(this.EmailLable);
            this.RegisterPage.Location = new System.Drawing.Point(4, 24);
            this.RegisterPage.Name = "RegisterPage";
            this.RegisterPage.Padding = new System.Windows.Forms.Padding(3);
            this.RegisterPage.Size = new System.Drawing.Size(640, 319);
            this.RegisterPage.TabIndex = 1;
            this.RegisterPage.Text = "Регистрация";
            this.RegisterPage.UseVisualStyleBackColor = true;
            // 
            // RegisterResponseInfo
            // 
            this.RegisterResponseInfo.AutoSize = true;
            this.RegisterResponseInfo.Location = new System.Drawing.Point(61, 279);
            this.RegisterResponseInfo.Name = "RegisterResponseInfo";
            this.RegisterResponseInfo.Size = new System.Drawing.Size(0, 15);
            this.RegisterResponseInfo.TabIndex = 21;
            // 
            // ConfirmPasswordLable
            // 
            this.ConfirmPasswordLable.AutoSize = true;
            this.ConfirmPasswordLable.Location = new System.Drawing.Point(150, 170);
            this.ConfirmPasswordLable.Name = "ConfirmPasswordLable";
            this.ConfirmPasswordLable.Size = new System.Drawing.Size(137, 15);
            this.ConfirmPasswordLable.TabIndex = 20;
            this.ConfirmPasswordLable.Text = "Подтверждение пароля";
            // 
            // ConfirmPasswordField
            // 
            this.ConfirmPasswordField.AcceptsReturn = true;
            this.ConfirmPasswordField.Location = new System.Drawing.Point(302, 167);
            this.ConfirmPasswordField.Name = "ConfirmPasswordField";
            this.ConfirmPasswordField.PlaceholderText = "Password";
            this.ConfirmPasswordField.Size = new System.Drawing.Size(100, 23);
            this.ConfirmPasswordField.TabIndex = 19;
            this.ConfirmPasswordField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FullNameLable
            // 
            this.FullNameLable.AutoSize = true;
            this.FullNameLable.Location = new System.Drawing.Point(248, 52);
            this.FullNameLable.Name = "FullNameLable";
            this.FullNameLable.Size = new System.Drawing.Size(31, 15);
            this.FullNameLable.TabIndex = 18;
            this.FullNameLable.Text = "Имя";
            // 
            // NameField
            // 
            this.NameField.AcceptsReturn = true;
            this.NameField.Location = new System.Drawing.Point(302, 49);
            this.NameField.Name = "NameField";
            this.NameField.PlaceholderText = "Name";
            this.NameField.Size = new System.Drawing.Size(100, 23);
            this.NameField.TabIndex = 17;
            this.NameField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EmailField
            // 
            this.EmailField.Location = new System.Drawing.Point(302, 90);
            this.EmailField.Name = "EmailField";
            this.EmailField.PlaceholderText = "Email";
            this.EmailField.Size = new System.Drawing.Size(100, 23);
            this.EmailField.TabIndex = 13;
            this.EmailField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(315, 225);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 12;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // PasswordLable
            // 
            this.PasswordLable.AutoSize = true;
            this.PasswordLable.Location = new System.Drawing.Point(238, 132);
            this.PasswordLable.Name = "PasswordLable";
            this.PasswordLable.Size = new System.Drawing.Size(49, 15);
            this.PasswordLable.TabIndex = 16;
            this.PasswordLable.Text = "Пароль";
            // 
            // PasswordField
            // 
            this.PasswordField.AcceptsReturn = true;
            this.PasswordField.Location = new System.Drawing.Point(302, 129);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PlaceholderText = "Password";
            this.PasswordField.Size = new System.Drawing.Size(100, 23);
            this.PasswordField.TabIndex = 15;
            this.PasswordField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EmailLable
            // 
            this.EmailLable.AutoSize = true;
            this.EmailLable.Location = new System.Drawing.Point(238, 93);
            this.EmailLable.Name = "EmailLable";
            this.EmailLable.Size = new System.Drawing.Size(41, 15);
            this.EmailLable.TabIndex = 14;
            this.EmailLable.Text = "Почта";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.tabControl1.ResumeLayout(false);
            this.EnterPage.ResumeLayout(false);
            this.EnterPage.PerformLayout();
            this.RegisterPage.ResumeLayout(false);
            this.RegisterPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Ender;
        private Label label1;
        private TextBox Password;
        private Label ProductIdTitle;
        private TextBox Email;
        private TabControl tabControl1;
        private TabPage EnterPage;
        private TabPage RegisterPage;
        private TextBox EmailField;
        private Button RegisterButton;
        private Label PasswordLable;
        private TextBox PasswordField;
        private Label EmailLable;
        private Label ConfirmPasswordLable;
        private TextBox ConfirmPasswordField;
        private Label FullNameLable;
        private TextBox NameField;
        private Label RegisterResponseInfo;
    }
}
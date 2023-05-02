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
            Ender = new Button();
            label1 = new Label();
            Password = new TextBox();
            ProductIdTitle = new Label();
            Email = new TextBox();
            tabControl1 = new TabControl();
            EnterPage = new TabPage();
            RegisterPage = new TabPage();
            EmailField = new TextBox();
            RegisterButton = new Button();
            PasswordLable = new Label();
            PasswordField = new TextBox();
            EmailLable = new Label();
            FullNameLable = new Label();
            NameField = new TextBox();
            ConfirmPasswordLable = new Label();
            ConfirmPasswordField = new TextBox();
            tabControl1.SuspendLayout();
            EnterPage.SuspendLayout();
            RegisterPage.SuspendLayout();
            SuspendLayout();
            // 
            // Ender
            // 
            Ender.Location = new Point(281, 204);
            Ender.Name = "Ender";
            Ender.Size = new Size(75, 23);
            Ender.TabIndex = 0;
            Ender.Text = "Enter";
            Ender.UseVisualStyleBackColor = true;
            Ender.Click += Ender_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 143);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 11;
            label1.Text = "Пароль";
            // 
            // Password
            // 
            Password.AcceptsReturn = true;
            Password.Location = new Point(271, 135);
            Password.Name = "Password";
            Password.PlaceholderText = "Password";
            Password.Size = new Size(100, 23);
            Password.TabIndex = 10;
            Password.TextAlign = HorizontalAlignment.Center;
            // 
            // ProductIdTitle
            // 
            ProductIdTitle.AutoSize = true;
            ProductIdTitle.Location = new Point(207, 92);
            ProductIdTitle.Name = "ProductIdTitle";
            ProductIdTitle.Size = new Size(41, 15);
            ProductIdTitle.TabIndex = 9;
            ProductIdTitle.Text = "Почта";
            ProductIdTitle.Click += ProductIdTitle_Click;
            // 
            // Email
            // 
            Email.Location = new Point(271, 89);
            Email.Name = "Email";
            Email.PlaceholderText = "Email";
            Email.Size = new Size(100, 23);
            Email.TabIndex = 8;
            Email.TextAlign = HorizontalAlignment.Center;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(EnterPage);
            tabControl1.Controls.Add(RegisterPage);
            tabControl1.Location = new Point(50, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(648, 347);
            tabControl1.TabIndex = 12;
            // 
            // EnterPage
            // 
            EnterPage.Controls.Add(Email);
            EnterPage.Controls.Add(Ender);
            EnterPage.Controls.Add(label1);
            EnterPage.Controls.Add(Password);
            EnterPage.Controls.Add(ProductIdTitle);
            EnterPage.Location = new Point(4, 24);
            EnterPage.Name = "EnterPage";
            EnterPage.Padding = new Padding(3);
            EnterPage.Size = new Size(640, 319);
            EnterPage.TabIndex = 0;
            EnterPage.Text = "Вход";
            EnterPage.UseVisualStyleBackColor = true;
            // 
            // RegisterPage
            // 
            RegisterPage.Controls.Add(ConfirmPasswordLable);
            RegisterPage.Controls.Add(ConfirmPasswordField);
            RegisterPage.Controls.Add(FullNameLable);
            RegisterPage.Controls.Add(NameField);
            RegisterPage.Controls.Add(EmailField);
            RegisterPage.Controls.Add(RegisterButton);
            RegisterPage.Controls.Add(PasswordLable);
            RegisterPage.Controls.Add(PasswordField);
            RegisterPage.Controls.Add(EmailLable);
            RegisterPage.Location = new Point(4, 24);
            RegisterPage.Name = "RegisterPage";
            RegisterPage.Padding = new Padding(3);
            RegisterPage.Size = new Size(640, 319);
            RegisterPage.TabIndex = 1;
            RegisterPage.Text = "Регистрация";
            RegisterPage.UseVisualStyleBackColor = true;
            // 
            // EmailField
            // 
            EmailField.Location = new Point(302, 90);
            EmailField.Name = "EmailField";
            EmailField.PlaceholderText = "Email";
            EmailField.Size = new Size(100, 23);
            EmailField.TabIndex = 13;
            EmailField.TextAlign = HorizontalAlignment.Center;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(315, 225);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(75, 23);
            RegisterButton.TabIndex = 12;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // PasswordLable
            // 
            PasswordLable.AutoSize = true;
            PasswordLable.Location = new Point(238, 132);
            PasswordLable.Name = "PasswordLable";
            PasswordLable.Size = new Size(49, 15);
            PasswordLable.TabIndex = 16;
            PasswordLable.Text = "Пароль";
            PasswordLable.Click += label2_Click;
            // 
            // PasswordField
            // 
            PasswordField.AcceptsReturn = true;
            PasswordField.Location = new Point(302, 129);
            PasswordField.Name = "PasswordField";
            PasswordField.PlaceholderText = "Password";
            PasswordField.Size = new Size(100, 23);
            PasswordField.TabIndex = 15;
            PasswordField.TextAlign = HorizontalAlignment.Center;
            // 
            // EmailLable
            // 
            EmailLable.AutoSize = true;
            EmailLable.Location = new Point(238, 93);
            EmailLable.Name = "EmailLable";
            EmailLable.Size = new Size(41, 15);
            EmailLable.TabIndex = 14;
            EmailLable.Text = "Почта";
            // 
            // FullNameLable
            // 
            FullNameLable.AutoSize = true;
            FullNameLable.Location = new Point(248, 52);
            FullNameLable.Name = "FullNameLable";
            FullNameLable.Size = new Size(31, 15);
            FullNameLable.TabIndex = 18;
            FullNameLable.Text = "Имя";
            // 
            // NameField
            // 
            NameField.AcceptsReturn = true;
            NameField.Location = new Point(302, 49);
            NameField.Name = "NameField";
            NameField.PlaceholderText = "Name";
            NameField.Size = new Size(100, 23);
            NameField.TabIndex = 17;
            NameField.TextAlign = HorizontalAlignment.Center;
            // 
            // ConfirmPasswordLable
            // 
            ConfirmPasswordLable.AutoSize = true;
            ConfirmPasswordLable.Location = new Point(150, 170);
            ConfirmPasswordLable.Name = "ConfirmPasswordLable";
            ConfirmPasswordLable.Size = new Size(137, 15);
            ConfirmPasswordLable.TabIndex = 20;
            ConfirmPasswordLable.Text = "Подтверждение пароля";
            // 
            // ConfirmPasswordField
            // 
            ConfirmPasswordField.AcceptsReturn = true;
            ConfirmPasswordField.Location = new Point(302, 167);
            ConfirmPasswordField.Name = "ConfirmPasswordField";
            ConfirmPasswordField.PlaceholderText = "Password";
            ConfirmPasswordField.Size = new Size(100, 23);
            ConfirmPasswordField.TabIndex = 19;
            ConfirmPasswordField.TextAlign = HorizontalAlignment.Center;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "LoginForm";
            Text = "LoginForm";
            tabControl1.ResumeLayout(false);
            EnterPage.ResumeLayout(false);
            EnterPage.PerformLayout();
            RegisterPage.ResumeLayout(false);
            RegisterPage.PerformLayout();
            ResumeLayout(false);
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
    }
}
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
            this.SuspendLayout();
            // 
            // Ender
            // 
            this.Ender.Location = new System.Drawing.Point(331, 282);
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
            this.label1.Location = new System.Drawing.Point(227, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Пароль";
            // 
            // Password
            // 
            this.Password.AcceptsReturn = true;
            this.Password.Location = new System.Drawing.Point(331, 142);
            this.Password.Name = "Password";
            this.Password.PlaceholderText = "Password";
            this.Password.Size = new System.Drawing.Size(100, 23);
            this.Password.TabIndex = 10;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProductIdTitle
            // 
            this.ProductIdTitle.AutoSize = true;
            this.ProductIdTitle.Location = new System.Drawing.Point(227, 107);
            this.ProductIdTitle.Name = "ProductIdTitle";
            this.ProductIdTitle.Size = new System.Drawing.Size(41, 15);
            this.ProductIdTitle.TabIndex = 9;
            this.ProductIdTitle.Text = "Почта";
            this.ProductIdTitle.Click += new System.EventHandler(this.ProductIdTitle_Click);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(331, 104);
            this.Email.Name = "Email";
            this.Email.PlaceholderText = "Email";
            this.Email.Size = new System.Drawing.Size(100, 23);
            this.Email.TabIndex = 8;
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.ProductIdTitle);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Ender);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Ender;
        private Label label1;
        private TextBox Password;
        private Label ProductIdTitle;
        private TextBox Email;
    }
}
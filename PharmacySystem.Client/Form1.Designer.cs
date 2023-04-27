namespace PharmacySystem.Client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Administration = new System.Windows.Forms.Button();
            this.ProductId = new System.Windows.Forms.TextBox();
            this.ProductIdTitle = new System.Windows.Forms.Label();
            this.OrderButton = new System.Windows.Forms.Button();
            this.OrderCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PharmacyId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.Mode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Administration
            // 
            this.Administration.Location = new System.Drawing.Point(625, 12);
            this.Administration.Name = "Administration";
            this.Administration.Size = new System.Drawing.Size(163, 23);
            this.Administration.TabIndex = 0;
            this.Administration.Text = "Администрирование";
            this.Administration.UseVisualStyleBackColor = true;
            this.Administration.Click += new System.EventHandler(this.Administration_Click);
            // 
            // ProductId
            // 
            this.ProductId.Location = new System.Drawing.Point(116, 54);
            this.ProductId.Name = "ProductId";
            this.ProductId.PlaceholderText = "ProductId";
            this.ProductId.Size = new System.Drawing.Size(100, 23);
            this.ProductId.TabIndex = 1;
            this.ProductId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProductIdTitle
            // 
            this.ProductIdTitle.AutoSize = true;
            this.ProductIdTitle.Location = new System.Drawing.Point(12, 57);
            this.ProductIdTitle.Name = "ProductIdTitle";
            this.ProductIdTitle.Size = new System.Drawing.Size(98, 15);
            this.ProductIdTitle.TabIndex = 2;
            this.ProductIdTitle.Text = "Номер продукта";
            this.ProductIdTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // OrderButton
            // 
            this.OrderButton.Location = new System.Drawing.Point(141, 173);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(75, 23);
            this.OrderButton.TabIndex = 3;
            this.OrderButton.Text = "Order";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.Order_Click);
            // 
            // OrderCount
            // 
            this.OrderCount.Location = new System.Drawing.Point(116, 92);
            this.OrderCount.Name = "OrderCount";
            this.OrderCount.PlaceholderText = "Count";
            this.OrderCount.Size = new System.Drawing.Size(100, 23);
            this.OrderCount.TabIndex = 4;
            this.OrderCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Количество";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // PharmacyId
            // 
            this.PharmacyId.Location = new System.Drawing.Point(116, 131);
            this.PharmacyId.Name = "PharmacyId";
            this.PharmacyId.PlaceholderText = "PharmacyId";
            this.PharmacyId.Size = new System.Drawing.Size(100, 23);
            this.PharmacyId.TabIndex = 6;
            this.PharmacyId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Номер аптеки";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.ErrorMessage.ForeColor = System.Drawing.Color.Brown;
            this.ErrorMessage.Location = new System.Drawing.Point(32, 423);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(0, 15);
            this.ErrorMessage.TabIndex = 8;
            this.ErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Mode
            // 
            this.Mode.AutoSize = true;
            this.Mode.ForeColor = System.Drawing.Color.Green;
            this.Mode.Location = new System.Drawing.Point(628, 369);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(30, 15);
            this.Mode.TabIndex = 9;
            this.Mode.Text = "User";
            this.Mode.Click += new System.EventHandler(this.Mode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Mode);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PharmacyId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderCount);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.ProductIdTitle);
            this.Controls.Add(this.ProductId);
            this.Controls.Add(this.Administration);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Administration;
        private TextBox ProductId;
        private Label ProductIdTitle;
        private Button OrderButton;
        private TextBox OrderCount;
        private Label label1;
        private TextBox PharmacyId;
        private Label label2;
        private Label ErrorMessage;
        private Label Mode;
    }
}
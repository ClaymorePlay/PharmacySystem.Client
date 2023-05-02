namespace PharmacySystem.Client
{
    partial class MainForm
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
            Administration = new Button();
            ProductId = new TextBox();
            ProductIdTitle = new Label();
            OrderButton = new Button();
            OrderCount = new TextBox();
            label1 = new Label();
            PharmacyId = new TextBox();
            label2 = new Label();
            ErrorMessage = new Label();
            Mode = new Label();
            ProductList = new ListBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // Administration
            // 
            Administration.Location = new Point(625, 12);
            Administration.Name = "Administration";
            Administration.Size = new Size(163, 23);
            Administration.TabIndex = 0;
            Administration.Text = "Администрирование";
            Administration.UseVisualStyleBackColor = true;
            Administration.Click += Administration_Click;
            // 
            // ProductId
            // 
            ProductId.Location = new Point(116, 54);
            ProductId.Name = "ProductId";
            ProductId.PlaceholderText = "ProductId";
            ProductId.Size = new Size(100, 23);
            ProductId.TabIndex = 1;
            ProductId.TextAlign = HorizontalAlignment.Center;
            // 
            // ProductIdTitle
            // 
            ProductIdTitle.AutoSize = true;
            ProductIdTitle.Location = new Point(12, 57);
            ProductIdTitle.Name = "ProductIdTitle";
            ProductIdTitle.Size = new Size(98, 15);
            ProductIdTitle.TabIndex = 2;
            ProductIdTitle.Text = "Номер продукта";
            ProductIdTitle.Click += label1_Click;
            // 
            // OrderButton
            // 
            OrderButton.Location = new Point(141, 173);
            OrderButton.Name = "OrderButton";
            OrderButton.Size = new Size(75, 23);
            OrderButton.TabIndex = 3;
            OrderButton.Text = "Order";
            OrderButton.UseVisualStyleBackColor = true;
            OrderButton.Click += Order_Click;
            // 
            // OrderCount
            // 
            OrderCount.Location = new Point(116, 92);
            OrderCount.Name = "OrderCount";
            OrderCount.PlaceholderText = "Count";
            OrderCount.Size = new Size(100, 23);
            OrderCount.TabIndex = 4;
            OrderCount.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 95);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 5;
            label1.Text = "Количество";
            label1.Click += label1_Click_1;
            // 
            // PharmacyId
            // 
            PharmacyId.Location = new Point(116, 131);
            PharmacyId.Name = "PharmacyId";
            PharmacyId.PlaceholderText = "PharmacyId";
            PharmacyId.Size = new Size(100, 23);
            PharmacyId.TabIndex = 6;
            PharmacyId.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 134);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 7;
            label2.Text = "Номер аптеки";
            label2.Click += label2_Click;
            // 
            // ErrorMessage
            // 
            ErrorMessage.AutoSize = true;
            ErrorMessage.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            ErrorMessage.ForeColor = Color.Brown;
            ErrorMessage.Location = new Point(32, 423);
            ErrorMessage.Name = "ErrorMessage";
            ErrorMessage.Size = new Size(0, 15);
            ErrorMessage.TabIndex = 8;
            ErrorMessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Mode
            // 
            Mode.AutoSize = true;
            Mode.ForeColor = Color.Green;
            Mode.Location = new Point(628, 369);
            Mode.Name = "Mode";
            Mode.Size = new Size(30, 15);
            Mode.TabIndex = 9;
            Mode.Text = "User";
            Mode.Click += Mode_Click;
            // 
            // ProductList
            // 
            ProductList.FormattingEnabled = true;
            ProductList.ItemHeight = 15;
            ProductList.Location = new Point(317, 54);
            ProductList.Name = "ProductList";
            ProductList.Size = new Size(120, 94);
            ProductList.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(317, 36);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 11;
            label3.Text = "Список продуктов";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(ProductList);
            Controls.Add(Mode);
            Controls.Add(ErrorMessage);
            Controls.Add(label2);
            Controls.Add(PharmacyId);
            Controls.Add(label1);
            Controls.Add(OrderCount);
            Controls.Add(OrderButton);
            Controls.Add(ProductIdTitle);
            Controls.Add(ProductId);
            Controls.Add(Administration);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
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
        private ListBox ProductList;
        private Label label3;
    }
}
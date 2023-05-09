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
            this.Administration = new System.Windows.Forms.Button();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.Mode = new System.Windows.Forms.Label();
            this.NameInfo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PharmacyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProducerColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GetProductsButton = new System.Windows.Forms.Button();
            this.SelectPharmacy = new System.Windows.Forms.ComboBox();
            this.PharmacyGetButton = new System.Windows.Forms.Button();
            this.ProducerGetButton = new System.Windows.Forms.Button();
            this.SelectProducers = new System.Windows.Forms.ComboBox();
            this.InTrashButton = new System.Windows.Forms.Button();
            this.CountField = new System.Windows.Forms.TextBox();
            this.ProductIdField = new System.Windows.Forms.TextBox();
            this.lable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenBucket = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.PageField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.Administration.Click += new System.EventHandler(this.Administration_Click_1);
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
            this.Mode.Size = new System.Drawing.Size(0, 15);
            this.Mode.TabIndex = 9;
            // 
            // NameInfo
            // 
            this.NameInfo.AutoSize = true;
            this.NameInfo.ForeColor = System.Drawing.Color.Green;
            this.NameInfo.Location = new System.Drawing.Point(628, 329);
            this.NameInfo.Name = "NameInfo";
            this.NameInfo.Size = new System.Drawing.Size(0, 15);
            this.NameInfo.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.ProductId,
            this.PharmacyColumn,
            this.ProducerColumn,
            this.PriceColumn,
            this.CountColumn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(650, 197);
            this.dataGridView1.TabIndex = 13;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Название";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Номер товара";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            // 
            // PharmacyColumn
            // 
            this.PharmacyColumn.HeaderText = "Аптека";
            this.PharmacyColumn.Name = "PharmacyColumn";
            this.PharmacyColumn.ReadOnly = true;
            // 
            // ProducerColumn
            // 
            this.ProducerColumn.HeaderText = "Производитель";
            this.ProducerColumn.Name = "ProducerColumn";
            this.ProducerColumn.ReadOnly = true;
            // 
            // PriceColumn
            // 
            this.PriceColumn.HeaderText = "Цена";
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            // 
            // CountColumn
            // 
            this.CountColumn.HeaderText = "Количество";
            this.CountColumn.Name = "CountColumn";
            this.CountColumn.ReadOnly = true;
            // 
            // GetProductsButton
            // 
            this.GetProductsButton.BackColor = System.Drawing.Color.Green;
            this.GetProductsButton.ForeColor = System.Drawing.Color.White;
            this.GetProductsButton.Location = new System.Drawing.Point(534, 320);
            this.GetProductsButton.Name = "GetProductsButton";
            this.GetProductsButton.Size = new System.Drawing.Size(128, 23);
            this.GetProductsButton.TabIndex = 14;
            this.GetProductsButton.Text = "Обновить список";
            this.GetProductsButton.UseVisualStyleBackColor = false;
            this.GetProductsButton.Click += new System.EventHandler(this.GetProductsButton_Click);
            // 
            // SelectPharmacy
            // 
            this.SelectPharmacy.FormattingEnabled = true;
            this.SelectPharmacy.Location = new System.Drawing.Point(12, 71);
            this.SelectPharmacy.Name = "SelectPharmacy";
            this.SelectPharmacy.Size = new System.Drawing.Size(173, 23);
            this.SelectPharmacy.TabIndex = 15;
            // 
            // PharmacyGetButton
            // 
            this.PharmacyGetButton.Location = new System.Drawing.Point(12, 42);
            this.PharmacyGetButton.Name = "PharmacyGetButton";
            this.PharmacyGetButton.Size = new System.Drawing.Size(173, 23);
            this.PharmacyGetButton.TabIndex = 16;
            this.PharmacyGetButton.Text = "Получить аптеки";
            this.PharmacyGetButton.UseVisualStyleBackColor = true;
            this.PharmacyGetButton.Click += new System.EventHandler(this.PharmacyGetButton_Click);
            // 
            // ProducerGetButton
            // 
            this.ProducerGetButton.Location = new System.Drawing.Point(209, 42);
            this.ProducerGetButton.Name = "ProducerGetButton";
            this.ProducerGetButton.Size = new System.Drawing.Size(173, 23);
            this.ProducerGetButton.TabIndex = 18;
            this.ProducerGetButton.Text = "Получить производителей";
            this.ProducerGetButton.UseVisualStyleBackColor = true;
            this.ProducerGetButton.Click += new System.EventHandler(this.ProducerGetButton_Click);
            // 
            // SelectProducers
            // 
            this.SelectProducers.FormattingEnabled = true;
            this.SelectProducers.Location = new System.Drawing.Point(209, 71);
            this.SelectProducers.Name = "SelectProducers";
            this.SelectProducers.Size = new System.Drawing.Size(173, 23);
            this.SelectProducers.TabIndex = 17;
            // 
            // InTrashButton
            // 
            this.InTrashButton.Location = new System.Drawing.Point(65, 415);
            this.InTrashButton.Name = "InTrashButton";
            this.InTrashButton.Size = new System.Drawing.Size(75, 23);
            this.InTrashButton.TabIndex = 19;
            this.InTrashButton.Text = "В корзину";
            this.InTrashButton.UseVisualStyleBackColor = true;
            this.InTrashButton.Click += new System.EventHandler(this.InBucketButton_Click);
            // 
            // CountField
            // 
            this.CountField.Location = new System.Drawing.Point(55, 386);
            this.CountField.Name = "CountField";
            this.CountField.Size = new System.Drawing.Size(100, 23);
            this.CountField.TabIndex = 20;
            // 
            // ProductIdField
            // 
            this.ProductIdField.Location = new System.Drawing.Point(55, 342);
            this.ProductIdField.Name = "ProductIdField";
            this.ProductIdField.Size = new System.Drawing.Size(100, 23);
            this.ProductIdField.TabIndex = 21;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(55, 324);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(85, 15);
            this.lable.TabIndex = 22;
            this.lable.Text = "Номер товара";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Количество";
            // 
            // OpenBucket
            // 
            this.OpenBucket.Location = new System.Drawing.Point(224, 419);
            this.OpenBucket.Name = "OpenBucket";
            this.OpenBucket.Size = new System.Drawing.Size(126, 23);
            this.OpenBucket.TabIndex = 24;
            this.OpenBucket.Text = "Открыть корзину";
            this.OpenBucket.UseVisualStyleBackColor = true;
            this.OpenBucket.Click += new System.EventHandler(this.OpenBucket_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(397, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Страница";
            // 
            // PageField
            // 
            this.PageField.Location = new System.Drawing.Point(397, 71);
            this.PageField.Name = "PageField";
            this.PageField.Size = new System.Drawing.Size(100, 23);
            this.PageField.TabIndex = 26;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PageField);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.OpenBucket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.ProductIdField);
            this.Controls.Add(this.CountField);
            this.Controls.Add(this.InTrashButton);
            this.Controls.Add(this.ProducerGetButton);
            this.Controls.Add(this.SelectProducers);
            this.Controls.Add(this.PharmacyGetButton);
            this.Controls.Add(this.SelectPharmacy);
            this.Controls.Add(this.GetProductsButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NameInfo);
            this.Controls.Add(this.Mode);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.Administration);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Administration;
        private Label ErrorMessage;
        private Label Mode;
        private Label NameInfo;
        private DataGridView dataGridView1;
        private Button GetProductsButton;
        private ComboBox SelectPharmacy;
        private Button PharmacyGetButton;
        private Button ProducerGetButton;
        private ComboBox SelectProducers;
        private Button InTrashButton;
        private TextBox CountField;
        private TextBox ProductIdField;
        private Label lable;
        private Label label1;
        private Button OpenBucket;
        private Label label10;
        private TextBox PageField;
        private DataGridViewButtonColumn NameColumn;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn PharmacyColumn;
        private DataGridViewButtonColumn ProducerColumn;
        private DataGridViewButtonColumn PriceColumn;
        private DataGridViewTextBoxColumn CountColumn;
    }
}
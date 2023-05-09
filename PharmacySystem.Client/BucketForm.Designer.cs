namespace PharmacySystem.Client
{
    partial class BucketForm
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
            BucketProductsList = new DataGridView();
            NameColumn = new DataGridViewTextBoxColumn();
            CountColumn = new DataGridViewTextBoxColumn();
            ProductId = new DataGridViewTextBoxColumn();
            PriceColumn = new DataGridViewTextBoxColumn();
            Buy = new Button();
            PriceResult = new Label();
            SumPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)BucketProductsList).BeginInit();
            SuspendLayout();
            // 
            // BucketProductsList
            // 
            BucketProductsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BucketProductsList.Columns.AddRange(new DataGridViewColumn[] { NameColumn, CountColumn, ProductId, PriceColumn });
            BucketProductsList.Location = new Point(12, 12);
            BucketProductsList.Name = "BucketProductsList";
            BucketProductsList.ReadOnly = true;
            BucketProductsList.RowTemplate.Height = 25;
            BucketProductsList.Size = new Size(450, 386);
            BucketProductsList.TabIndex = 0;
            BucketProductsList.RowsAdded += BucketProductsList_RowsUpdated;
            BucketProductsList.RowsRemoved += BucketProductsList_RowsUpdated;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Название товара";
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            // 
            // CountColumn
            // 
            CountColumn.HeaderText = "Количество";
            CountColumn.Name = "CountColumn";
            CountColumn.ReadOnly = true;
            // 
            // ProductId
            // 
            ProductId.HeaderText = "Номер товара";
            ProductId.Name = "ProductId";
            ProductId.ReadOnly = true;
            // 
            // PriceColumn
            // 
            PriceColumn.HeaderText = "Цена";
            PriceColumn.Name = "PriceColumn";
            PriceColumn.ReadOnly = true;
            // 
            // Buy
            // 
            Buy.BackColor = Color.Green;
            Buy.ForeColor = SystemColors.ControlLight;
            Buy.Location = new Point(570, 90);
            Buy.Name = "Buy";
            Buy.Size = new Size(75, 23);
            Buy.TabIndex = 1;
            Buy.Text = "Купить";
            Buy.UseVisualStyleBackColor = false;
            Buy.Click += BuyClickEvent;
            // 
            // PriceResult
            // 
            PriceResult.AutoSize = true;
            PriceResult.Location = new Point(570, 55);
            PriceResult.Name = "PriceResult";
            PriceResult.Size = new Size(73, 15);
            PriceResult.TabIndex = 2;
            PriceResult.Text = "Стоимость: ";
            // 
            // SumPrice
            // 
            SumPrice.AutoSize = true;
            SumPrice.Location = new Point(586, 72);
            SumPrice.Name = "SumPrice";
            SumPrice.Size = new Size(0, 15);
            SumPrice.TabIndex = 3;
            // 
            // BucketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SumPrice);
            Controls.Add(PriceResult);
            Controls.Add(Buy);
            Controls.Add(BucketProductsList);
            Name = "BucketForm";
            Text = "BucketForm";
            this.FormClosing += BucketForm_FormClosed; ;
            ((System.ComponentModel.ISupportInitialize)BucketProductsList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        

        #endregion

        private DataGridView BucketProductsList;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn CountColumn;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn PriceColumn;
        private Button Buy;
        private Label PriceResult;
        private Label SumPrice;
    }
}
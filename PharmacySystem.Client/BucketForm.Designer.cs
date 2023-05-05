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
            this.BucketProductsList = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buy = new System.Windows.Forms.Button();
            this.PriceResult = new System.Windows.Forms.Label();
            this.SumPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BucketProductsList)).BeginInit();
            this.SuspendLayout();
            // 
            // BucketProductsList
            // 
            this.BucketProductsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BucketProductsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.CountColumn,
            this.ProductId,
            this.PriceColumn});
            this.BucketProductsList.Location = new System.Drawing.Point(12, 12);
            this.BucketProductsList.Name = "BucketProductsList";
            this.BucketProductsList.ReadOnly = true;
            this.BucketProductsList.RowTemplate.Height = 25;
            this.BucketProductsList.Size = new System.Drawing.Size(450, 386);
            this.BucketProductsList.TabIndex = 0;
            this.BucketProductsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BucketProductsList_CellContentClick);
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Название товара";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // CountColumn
            // 
            this.CountColumn.HeaderText = "Количество";
            this.CountColumn.Name = "CountColumn";
            this.CountColumn.ReadOnly = true;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Номер товара";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            // 
            // PriceColumn
            // 
            this.PriceColumn.HeaderText = "Цена";
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            // 
            // Buy
            // 
            this.Buy.BackColor = System.Drawing.Color.Green;
            this.Buy.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Buy.Location = new System.Drawing.Point(570, 90);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(75, 23);
            this.Buy.TabIndex = 1;
            this.Buy.Text = "Купить";
            this.Buy.UseVisualStyleBackColor = false;
            // 
            // PriceResult
            // 
            this.PriceResult.AutoSize = true;
            this.PriceResult.Location = new System.Drawing.Point(570, 55);
            this.PriceResult.Name = "PriceResult";
            this.PriceResult.Size = new System.Drawing.Size(73, 15);
            this.PriceResult.TabIndex = 2;
            this.PriceResult.Text = "Стоимость: ";
            this.PriceResult.Click += new System.EventHandler(this.PriceResult_Click);
            // 
            // SumPrice
            // 
            this.SumPrice.AutoSize = true;
            this.SumPrice.Location = new System.Drawing.Point(586, 72);
            this.SumPrice.Name = "SumPrice";
            this.SumPrice.Size = new System.Drawing.Size(0, 15);
            this.SumPrice.TabIndex = 3;
            // 
            // BucketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SumPrice);
            this.Controls.Add(this.PriceResult);
            this.Controls.Add(this.Buy);
            this.Controls.Add(this.BucketProductsList);
            this.Name = "BucketForm";
            this.Text = "BucketForm";
            ((System.ComponentModel.ISupportInitialize)(this.BucketProductsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
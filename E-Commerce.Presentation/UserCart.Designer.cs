namespace E_Commerce.Presentation
{
    partial class UserCart
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
            dataGridView1 = new DataGridView();
            Product = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            Remove = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Product, Quantity, price, Remove });
            dataGridView1.Location = new Point(79, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(443, 150);
            dataGridView1.TabIndex = 0;
            // 
            // Product
            // 
            Product.HeaderText = "Product";
            Product.Name = "Product";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            // 
            // price
            // 
            price.HeaderText = "price";
            price.Name = "price";
            // 
            // Remove
            // 
            Remove.HeaderText = "Remove";
            Remove.Name = "Remove";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Location = new Point(185, 261);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(158, 100);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // UserCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView1);
            Name = "UserCart";
            Text = "UserCart";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn Remove;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
namespace E_Commerce.Presentation
{
    partial class Admin_product
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
            label1 = new Label();
            CategoryIdBox = new TextBox();
            label13 = new Label();
            ProductQuantityBox = new TextBox();
            label12 = new Label();
            ProductPriceBox = new TextBox();
            label11 = new Label();
            ProductNameBox = new TextBox();
            DeleteProduct = new Label();
            EditProduct = new Label();
            AddProduct = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(54, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(825, 358);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.CausesValidation = false;
            label1.Location = new Point(924, 392);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 31;
            label1.Text = "Category Id";
            // 
            // CategoryIdBox
            // 
            CategoryIdBox.CausesValidation = false;
            CategoryIdBox.Location = new Point(920, 437);
            CategoryIdBox.Name = "CategoryIdBox";
            CategoryIdBox.Size = new Size(100, 27);
            CategoryIdBox.TabIndex = 30;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(924, 265);
            label13.Name = "label13";
            label13.Size = new Size(120, 20);
            label13.TabIndex = 29;
            label13.Text = "Product Quantity";
            // 
            // ProductQuantityBox
            // 
            ProductQuantityBox.Location = new Point(924, 310);
            ProductQuantityBox.Name = "ProductQuantityBox";
            ProductQuantityBox.Size = new Size(100, 27);
            ProductQuantityBox.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(924, 154);
            label12.Name = "label12";
            label12.Size = new Size(96, 20);
            label12.TabIndex = 27;
            label12.Text = "Product Price";
            // 
            // ProductPriceBox
            // 
            ProductPriceBox.Location = new Point(924, 195);
            ProductPriceBox.Name = "ProductPriceBox";
            ProductPriceBox.Size = new Size(100, 27);
            ProductPriceBox.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(924, 46);
            label11.Name = "label11";
            label11.Size = new Size(104, 20);
            label11.TabIndex = 25;
            label11.Text = "Product Name";
            // 
            // ProductNameBox
            // 
            ProductNameBox.Location = new Point(928, 89);
            ProductNameBox.Name = "ProductNameBox";
            ProductNameBox.Size = new Size(100, 27);
            ProductNameBox.TabIndex = 24;
            // 
            // DeleteProduct
            // 
            DeleteProduct.AutoSize = true;
            DeleteProduct.Location = new Point(525, 424);
            DeleteProduct.Name = "DeleteProduct";
            DeleteProduct.Size = new Size(53, 20);
            DeleteProduct.TabIndex = 34;
            DeleteProduct.Text = "Delete";
            DeleteProduct.Click += DeleteProduct_Click;
            // 
            // EditProduct
            // 
            EditProduct.AutoSize = true;
            EditProduct.Location = new Point(427, 424);
            EditProduct.Name = "EditProduct";
            EditProduct.Size = new Size(35, 20);
            EditProduct.TabIndex = 33;
            EditProduct.Text = "Edit";
            EditProduct.Click += EditProduct_Click;
            // 
            // AddProduct
            // 
            AddProduct.AutoSize = true;
            AddProduct.Location = new Point(260, 424);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(37, 20);
            AddProduct.TabIndex = 32;
            AddProduct.Text = "Add";
            AddProduct.Click += AddProduct_Click;
            // 
            // Admin_product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            //BackgroundImage = Properties.Resources.blog_11;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1156, 548);
            Controls.Add(DeleteProduct);
            Controls.Add(EditProduct);
            Controls.Add(AddProduct);
            Controls.Add(label1);
            Controls.Add(CategoryIdBox);
            Controls.Add(label13);
            Controls.Add(ProductQuantityBox);
            Controls.Add(label12);
            Controls.Add(ProductPriceBox);
            Controls.Add(label11);
            Controls.Add(ProductNameBox);
            Controls.Add(dataGridView1);
            Name = "Admin_product";
            Text = "Admin_product";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox CategoryIdBox;
        private Label label13;
        private TextBox ProductQuantityBox;
        private Label label12;
        private TextBox ProductPriceBox;
        private Label label11;
        private TextBox ProductNameBox;
        private Label DeleteProduct;
        private Label EditProduct;
        private Label AddProduct;
    }
}
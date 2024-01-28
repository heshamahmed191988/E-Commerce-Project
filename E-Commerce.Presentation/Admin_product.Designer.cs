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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_product));
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
            label4 = new Label();
            PTorders = new Button();
            PTlogout = new Button();
            PTcategory = new Button();
            PTproduct = new Button();
            PTregister = new Button();
            BTlogin = new Button();
            Navebar = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Navebar.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(268, 98);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(734, 268);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.CausesValidation = false;
            label1.Location = new Point(16, 273);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 31;
            label1.Text = "Category Id";
            // 
            // CategoryIdBox
            // 
            CategoryIdBox.CausesValidation = false;
            CategoryIdBox.Location = new Point(16, 290);
            CategoryIdBox.Margin = new Padding(3, 2, 3, 2);
            CategoryIdBox.Name = "CategoryIdBox";
            CategoryIdBox.Size = new Size(210, 23);
            CategoryIdBox.TabIndex = 30;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(16, 219);
            label13.Name = "label13";
            label13.Size = new Size(98, 15);
            label13.TabIndex = 29;
            label13.Text = "Product Quantity";
            // 
            // ProductQuantityBox
            // 
            ProductQuantityBox.Location = new Point(16, 236);
            ProductQuantityBox.Margin = new Padding(3, 2, 3, 2);
            ProductQuantityBox.Name = "ProductQuantityBox";
            ProductQuantityBox.Size = new Size(210, 23);
            ProductQuantityBox.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 163);
            label12.Name = "label12";
            label12.Size = new Size(78, 15);
            label12.TabIndex = 27;
            label12.Text = "Product Price";
            // 
            // ProductPriceBox
            // 
            ProductPriceBox.Location = new Point(16, 180);
            ProductPriceBox.Margin = new Padding(3, 2, 3, 2);
            ProductPriceBox.Name = "ProductPriceBox";
            ProductPriceBox.Size = new Size(210, 23);
            ProductPriceBox.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 106);
            label11.Name = "label11";
            label11.Size = new Size(84, 15);
            label11.TabIndex = 25;
            label11.Text = "Product Name";
            // 
            // ProductNameBox
            // 
            ProductNameBox.Location = new Point(16, 123);
            ProductNameBox.Margin = new Padding(3, 2, 3, 2);
            ProductNameBox.Name = "ProductNameBox";
            ProductNameBox.Size = new Size(210, 23);
            ProductNameBox.TabIndex = 24;
            // 
            // DeleteProduct
            // 
            DeleteProduct.AutoSize = true;
            DeleteProduct.Location = new Point(625, 387);
            DeleteProduct.Name = "DeleteProduct";
            DeleteProduct.Size = new Size(40, 15);
            DeleteProduct.TabIndex = 34;
            DeleteProduct.Text = "Delete";
            DeleteProduct.Click += DeleteProduct_Click;
            // 
            // EditProduct
            // 
            EditProduct.AutoSize = true;
            EditProduct.Location = new Point(540, 387);
            EditProduct.Name = "EditProduct";
            EditProduct.Size = new Size(27, 15);
            EditProduct.TabIndex = 33;
            EditProduct.Text = "Edit";
            EditProduct.Click += EditProduct_Click;
            // 
            // AddProduct
            // 
            AddProduct.AutoSize = true;
            AddProduct.Location = new Point(475, 387);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(29, 15);
            AddProduct.TabIndex = 32;
            AddProduct.Text = "Add";
            AddProduct.Click += AddProduct_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Enabled = false;
            label4.Font = new Font("MV Boli", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(48, 12);
            label4.Name = "label4";
            label4.Size = new Size(120, 25);
            label4.TabIndex = 20;
            label4.Text = "Logo/Name";
            // 
            // PTorders
            // 
            PTorders.BackColor = Color.Black;
            PTorders.FlatAppearance.BorderSize = 0;
            PTorders.FlatStyle = FlatStyle.Flat;
            PTorders.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PTorders.ForeColor = Color.White;
            PTorders.Image = (Image)resources.GetObject("PTorders.Image");
            PTorders.ImageAlign = ContentAlignment.MiddleLeft;
            PTorders.Location = new Point(480, 6);
            PTorders.Name = "PTorders";
            PTorders.Size = new Size(118, 38);
            PTorders.TabIndex = 18;
            PTorders.Text = "  Orders";
            PTorders.UseVisualStyleBackColor = false;
            PTorders.Click += PTorders_Click;
            // 
            // PTlogout
            // 
            PTlogout.BackColor = Color.Black;
            PTlogout.FlatAppearance.BorderSize = 0;
            PTlogout.FlatStyle = FlatStyle.Flat;
            PTlogout.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PTlogout.ForeColor = Color.White;
            PTlogout.Image = (Image)resources.GetObject("PTlogout.Image");
            PTlogout.ImageAlign = ContentAlignment.MiddleLeft;
            PTlogout.Location = new Point(979, 7);
            PTlogout.Name = "PTlogout";
            PTlogout.Size = new Size(34, 38);
            PTlogout.TabIndex = 19;
            PTlogout.UseVisualStyleBackColor = false;
            PTlogout.Click += PTlogout_Click;
            // 
            // PTcategory
            // 
            PTcategory.BackColor = Color.Black;
            PTcategory.FlatAppearance.BorderSize = 0;
            PTcategory.FlatStyle = FlatStyle.Flat;
            PTcategory.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PTcategory.ForeColor = Color.White;
            PTcategory.Image = (Image)resources.GetObject("PTcategory.Image");
            PTcategory.ImageAlign = ContentAlignment.MiddleLeft;
            PTcategory.Location = new Point(358, 5);
            PTcategory.Name = "PTcategory";
            PTcategory.Size = new Size(118, 38);
            PTcategory.TabIndex = 17;
            PTcategory.Text = "   Category";
            PTcategory.UseVisualStyleBackColor = false;
            PTcategory.Click += PTcategory_Click;
            // 
            // PTproduct
            // 
            PTproduct.BackColor = Color.Black;
            PTproduct.FlatAppearance.BorderSize = 0;
            PTproduct.FlatStyle = FlatStyle.Flat;
            PTproduct.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PTproduct.ForeColor = Color.Red;
            PTproduct.Image = (Image)resources.GetObject("PTproduct.Image");
            PTproduct.ImageAlign = ContentAlignment.MiddleLeft;
            PTproduct.Location = new Point(234, 5);
            PTproduct.Name = "PTproduct";
            PTproduct.Size = new Size(118, 38);
            PTproduct.TabIndex = 16;
            PTproduct.Text = "  Product";
            PTproduct.UseVisualStyleBackColor = false;
            PTproduct.Click += PTproduct_Click;
            // 
            // PTregister
            // 
            PTregister.BackColor = Color.Black;
            PTregister.FlatAppearance.BorderSize = 0;
            PTregister.FlatStyle = FlatStyle.Flat;
            PTregister.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PTregister.ForeColor = Color.White;
            PTregister.Image = (Image)resources.GetObject("PTregister.Image");
            PTregister.ImageAlign = ContentAlignment.MiddleLeft;
            PTregister.Location = new Point(855, 6);
            PTregister.Name = "PTregister";
            PTregister.Size = new Size(118, 38);
            PTregister.TabIndex = 15;
            PTregister.Text = "  Register";
            PTregister.UseVisualStyleBackColor = false;
            PTregister.Click += PTregister_Click;
            // 
            // BTlogin
            // 
            BTlogin.BackColor = Color.Black;
            BTlogin.FlatAppearance.BorderSize = 0;
            BTlogin.FlatStyle = FlatStyle.Flat;
            BTlogin.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTlogin.ForeColor = Color.White;
            BTlogin.Image = (Image)resources.GetObject("BTlogin.Image");
            BTlogin.ImageAlign = ContentAlignment.MiddleLeft;
            BTlogin.Location = new Point(753, 5);
            BTlogin.Name = "BTlogin";
            BTlogin.Size = new Size(92, 38);
            BTlogin.TabIndex = 14;
            BTlogin.Text = "LogIn";
            BTlogin.TextAlign = ContentAlignment.MiddleRight;
            BTlogin.UseVisualStyleBackColor = false;
            BTlogin.Click += BTlogin_Click;
            // 
            // Navebar
            // 
            Navebar.BackColor = Color.Black;
            Navebar.Controls.Add(label4);
            Navebar.Controls.Add(PTorders);
            Navebar.Controls.Add(PTlogout);
            Navebar.Controls.Add(PTcategory);
            Navebar.Controls.Add(PTproduct);
            Navebar.Controls.Add(PTregister);
            Navebar.Controls.Add(BTlogin);
            Navebar.Dock = DockStyle.Top;
            Navebar.Location = new Point(0, 0);
            Navebar.Name = "Navebar";
            Navebar.Size = new Size(1025, 48);
            Navebar.TabIndex = 35;
            // 
            // Admin_product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1025, 461);
            Controls.Add(Navebar);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "Admin_product";
            Text = "Admin_product";
            Load += Admin_product_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Navebar.ResumeLayout(false);
            Navebar.PerformLayout();
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
        private Label label4;
        private Button PTorders;
        private Button PTlogout;
        private Button PTcategory;
        private Button PTproduct;
        private Button PTregister;
        private Button BTlogin;
        private Panel Navebar;
    }
}
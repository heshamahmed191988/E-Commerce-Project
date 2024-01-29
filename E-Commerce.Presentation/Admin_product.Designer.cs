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
            label2 = new Label();
            ImageBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Navebar.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(306, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(839, 357);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.CausesValidation = false;
            label1.Location = new Point(18, 364);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 31;
            label1.Text = "Category Id";
            // 
            // CategoryIdBox
            // 
            CategoryIdBox.CausesValidation = false;
            CategoryIdBox.Location = new Point(18, 387);
            CategoryIdBox.Name = "CategoryIdBox";
            CategoryIdBox.Size = new Size(239, 27);
            CategoryIdBox.TabIndex = 30;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(18, 292);
            label13.Name = "label13";
            label13.Size = new Size(120, 20);
            label13.TabIndex = 29;
            label13.Text = "Product Quantity";
            // 
            // ProductQuantityBox
            // 
            ProductQuantityBox.Location = new Point(18, 315);
            ProductQuantityBox.Name = "ProductQuantityBox";
            ProductQuantityBox.Size = new Size(239, 27);
            ProductQuantityBox.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(18, 217);
            label12.Name = "label12";
            label12.Size = new Size(96, 20);
            label12.TabIndex = 27;
            label12.Text = "Product Price";
            // 
            // ProductPriceBox
            // 
            ProductPriceBox.Location = new Point(18, 240);
            ProductPriceBox.Name = "ProductPriceBox";
            ProductPriceBox.Size = new Size(239, 27);
            ProductPriceBox.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(18, 141);
            label11.Name = "label11";
            label11.Size = new Size(104, 20);
            label11.TabIndex = 25;
            label11.Text = "Product Name";
            // 
            // ProductNameBox
            // 
            ProductNameBox.Location = new Point(18, 164);
            ProductNameBox.Name = "ProductNameBox";
            ProductNameBox.Size = new Size(239, 27);
            ProductNameBox.TabIndex = 24;
            // 
            // DeleteProduct
            // 
            DeleteProduct.AutoSize = true;
            DeleteProduct.Location = new Point(714, 516);
            DeleteProduct.Name = "DeleteProduct";
            DeleteProduct.Size = new Size(53, 20);
            DeleteProduct.TabIndex = 34;
            DeleteProduct.Text = "Delete";
            DeleteProduct.Click += DeleteProduct_Click;
            // 
            // EditProduct
            // 
            EditProduct.AutoSize = true;
            EditProduct.Location = new Point(617, 516);
            EditProduct.Name = "EditProduct";
            EditProduct.Size = new Size(35, 20);
            EditProduct.TabIndex = 33;
            EditProduct.Text = "Edit";
            EditProduct.Click += EditProduct_Click;
            // 
            // AddProduct
            // 
            AddProduct.AutoSize = true;
            AddProduct.Location = new Point(543, 516);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(37, 20);
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
            label4.Location = new Point(55, 16);
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
            PTorders.Location = new Point(549, 8);
            PTorders.Margin = new Padding(3, 4, 3, 4);
            PTorders.Name = "PTorders";
            PTorders.Size = new Size(135, 51);
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
            PTlogout.Location = new Point(1119, 9);
            PTlogout.Margin = new Padding(3, 4, 3, 4);
            PTlogout.Name = "PTlogout";
            PTlogout.Size = new Size(39, 51);
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
            PTcategory.Location = new Point(409, 7);
            PTcategory.Margin = new Padding(3, 4, 3, 4);
            PTcategory.Name = "PTcategory";
            PTcategory.Size = new Size(135, 51);
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
            PTproduct.Location = new Point(267, 7);
            PTproduct.Margin = new Padding(3, 4, 3, 4);
            PTproduct.Name = "PTproduct";
            PTproduct.Size = new Size(135, 51);
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
            PTregister.Location = new Point(977, 8);
            PTregister.Margin = new Padding(3, 4, 3, 4);
            PTregister.Name = "PTregister";
            PTregister.Size = new Size(135, 51);
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
            BTlogin.Location = new Point(861, 7);
            BTlogin.Margin = new Padding(3, 4, 3, 4);
            BTlogin.Name = "BTlogin";
            BTlogin.Size = new Size(105, 51);
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
            Navebar.Margin = new Padding(3, 4, 3, 4);
            Navebar.Name = "Navebar";
            Navebar.Size = new Size(1171, 64);
            Navebar.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.CausesValidation = false;
            label2.Location = new Point(18, 434);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 37;
            label2.Text = "Image";
            // 
            // ImageBox
            // 
            ImageBox.CausesValidation = false;
            ImageBox.Location = new Point(18, 457);
            ImageBox.Name = "ImageBox";
            ImageBox.Size = new Size(239, 27);
            ImageBox.TabIndex = 36;
            // 
            // Admin_product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1171, 615);
            Controls.Add(label2);
            Controls.Add(ImageBox);
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
        private Label label2;
        private TextBox ImageBox;
    }
}
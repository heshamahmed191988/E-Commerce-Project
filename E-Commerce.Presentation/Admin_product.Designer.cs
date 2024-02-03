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
            PTorders = new Button();
            PTlogout = new Button();
            PTcategory = new Button();
            PTproduct = new Button();
            PTregister = new Button();
            BTlogin = new Button();
            Navebar = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            Image = new Label();
            ImageBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Navebar.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(397, 140);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(613, 296);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView2_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.CausesValidation = false;
            label1.Font = new Font("Stencil", 12F, FontStyle.Bold);
            label1.Location = new Point(23, 316);
            label1.Name = "label1";
            label1.Size = new Size(125, 19);
            label1.TabIndex = 31;
            label1.Text = "Category Id:";
            // 
            // CategoryIdBox
            // 
            CategoryIdBox.CausesValidation = false;
            CategoryIdBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CategoryIdBox.Location = new Point(222, 311);
            CategoryIdBox.Margin = new Padding(3, 2, 3, 2);
            CategoryIdBox.Name = "CategoryIdBox";
            CategoryIdBox.Size = new Size(138, 29);
            CategoryIdBox.TabIndex = 30;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Stencil", 12F, FontStyle.Bold);
            label13.Location = new Point(23, 264);
            label13.Name = "label13";
            label13.Size = new Size(184, 19);
            label13.TabIndex = 29;
            label13.Text = "Product Quantity:";
            // 
            // ProductQuantityBox
            // 
            ProductQuantityBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductQuantityBox.Location = new Point(222, 259);
            ProductQuantityBox.Margin = new Padding(3, 2, 3, 2);
            ProductQuantityBox.Name = "ProductQuantityBox";
            ProductQuantityBox.Size = new Size(138, 29);
            ProductQuantityBox.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Stencil", 12F, FontStyle.Bold);
            label12.Location = new Point(23, 211);
            label12.Name = "label12";
            label12.Size = new Size(148, 19);
            label12.TabIndex = 27;
            label12.Text = "Product Price:";
            // 
            // ProductPriceBox
            // 
            ProductPriceBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductPriceBox.Location = new Point(222, 206);
            ProductPriceBox.Margin = new Padding(3, 2, 3, 2);
            ProductPriceBox.Name = "ProductPriceBox";
            ProductPriceBox.Size = new Size(138, 29);
            ProductPriceBox.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Stencil", 12F, FontStyle.Bold);
            label11.Location = new Point(23, 123);
            label11.Name = "label11";
            label11.Size = new Size(145, 19);
            label11.TabIndex = 25;
            label11.Text = "Product Name:";
            // 
            // ProductNameBox
            // 
            ProductNameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductNameBox.Location = new Point(23, 153);
            ProductNameBox.Margin = new Padding(3, 2, 3, 2);
            ProductNameBox.Name = "ProductNameBox";
            ProductNameBox.Size = new Size(337, 29);
            ProductNameBox.TabIndex = 24;
            // 
            // DeleteProduct
            // 
            DeleteProduct.BackColor = Color.Transparent;
            DeleteProduct.ForeColor = SystemColors.ControlText;
            DeleteProduct.Location = new Point(-9, -11);
            DeleteProduct.Name = "DeleteProduct";
            DeleteProduct.Size = new Size(102, 40);
            DeleteProduct.TabIndex = 34;
            DeleteProduct.Click += DeleteProduct_Click;
            // 
            // EditProduct
            // 
            EditProduct.BackColor = Color.Transparent;
            EditProduct.Font = new Font("Arial Rounded MT Bold", 14.25F);
            EditProduct.ForeColor = Color.White;
            EditProduct.Location = new Point(-3, 0);
            EditProduct.Name = "EditProduct";
            EditProduct.Size = new Size(102, 40);
            EditProduct.TabIndex = 33;
            EditProduct.Text = "Edit";
            EditProduct.TextAlign = ContentAlignment.MiddleCenter;
            EditProduct.Click += EditProduct_Click;
            // 
            // AddProduct
            // 
            AddProduct.BackColor = Color.Transparent;
            AddProduct.Font = new Font("Arial Rounded MT Bold", 14.25F);
            AddProduct.ForeColor = Color.White;
            AddProduct.Location = new Point(3, 0);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(102, 40);
            AddProduct.TabIndex = 32;
            AddProduct.Text = "Add";
            AddProduct.TextAlign = ContentAlignment.MiddleCenter;
            AddProduct.Click += AddProduct_Click;
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
            Navebar.Controls.Add(button2);
            Navebar.Controls.Add(button1);
            Navebar.Controls.Add(PTorders);
            Navebar.Controls.Add(PTlogout);
            Navebar.Controls.Add(PTcategory);
            Navebar.Controls.Add(PTproduct);
            Navebar.Controls.Add(PTregister);
            Navebar.Controls.Add(BTlogin);
            Navebar.Dock = DockStyle.Top;
            Navebar.Location = new Point(0, 0);
            Navebar.Name = "Navebar";
            Navebar.Size = new Size(1032, 48);
            Navebar.TabIndex = 35;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(585, 5);
            button2.Name = "button2";
            button2.Size = new Size(118, 38);
            button2.TabIndex = 41;
            button2.Text = "Stack";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImage = Properties.Resources.logo1;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 6);
            button1.Name = "button1";
            button1.Size = new Size(118, 38);
            button1.TabIndex = 21;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(AddProduct);
            panel3.Location = new Point(28, 396);
            panel3.Name = "panel3";
            panel3.Size = new Size(102, 40);
            panel3.TabIndex = 38;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(EditProduct);
            panel2.Location = new Point(139, 396);
            panel2.Name = "panel2";
            panel2.Size = new Size(102, 40);
            panel2.TabIndex = 37;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(DeleteProduct);
            panel1.Location = new Point(267, 396);
            panel1.Name = "panel1";
            panel1.Size = new Size(102, 40);
            panel1.TabIndex = 36;
            // 
            // Image
            // 
            Image.AutoSize = true;
            Image.BackColor = Color.Transparent;
            Image.CausesValidation = false;
            Image.Font = new Font("Stencil", 12F, FontStyle.Bold);
            Image.Location = new Point(23, 359);
            Image.Name = "Image";
            Image.Size = new Size(119, 19);
            Image.TabIndex = 39;
            Image.Text = "Image Path:";
            // 
            // ImageBox
            // 
            ImageBox.CausesValidation = false;
            ImageBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ImageBox.Location = new Point(222, 354);
            ImageBox.Margin = new Padding(3, 2, 3, 2);
            ImageBox.Name = "ImageBox";
            ImageBox.Size = new Size(138, 29);
            ImageBox.TabIndex = 40;
            // 
            // Admin_product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1032, 499);
            Controls.Add(ImageBox);
            Controls.Add(Image);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Navebar);
            Controls.Add(label1);
            Controls.Add(CategoryIdBox);
            Controls.Add(label13);
            Controls.Add(ProductQuantityBox);
            Controls.Add(label12);
            Controls.Add(ProductPriceBox);
            Controls.Add(label11);
            Controls.Add(ProductNameBox);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Admin_product";
            Text = "Admin_product";
            Load += Admin_product_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Navebar.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
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
        private Button PTorders;
        private Button PTlogout;
        private Button PTcategory;
        private Button PTproduct;
        private Button PTregister;
        private Button BTlogin;
        private Panel Navebar;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Label Image;
        private TextBox ImageBox;
        private Button button1;
        private Button button2;
    }
}
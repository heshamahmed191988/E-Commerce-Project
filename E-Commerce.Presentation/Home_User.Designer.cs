namespace E_Commerce.Presentation
{
    partial class Home_User
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_User));
            ProductdataGridView = new DataGridView();
            ProductName = new Label();
            Price = new Label();
            product = new GroupBox();
            productQuantity = new ComboBox();
            label1 = new Label();
            Add_Card = new Button();
            Pro_Price = new Label();
            Pro_Name = new Label();
            textBox1 = new TextBox();
            Filter_by_Name = new Label();
            label2 = new Label();
            userDTOBindingSource = new BindingSource(components);
            button1 = new Button();
            Navebar = new Panel();
            label4 = new Label();
            PTorders = new Button();
            PTlogout = new Button();
            PTcart = new Button();
            PTproduct = new Button();
            PTregister = new Button();
            BTlogin = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductdataGridView).BeginInit();
            product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userDTOBindingSource).BeginInit();
            Navebar.SuspendLayout();
            SuspendLayout();
            // 
            // ProductdataGridView
            // 
            ProductdataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            ProductdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductdataGridView.Location = new Point(313, 86);
            ProductdataGridView.Name = "ProductdataGridView";
            ProductdataGridView.Size = new Size(687, 446);
            ProductdataGridView.TabIndex = 0;
            ProductdataGridView.CellClick += ProductdataGridView_CellClick;
            ProductdataGridView.CellContentClick += ProductdataGridView_CellContentClick;
            // 
            // ProductName
            // 
            ProductName.AutoSize = true;
            ProductName.BackColor = Color.Transparent;
            ProductName.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            ProductName.ForeColor = Color.Black;
            ProductName.Location = new Point(17, 48);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(133, 22);
            ProductName.TabIndex = 2;
            ProductName.Text = "Product Name : ";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.BackColor = Color.Transparent;
            Price.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            Price.ForeColor = Color.Black;
            Price.Location = new Point(17, 102);
            Price.Name = "Price";
            Price.Size = new Size(129, 22);
            Price.TabIndex = 6;
            Price.Text = "Product Price : ";
            // 
            // product
            // 
            product.BackColor = Color.Transparent;
            product.Controls.Add(productQuantity);
            product.Controls.Add(label1);
            product.Controls.Add(Add_Card);
            product.Controls.Add(Pro_Price);
            product.Controls.Add(Pro_Name);
            product.Controls.Add(ProductName);
            product.Controls.Add(Price);
            product.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            product.ForeColor = Color.Black;
            product.Location = new Point(24, 152);
            product.Name = "product";
            product.Size = new Size(265, 299);
            product.TabIndex = 9;
            product.TabStop = false;
            product.Text = "Product";
            // 
            // productQuantity
            // 
            productQuantity.Font = new Font("Bahnschrift Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productQuantity.FormattingEnabled = true;
            productQuantity.Location = new Point(167, 152);
            productQuantity.Name = "productQuantity";
            productQuantity.Size = new Size(65, 24);
            productQuantity.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(17, 151);
            label1.Name = "label1";
            label1.Size = new Size(143, 22);
            label1.TabIndex = 12;
            label1.Text = "Product Quantity:";
            // 
            // Add_Card
            // 
            Add_Card.AccessibleRole = AccessibleRole.None;
            Add_Card.BackColor = Color.Transparent;
            Add_Card.BackgroundImage = (Image)resources.GetObject("Add_Card.BackgroundImage");
            Add_Card.BackgroundImageLayout = ImageLayout.Stretch;
            Add_Card.FlatAppearance.BorderSize = 0;
            Add_Card.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Add_Card.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Add_Card.FlatStyle = FlatStyle.Flat;
            Add_Card.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            Add_Card.ForeColor = Color.Transparent;
            Add_Card.Location = new Point(52, 216);
            Add_Card.Name = "Add_Card";
            Add_Card.Size = new Size(154, 52);
            Add_Card.TabIndex = 10;
            Add_Card.Text = "      Add to Cart";
            Add_Card.UseVisualStyleBackColor = false;
            Add_Card.Click += Add_Card_Click;
            // 
            // Pro_Price
            // 
            Pro_Price.AutoSize = true;
            Pro_Price.BackColor = Color.Transparent;
            Pro_Price.Font = new Font("MS Gothic", 12F, FontStyle.Bold);
            Pro_Price.ForeColor = Color.ForestGreen;
            Pro_Price.Location = new Point(169, 109);
            Pro_Price.Name = "Pro_Price";
            Pro_Price.Size = new Size(0, 16);
            Pro_Price.TabIndex = 9;
            // 
            // Pro_Name
            // 
            Pro_Name.AutoSize = true;
            Pro_Name.BackColor = Color.Transparent;
            Pro_Name.Font = new Font("MS Gothic", 12F, FontStyle.Bold);
            Pro_Name.ForeColor = Color.DarkRed;
            Pro_Name.Location = new Point(169, 55);
            Pro_Name.Name = "Pro_Name";
            Pro_Name.Size = new Size(0, 16);
            Pro_Name.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(139, 23);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Filter_by_Name
            // 
            Filter_by_Name.AutoSize = true;
            Filter_by_Name.BackColor = Color.Transparent;
            Filter_by_Name.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            Filter_by_Name.ForeColor = Color.Black;
            Filter_by_Name.Location = new Point(24, 106);
            Filter_by_Name.Name = "Filter_by_Name";
            Filter_by_Name.Size = new Size(120, 22);
            Filter_by_Name.TabIndex = 11;
            Filter_by_Name.Text = "Filter by Name";
            Filter_by_Name.Click += Filter_by_Name_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(140, 134);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 14;
            // 
            // userDTOBindingSource
            // 
            userDTOBindingSource.DataSource = typeof(DTOS.DTOS.UserDTO);
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Forte", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(76, 478);
            button1.Name = "button1";
            button1.Size = new Size(160, 40);
            button1.TabIndex = 15;
            button1.Text = "Go To Cart  ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Navebar
            // 
            Navebar.BackColor = Color.Black;
            Navebar.Controls.Add(label4);
            Navebar.Controls.Add(PTorders);
            Navebar.Controls.Add(PTlogout);
            Navebar.Controls.Add(PTcart);
            Navebar.Controls.Add(PTproduct);
            Navebar.Controls.Add(PTregister);
            Navebar.Controls.Add(BTlogin);
            Navebar.Dock = DockStyle.Top;
            Navebar.Location = new Point(0, 0);
            Navebar.Name = "Navebar";
            Navebar.Size = new Size(1032, 48);
            Navebar.TabIndex = 16;
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
            // PTcart
            // 
            PTcart.BackColor = Color.Black;
            PTcart.FlatAppearance.BorderSize = 0;
            PTcart.FlatStyle = FlatStyle.Flat;
            PTcart.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PTcart.ForeColor = Color.White;
            PTcart.Image = (Image)resources.GetObject("PTcart.Image");
            PTcart.ImageAlign = ContentAlignment.MiddleLeft;
            PTcart.Location = new Point(358, 5);
            PTcart.Name = "PTcart";
            PTcart.Size = new Size(118, 38);
            PTcart.TabIndex = 17;
            PTcart.Text = "Cart";
            PTcart.UseVisualStyleBackColor = false;
            PTcart.Click += PTcart_Click;
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
            // Home_User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1032, 556);
            Controls.Add(Navebar);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(Filter_by_Name);
            Controls.Add(textBox1);
            Controls.Add(product);
            Controls.Add(ProductdataGridView);
            Name = "Home_User";
            Text = "Home_User";
            Load += Home_User_Load;
            ((System.ComponentModel.ISupportInitialize)ProductdataGridView).EndInit();
            product.ResumeLayout(false);
            product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userDTOBindingSource).EndInit();
            Navebar.ResumeLayout(false);
            Navebar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView ProductdataGridView;
        private Label ProductName;
        private Label Price;
        private GroupBox product;
        private Label Pro_Price;
        private Label Pro_Name;
        private TextBox textBox1;
        private Label Filter_by_Name;
        private Button Add_Card;
        private Label label2;
        private Label label1;
        private ComboBox productQuantity;
        private BindingSource userDTOBindingSource;
        private Button button1;
        private Panel Navebar;
        private Label label4;
        private Button PTorders;
        private Button PTlogout;
        private Button PTcart;
        private Button PTproduct;
        private Button PTregister;
        private Button BTlogin;
    }
}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_User));
            ProductdataGridView = new DataGridView();
            ProductName = new Label();
            Price = new Label();
            product = new GroupBox();
            Add_Card = new Button();
            Pro_Price = new Label();
            Pro_Name = new Label();
            textBox1 = new TextBox();
            Filter_by_Name = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)ProductdataGridView).BeginInit();
            product.SuspendLayout();
            SuspendLayout();
            // 
            // ProductdataGridView
            // 
            ProductdataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            ProductdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductdataGridView.Location = new Point(294, 23);
            ProductdataGridView.Name = "ProductdataGridView";
            ProductdataGridView.Size = new Size(644, 554);
            ProductdataGridView.TabIndex = 0;
            ProductdataGridView.CellClick += ProductdataGridView_CellClick;
            ProductdataGridView.CellContentClick += ProductdataGridView_CellContentClick;
            // 
            // ProductName
            // 
            ProductName.AutoSize = true;
            ProductName.BackColor = Color.Transparent;
            ProductName.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductName.ForeColor = Color.White;
            ProductName.Location = new Point(19, 40);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(94, 15);
            ProductName.TabIndex = 2;
            ProductName.Text = "Product Name : ";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.BackColor = Color.Transparent;
            Price.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Price.ForeColor = Color.White;
            Price.Location = new Point(19, 80);
            Price.Name = "Price";
            Price.Size = new Size(93, 15);
            Price.TabIndex = 6;
            Price.Text = "Product Price : ";
            // 
            // product
            // 
            product.BackColor = Color.Transparent;
            product.Controls.Add(Add_Card);
            product.Controls.Add(Pro_Price);
            product.Controls.Add(Pro_Name);
            product.Controls.Add(ProductName);
            product.Controls.Add(Price);
            product.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            product.ForeColor = Color.White;
            product.Location = new Point(28, 183);
            product.Name = "product";
            product.Size = new Size(242, 203);
            product.TabIndex = 9;
            product.TabStop = false;
            product.Text = "Product";
            // 
            // Add_Card
            // 
            Add_Card.AccessibleRole = AccessibleRole.None;
            Add_Card.BackColor = Color.IndianRed;
            Add_Card.BackgroundImageLayout = ImageLayout.Stretch;
            Add_Card.FlatAppearance.BorderSize = 0;
            Add_Card.FlatStyle = FlatStyle.Flat;
            Add_Card.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            Add_Card.ForeColor = Color.Transparent;
            Add_Card.Location = new Point(46, 123);
            Add_Card.Name = "Add_Card";
            Add_Card.Size = new Size(129, 52);
            Add_Card.TabIndex = 10;
            Add_Card.Text = "Add to Cart";
            Add_Card.UseVisualStyleBackColor = false;
            Add_Card.Click += Add_Card_Click;
            // 
            // Pro_Price
            // 
            Pro_Price.AutoSize = true;
            Pro_Price.BackColor = Color.Transparent;
            Pro_Price.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pro_Price.ForeColor = Color.Moccasin;
            Pro_Price.Location = new Point(118, 80);
            Pro_Price.Name = "Pro_Price";
            Pro_Price.Size = new Size(0, 15);
            Pro_Price.TabIndex = 9;
            // 
            // Pro_Name
            // 
            Pro_Name.AutoSize = true;
            Pro_Name.BackColor = Color.Transparent;
            Pro_Name.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pro_Name.ForeColor = Color.Moccasin;
            Pro_Name.Location = new Point(119, 42);
            Pro_Name.Name = "Pro_Name";
            Pro_Name.Size = new Size(0, 15);
            Pro_Name.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 23);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Filter_by_Name
            // 
            Filter_by_Name.AutoSize = true;
            Filter_by_Name.BackColor = Color.Transparent;
            Filter_by_Name.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Filter_by_Name.ForeColor = Color.White;
            Filter_by_Name.Location = new Point(22, 48);
            Filter_by_Name.Name = "Filter_by_Name";
            Filter_by_Name.Size = new Size(87, 15);
            Filter_by_Name.TabIndex = 11;
            Filter_by_Name.Text = "Filter by Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 71);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 14;
            // 
            // Home_User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1005, 709);
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
    }
}
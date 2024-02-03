namespace E_Commerce.Presentation
{
    partial class Admin_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Home));
            groupBox1 = new GroupBox();
            label1 = new Label();
            GoCategory = new Button();
            CategorysImg = new PictureBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            GoProducts = new Button();
            ProductImg = new PictureBox();
            groupBox3 = new GroupBox();
            label3 = new Label();
            GoOrders = new Button();
            OrderImg = new PictureBox();
            label4 = new Label();
            PTorders = new Button();
            PTlogout = new Button();
            PTcategory = new Button();
            PTproduct = new Button();
            PTregister = new Button();
            BTlogin = new Button();
            Navebar = new Panel();
            slider = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CategorysImg).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductImg).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrderImg).BeginInit();
            Navebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)slider).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(GoCategory);
            groupBox1.Controls.Add(CategorysImg);
            groupBox1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(29, 305);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(425, 409);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Categorys";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DimGray;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(151, 312);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(57, 18);
            label1.TabIndex = 2;
            label1.Text = "Go To";
            // 
            // GoCategory
            // 
            GoCategory.BackgroundImage = Properties.Resources.pngegg__4_;
            GoCategory.BackgroundImageLayout = ImageLayout.Stretch;
            GoCategory.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            GoCategory.FlatAppearance.BorderSize = 0;
            GoCategory.FlatAppearance.MouseDownBackColor = Color.Transparent;
            GoCategory.FlatAppearance.MouseOverBackColor = Color.Transparent;
            GoCategory.FlatStyle = FlatStyle.Flat;
            GoCategory.Font = new Font("Rockwell Extra Bold", 15F);
            GoCategory.ForeColor = Color.Black;
            GoCategory.Location = new Point(120, 312);
            GoCategory.Margin = new Padding(8, 3, 3, 3);
            GoCategory.Name = "GoCategory";
            GoCategory.Padding = new Padding(0, 20, 0, 0);
            GoCategory.Size = new Size(169, 70);
            GoCategory.TabIndex = 1;
            GoCategory.Text = "Category";
            GoCategory.TextAlign = ContentAlignment.MiddleLeft;
            GoCategory.UseVisualStyleBackColor = true;
            GoCategory.Click += button1_Click;
            // 
            // CategorysImg
            // 
            CategorysImg.BackgroundImageLayout = ImageLayout.Stretch;
            CategorysImg.Cursor = Cursors.No;
            CategorysImg.Image = Properties.Resources.category4;
            CategorysImg.Location = new Point(0, 22);
            CategorysImg.Name = "CategorysImg";
            CategorysImg.Size = new Size(425, 263);
            CategorysImg.SizeMode = PictureBoxSizeMode.StretchImage;
            CategorysImg.TabIndex = 0;
            CategorysImg.TabStop = false;
            CategorysImg.Click += CategorysImg_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(GoProducts);
            groupBox2.Controls.Add(ProductImg);
            groupBox2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(480, 305);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(425, 409);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Products";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.WindowFrame;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Goldenrod;
            label2.Location = new Point(167, 312);
            label2.Name = "label2";
            label2.Size = new Size(57, 18);
            label2.TabIndex = 2;
            label2.Text = "Go To";
            // 
            // GoProducts
            // 
            GoProducts.BackgroundImage = Properties.Resources.pngegg__4_;
            GoProducts.BackgroundImageLayout = ImageLayout.Stretch;
            GoProducts.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            GoProducts.FlatAppearance.BorderSize = 0;
            GoProducts.FlatAppearance.MouseDownBackColor = Color.Transparent;
            GoProducts.FlatAppearance.MouseOverBackColor = Color.Transparent;
            GoProducts.FlatStyle = FlatStyle.Flat;
            GoProducts.Font = new Font("Rockwell Extra Bold", 15F);
            GoProducts.Location = new Point(131, 312);
            GoProducts.Margin = new Padding(8, 3, 3, 3);
            GoProducts.Name = "GoProducts";
            GoProducts.Padding = new Padding(0, 20, 0, 0);
            GoProducts.Size = new Size(169, 70);
            GoProducts.TabIndex = 1;
            GoProducts.Text = "Products";
            GoProducts.TextAlign = ContentAlignment.MiddleLeft;
            GoProducts.UseVisualStyleBackColor = true;
            GoProducts.Click += GoProducts_Click;
            // 
            // ProductImg
            // 
            ProductImg.BackgroundImageLayout = ImageLayout.Stretch;
            ProductImg.Cursor = Cursors.No;
            ProductImg.Image = Properties.Resources.Product3;
            ProductImg.Location = new Point(0, 22);
            ProductImg.Name = "ProductImg";
            ProductImg.Size = new Size(425, 263);
            ProductImg.SizeMode = PictureBoxSizeMode.StretchImage;
            ProductImg.TabIndex = 0;
            ProductImg.TabStop = false;
            ProductImg.Click += ProductImg_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(GoOrders);
            groupBox3.Controls.Add(OrderImg);
            groupBox3.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(927, 305);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(425, 409);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Orders";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.WindowFrame;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Goldenrod;
            label3.Location = new Point(172, 312);
            label3.Name = "label3";
            label3.Size = new Size(57, 18);
            label3.TabIndex = 2;
            label3.Text = "Go To";
            // 
            // GoOrders
            // 
            GoOrders.BackgroundImage = Properties.Resources.pngegg__4_;
            GoOrders.BackgroundImageLayout = ImageLayout.Stretch;
            GoOrders.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            GoOrders.FlatAppearance.BorderSize = 0;
            GoOrders.FlatAppearance.MouseDownBackColor = Color.Transparent;
            GoOrders.FlatAppearance.MouseOverBackColor = Color.Transparent;
            GoOrders.FlatStyle = FlatStyle.Flat;
            GoOrders.Font = new Font("Rockwell Extra Bold", 15F);
            GoOrders.Location = new Point(136, 312);
            GoOrders.Margin = new Padding(8, 3, 3, 3);
            GoOrders.Name = "GoOrders";
            GoOrders.Padding = new Padding(0, 20, 0, 0);
            GoOrders.Size = new Size(169, 70);
            GoOrders.TabIndex = 1;
            GoOrders.Text = "  Orders";
            GoOrders.TextAlign = ContentAlignment.MiddleLeft;
            GoOrders.UseVisualStyleBackColor = true;
            GoOrders.Click += GoOrders_Click;
            // 
            // OrderImg
            // 
            OrderImg.BackgroundImageLayout = ImageLayout.Stretch;
            OrderImg.Cursor = Cursors.No;
            OrderImg.Image = Properties.Resources.order2;
            OrderImg.Location = new Point(0, 22);
            OrderImg.Name = "OrderImg";
            OrderImg.Size = new Size(425, 263);
            OrderImg.SizeMode = PictureBoxSizeMode.StretchImage;
            OrderImg.TabIndex = 0;
            OrderImg.TabStop = false;
            OrderImg.Click += OrderImg_Click;
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
            PTlogout.Location = new Point(1331, 7);
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
            PTproduct.ForeColor = Color.White;
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
            PTregister.Location = new Point(1207, 6);
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
            BTlogin.Location = new Point(1105, 5);
            BTlogin.Name = "BTlogin";
            BTlogin.Size = new Size(92, 38);
            BTlogin.TabIndex = 1;
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
            Navebar.Size = new Size(1382, 48);
            Navebar.TabIndex = 14;
            // 
            // slider
            // 
            slider.Image = Properties.Resources.Slide4;
            slider.Location = new Point(149, 49);
            slider.Name = "slider";
            slider.Size = new Size(1083, 236);
            slider.SizeMode = PictureBoxSizeMode.StretchImage;
            slider.TabIndex = 15;
            slider.TabStop = false;
            slider.Click += slider_Click;
            // 
            // timer1
            // 
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // Admin_Home
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1382, 750);
            Controls.Add(slider);
            Controls.Add(Navebar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin_Home";
            Text = "Admin Home";
            WindowState = FormWindowState.Maximized;
            Load += Admin_Home_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CategorysImg).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductImg).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrderImg).EndInit();
            Navebar.ResumeLayout(false);
            Navebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)slider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox CategorysImg;
        private Button GoCategory;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private Button GoProducts;
        private PictureBox ProductImg;
        private GroupBox groupBox3;
        private Label label3;
        private Button GoOrders;
        private PictureBox OrderImg;
        private Label label4;
        private Button PTorders;
        private Button PTlogout;
        private Button PTcategory;
        private Button PTproduct;
        private Button PTregister;
        private Button BTlogin;
        private Panel Navebar;
        private PictureBox slider;
        private System.Windows.Forms.Timer timer1;
    }
}
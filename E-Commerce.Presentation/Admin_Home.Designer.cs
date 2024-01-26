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
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            GoProducts = new Button();
            pictureBox2 = new PictureBox();
            groupBox3 = new GroupBox();
            label3 = new Label();
            GoOrders = new Button();
            pictureBox3 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            Navebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)slider).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(GoCategory);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(183, 225);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(208, 270);
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
            label1.Location = new Point(42, 182);
            label1.Name = "label1";
            label1.Size = new Size(57, 18);
            label1.TabIndex = 2;
            label1.Text = "Go To";
            // 
            // GoCategory
            // 
            GoCategory.BackgroundImage = Properties.Resources.pngegg__4_1;
            GoCategory.BackgroundImageLayout = ImageLayout.Stretch;
            GoCategory.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            GoCategory.FlatAppearance.BorderSize = 0;
            GoCategory.FlatAppearance.MouseDownBackColor = Color.Transparent;
            GoCategory.FlatAppearance.MouseOverBackColor = Color.Transparent;
            GoCategory.FlatStyle = FlatStyle.Flat;
            GoCategory.Font = new Font("Rockwell Extra Bold", 15F);
            GoCategory.ForeColor = Color.Black;
            GoCategory.Location = new Point(11, 182);
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
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Cursor = Cursors.No;
            pictureBox1.Location = new Point(0, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 136);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(GoProducts);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(410, 225);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(208, 270);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Products";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.WindowFrame;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Goldenrod;
            label2.Location = new Point(47, 182);
            label2.Name = "label2";
            label2.Size = new Size(57, 18);
            label2.TabIndex = 2;
            label2.Text = "Go To";
            // 
            // GoProducts
            // 
            GoProducts.BackgroundImage = Properties.Resources.pngegg__4_1;
            GoProducts.BackgroundImageLayout = ImageLayout.Stretch;
            GoProducts.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            GoProducts.FlatAppearance.BorderSize = 0;
            GoProducts.FlatAppearance.MouseDownBackColor = Color.Transparent;
            GoProducts.FlatAppearance.MouseOverBackColor = Color.Transparent;
            GoProducts.FlatStyle = FlatStyle.Flat;
            GoProducts.Font = new Font("Rockwell Extra Bold", 15F);
            GoProducts.Location = new Point(11, 182);
            GoProducts.Margin = new Padding(8, 3, 3, 3);
            GoProducts.Name = "GoProducts";
            GoProducts.Padding = new Padding(0, 20, 0, 0);
            GoProducts.Size = new Size(169, 70);
            GoProducts.TabIndex = 1;
            GoProducts.Text = "Products";
            GoProducts.TextAlign = ContentAlignment.MiddleLeft;
            GoProducts.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Cursor = Cursors.No;
            pictureBox2.Location = new Point(0, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(206, 136);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(GoOrders);
            groupBox3.Controls.Add(pictureBox3);
            groupBox3.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(639, 225);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(208, 270);
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
            label3.Location = new Point(47, 182);
            label3.Name = "label3";
            label3.Size = new Size(57, 18);
            label3.TabIndex = 2;
            label3.Text = "Go To";
            // 
            // GoOrders
            // 
            GoOrders.BackgroundImage = Properties.Resources.pngegg__4_1;
            GoOrders.BackgroundImageLayout = ImageLayout.Stretch;
            GoOrders.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            GoOrders.FlatAppearance.BorderSize = 0;
            GoOrders.FlatAppearance.MouseDownBackColor = Color.Transparent;
            GoOrders.FlatAppearance.MouseOverBackColor = Color.Transparent;
            GoOrders.FlatStyle = FlatStyle.Flat;
            GoOrders.Font = new Font("Rockwell Extra Bold", 15F);
            GoOrders.Location = new Point(11, 182);
            GoOrders.Margin = new Padding(8, 3, 3, 3);
            GoOrders.Name = "GoOrders";
            GoOrders.Padding = new Padding(0, 20, 0, 0);
            GoOrders.Size = new Size(169, 70);
            GoOrders.TabIndex = 1;
            GoOrders.Text = "Orders";
            GoOrders.TextAlign = ContentAlignment.MiddleLeft;
            GoOrders.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Cursor = Cursors.No;
            pictureBox3.Location = new Point(0, 22);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(206, 136);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
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
            Navebar.TabIndex = 14;
            // 
            // slider
            // 
            slider.Image = Properties.Resources.Slide4;
            slider.Location = new Point(183, 67);
            slider.Name = "slider";
            slider.Size = new Size(662, 152);
            slider.SizeMode = PictureBoxSizeMode.StretchImage;
            slider.TabIndex = 15;
            slider.TabStop = false;
            slider.Click += slider_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Admin_Home
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1025, 537);
            Controls.Add(slider);
            Controls.Add(Navebar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Admin_Home";
            Text = "Admin_Home";
            Load += Admin_Home_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            Navebar.ResumeLayout(false);
            Navebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)slider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Button GoCategory;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private Button GoProducts;
        private PictureBox pictureBox2;
        private GroupBox groupBox3;
        private Label label3;
        private Button GoOrders;
        private PictureBox pictureBox3;
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
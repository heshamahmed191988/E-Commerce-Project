namespace E_Commerce.Presentation
{
    partial class Orders_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders_View));
            OrderdataGridView = new DataGridView();
            groupBox1 = new GroupBox();
            OTotalPrice = new Label();
            ODate = new Label();
            Total_Price = new Label();
            BOUpdate = new Button();
            OStates = new TextBox();
            NProduct = new TextBox();
            Order_Status = new Label();
            label2 = new Label();
            label1 = new Label();
            Navebar = new Panel();
            label4 = new Label();
            PTorders = new Button();
            PTlogout = new Button();
            PTcategory = new Button();
            PTproduct = new Button();
            PTregister = new Button();
            BTlogin = new Button();
            ((System.ComponentModel.ISupportInitialize)OrderdataGridView).BeginInit();
            groupBox1.SuspendLayout();
            Navebar.SuspendLayout();
            SuspendLayout();
            // 
            // OrderdataGridView
            // 
            OrderdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderdataGridView.Location = new Point(333, 121);
            OrderdataGridView.Name = "OrderdataGridView";
            OrderdataGridView.Size = new Size(680, 282);
            OrderdataGridView.TabIndex = 0;
            OrderdataGridView.CellClick += OrderdataGridView_CellContentClick;
            OrderdataGridView.CellContentClick += OrderdataGridView_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(OTotalPrice);
            groupBox1.Controls.Add(ODate);
            groupBox1.Controls.Add(Total_Price);
            groupBox1.Controls.Add(BOUpdate);
            groupBox1.Controls.Add(OStates);
            groupBox1.Controls.Add(NProduct);
            groupBox1.Controls.Add(Order_Status);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(57, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 292);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Edit Your Orders";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // OTotalPrice
            // 
            OTotalPrice.AutoSize = true;
            OTotalPrice.Location = new Point(123, 164);
            OTotalPrice.Name = "OTotalPrice";
            OTotalPrice.Size = new Size(80, 17);
            OTotalPrice.TabIndex = 11;
            OTotalPrice.Text = "Total Price";
            // 
            // ODate
            // 
            ODate.AutoSize = true;
            ODate.Location = new Point(123, 39);
            ODate.Name = "ODate";
            ODate.Size = new Size(89, 17);
            ODate.TabIndex = 10;
            ODate.Text = "Order Date ";
            // 
            // Total_Price
            // 
            Total_Price.AutoSize = true;
            Total_Price.Location = new Point(22, 164);
            Total_Price.Name = "Total_Price";
            Total_Price.Size = new Size(80, 17);
            Total_Price.TabIndex = 9;
            Total_Price.Text = "Total Price";
            // 
            // BOUpdate
            // 
            BOUpdate.BackgroundImage = (Image)resources.GetObject("BOUpdate.BackgroundImage");
            BOUpdate.BackgroundImageLayout = ImageLayout.Stretch;
            BOUpdate.FlatAppearance.BorderSize = 0;
            BOUpdate.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BOUpdate.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BOUpdate.FlatStyle = FlatStyle.Flat;
            BOUpdate.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BOUpdate.Location = new Point(41, 213);
            BOUpdate.Name = "BOUpdate";
            BOUpdate.Size = new Size(171, 51);
            BOUpdate.TabIndex = 8;
            BOUpdate.Text = "Edit ";
            BOUpdate.UseVisualStyleBackColor = true;
            BOUpdate.Click += BOUpdate_Click;
            // 
            // OStates
            // 
            OStates.Location = new Point(150, 118);
            OStates.Name = "OStates";
            OStates.Size = new Size(100, 25);
            OStates.TabIndex = 7;
            // 
            // NProduct
            // 
            NProduct.Location = new Point(150, 76);
            NProduct.Name = "NProduct";
            NProduct.Size = new Size(100, 25);
            NProduct.TabIndex = 5;
            // 
            // Order_Status
            // 
            Order_Status.AutoSize = true;
            Order_Status.Location = new Point(22, 118);
            Order_Status.Name = "Order_Status";
            Order_Status.Size = new Size(94, 17);
            Order_Status.TabIndex = 3;
            Order_Status.Text = "Order Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 76);
            label2.Name = "label2";
            label2.Size = new Size(67, 17);
            label2.TabIndex = 1;
            label2.Text = "Order ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 39);
            label1.Name = "label1";
            label1.Size = new Size(93, 17);
            label1.TabIndex = 0;
            label1.Text = "Order Date :";
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
            Navebar.Size = new Size(1060, 48);
            Navebar.TabIndex = 15;
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
            PTorders.ForeColor = Color.Red;
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
            // Orders_View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1060, 506);
            Controls.Add(Navebar);
            Controls.Add(groupBox1);
            Controls.Add(OrderdataGridView);
            Name = "Orders_View";
            Text = "Orders_View";
            Load += Orders_View_Load;
            ((System.ComponentModel.ISupportInitialize)OrderdataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            Navebar.ResumeLayout(false);
            Navebar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView OrderdataGridView;
        private GroupBox groupBox1;
        private Label Order_Status;
        private Label label2;
        private Label label1;
        private Button BOUpdate;
        private TextBox OStates;
        private TextBox NProduct;
        private Label Total_Price;
        private Label ODate;
        private Label OTotalPrice;
        private Panel Navebar;
        private Label label4;
        private Button PTorders;
        private Button PTlogout;
        private Button PTcategory;
        private Button PTproduct;
        private Button PTregister;
        private Button BTlogin;
    }
}
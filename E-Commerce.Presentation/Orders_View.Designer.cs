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
            button2 = new Button();
            button1 = new Button();
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
            OrderdataGridView.Location = new Point(452, 121);
            OrderdataGridView.Name = "OrderdataGridView";
            OrderdataGridView.Size = new Size(579, 282);
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
            groupBox1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(30, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(401, 292);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Edit Your Orders";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // OTotalPrice
            // 
            OTotalPrice.AutoSize = true;
            OTotalPrice.Font = new Font("OCR A Extended", 12F, FontStyle.Bold);
            OTotalPrice.ForeColor = Color.DarkGreen;
            OTotalPrice.Location = new Point(207, 165);
            OTotalPrice.Name = "OTotalPrice";
            OTotalPrice.Size = new Size(0, 17);
            OTotalPrice.TabIndex = 11;
            // 
            // ODate
            // 
            ODate.AutoSize = true;
            ODate.Font = new Font("OCR A Extended", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ODate.ForeColor = Color.DarkRed;
            ODate.Location = new Point(207, 43);
            ODate.Name = "ODate";
            ODate.Size = new Size(0, 13);
            ODate.TabIndex = 10;
            ODate.Click += ODate_Click;
            // 
            // Total_Price
            // 
            Total_Price.AutoSize = true;
            Total_Price.Font = new Font("Stencil", 12F, FontStyle.Bold);
            Total_Price.Location = new Point(36, 165);
            Total_Price.Name = "Total_Price";
            Total_Price.Size = new Size(129, 19);
            Total_Price.TabIndex = 9;
            Total_Price.Text = "Total Price :";
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
            BOUpdate.Location = new Point(117, 211);
            BOUpdate.Name = "BOUpdate";
            BOUpdate.Size = new Size(171, 51);
            BOUpdate.TabIndex = 8;
            BOUpdate.Text = "Edit ";
            BOUpdate.UseVisualStyleBackColor = true;
            BOUpdate.Click += BOUpdate_Click;
            // 
            // OStates
            // 
            OStates.Location = new Point(207, 119);
            OStates.Name = "OStates";
            OStates.Size = new Size(160, 27);
            OStates.TabIndex = 7;
            // 
            // NProduct
            // 
            NProduct.Location = new Point(207, 77);
            NProduct.Name = "NProduct";
            NProduct.Size = new Size(160, 27);
            NProduct.TabIndex = 5;
            // 
            // Order_Status
            // 
            Order_Status.AutoSize = true;
            Order_Status.Font = new Font("Stencil", 12F, FontStyle.Bold);
            Order_Status.Location = new Point(36, 119);
            Order_Status.Name = "Order_Status";
            Order_Status.Size = new Size(146, 19);
            Order_Status.TabIndex = 3;
            Order_Status.Text = "Order Status :";
            Order_Status.Click += Order_Status_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 12F, FontStyle.Bold);
            label2.Location = new Point(36, 79);
            label2.Name = "label2";
            label2.Size = new Size(99, 19);
            label2.TabIndex = 1;
            label2.Text = "ORDER ID :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 12F, FontStyle.Bold);
            label1.Location = new Point(36, 40);
            label1.Name = "label1";
            label1.Size = new Size(124, 19);
            label1.TabIndex = 0;
            label1.Text = "Order Date :";
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
            Navebar.Size = new Size(1060, 48);
            Navebar.TabIndex = 15;
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
            button2.Location = new Point(589, 7);
            button2.Name = "button2";
            button2.Size = new Size(118, 38);
            button2.TabIndex = 22;
            button2.Text = "Stack";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            button1.Location = new Point(12, 5);
            button1.Name = "button1";
            button1.Size = new Size(118, 38);
            button1.TabIndex = 21;
            button1.UseVisualStyleBackColor = false;
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
        private Button PTorders;
        private Button PTlogout;
        private Button PTcategory;
        private Button PTproduct;
        private Button PTregister;
        private Button BTlogin;
        private Button button1;
        private Button button2;
    }
}
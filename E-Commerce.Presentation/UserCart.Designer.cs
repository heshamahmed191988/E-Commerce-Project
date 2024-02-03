namespace E_Commerce.Presentation
{
    partial class UserCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCart));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            prodNo = new Label();
            price = new Label();
            PTlogout = new Button();
            PTregister = new Button();
            Navebar = new Panel();
            label4 = new Label();
            PTorders = new Button();
            PTcategory = new Button();
            PTproduct = new Button();
            BTlogin = new Button();
            label3 = new Label();
            ChangeQuantity = new ComboBox();
            Remove = new Button();
            label5 = new Label();
            update = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Navebar.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(358, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(306, 220);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold);
            label1.Location = new Point(17, 32);
            label1.Name = "label1";
            label1.Size = new Size(138, 23);
            label1.TabIndex = 1;
            label1.Text = "NO of Products:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold);
            label2.Location = new Point(17, 74);
            label2.Name = "label2";
            label2.Size = new Size(103, 23);
            label2.TabIndex = 2;
            label2.Text = "Total Price:";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(50, 135);
            button1.Name = "button1";
            button1.Size = new Size(183, 49);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // prodNo
            // 
            prodNo.AutoSize = true;
            prodNo.BackColor = Color.Transparent;
            prodNo.Font = new Font("SimSun-ExtB", 9.75F, FontStyle.Bold);
            prodNo.ForeColor = SystemColors.AppWorkspace;
            prodNo.Location = new Point(173, 38);
            prodNo.Name = "prodNo";
            prodNo.Size = new Size(0, 13);
            prodNo.TabIndex = 4;
            // 
            // price
            // 
            price.AutoSize = true;
            price.BackColor = Color.Transparent;
            price.Font = new Font("SimSun-ExtB", 9.75F, FontStyle.Bold);
            price.ForeColor = SystemColors.WindowFrame;
            price.Location = new Point(173, 80);
            price.Name = "price";
            price.Size = new Size(0, 13);
            price.TabIndex = 5;
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
            PTlogout.Location = new Point(862, 7);
            PTlogout.Name = "PTlogout";
            PTlogout.Size = new Size(34, 38);
            PTlogout.TabIndex = 19;
            PTlogout.UseVisualStyleBackColor = false;
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
            PTregister.Location = new Point(738, 6);
            PTregister.Name = "PTregister";
            PTregister.Size = new Size(118, 38);
            PTregister.TabIndex = 15;
            PTregister.Text = "  Register";
            PTregister.UseVisualStyleBackColor = false;
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
            // BTlogin
            // 
            BTlogin.BackColor = Color.Black;
            BTlogin.FlatAppearance.BorderSize = 0;
            BTlogin.FlatStyle = FlatStyle.Flat;
            BTlogin.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTlogin.ForeColor = Color.White;
            BTlogin.Image = (Image)resources.GetObject("BTlogin.Image");
            BTlogin.ImageAlign = ContentAlignment.MiddleLeft;
            BTlogin.Location = new Point(636, 5);
            BTlogin.Name = "BTlogin";
            BTlogin.Size = new Size(92, 38);
            BTlogin.TabIndex = 14;
            BTlogin.Text = "LogIn";
            BTlogin.TextAlign = ContentAlignment.MiddleRight;
            BTlogin.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold);
            label3.Location = new Point(18, 55);
            label3.Name = "label3";
            label3.Size = new Size(142, 23);
            label3.TabIndex = 17;
            label3.Text = "Change Quantity";
            // 
            // ChangeQuantity
            // 
            ChangeQuantity.FormattingEnabled = true;
            ChangeQuantity.Location = new Point(175, 50);
            ChangeQuantity.Margin = new Padding(4, 6, 4, 6);
            ChangeQuantity.Name = "ChangeQuantity";
            ChangeQuantity.Size = new Size(60, 28);
            ChangeQuantity.TabIndex = 19;
            // 
            // Remove
            // 
            Remove.BackgroundImage = (Image)resources.GetObject("Remove.BackgroundImage");
            Remove.BackgroundImageLayout = ImageLayout.Stretch;
            Remove.FlatAppearance.BorderSize = 0;
            Remove.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Remove.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Remove.FlatStyle = FlatStyle.Flat;
            Remove.Location = new Point(145, 150);
            Remove.Name = "Remove";
            Remove.Size = new Size(128, 48);
            Remove.TabIndex = 20;
            Remove.UseVisualStyleBackColor = true;
            Remove.Click += Remove_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Goudy Stout", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(424, 81);
            label5.Name = "label5";
            label5.Size = new Size(0, 32);
            label5.TabIndex = 21;
            label5.Click += label5_Click;
            // 
            // update
            // 
            update.BackColor = Color.Transparent;
            update.BackgroundImage = (Image)resources.GetObject("update.BackgroundImage");
            update.BackgroundImageLayout = ImageLayout.Stretch;
            update.FlatAppearance.BorderSize = 0;
            update.FlatAppearance.MouseDownBackColor = Color.Transparent;
            update.FlatAppearance.MouseOverBackColor = Color.Transparent;
            update.FlatStyle = FlatStyle.Flat;
            update.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update.Location = new Point(11, 149);
            update.Name = "update";
            update.Size = new Size(128, 48);
            update.TabIndex = 22;
            update.Text = "Edit";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(prodNo);
            groupBox1.Controls.Add(price);
            groupBox1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(30, 135);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(279, 220);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Info Cart";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(ChangeQuantity);
            groupBox2.Controls.Add(update);
            groupBox2.Controls.Add(Remove);
            groupBox2.Font = new Font("Showcard Gothic", 12F);
            groupBox2.Location = new Point(720, 135);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(279, 220);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "update Cart";
            // 
            // UserCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1032, 435);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(Navebar);
            Controls.Add(dataGridView1);
            Name = "UserCart";
            Text = "UserCart";
            Load += UserCart_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Navebar.ResumeLayout(false);
            Navebar.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label prodNo;
        private Label label4;
        private Label price;
        private Button PTlogout;
        private Button PTregister;
        private Panel Navebar;
        private Button PTorders;
        private Button PTcategory;
        private Button PTproduct;
        private Button BTlogin;
        private Label label3;
       // private Label ChangeQuantity;
        private Button updateQuantity;
        private ComboBox ChangeQuantity;
        private Button Remove;
        private Label label5;
        private Button update;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
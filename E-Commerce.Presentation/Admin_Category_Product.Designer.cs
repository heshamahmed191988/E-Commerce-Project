namespace E_Commerce.Presentation
{
    partial class Admin_Category_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Category_Product));
            dataGridView2 = new DataGridView();
            DeleteCtegorey = new Label();
            EditCtegorey = new Label();
            AddCtegorey = new Label();
            label14 = new Label();
            CatogeryDescriptionBox = new TextBox();
            label15 = new Label();
            CatogeryNameBox = new TextBox();
            label4 = new Label();
            PTorders = new Button();
            PTlogout = new Button();
            PTcategory = new Button();
            PTproduct = new Button();
            PTregister = new Button();
            BTlogin = new Button();
            Navebar = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            Navebar.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(252, 121);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(761, 288);
            dataGridView2.TabIndex = 1;
            // 
            // DeleteCtegorey
            // 
            DeleteCtegorey.AutoSize = true;
            DeleteCtegorey.Location = new Point(528, 441);
            DeleteCtegorey.Name = "DeleteCtegorey";
            DeleteCtegorey.Size = new Size(40, 15);
            DeleteCtegorey.TabIndex = 9;
            DeleteCtegorey.Text = "Delete";
            DeleteCtegorey.Click += DeleteCtegorey_Click;
            // 
            // EditCtegorey
            // 
            EditCtegorey.AutoSize = true;
            EditCtegorey.Location = new Point(462, 441);
            EditCtegorey.Name = "EditCtegorey";
            EditCtegorey.Size = new Size(27, 15);
            EditCtegorey.TabIndex = 8;
            EditCtegorey.Text = "Edit";
            EditCtegorey.Click += EditCtegorey_Click;
            // 
            // AddCtegorey
            // 
            AddCtegorey.AutoSize = true;
            AddCtegorey.Location = new Point(405, 441);
            AddCtegorey.Name = "AddCtegorey";
            AddCtegorey.Size = new Size(29, 15);
            AddCtegorey.TabIndex = 6;
            AddCtegorey.Text = "Add";
            AddCtegorey.Click += AddCtegorey_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Sitka Text", 9F, FontStyle.Bold);
            label14.Location = new Point(41, 250);
            label14.Name = "label14";
            label14.Size = new Size(132, 18);
            label14.TabIndex = 21;
            label14.Text = "Catogery Description";
            // 
            // CatogeryDescriptionBox
            // 
            CatogeryDescriptionBox.Font = new Font("Sitka Text", 9F, FontStyle.Bold);
            CatogeryDescriptionBox.Location = new Point(41, 279);
            CatogeryDescriptionBox.Margin = new Padding(3, 2, 3, 2);
            CatogeryDescriptionBox.Name = "CatogeryDescriptionBox";
            CatogeryDescriptionBox.Size = new Size(184, 23);
            CatogeryDescriptionBox.TabIndex = 20;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Sitka Text", 9F, FontStyle.Bold);
            label15.Location = new Point(41, 172);
            label15.Name = "label15";
            label15.Size = new Size(97, 18);
            label15.TabIndex = 19;
            label15.Text = "Catogery Name";
            // 
            // CatogeryNameBox
            // 
            CatogeryNameBox.Font = new Font("Sitka Text", 9F, FontStyle.Bold);
            CatogeryNameBox.Location = new Point(41, 200);
            CatogeryNameBox.Margin = new Padding(3, 2, 3, 2);
            CatogeryNameBox.Name = "CatogeryNameBox";
            CatogeryNameBox.Size = new Size(184, 23);
            CatogeryNameBox.TabIndex = 18;
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
            PTcategory.ForeColor = Color.Red;
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
            Navebar.TabIndex = 22;
            // 
            // Admin_Category_Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1032, 499);
            Controls.Add(Navebar);
            Controls.Add(label14);
            Controls.Add(CatogeryDescriptionBox);
            Controls.Add(label15);
            Controls.Add(CatogeryNameBox);
            Controls.Add(DeleteCtegorey);
            Controls.Add(EditCtegorey);
            Controls.Add(AddCtegorey);
            Controls.Add(dataGridView2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Admin_Category_Product";
            Text = "Admin_Category_Product";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            Navebar.ResumeLayout(false);
            Navebar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView2;
        private Label DeleteCtegorey;
        private Label EditCtegorey;
        private Label AddCtegorey;
        private Label label14;
        private TextBox CatogeryDescriptionBox;
        private Label label15;
        private TextBox CatogeryNameBox;
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
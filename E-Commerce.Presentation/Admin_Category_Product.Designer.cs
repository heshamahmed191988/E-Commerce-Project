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
            dataGridView2 = new DataGridView();
            DeleteCtegorey = new Label();
            EditCtegorey = new Label();
            AddCtegorey = new Label();
            label9 = new Label();
            label14 = new Label();
            CatogeryDescriptionBox = new TextBox();
            label15 = new Label();
            CatogeryNameBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(284, 73);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(1154, 384);
            dataGridView2.TabIndex = 1;
            // 
            // DeleteCtegorey
            // 
            DeleteCtegorey.AutoSize = true;
            DeleteCtegorey.Location = new Point(1209, 495);
            DeleteCtegorey.Name = "DeleteCtegorey";
            DeleteCtegorey.Size = new Size(53, 20);
            DeleteCtegorey.TabIndex = 9;
            DeleteCtegorey.Text = "Delete";
            DeleteCtegorey.Click += DeleteCtegorey_Click;
            // 
            // EditCtegorey
            // 
            EditCtegorey.AutoSize = true;
            EditCtegorey.Location = new Point(1134, 495);
            EditCtegorey.Name = "EditCtegorey";
            EditCtegorey.Size = new Size(35, 20);
            EditCtegorey.TabIndex = 8;
            EditCtegorey.Text = "Edit";
            EditCtegorey.Click += EditCtegorey_Click;
            // 
            // AddCtegorey
            // 
            AddCtegorey.AutoSize = true;
            AddCtegorey.Location = new Point(1069, 495);
            AddCtegorey.Name = "AddCtegorey";
            AddCtegorey.Size = new Size(37, 20);
            AddCtegorey.TabIndex = 6;
            AddCtegorey.Text = "Add";
            AddCtegorey.Click += AddCtegorey_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(832, 30);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 10;
            label9.Text = "Catogeries";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(53, 247);
            label14.Name = "label14";
            label14.Size = new Size(149, 20);
            label14.TabIndex = 21;
            label14.Text = "Catogery Description";
            // 
            // CatogeryDescriptionBox
            // 
            CatogeryDescriptionBox.Location = new Point(66, 284);
            CatogeryDescriptionBox.Name = "CatogeryDescriptionBox";
            CatogeryDescriptionBox.Size = new Size(100, 27);
            CatogeryDescriptionBox.TabIndex = 20;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(66, 135);
            label15.Name = "label15";
            label15.Size = new Size(113, 20);
            label15.TabIndex = 19;
            label15.Text = "Catogery Name";
            // 
            // CatogeryNameBox
            // 
            CatogeryNameBox.Location = new Point(66, 178);
            CatogeryNameBox.Name = "CatogeryNameBox";
            CatogeryNameBox.Size = new Size(100, 27);
            CatogeryNameBox.TabIndex = 18;
            // 
            // Admin_Category_Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.project_Backgrowind;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1469, 608);
            Controls.Add(label14);
            Controls.Add(CatogeryDescriptionBox);
            Controls.Add(label15);
            Controls.Add(CatogeryNameBox);
            Controls.Add(label9);
            Controls.Add(DeleteCtegorey);
            Controls.Add(EditCtegorey);
            Controls.Add(AddCtegorey);
            Controls.Add(dataGridView2);
            Name = "Admin_Category_Product";
            Text = "Admin_Category_Product";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView2;
        private Label DeleteCtegorey;
        private Label EditCtegorey;
        private Label AddCtegorey;
        private Label label9;
        private Label label14;
        private TextBox CatogeryDescriptionBox;
        private Label label15;
        private TextBox CatogeryNameBox;
    }
}
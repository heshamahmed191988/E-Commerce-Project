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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            prodNo = new Label();
            price = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(201, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(363, 119);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 195);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 1;
            label1.Text = "NO. of Products:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(234, 232);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "Total Price:";
            // 
            // button1
            // 
            button1.Location = new Point(328, 265);
            button1.Name = "button1";
            button1.Size = new Size(100, 35);
            button1.TabIndex = 3;
            button1.Text = "Order";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // prodNo
            // 
            prodNo.AutoSize = true;
            prodNo.Location = new Point(328, 195);
            prodNo.Name = "prodNo";
            prodNo.Size = new Size(0, 15);
            prodNo.TabIndex = 4;
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(328, 232);
            price.Name = "price";
            price.Size = new Size(0, 15);
            price.TabIndex = 5;
            // 
            // UserCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(price);
            Controls.Add(prodNo);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "UserCart";
            Text = "UserCart";
            Load += UserCart_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}
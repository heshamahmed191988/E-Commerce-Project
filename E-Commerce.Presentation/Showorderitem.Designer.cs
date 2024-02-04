namespace E_Commerce.Presentation
{
    partial class Showorderitem
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
            pictureBox2 = new PictureBox();
            button1 = new Button();
            pictureBox4 = new PictureBox();
            OrderId = new Label();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(309, 131);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(543, 191);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.order4;
            pictureBox2.Location = new Point(286, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(175, 130);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.Exit1;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(35, 15);
            button1.Name = "button1";
            button1.Size = new Size(141, 64);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.logo3;
            pictureBox4.Location = new Point(792, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(74, 67);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 26;
            pictureBox4.TabStop = false;
            // 
            // OrderId
            // 
            OrderId.AutoSize = true;
            OrderId.BackColor = Color.Transparent;
            OrderId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrderId.ForeColor = Color.DimGray;
            OrderId.Location = new Point(601, 39);
            OrderId.Name = "OrderId";
            OrderId.Size = new Size(0, 20);
            OrderId.TabIndex = 27;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(27, 131);
            dataGridView2.Margin = new Padding(2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(264, 191);
            dataGridView2.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(539, 105);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 29;
            label1.Text = "Your Orders";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(92, 105);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 30;
            label2.Text = "Order Items";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(510, 39);
            label3.Name = "label3";
            label3.Size = new Size(85, 21);
            label3.TabIndex = 31;
            label3.Text = "Orders ID:";
            // 
            // Showorderitem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(878, 362);
            Controls.Add(label3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(OrderId);
            Controls.Add(pictureBox4);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "Showorderitem";
            Text = "Showorderitem";
            Load += Showorderitem_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox pictureBox2;
        private Button button1;
        private PictureBox pictureBox4;
        private Label OrderId;
        private DataGridView dataGridView2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
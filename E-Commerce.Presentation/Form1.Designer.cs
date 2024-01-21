namespace Forms_ProjectVC_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(83, 116);
            label1.Name = "label1";
            label1.Size = new Size(122, 22);
            label1.TabIndex = 0;
            label1.Text = "User Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(83, 169);
            label2.Name = "label2";
            label2.Size = new Size(111, 22);
            label2.TabIndex = 1;
            label2.Text = "Password :";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Mudir MT", 11.25F, FontStyle.Bold);
            textBox1.Location = new Point(220, 119);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveCaption;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Mudir MT", 11.25F, FontStyle.Bold);
            textBox2.Location = new Point(220, 169);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 23);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(220, 236);
            button1.Name = "button1";
            button1.Size = new Size(155, 54);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(689, 450);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}

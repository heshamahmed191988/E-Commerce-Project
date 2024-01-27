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
            userName = new TextBox();
            pass = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(95, 155);
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
            label2.Location = new Point(95, 225);
            label2.Name = "label2";
            label2.Size = new Size(111, 22);
            label2.TabIndex = 1;
            label2.Text = "Password :";
            // 
            // userName
            // 
            userName.BackColor = SystemColors.ActiveCaption;
            userName.BorderStyle = BorderStyle.None;
            userName.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            userName.Location = new Point(251, 159);
            userName.Margin = new Padding(3, 4, 3, 4);
            userName.Multiline = true;
            userName.Name = "userName";
            userName.Size = new Size(217, 31);
            userName.TabIndex = 2;
            // 
            // pass
            // 
            pass.BackColor = SystemColors.ActiveCaption;
            pass.BorderStyle = BorderStyle.None;
            pass.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            pass.Location = new Point(251, 225);
            pass.Margin = new Padding(3, 4, 3, 4);
            pass.Multiline = true;
            pass.Name = "pass";
            pass.Size = new Size(217, 31);
            pass.TabIndex = 3;
            pass.TextChanged += pass_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(251, 315);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(177, 72);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(787, 600);
            Controls.Add(button1);
            Controls.Add(pass);
            Controls.Add(userName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox userName;
        private TextBox pass;
        private Button button1;
    }
}

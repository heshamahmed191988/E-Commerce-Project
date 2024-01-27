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
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(119, 193);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(188, 33);
            label1.TabIndex = 0;
            label1.Text = "User Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(119, 282);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(172, 33);
            label2.TabIndex = 1;
            label2.Text = "Password :";
            // 
            // userName
            // 
            userName.BackColor = SystemColors.ActiveCaption;
            userName.BorderStyle = BorderStyle.None;
            userName.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            userName.Location = new Point(314, 198);
            userName.Margin = new Padding(4, 5, 4, 5);
            userName.Multiline = true;
            userName.Name = "userName";
            userName.Size = new Size(271, 38);
            userName.TabIndex = 2;
            // 
            // pass
            // 
            pass.BackColor = SystemColors.ActiveCaption;
            pass.BorderStyle = BorderStyle.None;
            pass.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            pass.Location = new Point(314, 282);
            pass.Margin = new Padding(4, 5, 4, 5);
            pass.Multiline = true;
            pass.Name = "pass";
            pass.Size = new Size(271, 38);
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
            button1.Location = new Point(375, 418);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(194, 65);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(175, 447);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(90, 25);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(966, 524);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(pass);
            Controls.Add(userName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
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
        private LinkLabel linkLabel1;
    }
}

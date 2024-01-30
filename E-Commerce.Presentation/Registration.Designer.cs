using Forms_ProjectVC_;

namespace E_Commerce.Presentation
{
    partial class Registration
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            Email = new TextBox();
            pass = new TextBox();
            Phone = new TextBox();
            Address = new TextBox();
            UserName = new TextBox();
            button1 = new Button();
            nameMsg = new Label();
            EmailMsg = new Label();
            PassMSg = new Label();
            comboBox1 = new ComboBox();
            PhonMSG = new Label();
            AddressMSG = new Label();
            userDTOBindingSource = new BindingSource(components);
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)userDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Urdu Typesetting", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(60, 381);
            label2.Name = "label2";
            label2.Size = new Size(55, 29);
            label2.TabIndex = 1;
            label2.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Urdu Typesetting", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(60, 192);
            label3.Name = "label3";
            label3.Size = new Size(50, 29);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Urdu Typesetting", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(60, 322);
            label4.Name = "label4";
            label4.Size = new Size(68, 29);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Urdu Typesetting", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(60, 257);
            label5.Name = "label5";
            label5.Size = new Size(77, 29);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Urdu Typesetting", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(60, 127);
            label6.Name = "label6";
            label6.Size = new Size(56, 29);
            label6.TabIndex = 5;
            label6.Text = "Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Urdu Typesetting", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(60, 60);
            label7.Name = "label7";
            label7.Size = new Size(82, 29);
            label7.TabIndex = 6;
            label7.Text = "Username";
            // 
            // Email
            // 
            Email.Location = new Point(160, 184);
            Email.Name = "Email";
            Email.Size = new Size(313, 37);
            Email.TabIndex = 7;
            // 
            // pass
            // 
            pass.Location = new Point(160, 249);
            pass.Name = "pass";
            pass.Size = new Size(313, 37);
            pass.TabIndex = 8;
            pass.TextChanged += pass_TextChanged;
            // 
            // Phone
            // 
            Phone.Location = new Point(160, 119);
            Phone.Name = "Phone";
            Phone.Size = new Size(313, 37);
            Phone.TabIndex = 10;
            // 
            // Address
            // 
            Address.Location = new Point(160, 314);
            Address.Name = "Address";
            Address.Size = new Size(313, 37);
            Address.TabIndex = 11;
            // 
            // UserName
            // 
            UserName.Location = new Point(160, 52);
            UserName.Name = "UserName";
            UserName.Size = new Size(313, 37);
            UserName.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(241, 432);
            button1.Name = "button1";
            button1.Size = new Size(135, 47);
            button1.TabIndex = 13;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // nameMsg
            // 
            nameMsg.AutoSize = true;
            nameMsg.BackColor = Color.Transparent;
            nameMsg.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            nameMsg.ForeColor = Color.Red;
            nameMsg.Location = new Point(479, 66);
            nameMsg.Name = "nameMsg";
            nameMsg.Size = new Size(0, 15);
            nameMsg.TabIndex = 15;
            // 
            // EmailMsg
            // 
            EmailMsg.AutoSize = true;
            EmailMsg.BackColor = Color.Transparent;
            EmailMsg.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            EmailMsg.ForeColor = Color.Red;
            EmailMsg.Location = new Point(479, 192);
            EmailMsg.Name = "EmailMsg";
            EmailMsg.Size = new Size(0, 15);
            EmailMsg.TabIndex = 16;
            // 
            // PassMSg
            // 
            PassMSg.AutoSize = true;
            PassMSg.BackColor = Color.Transparent;
            PassMSg.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            PassMSg.ForeColor = Color.Red;
            PassMSg.Location = new Point(479, 263);
            PassMSg.Name = "PassMSg";
            PassMSg.Size = new Size(0, 15);
            PassMSg.TabIndex = 17;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(160, 373);
            comboBox1.Margin = new Padding(4, 6, 4, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(313, 37);
            comboBox1.TabIndex = 18;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // PhonMSG
            // 
            PhonMSG.AutoSize = true;
            PhonMSG.BackColor = Color.Transparent;
            PhonMSG.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            PhonMSG.ForeColor = Color.Red;
            PhonMSG.Location = new Point(479, 127);
            PhonMSG.Name = "PhonMSG";
            PhonMSG.Size = new Size(0, 15);
            PhonMSG.TabIndex = 19;
            PhonMSG.Click += PhonMSG_Click;
            // 
            // AddressMSG
            // 
            AddressMSG.AutoSize = true;
            AddressMSG.BackColor = Color.Transparent;
            AddressMSG.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            AddressMSG.ForeColor = Color.Red;
            AddressMSG.Location = new Point(479, 328);
            AddressMSG.Name = "AddressMSG";
            AddressMSG.Size = new Size(0, 15);
            AddressMSG.TabIndex = 20;
            // 
            // userDTOBindingSource
            // 
            userDTOBindingSource.DataSource = typeof(DTOS.DTOS.UserDTO);
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(681, 450);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(50, 29);
            linkLabel1.TabIndex = 22;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(492, 450);
            label1.Name = "label1";
            label1.Size = new Size(183, 29);
            label1.TabIndex = 21;
            label1.Text = "Already have an account?";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(9F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(886, 523);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(AddressMSG);
            Controls.Add(PhonMSG);
            Controls.Add(comboBox1);
            Controls.Add(PassMSg);
            Controls.Add(EmailMsg);
            Controls.Add(nameMsg);
            Controls.Add(button1);
            Controls.Add(UserName);
            Controls.Add(Address);
            Controls.Add(Phone);
            Controls.Add(pass);
            Controls.Add(Email);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Urdu Typesetting", 12F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Registration";
            Text = "Registration";
            Load += Registration_Load;
            ((System.ComponentModel.ISupportInitialize)userDTOBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox Email;
        private TextBox pass;
        private TextBox Phone;
        private TextBox Address;
        private TextBox UserName;
        private Button button1;
        private Label nameMsg;
        private Label EmailMsg;
        private Label PassMSg;
        private ComboBox comboBox1;
        private Label PhonMSG;
        private Label AddressMSG;
        private BindingSource userDTOBindingSource;
        private LinkLabel linkLabel1;
        private Label label1;
    }
}
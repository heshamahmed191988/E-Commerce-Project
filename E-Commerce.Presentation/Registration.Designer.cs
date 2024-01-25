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
            label1 = new Label();
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
            button2 = new Button();
            nameMsg = new Label();
            EmailMsg = new Label();
            PassMSg = new Label();
            comboBox1 = new ComboBox();
            PhonMSG = new Label();
            AddressMSG = new Label();
            userDTOBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)userDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Goudy Stout", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(225, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(193, 26);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(482, 195);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(482, 59);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(11, 194);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(482, 127);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(11, 127);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 5;
            label6.Text = "Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(11, 59);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 6;
            label7.Text = "Username";
            // 
            // Email
            // 
            Email.Location = new Point(471, 89);
            Email.Margin = new Padding(2);
            Email.Name = "Email";
            Email.Size = new Size(181, 23);
            Email.TabIndex = 7;
            // 
            // pass
            // 
            pass.Location = new Point(471, 155);
            pass.Margin = new Padding(2);
            pass.Name = "pass";
            pass.Size = new Size(181, 23);
            pass.TabIndex = 8;
            pass.TextChanged += pass_TextChanged;
            // 
            // Phone
            // 
            Phone.Location = new Point(8, 155);
            Phone.Margin = new Padding(2);
            Phone.Name = "Phone";
            Phone.Size = new Size(172, 23);
            Phone.TabIndex = 10;
            // 
            // Address
            // 
            Address.Location = new Point(8, 222);
            Address.Margin = new Padding(2);
            Address.Name = "Address";
            Address.Size = new Size(172, 23);
            Address.TabIndex = 11;
            // 
            // UserName
            // 
            UserName.Location = new Point(8, 89);
            UserName.Margin = new Padding(2);
            UserName.Name = "UserName";
            UserName.Size = new Size(172, 23);
            UserName.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(136, 287);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(119, 24);
            button1.TabIndex = 13;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(388, 287);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(119, 24);
            button2.TabIndex = 14;
            button2.Text = " L o g i n";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // nameMsg
            // 
            nameMsg.AutoSize = true;
            nameMsg.BackColor = Color.Transparent;
            nameMsg.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            nameMsg.ForeColor = Color.Red;
            nameMsg.Location = new Point(184, 92);
            nameMsg.Margin = new Padding(2, 0, 2, 0);
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
            EmailMsg.Location = new Point(656, 92);
            EmailMsg.Margin = new Padding(2, 0, 2, 0);
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
            PassMSg.Location = new Point(656, 158);
            PassMSg.Margin = new Padding(2, 0, 2, 0);
            PassMSg.Name = "PassMSg";
            PassMSg.Size = new Size(0, 15);
            PassMSg.TabIndex = 17;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(471, 222);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(181, 23);
            comboBox1.TabIndex = 18;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // PhonMSG
            // 
            PhonMSG.AutoSize = true;
            PhonMSG.BackColor = Color.Transparent;
            PhonMSG.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            PhonMSG.ForeColor = Color.Red;
            PhonMSG.Location = new Point(184, 163);
            PhonMSG.Margin = new Padding(2, 0, 2, 0);
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
            AddressMSG.Location = new Point(197, 230);
            AddressMSG.Margin = new Padding(2, 0, 2, 0);
            AddressMSG.Name = "AddressMSG";
            AddressMSG.Size = new Size(0, 15);
            AddressMSG.TabIndex = 20;
            // 
            // userDTOBindingSource
            // 
            userDTOBindingSource.DataSource = typeof(DTOS.DTOS.UserDTO);
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(685, 337);
            Controls.Add(AddressMSG);
            Controls.Add(PhonMSG);
            Controls.Add(comboBox1);
            Controls.Add(PassMSg);
            Controls.Add(EmailMsg);
            Controls.Add(nameMsg);
            Controls.Add(button2);
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
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Registration";
            Text = "Registration";
            Load += Registration_Load;
            ((System.ComponentModel.ISupportInitialize)userDTOBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
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
        private Button button2;
        private Label nameMsg;
        private Label EmailMsg;
        private Label PassMSg;
        private ComboBox comboBox1;
        private Label PhonMSG;
        private Label AddressMSG;
        private BindingSource userDTOBindingSource;
    }
}
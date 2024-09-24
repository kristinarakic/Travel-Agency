namespace ProjekatTVP
{
    partial class LoginForm
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            cbType = new ComboBox();
            lblErrorUsername = new Label();
            lblErrorPassword = new Label();
            btnLogin = new Button();
            label1 = new Label();
            panel1 = new Panel();
            lblUsername = new Label();
            lblPassword = new Label();
            lblUserType = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(194, 136);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(156, 26);
            txtUsername.TabIndex = 3;
            txtUsername.TextChanged += TextBoxTextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(194, 238);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(156, 26);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += TextBoxTextChanged;
            // 
            // cbType
            // 
            cbType.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "Admin", "Klijent" });
            cbType.Location = new Point(194, 342);
            cbType.Name = "cbType";
            cbType.Size = new Size(151, 28);
            cbType.TabIndex = 7;
            // 
            // lblErrorUsername
            // 
            lblErrorUsername.AutoSize = true;
            lblErrorUsername.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorUsername.ForeColor = Color.Red;
            lblErrorUsername.Location = new Point(194, 165);
            lblErrorUsername.Name = "lblErrorUsername";
            lblErrorUsername.Size = new Size(214, 20);
            lblErrorUsername.TabIndex = 8;
            lblErrorUsername.Text = "Morate uneti korisničko ime!";
            lblErrorUsername.Visible = false;
            // 
            // lblErrorPassword
            // 
            lblErrorPassword.AutoSize = true;
            lblErrorPassword.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorPassword.ForeColor = Color.Red;
            lblErrorPassword.Location = new Point(194, 267);
            lblErrorPassword.Name = "lblErrorPassword";
            lblErrorPassword.Size = new Size(160, 20);
            lblErrorPassword.TabIndex = 9;
            lblErrorPassword.Text = "Morate uneti lozinku!";
            lblErrorPassword.Visible = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.RoyalBlue;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.AliceBlue;
            btnLogin.Location = new Point(194, 405);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(151, 46);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Uloguj se";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(167, 45);
            label1.Name = "label1";
            label1.Size = new Size(224, 23);
            label1.TabIndex = 12;
            label1.Text = "Unesite vaše podatke";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.back_blue_button_icon_227866;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(38, 473);
            panel1.Name = "panel1";
            panel1.Size = new Size(62, 53);
            panel1.TabIndex = 13;
            panel1.MouseClick += panel1_MouseClick;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.MediumBlue;
            lblUsername.Location = new Point(194, 112);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(129, 21);
            lblUsername.TabIndex = 15;
            lblUsername.Text = "Korisničko ime:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.MediumBlue;
            lblPassword.Location = new Point(194, 214);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(75, 21);
            lblPassword.TabIndex = 16;
            lblPassword.Text = "Lozinka:";
            // 
            // lblUserType
            // 
            lblUserType.AutoSize = true;
            lblUserType.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserType.ForeColor = Color.MediumBlue;
            lblUserType.Location = new Point(194, 318);
            lblUserType.Name = "lblUserType";
            lblUserType.Size = new Size(38, 21);
            lblUserType.TabIndex = 17;
            lblUserType.Text = "Tip:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(559, 551);
            Controls.Add(lblUserType);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(lblErrorPassword);
            Controls.Add(lblErrorUsername);
            Controls.Add(cbType);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsername;
        private TextBox txtPassword;
        private ComboBox cbType;
        private Label lblErrorUsername;
        private Label lblErrorPassword;
        private Button btnLogin;
        private Label label1;
        private Panel panel1;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblUserType;
    }
}
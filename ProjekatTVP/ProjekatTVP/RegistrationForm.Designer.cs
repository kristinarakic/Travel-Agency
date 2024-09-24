namespace ProjekatTVP
{
    partial class RegistrationForm
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
            label1 = new Label();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtPasswordAgain = new TextBox();
            btnRegistrationComplete = new Button();
            lblErrorName = new Label();
            lblErrorSurname = new Label();
            lblErrorUsername = new Label();
            lblErrorPassword = new Label();
            lblErrorPasswordAgain = new Label();
            panel2 = new Panel();
            lblName = new Label();
            lblSurname = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(232, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 23);
            label1.TabIndex = 0;
            label1.Text = "Registracija";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtName
            // 
            txtName.Location = new Point(194, 115);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(181, 28);
            txtName.TabIndex = 7;
            txtName.TextChanged += TextBoxTextChanged;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(194, 207);
            txtSurname.Margin = new Padding(4);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(181, 28);
            txtSurname.TabIndex = 8;
            txtSurname.TextChanged += TextBoxTextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(194, 303);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(181, 28);
            txtUsername.TabIndex = 9;
            txtUsername.TextChanged += TextBoxTextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(194, 395);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(181, 28);
            txtPassword.TabIndex = 10;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += TextBoxTextChanged;
            // 
            // txtPasswordAgain
            // 
            txtPasswordAgain.Location = new Point(194, 488);
            txtPasswordAgain.Margin = new Padding(4);
            txtPasswordAgain.Name = "txtPasswordAgain";
            txtPasswordAgain.Size = new Size(181, 28);
            txtPasswordAgain.TabIndex = 11;
            txtPasswordAgain.UseSystemPasswordChar = true;
            txtPasswordAgain.TextChanged += TextBoxTextChanged;
            // 
            // btnRegistrationComplete
            // 
            btnRegistrationComplete.BackColor = Color.RoyalBlue;
            btnRegistrationComplete.Cursor = Cursors.Hand;
            btnRegistrationComplete.ForeColor = SystemColors.ButtonHighlight;
            btnRegistrationComplete.Location = new Point(194, 567);
            btnRegistrationComplete.Margin = new Padding(4);
            btnRegistrationComplete.Name = "btnRegistrationComplete";
            btnRegistrationComplete.Size = new Size(169, 51);
            btnRegistrationComplete.TabIndex = 12;
            btnRegistrationComplete.Text = "Registruj se ";
            btnRegistrationComplete.UseVisualStyleBackColor = false;
            btnRegistrationComplete.Click += btnRegistrationComplete_Click;
            // 
            // lblErrorName
            // 
            lblErrorName.AutoSize = true;
            lblErrorName.ForeColor = Color.Red;
            lblErrorName.Location = new Point(194, 147);
            lblErrorName.Margin = new Padding(4, 0, 4, 0);
            lblErrorName.Name = "lblErrorName";
            lblErrorName.Size = new Size(157, 21);
            lblErrorName.TabIndex = 13;
            lblErrorName.Text = "Morate uneti ime!";
            lblErrorName.Visible = false;
            // 
            // lblErrorSurname
            // 
            lblErrorSurname.AutoSize = true;
            lblErrorSurname.ForeColor = Color.Red;
            lblErrorSurname.Location = new Point(194, 239);
            lblErrorSurname.Margin = new Padding(4, 0, 4, 0);
            lblErrorSurname.Name = "lblErrorSurname";
            lblErrorSurname.Size = new Size(192, 21);
            lblErrorSurname.TabIndex = 14;
            lblErrorSurname.Text = "Morate uneti prezime!";
            lblErrorSurname.Visible = false;
            // 
            // lblErrorUsername
            // 
            lblErrorUsername.AutoSize = true;
            lblErrorUsername.ForeColor = Color.Red;
            lblErrorUsername.Location = new Point(194, 335);
            lblErrorUsername.Margin = new Padding(4, 0, 4, 0);
            lblErrorUsername.Name = "lblErrorUsername";
            lblErrorUsername.Size = new Size(241, 21);
            lblErrorUsername.TabIndex = 15;
            lblErrorUsername.Text = "Morate uneti korisničko ime!";
            lblErrorUsername.Visible = false;
            // 
            // lblErrorPassword
            // 
            lblErrorPassword.AutoSize = true;
            lblErrorPassword.ForeColor = Color.Red;
            lblErrorPassword.Location = new Point(194, 427);
            lblErrorPassword.Margin = new Padding(4, 0, 4, 0);
            lblErrorPassword.Name = "lblErrorPassword";
            lblErrorPassword.Size = new Size(181, 21);
            lblErrorPassword.TabIndex = 16;
            lblErrorPassword.Text = "Morate uneti lozinku!";
            lblErrorPassword.Visible = false;
            // 
            // lblErrorPasswordAgain
            // 
            lblErrorPasswordAgain.AutoSize = true;
            lblErrorPasswordAgain.BackColor = SystemColors.Control;
            lblErrorPasswordAgain.ForeColor = Color.Red;
            lblErrorPasswordAgain.Location = new Point(194, 520);
            lblErrorPasswordAgain.Margin = new Padding(4, 0, 4, 0);
            lblErrorPasswordAgain.Name = "lblErrorPasswordAgain";
            lblErrorPasswordAgain.Size = new Size(252, 21);
            lblErrorPasswordAgain.TabIndex = 17;
            lblErrorPasswordAgain.Text = "Morate ponovo uneti lozinku!";
            lblErrorPasswordAgain.Visible = false;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.back_blue_button_icon_227866;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Cursor = Cursors.Hand;
            panel2.ForeColor = SystemColors.ControlLightLight;
            panel2.Location = new Point(35, 599);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(60, 57);
            panel2.TabIndex = 109;
            panel2.MouseClick += panel2_MouseClick;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.MediumBlue;
            lblName.Location = new Point(194, 90);
            lblName.Name = "lblName";
            lblName.Size = new Size(46, 21);
            lblName.TabIndex = 16;
            lblName.Text = "Ime:";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblSurname.ForeColor = Color.MediumBlue;
            lblSurname.Location = new Point(194, 182);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(77, 21);
            lblSurname.TabIndex = 110;
            lblSurname.Text = "Prezime:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.MediumBlue;
            lblUsername.Location = new Point(194, 278);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(129, 21);
            lblUsername.TabIndex = 111;
            lblUsername.Text = "Korisničko ime:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.MediumBlue;
            lblPassword.Location = new Point(194, 370);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(75, 21);
            lblPassword.TabIndex = 112;
            lblPassword.Text = "Lozinka:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.MediumBlue;
            label4.Location = new Point(194, 463);
            label4.Name = "label4";
            label4.Size = new Size(146, 21);
            label4.TabIndex = 113;
            label4.Text = "Lozinka ponovo:";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(566, 681);
            Controls.Add(label4);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblSurname);
            Controls.Add(lblName);
            Controls.Add(panel2);
            Controls.Add(lblErrorPasswordAgain);
            Controls.Add(lblErrorPassword);
            Controls.Add(lblErrorUsername);
            Controls.Add(lblErrorSurname);
            Controls.Add(lblErrorName);
            Controls.Add(btnRegistrationComplete);
            Controls.Add(txtPasswordAgain);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtPasswordAgain;
        private Button btnRegistrationComplete;
        private Label lblErrorName;
        private Label lblErrorSurname;
        private Label lblErrorUsername;
        private Label lblErrorPassword;
        private Label lblErrorPasswordAgain;
        private Panel panel2;
        private Label label2;
        private Label lblName;
        private Label lblSurname;
        private Label lblUsername;
        private Label lblPassword;
        private Label label4;
        private Label label3;
    }
}
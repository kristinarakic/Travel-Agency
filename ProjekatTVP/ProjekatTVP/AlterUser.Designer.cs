namespace ProjekatTVP
{
    partial class AlterUser
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
            rbAdmins = new RadioButton();
            rbClients = new RadioButton();
            btnDeleteUser = new Button();
            btnAlterUser = new Button();
            btnCreateUser = new Button();
            listView1 = new ListView();
            cmbOption = new ComboBox();
            lblChoice = new Label();
            txtName = new TextBox();
            txtUsername = new TextBox();
            txtSurname = new TextBox();
            txtPassword = new TextBox();
            lblErrorName = new Label();
            lblErrorSurname = new Label();
            lblErrorUsername = new Label();
            lblErrorPassword = new Label();
            lblName = new Label();
            lblSurname = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            lblUserType = new Label();
            txtUserType = new ComboBox();
            lblListViewCaption = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // rbAdmins
            // 
            rbAdmins.AutoSize = true;
            rbAdmins.Location = new Point(136, 46);
            rbAdmins.Margin = new Padding(4, 3, 4, 3);
            rbAdmins.Name = "rbAdmins";
            rbAdmins.Size = new Size(87, 25);
            rbAdmins.TabIndex = 18;
            rbAdmins.TabStop = true;
            rbAdmins.Text = "Admini";
            rbAdmins.UseVisualStyleBackColor = true;
            // 
            // rbClients
            // 
            rbClients.AutoSize = true;
            rbClients.Location = new Point(326, 46);
            rbClients.Margin = new Padding(4, 3, 4, 3);
            rbClients.Name = "rbClients";
            rbClients.Size = new Size(81, 25);
            rbClients.TabIndex = 19;
            rbClients.TabStop = true;
            rbClients.Text = "Klijenti";
            rbClients.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.RoyalBlue;
            btnDeleteUser.Cursor = Cursors.Hand;
            btnDeleteUser.ForeColor = Color.White;
            btnDeleteUser.Location = new Point(177, 471);
            btnDeleteUser.Margin = new Padding(4, 3, 4, 3);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(188, 55);
            btnDeleteUser.TabIndex = 21;
            btnDeleteUser.Text = "Obriši podatke";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Visible = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnAlterUser
            // 
            btnAlterUser.BackColor = Color.RoyalBlue;
            btnAlterUser.Cursor = Cursors.Hand;
            btnAlterUser.ForeColor = Color.White;
            btnAlterUser.Location = new Point(177, 471);
            btnAlterUser.Margin = new Padding(4, 3, 4, 3);
            btnAlterUser.Name = "btnAlterUser";
            btnAlterUser.Size = new Size(188, 55);
            btnAlterUser.TabIndex = 22;
            btnAlterUser.Text = "Izmeni podatke";
            btnAlterUser.UseVisualStyleBackColor = false;
            btnAlterUser.Visible = false;
            btnAlterUser.Click += btnAlterUser_Click;
            // 
            // btnCreateUser
            // 
            btnCreateUser.BackColor = Color.RoyalBlue;
            btnCreateUser.Cursor = Cursors.Hand;
            btnCreateUser.ForeColor = Color.White;
            btnCreateUser.Location = new Point(177, 471);
            btnCreateUser.Margin = new Padding(4, 3, 4, 3);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(188, 55);
            btnCreateUser.TabIndex = 23;
            btnCreateUser.Text = "Kreiraj korisnika";
            btnCreateUser.UseVisualStyleBackColor = false;
            btnCreateUser.Visible = false;
            btnCreateUser.Click += btnCreateUser_Click;
            // 
            // listView1
            // 
            listView1.FullRowSelect = true;
            listView1.Location = new Point(41, 119);
            listView1.Margin = new Padding(4);
            listView1.Name = "listView1";
            listView1.Size = new Size(485, 339);
            listView1.TabIndex = 24;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.ItemActivate += listView1_ItemActivate;
            // 
            // cmbOption
            // 
            cmbOption.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOption.FormattingEnabled = true;
            cmbOption.Items.AddRange(new object[] { "Kreirajte korisnika", "Obrišite korisnika ", "Izmenite podatke" });
            cmbOption.Location = new Point(113, 65);
            cmbOption.Margin = new Padding(4, 3, 4, 3);
            cmbOption.Name = "cmbOption";
            cmbOption.Size = new Size(228, 29);
            cmbOption.TabIndex = 25;
            cmbOption.SelectedIndexChanged += cmbOption_SelectedIndexChanged;
            // 
            // lblChoice
            // 
            lblChoice.AutoSize = true;
            lblChoice.ForeColor = SystemColors.ButtonHighlight;
            lblChoice.Location = new Point(136, 32);
            lblChoice.Margin = new Padding(4, 0, 4, 0);
            lblChoice.Name = "lblChoice";
            lblChoice.Size = new Size(174, 21);
            lblChoice.TabIndex = 26;
            lblChoice.Text = "Kreiraj, obriši, izmeni:";
            // 
            // txtName
            // 
            txtName.Location = new Point(183, 174);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(192, 28);
            txtName.TabIndex = 0;
            txtName.TextChanged += TextBoxTextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(183, 335);
            txtUsername.Margin = new Padding(4, 3, 4, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(192, 28);
            txtUsername.TabIndex = 1;
            txtUsername.TextChanged += TextBoxTextChanged;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(183, 255);
            txtSurname.Margin = new Padding(4, 3, 4, 3);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(192, 28);
            txtSurname.TabIndex = 2;
            txtSurname.TextChanged += TextBoxTextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(183, 418);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(192, 28);
            txtPassword.TabIndex = 3;
            txtPassword.TextChanged += TextBoxTextChanged;
            // 
            // lblErrorName
            // 
            lblErrorName.AutoSize = true;
            lblErrorName.ForeColor = Color.Firebrick;
            lblErrorName.Location = new Point(183, 207);
            lblErrorName.Margin = new Padding(4, 0, 4, 0);
            lblErrorName.Name = "lblErrorName";
            lblErrorName.Size = new Size(157, 21);
            lblErrorName.TabIndex = 5;
            lblErrorName.Text = "Morate uneti ime!";
            lblErrorName.Visible = false;
            // 
            // lblErrorSurname
            // 
            lblErrorSurname.AutoSize = true;
            lblErrorSurname.ForeColor = Color.Firebrick;
            lblErrorSurname.Location = new Point(183, 291);
            lblErrorSurname.Margin = new Padding(4, 0, 4, 0);
            lblErrorSurname.Name = "lblErrorSurname";
            lblErrorSurname.Size = new Size(192, 21);
            lblErrorSurname.TabIndex = 6;
            lblErrorSurname.Text = "Morate uneti prezime!";
            lblErrorSurname.Visible = false;
            // 
            // lblErrorUsername
            // 
            lblErrorUsername.AutoSize = true;
            lblErrorUsername.ForeColor = Color.Firebrick;
            lblErrorUsername.Location = new Point(180, 368);
            lblErrorUsername.Margin = new Padding(4, 0, 4, 0);
            lblErrorUsername.Name = "lblErrorUsername";
            lblErrorUsername.Size = new Size(241, 21);
            lblErrorUsername.TabIndex = 7;
            lblErrorUsername.Text = "Morate uneti korisničko ime!";
            lblErrorUsername.Visible = false;
            // 
            // lblErrorPassword
            // 
            lblErrorPassword.AutoSize = true;
            lblErrorPassword.ForeColor = Color.Firebrick;
            lblErrorPassword.Location = new Point(183, 453);
            lblErrorPassword.Margin = new Padding(4, 0, 4, 0);
            lblErrorPassword.Name = "lblErrorPassword";
            lblErrorPassword.Size = new Size(181, 21);
            lblErrorPassword.TabIndex = 8;
            lblErrorPassword.Text = "Morate uneti lozinku!";
            lblErrorPassword.Visible = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = SystemColors.ButtonHighlight;
            lblName.Location = new Point(118, 179);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(46, 21);
            lblName.TabIndex = 11;
            lblName.Text = "Ime:";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.ForeColor = SystemColors.ButtonHighlight;
            lblSurname.Location = new Point(87, 267);
            lblSurname.Margin = new Padding(4, 0, 4, 0);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(77, 21);
            lblSurname.TabIndex = 12;
            lblSurname.Text = "Prezime:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = SystemColors.ButtonHighlight;
            lblUsername.Location = new Point(35, 347);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(129, 21);
            lblUsername.TabIndex = 13;
            lblUsername.Text = "Korisničko ime:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.ForeColor = SystemColors.ButtonHighlight;
            lblPassword.Location = new Point(87, 422);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(75, 21);
            lblPassword.TabIndex = 14;
            lblPassword.Text = "Lozinka:";
            // 
            // lblUserType
            // 
            lblUserType.AutoSize = true;
            lblUserType.ForeColor = SystemColors.ButtonHighlight;
            lblUserType.Location = new Point(52, 501);
            lblUserType.Margin = new Padding(4, 0, 4, 0);
            lblUserType.Name = "lblUserType";
            lblUserType.Size = new Size(112, 21);
            lblUserType.TabIndex = 32;
            lblUserType.Text = "Tip korisnika:";
            // 
            // txtUserType
            // 
            txtUserType.DropDownStyle = ComboBoxStyle.DropDownList;
            txtUserType.FormattingEnabled = true;
            txtUserType.Items.AddRange(new object[] { "Admin", "Klijent" });
            txtUserType.Location = new Point(183, 498);
            txtUserType.Margin = new Padding(4);
            txtUserType.Name = "txtUserType";
            txtUserType.Size = new Size(192, 29);
            txtUserType.TabIndex = 33;
            // 
            // lblListViewCaption
            // 
            lblListViewCaption.AutoSize = true;
            lblListViewCaption.Location = new Point(41, 94);
            lblListViewCaption.Margin = new Padding(4, 0, 4, 0);
            lblListViewCaption.Name = "lblListViewCaption";
            lblListViewCaption.Size = new Size(60, 21);
            lblListViewCaption.TabIndex = 35;
            lblListViewCaption.Text = "label1";
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.back_blue_button_icon_227866;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.ForeColor = SystemColors.ControlLightLight;
            panel2.Location = new Point(41, 519);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(60, 57);
            panel2.TabIndex = 70;
            panel2.MouseClick += panel2_MouseClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(listView1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnDeleteUser);
            panel1.Controls.Add(rbClients);
            panel1.Controls.Add(btnAlterUser);
            panel1.Controls.Add(rbAdmins);
            panel1.Controls.Add(btnCreateUser);
            panel1.Controls.Add(lblListViewCaption);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(576, 594);
            panel1.TabIndex = 71;
            // 
            // panel3
            // 
            panel3.BackColor = Color.RoyalBlue;
            panel3.Controls.Add(txtUsername);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(txtUserType);
            panel3.Controls.Add(txtSurname);
            panel3.Controls.Add(lblUserType);
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(lblErrorName);
            panel3.Controls.Add(lblPassword);
            panel3.Controls.Add(lblErrorSurname);
            panel3.Controls.Add(lblChoice);
            panel3.Controls.Add(lblErrorUsername);
            panel3.Controls.Add(lblUsername);
            panel3.Controls.Add(lblErrorPassword);
            panel3.Controls.Add(cmbOption);
            panel3.Controls.Add(lblName);
            panel3.Controls.Add(lblSurname);
            panel3.Location = new Point(575, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(443, 594);
            panel3.TabIndex = 72;
            // 
            // AlterUser
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 597);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "AlterUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlterKorisnik";
            Load += AlterKorisnik_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private RadioButton rbAdmins;
        private RadioButton rbClients;
        private Button btnDeleteUser;
        private Button btnAlterUser;
        private Button btnCreateUser;
        private ListView listView1;
        private ComboBox cmbOption;
        private Label lblChoice;
        private TextBox txtName;
        private TextBox txtUsername;
        private TextBox txtSurname;
        private TextBox txtPassword;
        private Label lblErrorName;
        private Label lblErrorSurname;
        private Label lblErrorUsername;
        private Label lblErrorPassword;
        private Label lblName;
        private Label lblSurname;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblUserType;
        private ComboBox txtUserType;
        private Label lblListViewCaption;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
    }
}
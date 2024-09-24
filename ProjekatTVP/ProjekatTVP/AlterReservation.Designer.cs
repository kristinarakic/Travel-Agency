namespace ProjekatTVP
{
    partial class AlterReservation
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
            lblUserID = new Label();
            lblErrorUserID = new Label();
            txtUserID = new TextBox();
            lblChoice = new Label();
            lblNumberOfTravelers = new Label();
            cmbOption = new ComboBox();
            lblPriceID = new Label();
            listView1 = new ListView();
            lblTripID = new Label();
            btnCreateReservation = new Button();
            btnAlterReservation = new Button();
            lblErrorTravelers = new Label();
            btnDeleteRezervation = new Button();
            lblErrorTripID = new Label();
            txtPrice = new TextBox();
            txtTripID = new TextBox();
            txtTravelers = new TextBox();
            lblCmbPrint = new Label();
            cmbPrint = new ComboBox();
            lblListViewCaption = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.ForeColor = SystemColors.ButtonHighlight;
            lblUserID.Location = new Point(39, 162);
            lblUserID.Margin = new Padding(4, 0, 4, 0);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(107, 21);
            lblUserID.TabIndex = 57;
            lblUserID.Text = "ID korisnika:";
            // 
            // lblErrorUserID
            // 
            lblErrorUserID.AutoSize = true;
            lblErrorUserID.ForeColor = Color.Firebrick;
            lblErrorUserID.Location = new Point(177, 193);
            lblErrorUserID.Margin = new Padding(4, 0, 4, 0);
            lblErrorUserID.Name = "lblErrorUserID";
            lblErrorUserID.Size = new Size(220, 21);
            lblErrorUserID.TabIndex = 56;
            lblErrorUserID.Text = "Morate uneti ID korisnika!";
            lblErrorUserID.Visible = false;
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(177, 160);
            txtUserID.Margin = new Padding(4, 3, 4, 3);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(192, 28);
            txtUserID.TabIndex = 55;
            txtUserID.TextChanged += TextBoxTextChanged;
            // 
            // lblChoice
            // 
            lblChoice.AutoSize = true;
            lblChoice.ForeColor = SystemColors.ButtonHighlight;
            lblChoice.Location = new Point(150, 33);
            lblChoice.Margin = new Padding(4, 0, 4, 0);
            lblChoice.Name = "lblChoice";
            lblChoice.Size = new Size(174, 21);
            lblChoice.TabIndex = 54;
            lblChoice.Text = "Kreiraj, obriši, izmeni:";
            // 
            // lblNumberOfTravelers
            // 
            lblNumberOfTravelers.AutoSize = true;
            lblNumberOfTravelers.ForeColor = SystemColors.ButtonHighlight;
            lblNumberOfTravelers.Location = new Point(47, 429);
            lblNumberOfTravelers.Margin = new Padding(4, 0, 4, 0);
            lblNumberOfTravelers.Name = "lblNumberOfTravelers";
            lblNumberOfTravelers.Size = new Size(101, 21);
            lblNumberOfTravelers.TabIndex = 45;
            lblNumberOfTravelers.Text = "Broj mesta:";
            // 
            // cmbOption
            // 
            cmbOption.FormattingEnabled = true;
            cmbOption.Items.AddRange(new object[] { "Kreirajte rezervaciju", "Obrišite rezervaciju", "Izmenite podatke" });
            cmbOption.Location = new Point(126, 62);
            cmbOption.Margin = new Padding(4, 3, 4, 3);
            cmbOption.Name = "cmbOption";
            cmbOption.Size = new Size(228, 29);
            cmbOption.TabIndex = 53;
            cmbOption.SelectedIndexChanged += cmbPrint_SelectedIndexChanged;
            // 
            // lblPriceID
            // 
            lblPriceID.AutoSize = true;
            lblPriceID.ForeColor = SystemColors.ButtonHighlight;
            lblPriceID.Location = new Point(84, 340);
            lblPriceID.Margin = new Padding(4, 0, 4, 0);
            lblPriceID.Name = "lblPriceID";
            lblPriceID.Size = new Size(62, 21);
            lblPriceID.TabIndex = 44;
            lblPriceID.Text = "Cena:";
            // 
            // listView1
            // 
            listView1.FullRowSelect = true;
            listView1.Location = new Point(34, 135);
            listView1.Margin = new Padding(4);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(532, 291);
            listView1.TabIndex = 52;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.ItemActivate += listView1_ItemActivate;
            // 
            // lblTripID
            // 
            lblTripID.AutoSize = true;
            lblTripID.ForeColor = SystemColors.ButtonHighlight;
            lblTripID.Location = new Point(67, 249);
            lblTripID.Margin = new Padding(4, 0, 4, 0);
            lblTripID.Name = "lblTripID";
            lblTripID.Size = new Size(81, 21);
            lblTripID.TabIndex = 43;
            lblTripID.Text = "ID izleta:";
            // 
            // btnCreateReservation
            // 
            btnCreateReservation.BackColor = Color.RoyalBlue;
            btnCreateReservation.Cursor = Cursors.Hand;
            btnCreateReservation.ForeColor = SystemColors.ButtonHighlight;
            btnCreateReservation.Location = new Point(205, 446);
            btnCreateReservation.Margin = new Padding(4, 3, 4, 3);
            btnCreateReservation.Name = "btnCreateReservation";
            btnCreateReservation.Size = new Size(187, 53);
            btnCreateReservation.TabIndex = 51;
            btnCreateReservation.Text = "Kreiraj rezervaciju";
            btnCreateReservation.UseVisualStyleBackColor = false;
            btnCreateReservation.Visible = false;
            btnCreateReservation.Click += btnCreateReservation_Click;
            // 
            // btnAlterReservation
            // 
            btnAlterReservation.BackColor = Color.RoyalBlue;
            btnAlterReservation.Cursor = Cursors.Hand;
            btnAlterReservation.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlterReservation.ForeColor = SystemColors.ButtonHighlight;
            btnAlterReservation.Location = new Point(205, 444);
            btnAlterReservation.Margin = new Padding(4, 3, 4, 3);
            btnAlterReservation.Name = "btnAlterReservation";
            btnAlterReservation.Size = new Size(187, 55);
            btnAlterReservation.TabIndex = 50;
            btnAlterReservation.Text = "Izmeni podatke";
            btnAlterReservation.UseVisualStyleBackColor = false;
            btnAlterReservation.Visible = false;
            btnAlterReservation.Click += btnAlterReservation_Click;
            // 
            // lblErrorTravelers
            // 
            lblErrorTravelers.AutoSize = true;
            lblErrorTravelers.ForeColor = Color.Firebrick;
            lblErrorTravelers.Location = new Point(174, 460);
            lblErrorTravelers.Margin = new Padding(4, 0, 4, 0);
            lblErrorTravelers.Name = "lblErrorTravelers";
            lblErrorTravelers.Size = new Size(216, 21);
            lblErrorTravelers.TabIndex = 41;
            lblErrorTravelers.Text = "Morate uneti broj mesta!";
            lblErrorTravelers.Visible = false;
            // 
            // btnDeleteRezervation
            // 
            btnDeleteRezervation.BackColor = Color.RoyalBlue;
            btnDeleteRezervation.Cursor = Cursors.Hand;
            btnDeleteRezervation.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteRezervation.Location = new Point(205, 444);
            btnDeleteRezervation.Margin = new Padding(4, 3, 4, 3);
            btnDeleteRezervation.Name = "btnDeleteRezervation";
            btnDeleteRezervation.Size = new Size(187, 55);
            btnDeleteRezervation.TabIndex = 49;
            btnDeleteRezervation.Text = "Obriši rezervaciju";
            btnDeleteRezervation.UseVisualStyleBackColor = false;
            btnDeleteRezervation.Visible = false;
            btnDeleteRezervation.Click += btnDeleteRezervation_Click;
            // 
            // lblErrorTripID
            // 
            lblErrorTripID.AutoSize = true;
            lblErrorTripID.ForeColor = Color.Firebrick;
            lblErrorTripID.Location = new Point(177, 278);
            lblErrorTripID.Margin = new Padding(4, 0, 4, 0);
            lblErrorTripID.Name = "lblErrorTripID";
            lblErrorTripID.Size = new Size(194, 21);
            lblErrorTripID.TabIndex = 39;
            lblErrorTripID.Text = "Morate uneti ID izleta!";
            lblErrorTripID.Visible = false;
            // 
            // txtPrice
            // 
            txtPrice.Cursor = Cursors.No;
            txtPrice.Location = new Point(177, 340);
            txtPrice.Margin = new Padding(4, 3, 4, 3);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(192, 28);
            txtPrice.TabIndex = 37;
            // 
            // txtTripID
            // 
            txtTripID.Location = new Point(177, 246);
            txtTripID.Margin = new Padding(4, 3, 4, 3);
            txtTripID.Name = "txtTripID";
            txtTripID.Size = new Size(192, 28);
            txtTripID.TabIndex = 35;
            txtTripID.TextChanged += TextBoxTextChanged;
            // 
            // txtTravelers
            // 
            txtTravelers.Location = new Point(177, 425);
            txtTravelers.Margin = new Padding(4, 3, 4, 3);
            txtTravelers.Name = "txtTravelers";
            txtTravelers.Size = new Size(192, 28);
            txtTravelers.TabIndex = 36;
            txtTravelers.TextChanged += txtTravelers_TextChanged;
            // 
            // lblCmbPrint
            // 
            lblCmbPrint.AutoSize = true;
            lblCmbPrint.ForeColor = Color.MediumBlue;
            lblCmbPrint.Location = new Point(264, 33);
            lblCmbPrint.Margin = new Padding(4, 0, 4, 0);
            lblCmbPrint.Name = "lblCmbPrint";
            lblCmbPrint.Size = new Size(64, 21);
            lblCmbPrint.TabIndex = 63;
            lblCmbPrint.Text = "Prikaži:";
            // 
            // cmbPrint
            // 
            cmbPrint.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPrint.FormattingEnabled = true;
            cmbPrint.Items.AddRange(new object[] { "Klijenti", "Izleti" });
            cmbPrint.Location = new Point(187, 62);
            cmbPrint.Margin = new Padding(4, 3, 4, 3);
            cmbPrint.Name = "cmbPrint";
            cmbPrint.Size = new Size(228, 29);
            cmbPrint.TabIndex = 62;
            cmbPrint.SelectedIndexChanged += cmbPrint_SelectedIndexChanged;
            // 
            // lblListViewCaption
            // 
            lblListViewCaption.AutoSize = true;
            lblListViewCaption.ForeColor = Color.MediumBlue;
            lblListViewCaption.Location = new Point(34, 110);
            lblListViewCaption.Margin = new Padding(4, 0, 4, 0);
            lblListViewCaption.Name = "lblListViewCaption";
            lblListViewCaption.Size = new Size(60, 21);
            lblListViewCaption.TabIndex = 64;
            lblListViewCaption.Text = "label1";
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.back_blue_button_icon_227866;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Cursor = Cursors.Hand;
            panel2.ForeColor = SystemColors.ControlLightLight;
            panel2.Location = new Point(34, 475);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(60, 57);
            panel2.TabIndex = 69;
            panel2.MouseClick += panel2_MouseClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(txtTravelers);
            panel1.Controls.Add(txtTripID);
            panel1.Controls.Add(lblErrorTripID);
            panel1.Controls.Add(lblErrorTravelers);
            panel1.Controls.Add(lblChoice);
            panel1.Controls.Add(cmbOption);
            panel1.Controls.Add(lblUserID);
            panel1.Controls.Add(lblTripID);
            panel1.Controls.Add(lblErrorUserID);
            panel1.Controls.Add(lblPriceID);
            panel1.Controls.Add(txtUserID);
            panel1.Controls.Add(lblNumberOfTravelers);
            panel1.Location = new Point(607, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(522, 547);
            panel1.TabIndex = 70;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(listView1);
            panel3.Controls.Add(btnDeleteRezervation);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(btnAlterReservation);
            panel3.Controls.Add(lblListViewCaption);
            panel3.Controls.Add(btnCreateReservation);
            panel3.Controls.Add(lblCmbPrint);
            panel3.Controls.Add(cmbPrint);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(612, 547);
            panel3.TabIndex = 71;
            // 
            // AlterReservation
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1128, 548);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "AlterReservation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlterReservation";
            Load += AlterReservation_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblUserID;
        private Label lblErrorUserID;
        private TextBox txtUserID;
        private Label lblChoice;
        private Label lblNumberOfTravelers;
        private ComboBox cmbOption;
        private Label lblPriceID;
        private ListView listView1;
        private Label lblTripID;
        private Button btnCreateReservation;
        private Button btnAlterReservation;
        private Label lblErrorTravelers;
        private Button btnDeleteRezervation;
        private Label lblErrorTripID;
        private TextBox txtPrice;
        private TextBox txtTripID;
        private TextBox txtTravelers;
        private Label lblCmbPrint;
        private ComboBox cmbPrint;
        private Label lblListViewCaption;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
    }
}
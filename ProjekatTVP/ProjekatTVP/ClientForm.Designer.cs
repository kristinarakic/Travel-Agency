namespace ProjekatTVP
{
    partial class ClientForm
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
            listView1 = new ListView();
            lblFilter = new Label();
            cmbFilter = new ComboBox();
            lblListViewCaption = new Label();
            txtTravelers = new TextBox();
            txtDate = new TextBox();
            lblDate = new Label();
            lblTravelers = new Label();
            lblErrorTravelers = new Label();
            lblCity = new Label();
            txtCity = new TextBox();
            lblDays = new Label();
            txtDays = new TextBox();
            label2 = new Label();
            txtPrice = new TextBox();
            btnCreateReservation = new Button();
            btnAlterReservation = new Button();
            btnDeleteRezervation = new Button();
            cmbOption = new ComboBox();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.FullRowSelect = true;
            listView1.Location = new Point(48, 118);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(587, 363);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.ItemActivate += listView1_ItemActivate;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.ForeColor = Color.MediumBlue;
            lblFilter.Location = new Point(289, 21);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(68, 21);
            lblFilter.TabIndex = 1;
            lblFilter.Text = "Mesto:";
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Location = new Point(207, 46);
            cmbFilter.Margin = new Padding(3, 4, 3, 4);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(244, 29);
            cmbFilter.TabIndex = 2;
            cmbFilter.SelectedValueChanged += cmbFilter_SelectedValueChanged;
            // 
            // lblListViewCaption
            // 
            lblListViewCaption.AutoSize = true;
            lblListViewCaption.ForeColor = Color.MediumBlue;
            lblListViewCaption.Location = new Point(51, 88);
            lblListViewCaption.Name = "lblListViewCaption";
            lblListViewCaption.Size = new Size(60, 21);
            lblListViewCaption.TabIndex = 3;
            lblListViewCaption.Text = "label2";
            // 
            // txtTravelers
            // 
            txtTravelers.Location = new Point(196, 453);
            txtTravelers.Name = "txtTravelers";
            txtTravelers.Size = new Size(192, 28);
            txtTravelers.TabIndex = 86;
            txtTravelers.TextChanged += txtTravelers_TextChanged;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(196, 217);
            txtDate.Name = "txtDate";
            txtDate.ReadOnly = true;
            txtDate.Size = new Size(192, 28);
            txtDate.TabIndex = 85;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.ForeColor = SystemColors.ButtonHighlight;
            lblDate.Location = new Point(36, 222);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(143, 21);
            lblDate.TabIndex = 84;
            lblDate.Text = "Datum polaska:";
            // 
            // lblTravelers
            // 
            lblTravelers.AutoSize = true;
            lblTravelers.ForeColor = SystemColors.ButtonHighlight;
            lblTravelers.Location = new Point(60, 457);
            lblTravelers.Name = "lblTravelers";
            lblTravelers.Size = new Size(112, 21);
            lblTravelers.TabIndex = 82;
            lblTravelers.Text = "Broj putnika:";
            // 
            // lblErrorTravelers
            // 
            lblErrorTravelers.AutoSize = true;
            lblErrorTravelers.ForeColor = Color.Firebrick;
            lblErrorTravelers.Location = new Point(194, 487);
            lblErrorTravelers.Name = "lblErrorTravelers";
            lblErrorTravelers.Size = new Size(227, 21);
            lblErrorTravelers.TabIndex = 81;
            lblErrorTravelers.Text = "Morate uneti broj putnika!";
            lblErrorTravelers.Visible = false;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.ForeColor = SystemColors.ButtonHighlight;
            lblCity.Location = new Point(100, 154);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(68, 21);
            lblCity.TabIndex = 80;
            lblCity.Text = "Mesto:";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(196, 146);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(192, 28);
            txtCity.TabIndex = 78;
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.ForeColor = SystemColors.ButtonHighlight;
            lblDays.Location = new Point(79, 290);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(95, 21);
            lblDays.TabIndex = 77;
            lblDays.Text = "Broj dana:";
            // 
            // txtDays
            // 
            txtDays.Location = new Point(196, 286);
            txtDays.Name = "txtDays";
            txtDays.ReadOnly = true;
            txtDays.Size = new Size(192, 28);
            txtDays.TabIndex = 69;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(55, 361);
            label2.Name = "label2";
            label2.Size = new Size(129, 21);
            label2.TabIndex = 88;
            label2.Text = "Ukupna cena:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(196, 355);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(192, 28);
            txtPrice.TabIndex = 89;
            // 
            // btnCreateReservation
            // 
            btnCreateReservation.BackColor = Color.RoyalBlue;
            btnCreateReservation.Cursor = Cursors.Hand;
            btnCreateReservation.ForeColor = Color.White;
            btnCreateReservation.Location = new Point(247, 488);
            btnCreateReservation.Name = "btnCreateReservation";
            btnCreateReservation.Size = new Size(187, 51);
            btnCreateReservation.TabIndex = 92;
            btnCreateReservation.Text = "Kreiraj rezervaciju";
            btnCreateReservation.UseVisualStyleBackColor = false;
            btnCreateReservation.Visible = false;
            btnCreateReservation.Click += btnCreateReservation_Click;
            // 
            // btnAlterReservation
            // 
            btnAlterReservation.BackColor = Color.RoyalBlue;
            btnAlterReservation.Cursor = Cursors.Hand;
            btnAlterReservation.ForeColor = Color.White;
            btnAlterReservation.Location = new Point(247, 488);
            btnAlterReservation.Name = "btnAlterReservation";
            btnAlterReservation.Size = new Size(187, 51);
            btnAlterReservation.TabIndex = 91;
            btnAlterReservation.Text = "Izmeni podatke";
            btnAlterReservation.UseVisualStyleBackColor = false;
            btnAlterReservation.Visible = false;
            btnAlterReservation.Click += btnAlterReservation_Click;
            // 
            // btnDeleteRezervation
            // 
            btnDeleteRezervation.BackColor = Color.RoyalBlue;
            btnDeleteRezervation.Cursor = Cursors.Hand;
            btnDeleteRezervation.ForeColor = Color.White;
            btnDeleteRezervation.Location = new Point(247, 488);
            btnDeleteRezervation.Name = "btnDeleteRezervation";
            btnDeleteRezervation.Size = new Size(187, 51);
            btnDeleteRezervation.TabIndex = 90;
            btnDeleteRezervation.Text = "Obriši rezervaciju";
            btnDeleteRezervation.UseVisualStyleBackColor = false;
            btnDeleteRezervation.Visible = false;
            btnDeleteRezervation.Click += btnDeleteRezervation_Click;
            // 
            // cmbOption
            // 
            cmbOption.FormattingEnabled = true;
            cmbOption.Items.AddRange(new object[] { "Kreiraj rezervaciju ", "Obriši rezervaciju", "Izmeni podatke" });
            cmbOption.Location = new Point(107, 56);
            cmbOption.Margin = new Padding(3, 4, 3, 4);
            cmbOption.Name = "cmbOption";
            cmbOption.Size = new Size(244, 29);
            cmbOption.TabIndex = 95;
            cmbOption.SelectedIndexChanged += cmbOption_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(135, 21);
            label3.Name = "label3";
            label3.Size = new Size(174, 21);
            label3.TabIndex = 94;
            label3.Text = "Kreiraj, obriši, izmeni:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(txtDate);
            panel1.Controls.Add(cmbOption);
            panel1.Controls.Add(txtDays);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblDays);
            panel1.Controls.Add(txtCity);
            panel1.Controls.Add(lblCity);
            panel1.Controls.Add(lblErrorTravelers);
            panel1.Controls.Add(lblTravelers);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTravelers);
            panel1.Location = new Point(688, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(461, 576);
            panel1.TabIndex = 96;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(listView1);
            panel2.Controls.Add(lblFilter);
            panel2.Controls.Add(cmbFilter);
            panel2.Controls.Add(btnCreateReservation);
            panel2.Controls.Add(lblListViewCaption);
            panel2.Controls.Add(btnAlterReservation);
            panel2.Controls.Add(btnDeleteRezervation);
            panel2.Location = new Point(-1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(694, 576);
            panel2.TabIndex = 97;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.back_blue_button_icon_227866;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Cursor = Cursors.Hand;
            panel3.ForeColor = SystemColors.ControlLightLight;
            panel3.Location = new Point(48, 507);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(60, 57);
            panel3.TabIndex = 93;
            panel3.MouseClick += panel3_MouseClick;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 576);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            ImeMode = ImeMode.On;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ClientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClientForm";
            Load += ClientForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Label lblFilter;
        private ComboBox cmbFilter;
        private Label lblListViewCaption;
        private TextBox txtTravelers;
        private TextBox txtDate;
        private Label lblDate;
        private Label lblTravelers;
        private Label lblErrorTravelers;
        private Label lblCity;
        private TextBox txtCity;
        private Label lblDays;
        private TextBox txtDays;
        private Label label2;
        private TextBox txtPrice;
        private Button btnCreateReservation;
        private Button btnAlterReservation;
        private Button btnDeleteRezervation;
        private ComboBox cmbOption;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}
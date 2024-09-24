namespace ProjekatTVP
{
    partial class AlterTrip
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
            lblTravelers = new Label();
            lblErrorTravelers = new Label();
            lblCity = new Label();
            lblErrorCity = new Label();
            txtCity = new TextBox();
            lblDays = new Label();
            lblChoice = new Label();
            lblDiscount = new Label();
            cmbOption = new ComboBox();
            lblPrice = new Label();
            listView1 = new ListView();
            lblState = new Label();
            btnCreateTrip = new Button();
            lblErrorDays = new Label();
            btnAlterTrip = new Button();
            lblErrorDiscount = new Label();
            btnDeleteTrip = new Button();
            lblErrorPrice = new Label();
            lblErrorState = new Label();
            txtDays = new TextBox();
            txtPrice = new TextBox();
            txtState = new TextBox();
            txtDiscount = new TextBox();
            txtTravelers = new TextBox();
            lblListViewCaption = new Label();
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblTravelers
            // 
            lblTravelers.AutoSize = true;
            lblTravelers.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTravelers.ForeColor = SystemColors.ButtonHighlight;
            lblTravelers.Location = new Point(136, 437);
            lblTravelers.Margin = new Padding(4, 0, 4, 0);
            lblTravelers.Name = "lblTravelers";
            lblTravelers.Size = new Size(101, 21);
            lblTravelers.TabIndex = 59;
            lblTravelers.Text = "Broj mesta:";
            // 
            // lblErrorTravelers
            // 
            lblErrorTravelers.AutoSize = true;
            lblErrorTravelers.ForeColor = Color.Firebrick;
            lblErrorTravelers.Location = new Point(253, 468);
            lblErrorTravelers.Margin = new Padding(4, 0, 4, 0);
            lblErrorTravelers.Name = "lblErrorTravelers";
            lblErrorTravelers.Size = new Size(216, 21);
            lblErrorTravelers.TabIndex = 58;
            lblErrorTravelers.Text = "Morate uneti broj mesta!";
            lblErrorTravelers.Visible = false;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblCity.ForeColor = SystemColors.ButtonHighlight;
            lblCity.Location = new Point(175, 38);
            lblCity.Margin = new Padding(4, 0, 4, 0);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(68, 21);
            lblCity.TabIndex = 57;
            lblCity.Text = "Mesto:";
            // 
            // lblErrorCity
            // 
            lblErrorCity.AutoSize = true;
            lblErrorCity.ForeColor = Color.Firebrick;
            lblErrorCity.Location = new Point(250, 63);
            lblErrorCity.Margin = new Padding(4, 0, 4, 0);
            lblErrorCity.Name = "lblErrorCity";
            lblErrorCity.Size = new Size(179, 21);
            lblErrorCity.TabIndex = 56;
            lblErrorCity.Text = "Morate uneti mesto!";
            lblErrorCity.Visible = false;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(253, 35);
            txtCity.Margin = new Padding(4, 3, 4, 3);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(192, 28);
            txtCity.TabIndex = 55;
            txtCity.TextChanged += TextBoxTextChanged;
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblDays.ForeColor = SystemColors.ButtonHighlight;
            lblDays.Location = new Point(142, 360);
            lblDays.Margin = new Padding(4, 0, 4, 0);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(95, 21);
            lblDays.TabIndex = 46;
            lblDays.Text = "Broj dana:";
            // 
            // lblChoice
            // 
            lblChoice.AutoSize = true;
            lblChoice.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblChoice.ForeColor = Color.RoyalBlue;
            lblChoice.Location = new Point(216, 27);
            lblChoice.Margin = new Padding(4, 0, 4, 0);
            lblChoice.Name = "lblChoice";
            lblChoice.Size = new Size(174, 21);
            lblChoice.TabIndex = 54;
            lblChoice.Text = "Kreiraj, izmeni, obriši:";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiscount.ForeColor = SystemColors.ButtonHighlight;
            lblDiscount.Location = new Point(165, 274);
            lblDiscount.Margin = new Padding(4, 0, 4, 0);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(72, 21);
            lblDiscount.TabIndex = 45;
            lblDiscount.Text = "Popust:";
            // 
            // cmbOption
            // 
            cmbOption.BackColor = Color.GhostWhite;
            cmbOption.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOption.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbOption.ForeColor = SystemColors.WindowText;
            cmbOption.FormattingEnabled = true;
            cmbOption.Items.AddRange(new object[] { "Kreirajte izlet", "Obrišite izlet", "Izmenite podatke" });
            cmbOption.Location = new Point(197, 63);
            cmbOption.Margin = new Padding(4, 3, 4, 3);
            cmbOption.Name = "cmbOption";
            cmbOption.Size = new Size(238, 29);
            cmbOption.TabIndex = 53;
            cmbOption.SelectedIndexChanged += cmbOption_SelectedIndexChanged;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrice.ForeColor = SystemColors.ButtonHighlight;
            lblPrice.Location = new Point(175, 197);
            lblPrice.Margin = new Padding(4, 0, 4, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(62, 21);
            lblPrice.TabIndex = 44;
            lblPrice.Text = "Cena:";
            // 
            // listView1
            // 
            listView1.FullRowSelect = true;
            listView1.Location = new Point(28, 151);
            listView1.Margin = new Padding(4);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(542, 339);
            listView1.TabIndex = 52;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.ItemActivate += listView1_ItemActivate;
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblState.ForeColor = SystemColors.ButtonHighlight;
            lblState.Location = new Point(168, 114);
            lblState.Margin = new Padding(4, 0, 4, 0);
            lblState.Name = "lblState";
            lblState.Size = new Size(75, 21);
            lblState.TabIndex = 43;
            lblState.Text = "Država:";
            // 
            // btnCreateTrip
            // 
            btnCreateTrip.BackColor = Color.RoyalBlue;
            btnCreateTrip.Cursor = Cursors.Hand;
            btnCreateTrip.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateTrip.ForeColor = SystemColors.ControlLightLight;
            btnCreateTrip.Location = new Point(216, 497);
            btnCreateTrip.Margin = new Padding(4, 3, 4, 3);
            btnCreateTrip.Name = "btnCreateTrip";
            btnCreateTrip.Size = new Size(202, 54);
            btnCreateTrip.TabIndex = 51;
            btnCreateTrip.Text = "Kreiraj izlet";
            btnCreateTrip.UseVisualStyleBackColor = false;
            btnCreateTrip.Visible = false;
            btnCreateTrip.Click += btnCreateTrip_Click;
            // 
            // lblErrorDays
            // 
            lblErrorDays.AutoSize = true;
            lblErrorDays.ForeColor = Color.Firebrick;
            lblErrorDays.Location = new Point(253, 389);
            lblErrorDays.Margin = new Padding(4, 0, 4, 0);
            lblErrorDays.Name = "lblErrorDays";
            lblErrorDays.Size = new Size(210, 21);
            lblErrorDays.TabIndex = 42;
            lblErrorDays.Text = "Morate uneti broj dana!";
            lblErrorDays.Visible = false;
            // 
            // btnAlterTrip
            // 
            btnAlterTrip.BackColor = Color.RoyalBlue;
            btnAlterTrip.Cursor = Cursors.Hand;
            btnAlterTrip.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlterTrip.ForeColor = SystemColors.ControlLightLight;
            btnAlterTrip.Location = new Point(216, 497);
            btnAlterTrip.Margin = new Padding(4, 3, 4, 3);
            btnAlterTrip.Name = "btnAlterTrip";
            btnAlterTrip.Size = new Size(202, 52);
            btnAlterTrip.TabIndex = 50;
            btnAlterTrip.Text = "Izmeni podatke";
            btnAlterTrip.UseVisualStyleBackColor = false;
            btnAlterTrip.Visible = false;
            btnAlterTrip.Click += btnAlterTrip_Click;
            // 
            // lblErrorDiscount
            // 
            lblErrorDiscount.AutoSize = true;
            lblErrorDiscount.ForeColor = Color.Firebrick;
            lblErrorDiscount.Location = new Point(250, 307);
            lblErrorDiscount.Margin = new Padding(4, 0, 4, 0);
            lblErrorDiscount.Name = "lblErrorDiscount";
            lblErrorDiscount.Size = new Size(187, 21);
            lblErrorDiscount.TabIndex = 41;
            lblErrorDiscount.Text = "Morate uneti popust!";
            lblErrorDiscount.Visible = false;
            // 
            // btnDeleteTrip
            // 
            btnDeleteTrip.BackColor = Color.RoyalBlue;
            btnDeleteTrip.Cursor = Cursors.Hand;
            btnDeleteTrip.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteTrip.ForeColor = SystemColors.ControlLightLight;
            btnDeleteTrip.Location = new Point(216, 497);
            btnDeleteTrip.Margin = new Padding(4, 3, 4, 3);
            btnDeleteTrip.Name = "btnDeleteTrip";
            btnDeleteTrip.Size = new Size(202, 55);
            btnDeleteTrip.TabIndex = 49;
            btnDeleteTrip.Text = "Obriši podatke";
            btnDeleteTrip.UseVisualStyleBackColor = false;
            btnDeleteTrip.Visible = false;
            btnDeleteTrip.Click += btnDeleteTrip_Click;
            // 
            // lblErrorPrice
            // 
            lblErrorPrice.AutoSize = true;
            lblErrorPrice.ForeColor = Color.Firebrick;
            lblErrorPrice.Location = new Point(253, 226);
            lblErrorPrice.Margin = new Padding(4, 0, 4, 0);
            lblErrorPrice.Name = "lblErrorPrice";
            lblErrorPrice.Size = new Size(170, 21);
            lblErrorPrice.TabIndex = 40;
            lblErrorPrice.Text = "Morate uneti cenu!";
            lblErrorPrice.Visible = false;
            // 
            // lblErrorState
            // 
            lblErrorState.AutoSize = true;
            lblErrorState.ForeColor = Color.Firebrick;
            lblErrorState.Location = new Point(253, 145);
            lblErrorState.Margin = new Padding(4, 0, 4, 0);
            lblErrorState.Name = "lblErrorState";
            lblErrorState.Size = new Size(185, 21);
            lblErrorState.TabIndex = 39;
            lblErrorState.Text = "Morate uneti državu!";
            lblErrorState.Visible = false;
            // 
            // txtDays
            // 
            txtDays.Location = new Point(253, 357);
            txtDays.Margin = new Padding(4, 3, 4, 3);
            txtDays.Name = "txtDays";
            txtDays.Size = new Size(192, 28);
            txtDays.TabIndex = 38;
            txtDays.TextChanged += TextBoxTextChanged;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(253, 194);
            txtPrice.Margin = new Padding(4, 3, 4, 3);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(192, 28);
            txtPrice.TabIndex = 37;
            txtPrice.TextChanged += TextBoxTextChanged;
            // 
            // txtState
            // 
            txtState.Location = new Point(253, 114);
            txtState.Margin = new Padding(4, 3, 4, 3);
            txtState.Name = "txtState";
            txtState.Size = new Size(192, 28);
            txtState.TabIndex = 35;
            txtState.TextChanged += TextBoxTextChanged;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(253, 274);
            txtDiscount.Margin = new Padding(4, 3, 4, 3);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(192, 28);
            txtDiscount.TabIndex = 36;
            txtDiscount.TextChanged += TextBoxTextChanged;
            // 
            // txtTravelers
            // 
            txtTravelers.Location = new Point(253, 437);
            txtTravelers.Margin = new Padding(4, 3, 4, 3);
            txtTravelers.Name = "txtTravelers";
            txtTravelers.Size = new Size(192, 28);
            txtTravelers.TabIndex = 65;
            txtTravelers.TextChanged += TextBoxTextChanged;
            // 
            // lblListViewCaption
            // 
            lblListViewCaption.AutoSize = true;
            lblListViewCaption.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblListViewCaption.ForeColor = Color.RoyalBlue;
            lblListViewCaption.Location = new Point(28, 124);
            lblListViewCaption.Margin = new Padding(4, 0, 4, 0);
            lblListViewCaption.Name = "lblListViewCaption";
            lblListViewCaption.Size = new Size(114, 21);
            lblListViewCaption.TabIndex = 66;
            lblListViewCaption.Text = "Prikaz izleta: ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(txtDiscount);
            panel1.Controls.Add(txtTravelers);
            panel1.Controls.Add(txtState);
            panel1.Controls.Add(txtDays);
            panel1.Controls.Add(lblErrorState);
            panel1.Controls.Add(lblErrorPrice);
            panel1.Controls.Add(lblTravelers);
            panel1.Controls.Add(lblErrorDiscount);
            panel1.Controls.Add(lblErrorTravelers);
            panel1.Controls.Add(lblErrorDays);
            panel1.Controls.Add(lblCity);
            panel1.Controls.Add(lblState);
            panel1.Controls.Add(lblErrorCity);
            panel1.Controls.Add(lblPrice);
            panel1.Controls.Add(txtCity);
            panel1.Controls.Add(lblDiscount);
            panel1.Controls.Add(lblDays);
            panel1.ForeColor = Color.Firebrick;
            panel1.Location = new Point(601, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(585, 608);
            panel1.TabIndex = 67;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(80, 517);
            dateTimePicker1.MinDate = new DateTime(2024, 9, 18, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(365, 28);
            dateTimePicker1.TabIndex = 66;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.back_blue_button_icon_227866;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Cursor = Cursors.Hand;
            panel2.ForeColor = SystemColors.ControlLightLight;
            panel2.Location = new Point(28, 534);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(65, 61);
            panel2.TabIndex = 68;
            panel2.MouseClick += panel2_MouseClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(listView1);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(btnDeleteTrip);
            panel3.Controls.Add(btnAlterTrip);
            panel3.Controls.Add(lblListViewCaption);
            panel3.Controls.Add(btnCreateTrip);
            panel3.Controls.Add(lblChoice);
            panel3.Controls.Add(cmbOption);
            panel3.Location = new Point(-3, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(606, 608);
            panel3.TabIndex = 69;
            // 
            // AlterTrip
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1186, 607);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "AlterTrip";
            Text = "AlterTrip";
            Load += AlterTrip_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblTravelers;
        private Label lblErrorTravelers;
        private Label lblCity;
        private Label lblErrorCity;
        private TextBox txtCity;
        private Label lblDays;
        private Label lblChoice;
        private Label lblDiscount;
        private ComboBox cmbOption;
        private Label lblPrice;
        private ListView listView1;
        private Label lblState;
        private Button btnCreateTrip;
        private Label lblErrorDays;
        private Button btnAlterTrip;
        private Label lblErrorDiscount;
        private Button btnDeleteTrip;
        private Label lblErrorPrice;
        private Label lblErrorState;
        private TextBox txtDays;
        private TextBox txtPrice;
        private TextBox txtState;
        private TextBox txtDiscount;
        private TextBox txtTravelers;
        private Label lblListViewCaption;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DateTimePicker dateTimePicker1;
    }
}
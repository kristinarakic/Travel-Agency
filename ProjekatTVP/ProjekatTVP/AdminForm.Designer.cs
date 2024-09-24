namespace ProjekatTVP
{
    partial class AdminForm
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
            btnChangeTrip = new Button();
            btnChangeUser = new Button();
            btnChangeReservation = new Button();
            label1 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // btnChangeTrip
            // 
            btnChangeTrip.BackColor = SystemColors.ButtonHighlight;
            btnChangeTrip.Cursor = Cursors.Hand;
            btnChangeTrip.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangeTrip.ForeColor = Color.MediumBlue;
            btnChangeTrip.Location = new Point(141, 159);
            btnChangeTrip.Margin = new Padding(3, 4, 3, 4);
            btnChangeTrip.Name = "btnChangeTrip";
            btnChangeTrip.Size = new Size(144, 43);
            btnChangeTrip.TabIndex = 1;
            btnChangeTrip.Text = "Izlet";
            btnChangeTrip.UseVisualStyleBackColor = false;
            btnChangeTrip.Click += btnChangeTrip_Click;
            // 
            // btnChangeUser
            // 
            btnChangeUser.BackColor = SystemColors.ButtonHighlight;
            btnChangeUser.Cursor = Cursors.Hand;
            btnChangeUser.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangeUser.ForeColor = Color.MediumBlue;
            btnChangeUser.Location = new Point(141, 241);
            btnChangeUser.Margin = new Padding(3, 4, 3, 4);
            btnChangeUser.Name = "btnChangeUser";
            btnChangeUser.Size = new Size(144, 43);
            btnChangeUser.TabIndex = 2;
            btnChangeUser.Text = "Korisnik";
            btnChangeUser.UseVisualStyleBackColor = false;
            btnChangeUser.Click += btnChangeUser_Click;
            // 
            // btnChangeReservation
            // 
            btnChangeReservation.BackColor = Color.White;
            btnChangeReservation.Cursor = Cursors.Hand;
            btnChangeReservation.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangeReservation.ForeColor = Color.MediumBlue;
            btnChangeReservation.Location = new Point(141, 319);
            btnChangeReservation.Margin = new Padding(3, 4, 3, 4);
            btnChangeReservation.Name = "btnChangeReservation";
            btnChangeReservation.Size = new Size(144, 43);
            btnChangeReservation.TabIndex = 3;
            btnChangeReservation.Text = "Rezervacija";
            btnChangeReservation.UseVisualStyleBackColor = false;
            btnChangeReservation.Click += btnChangeReservation_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(141, 71);
            label1.Name = "label1";
            label1.Size = new Size(150, 23);
            label1.TabIndex = 5;
            label1.Text = "Ažurirajte listu: ";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.back_blue_button_icon_227866;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(46, 405);
            panel1.Name = "panel1";
            panel1.Size = new Size(62, 53);
            panel1.TabIndex = 14;
            panel1.MouseClick += panel1_MouseClick;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(422, 488);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btnChangeReservation);
            Controls.Add(btnChangeUser);
            Controls.Add(btnChangeTrip);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnChangeTrip;
        private Button btnChangeUser;
        private Button btnChangeReservation;
        private Label label1;
        private Panel panel1;
    }
}
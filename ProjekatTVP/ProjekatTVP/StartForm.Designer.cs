namespace ProjekatTVP
{
    partial class StartForm
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
            Button btnLogin;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnRegistration = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            btnLogin = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.BackgroundImageLayout = ImageLayout.None;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderColor = Color.GhostWhite;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 255);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            btnLogin.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.MediumBlue;
            btnLogin.Location = new Point(182, 192);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(162, 55);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Ulogujte se";
            btnLogin.UseMnemonic = false;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.UseWaitCursor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Forte", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(164, 39);
            label1.Name = "label1";
            label1.Size = new Size(204, 41);
            label1.TabIndex = 0;
            label1.Text = "The Horizon";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(207, 137);
            label2.Name = "label2";
            label2.Size = new Size(105, 21);
            label2.TabIndex = 1;
            label2.Text = "DobrodošlI!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(191, 283);
            label3.Name = "label3";
            label3.Size = new Size(144, 21);
            label3.TabIndex = 4;
            label3.Text = "Nemate nalog?";
            // 
            // btnRegistration
            // 
            btnRegistration.BackColor = Color.RoyalBlue;
            btnRegistration.Cursor = Cursors.Hand;
            btnRegistration.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistration.ForeColor = Color.White;
            btnRegistration.Location = new Point(182, 320);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(162, 55);
            btnRegistration.TabIndex = 5;
            btnRegistration.Text = "Registrujte se ";
            btnRegistration.UseMnemonic = false;
            btnRegistration.UseVisualStyleBackColor = false;
            btnRegistration.Click += btnRegistration_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnRegistration);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(387, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(514, 463);
            panel1.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGreen;
            panel3.BackgroundImage = Properties.Resources.xx;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Cursor = Cursors.Hand;
            panel3.Location = new Point(458, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(56, 49);
            panel3.TabIndex = 8;
            panel3.MouseClick += panel3_MouseClick;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(393, 466);
            panel2.TabIndex = 7;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            CausesValidation = false;
            ClientSize = new Size(901, 462);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnLogin;
        private Label label3;
        private Button btnRegistration;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}
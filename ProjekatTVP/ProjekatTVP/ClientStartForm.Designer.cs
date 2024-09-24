namespace ProjekatTVP
{
    partial class ClientStartForm
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
            btnAlterReservations = new Button();
            lblListViewCaption = new Label();
            listView1 = new ListView();
            label1 = new Label();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            lblCaptionListView = new Label();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // btnAlterReservations
            // 
            btnAlterReservations.BackColor = Color.RoyalBlue;
            btnAlterReservations.Cursor = Cursors.Hand;
            btnAlterReservations.ForeColor = SystemColors.ButtonHighlight;
            btnAlterReservations.Location = new Point(253, 520);
            btnAlterReservations.Margin = new Padding(4, 3, 4, 3);
            btnAlterReservations.Name = "btnAlterReservations";
            btnAlterReservations.Size = new Size(201, 51);
            btnAlterReservations.TabIndex = 96;
            btnAlterReservations.Text = "Ažuriraj listu";
            btnAlterReservations.UseVisualStyleBackColor = false;
            btnAlterReservations.Click += btnAlterReservations_Click;
            // 
            // lblListViewCaption
            // 
            lblListViewCaption.AutoSize = true;
            lblListViewCaption.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblListViewCaption.ForeColor = Color.MediumBlue;
            lblListViewCaption.Location = new Point(199, 31);
            lblListViewCaption.Margin = new Padding(4, 0, 4, 0);
            lblListViewCaption.Name = "lblListViewCaption";
            lblListViewCaption.Size = new Size(300, 23);
            lblListViewCaption.TabIndex = 95;
            lblListViewCaption.Text = "Izlistajte rezervacije u periodu:";
            // 
            // listView1
            // 
            listView1.FullRowSelect = true;
            listView1.Location = new Point(0, 168);
            listView1.Margin = new Padding(4);
            listView1.Name = "listView1";
            listView1.Size = new Size(689, 345);
            listView1.TabIndex = 94;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(342, 83);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(16, 21);
            label1.TabIndex = 102;
            label1.Text = "-";
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(0, 83);
            dtpStart.Margin = new Padding(4);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(334, 28);
            dtpStart.TabIndex = 104;
            dtpStart.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // dtpEnd
            // 
            dtpEnd.CalendarForeColor = Color.RoyalBlue;
            dtpEnd.CalendarTitleForeColor = Color.RoyalBlue;
            dtpEnd.CalendarTrailingForeColor = Color.RoyalBlue;
            dtpEnd.Location = new Point(366, 83);
            dtpEnd.Margin = new Padding(4);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(323, 28);
            dtpEnd.TabIndex = 105;
            // 
            // lblCaptionListView
            // 
            lblCaptionListView.AutoSize = true;
            lblCaptionListView.ForeColor = Color.MediumBlue;
            lblCaptionListView.Location = new Point(13, 143);
            lblCaptionListView.Margin = new Padding(4, 0, 4, 0);
            lblCaptionListView.Name = "lblCaptionListView";
            lblCaptionListView.Size = new Size(60, 21);
            lblCaptionListView.TabIndex = 107;
            lblCaptionListView.Text = "label2";
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.back_blue_button_icon_227866;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.ForeColor = SystemColors.ControlLightLight;
            panel2.Location = new Point(31, 556);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(60, 57);
            panel2.TabIndex = 108;
            panel2.MouseClick += panel2_MouseClick;
            // 
            // ClientStartForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(690, 634);
            Controls.Add(panel2);
            Controls.Add(lblCaptionListView);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(label1);
            Controls.Add(btnAlterReservations);
            Controls.Add(lblListViewCaption);
            Controls.Add(listView1);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ClientStartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClientFormStart";
            Load += ClientStartForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAlterReservations;
        private Label lblListViewCaption;
        private ListView listView1;
        private Label label1;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private Label lblCaptionListView;
        private Panel panel2;
    }
}
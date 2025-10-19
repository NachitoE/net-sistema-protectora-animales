namespace WindowsForms.menuAdmin
{
    partial class fm_AdminMenu
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
            pb_headerPic = new PictureBox();
            lb_MenuTitle = new Label();
            btn_menuAdoptions = new Button();
            btn_menuSightings = new Button();
            btn_menuReports = new Button();
            btn_menuUsers = new Button();
            btn_FosterHouses = new Button();
            btn_debugDownload = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_headerPic).BeginInit();
            SuspendLayout();
            // 
            // pb_headerPic
            // 
            pb_headerPic.BackgroundImage = Properties.Resources.Studio_Ghibli__Cattt__;
            pb_headerPic.Location = new Point(-161, -105);
            pb_headerPic.Name = "pb_headerPic";
            pb_headerPic.Size = new Size(774, 231);
            pb_headerPic.TabIndex = 0;
            pb_headerPic.TabStop = false;
            // 
            // lb_MenuTitle
            // 
            lb_MenuTitle.AutoSize = true;
            lb_MenuTitle.BackColor = Color.Olive;
            lb_MenuTitle.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_MenuTitle.ForeColor = SystemColors.ControlLight;
            lb_MenuTitle.Location = new Point(-2, 79);
            lb_MenuTitle.Name = "lb_MenuTitle";
            lb_MenuTitle.Size = new Size(119, 47);
            lb_MenuTitle.TabIndex = 1;
            lb_MenuTitle.Text = "MENU";
            lb_MenuTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_menuAdoptions
            // 
            btn_menuAdoptions.Location = new Point(93, 160);
            btn_menuAdoptions.Name = "btn_menuAdoptions";
            btn_menuAdoptions.Size = new Size(250, 23);
            btn_menuAdoptions.TabIndex = 2;
            btn_menuAdoptions.Text = "Adopciones";
            btn_menuAdoptions.UseVisualStyleBackColor = true;
            btn_menuAdoptions.Click += btn_menuAdoptions_Click;
            // 
            // btn_menuSightings
            // 
            btn_menuSightings.Location = new Point(93, 218);
            btn_menuSightings.Name = "btn_menuSightings";
            btn_menuSightings.Size = new Size(250, 23);
            btn_menuSightings.TabIndex = 4;
            btn_menuSightings.Text = "Avistamientos";
            btn_menuSightings.UseVisualStyleBackColor = true;
            btn_menuSightings.Click += btn_menuSightings_Click;
            // 
            // btn_menuReports
            // 
            btn_menuReports.Location = new Point(93, 276);
            btn_menuReports.Name = "btn_menuReports";
            btn_menuReports.Size = new Size(250, 23);
            btn_menuReports.TabIndex = 5;
            btn_menuReports.Text = "Reportes";
            btn_menuReports.UseVisualStyleBackColor = true;
            btn_menuReports.Click += btn_menuReports_Click;
            // 
            // btn_menuUsers
            // 
            btn_menuUsers.Location = new Point(93, 305);
            btn_menuUsers.Name = "btn_menuUsers";
            btn_menuUsers.Size = new Size(250, 23);
            btn_menuUsers.TabIndex = 6;
            btn_menuUsers.Text = "Usuarios";
            btn_menuUsers.UseVisualStyleBackColor = true;
            btn_menuUsers.Click += btn_menuUsers_Click;
            // 
            // btn_FosterHouses
            // 
            btn_FosterHouses.Location = new Point(93, 247);
            btn_FosterHouses.Name = "btn_FosterHouses";
            btn_FosterHouses.Size = new Size(250, 23);
            btn_FosterHouses.TabIndex = 7;
            btn_FosterHouses.Text = "Casas";
            btn_FosterHouses.UseVisualStyleBackColor = true;
            btn_FosterHouses.Click += btn_FosterHouses_Click;
            // 
            // btn_debugDownload
            // 
            btn_debugDownload.Location = new Point(93, 189);
            btn_debugDownload.Name = "btn_debugDownload";
            btn_debugDownload.Size = new Size(250, 23);
            btn_debugDownload.TabIndex = 8;
            btn_debugDownload.Text = "Adopciones";
            btn_debugDownload.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(93, 334);
            button1.Name = "button1";
            button1.Size = new Size(250, 23);
            button1.TabIndex = 9;
            button1.Text = "DEBUG DOWNLOAD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // fm_AdminMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 400);
            Controls.Add(button1);
            Controls.Add(btn_FosterHouses);
            Controls.Add(btn_menuUsers);
            Controls.Add(btn_menuReports);
            Controls.Add(btn_menuSightings);
            Controls.Add(btn_menuAdoptions);
            Controls.Add(btn_debugDownload);
            Controls.Add(lb_MenuTitle);
            Controls.Add(pb_headerPic);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "fm_AdminMenu";
            Text = "Administrador";
            ((System.ComponentModel.ISupportInitialize)pb_headerPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb_headerPic;
        private Label lb_MenuTitle;
        private Button btn_menuAdoptions;
        private Button btn_menuSightings;
        private Button btn_menuReports;
        private Button btn_menuUsers;
        private Button btn_FosterHouses;
        private Button btn_debugDownload;
        private Button button1;
    }
}
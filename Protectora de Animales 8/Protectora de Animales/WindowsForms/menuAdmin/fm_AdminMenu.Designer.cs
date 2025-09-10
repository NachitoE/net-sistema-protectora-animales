namespace WindowsFormsApp1
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
            this.lb_MenuTitle = new System.Windows.Forms.Label();
            this.btn_menuAdoptions = new System.Windows.Forms.Button();
            this.btn_menuSightings = new System.Windows.Forms.Button();
            this.btn_menuReports = new System.Windows.Forms.Button();
            this.btn_menuUsers = new System.Windows.Forms.Button();
            this.btn_menuAnimals = new System.Windows.Forms.Button();
            this.pb_headerpic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_headerpic)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_MenuTitle
            // 
            this.lb_MenuTitle.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lb_MenuTitle.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MenuTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_MenuTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_MenuTitle.Location = new System.Drawing.Point(1, 53);
            this.lb_MenuTitle.Name = "lb_MenuTitle";
            this.lb_MenuTitle.Size = new System.Drawing.Size(98, 42);
            this.lb_MenuTitle.TabIndex = 3;
            this.lb_MenuTitle.Text = "MENU";
            // 
            // btn_menuAdoptions
            // 
            this.btn_menuAdoptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_menuAdoptions.Location = new System.Drawing.Point(77, 120);
            this.btn_menuAdoptions.Name = "btn_menuAdoptions";
            this.btn_menuAdoptions.Size = new System.Drawing.Size(217, 26);
            this.btn_menuAdoptions.TabIndex = 5;
            this.btn_menuAdoptions.Text = "Adopciones";
            this.btn_menuAdoptions.UseVisualStyleBackColor = true;
            this.btn_menuAdoptions.Click += new System.EventHandler(this.btn_menuAdoptions_Click);
            // 
            // btn_menuSightings
            // 
            this.btn_menuSightings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_menuSightings.Location = new System.Drawing.Point(77, 209);
            this.btn_menuSightings.Name = "btn_menuSightings";
            this.btn_menuSightings.Size = new System.Drawing.Size(217, 26);
            this.btn_menuSightings.TabIndex = 6;
            this.btn_menuSightings.Text = "Avistamientos";
            this.btn_menuSightings.UseVisualStyleBackColor = true;
            this.btn_menuSightings.Click += new System.EventHandler(this.btn_menuSightings_Click);
            // 
            // btn_menuReports
            // 
            this.btn_menuReports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_menuReports.Location = new System.Drawing.Point(77, 252);
            this.btn_menuReports.Name = "btn_menuReports";
            this.btn_menuReports.Size = new System.Drawing.Size(217, 26);
            this.btn_menuReports.TabIndex = 7;
            this.btn_menuReports.Text = "Reportes";
            this.btn_menuReports.UseVisualStyleBackColor = true;
            this.btn_menuReports.Click += new System.EventHandler(this.btn_menuReports_Click);
            // 
            // btn_menuUsers
            // 
            this.btn_menuUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_menuUsers.Location = new System.Drawing.Point(77, 296);
            this.btn_menuUsers.Name = "btn_menuUsers";
            this.btn_menuUsers.Size = new System.Drawing.Size(217, 26);
            this.btn_menuUsers.TabIndex = 9;
            this.btn_menuUsers.Text = "Usuarios";
            this.btn_menuUsers.UseVisualStyleBackColor = true;
            this.btn_menuUsers.Click += new System.EventHandler(this.btn_menuUsers_Click);
            // 
            // btn_menuAnimals
            // 
            this.btn_menuAnimals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_menuAnimals.Location = new System.Drawing.Point(77, 163);
            this.btn_menuAnimals.Name = "btn_menuAnimals";
            this.btn_menuAnimals.Size = new System.Drawing.Size(217, 26);
            this.btn_menuAnimals.TabIndex = 10;
            this.btn_menuAnimals.Text = "Animales";
            this.btn_menuAnimals.UseVisualStyleBackColor = true;
            this.btn_menuAnimals.Click += new System.EventHandler(this.btn_AnimalsMenu_Click);
            // 
            // pb_headerpic
            // 
            this.pb_headerpic.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb_headerpic.Image = WindowsForms.Properties.Resources.Studio_Ghibli__Cattt__;
            this.pb_headerpic.Location = new System.Drawing.Point(0, 0);
            this.pb_headerpic.Name = "pb_headerpic";
            this.pb_headerpic.Size = new System.Drawing.Size(390, 95);
            this.pb_headerpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_headerpic.TabIndex = 2;
            this.pb_headerpic.TabStop = false;
            // 
            // fm_AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 360);
            this.Controls.Add(this.btn_menuAnimals);
            this.Controls.Add(this.btn_menuUsers);
            this.Controls.Add(this.btn_menuReports);
            this.Controls.Add(this.btn_menuSightings);
            this.Controls.Add(this.btn_menuAdoptions);
            this.Controls.Add(this.lb_MenuTitle);
            this.Controls.Add(this.pb_headerpic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fm_AdminMenu";
            this.Text = "MENU ADMINISTRADOR";
            ((System.ComponentModel.ISupportInitialize)(this.pb_headerpic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_headerpic;
        protected internal System.Windows.Forms.Label lb_MenuTitle;
        public System.Windows.Forms.Button btn_menuAdoptions;
        public System.Windows.Forms.Button btn_menuAnimals;
        protected System.Windows.Forms.Button btn_menuReports;
        protected System.Windows.Forms.Button btn_menuUsers;
        protected System.Windows.Forms.Button btn_menuSightings;
    }
}
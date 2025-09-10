namespace WindowsFormsApp1.menuVolunteer
{
    partial class fm_VolunteerMenu
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
            this.btn_menuAnimals = new System.Windows.Forms.Button();
            this.btn_menuSightings = new System.Windows.Forms.Button();
            this.btn_MenuAdoption = new System.Windows.Forms.Button();
            this.lb_MenuTitle = new System.Windows.Forms.Label();
            this.pb_headerpic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_headerpic)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_menuAnimals
            // 
            this.btn_menuAnimals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_menuAnimals.Location = new System.Drawing.Point(81, 209);
            this.btn_menuAnimals.Name = "btn_menuAnimals";
            this.btn_menuAnimals.Size = new System.Drawing.Size(217, 26);
            this.btn_menuAnimals.TabIndex = 18;
            this.btn_menuAnimals.Text = "Animales";
            this.btn_menuAnimals.UseVisualStyleBackColor = true;
            this.btn_menuAnimals.Click += new System.EventHandler(this.btn_menuAnimals_Click);
            // 
            // btn_menuSightings
            // 
            this.btn_menuSightings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_menuSightings.Location = new System.Drawing.Point(81, 264);
            this.btn_menuSightings.Name = "btn_menuSightings";
            this.btn_menuSightings.Size = new System.Drawing.Size(217, 26);
            this.btn_menuSightings.TabIndex = 17;
            this.btn_menuSightings.Text = "Avistamientos";
            this.btn_menuSightings.UseVisualStyleBackColor = true;
            // 
            // btn_MenuAdoption
            // 
            this.btn_MenuAdoption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MenuAdoption.Location = new System.Drawing.Point(81, 150);
            this.btn_MenuAdoption.Name = "btn_MenuAdoption";
            this.btn_MenuAdoption.Size = new System.Drawing.Size(217, 26);
            this.btn_MenuAdoption.TabIndex = 16;
            this.btn_MenuAdoption.Text = "Adopciones";
            this.btn_MenuAdoption.UseVisualStyleBackColor = true;
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
            this.lb_MenuTitle.TabIndex = 15;
            this.lb_MenuTitle.Text = "MENU";
            // 
            // pb_headerpic
            // 
            this.pb_headerpic.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb_headerpic.Image = WindowsForms.Properties.Resources.Studio_Ghibli__Cattt__;
            this.pb_headerpic.Location = new System.Drawing.Point(0, 0);
            this.pb_headerpic.Name = "pb_headerpic";
            this.pb_headerpic.Size = new System.Drawing.Size(390, 95);
            this.pb_headerpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_headerpic.TabIndex = 14;
            this.pb_headerpic.TabStop = false;
            // 
            // fm_VolunteerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 360);
            this.Controls.Add(this.btn_menuAnimals);
            this.Controls.Add(this.btn_menuSightings);
            this.Controls.Add(this.btn_MenuAdoption);
            this.Controls.Add(this.lb_MenuTitle);
            this.Controls.Add(this.pb_headerpic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fm_VolunteerMenu";
            this.Text = "MENU";
            ((System.ComponentModel.ISupportInitialize)(this.pb_headerpic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btn_menuAnimals;
        protected System.Windows.Forms.Button btn_menuSightings;
        public System.Windows.Forms.Button btn_MenuAdoption;
        protected internal System.Windows.Forms.Label lb_MenuTitle;
        private System.Windows.Forms.PictureBox pb_headerpic;
    }
}
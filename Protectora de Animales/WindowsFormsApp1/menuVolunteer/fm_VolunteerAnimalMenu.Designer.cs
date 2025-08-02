namespace WindowsFormsApp1.menuVolunteer
{
    partial class fm_VolunteerAnimalMenu
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
            this.pb_headerpic = new System.Windows.Forms.PictureBox();
            this.btn_AnimalsCatalog = new System.Windows.Forms.Button();
            this.btn_AdoptionFollowing = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_headerpic)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_MenuTitle
            // 
            this.lb_MenuTitle.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lb_MenuTitle.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MenuTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_MenuTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_MenuTitle.Location = new System.Drawing.Point(0, 53);
            this.lb_MenuTitle.Name = "lb_MenuTitle";
            this.lb_MenuTitle.Size = new System.Drawing.Size(98, 42);
            this.lb_MenuTitle.TabIndex = 7;
            this.lb_MenuTitle.Text = "MENU";
            // 
            // pb_headerpic
            // 
            this.pb_headerpic.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb_headerpic.Image = global::WindowsFormsApp1.Properties.Resources.Studio_Ghibli__Cattt__;
            this.pb_headerpic.Location = new System.Drawing.Point(0, 0);
            this.pb_headerpic.Name = "pb_headerpic";
            this.pb_headerpic.Size = new System.Drawing.Size(390, 95);
            this.pb_headerpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_headerpic.TabIndex = 6;
            this.pb_headerpic.TabStop = false;
            // 
            // btn_AnimalsCatalog
            // 
            this.btn_AnimalsCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AnimalsCatalog.Location = new System.Drawing.Point(87, 213);
            this.btn_AnimalsCatalog.Name = "btn_AnimalsCatalog";
            this.btn_AnimalsCatalog.Size = new System.Drawing.Size(217, 26);
            this.btn_AnimalsCatalog.TabIndex = 15;
            this.btn_AnimalsCatalog.Text = "Registro Medico";
            this.btn_AnimalsCatalog.UseVisualStyleBackColor = true;
            // 
            // btn_AdoptionFollowing
            // 
            this.btn_AdoptionFollowing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AdoptionFollowing.Location = new System.Drawing.Point(87, 152);
            this.btn_AdoptionFollowing.Name = "btn_AdoptionFollowing";
            this.btn_AdoptionFollowing.Size = new System.Drawing.Size(217, 26);
            this.btn_AdoptionFollowing.TabIndex = 14;
            this.btn_AdoptionFollowing.Text = "Mis Animales";
            this.btn_AdoptionFollowing.UseVisualStyleBackColor = true;
            // 
            // fm_VolunteerAnimalMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 360);
            this.Controls.Add(this.btn_AnimalsCatalog);
            this.Controls.Add(this.btn_AdoptionFollowing);
            this.Controls.Add(this.lb_MenuTitle);
            this.Controls.Add(this.pb_headerpic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fm_VolunteerAnimalMenu";
            this.Text = "fm_VolunteerAnimalMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pb_headerpic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.Label lb_MenuTitle;
        private System.Windows.Forms.PictureBox pb_headerpic;
        public System.Windows.Forms.Button btn_AnimalsCatalog;
        public System.Windows.Forms.Button btn_AdoptionFollowing;
    }
}
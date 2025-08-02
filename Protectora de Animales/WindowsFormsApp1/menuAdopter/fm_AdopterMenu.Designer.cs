namespace WindowsFormsApp1.menuAdopter
{
    partial class fm_AdopterMenu
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
            this.btn_AdopterInfo = new System.Windows.Forms.Button();
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
            this.lb_MenuTitle.TabIndex = 5;
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
            this.pb_headerpic.TabIndex = 4;
            this.pb_headerpic.TabStop = false;
            // 
            // btn_AnimalsCatalog
            // 
            this.btn_AnimalsCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AnimalsCatalog.Location = new System.Drawing.Point(75, 236);
            this.btn_AnimalsCatalog.Name = "btn_AnimalsCatalog";
            this.btn_AnimalsCatalog.Size = new System.Drawing.Size(217, 26);
            this.btn_AnimalsCatalog.TabIndex = 13;
            this.btn_AnimalsCatalog.Text = "Ver Animales";
            this.btn_AnimalsCatalog.UseVisualStyleBackColor = true;
            this.btn_AnimalsCatalog.Click += new System.EventHandler(this.btn_AnimalsCatalog_Click);
            // 
            // btn_AdoptionFollowing
            // 
            this.btn_AdoptionFollowing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AdoptionFollowing.Location = new System.Drawing.Point(75, 169);
            this.btn_AdoptionFollowing.Name = "btn_AdoptionFollowing";
            this.btn_AdoptionFollowing.Size = new System.Drawing.Size(217, 26);
            this.btn_AdoptionFollowing.TabIndex = 11;
            this.btn_AdoptionFollowing.Text = "Seguir mis Adopciones";
            this.btn_AdoptionFollowing.UseVisualStyleBackColor = true;
            // 
            // btn_AdopterInfo
            // 
            this.btn_AdopterInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AdopterInfo.Location = new System.Drawing.Point(75, 117);
            this.btn_AdopterInfo.Name = "btn_AdopterInfo";
            this.btn_AdopterInfo.Size = new System.Drawing.Size(217, 26);
            this.btn_AdopterInfo.TabIndex = 14;
            this.btn_AdopterInfo.Text = "Requisitos para adoptar";
            this.btn_AdopterInfo.UseVisualStyleBackColor = true;
            // 
            // fm_AdopterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 360);
            this.Controls.Add(this.btn_AdopterInfo);
            this.Controls.Add(this.btn_AnimalsCatalog);
            this.Controls.Add(this.btn_AdoptionFollowing);
            this.Controls.Add(this.lb_MenuTitle);
            this.Controls.Add(this.pb_headerpic);
            this.MaximizeBox = false;
            this.Name = "fm_AdopterMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pb_headerpic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.Label lb_MenuTitle;
        private System.Windows.Forms.PictureBox pb_headerpic;
        public System.Windows.Forms.Button btn_AnimalsCatalog;
        public System.Windows.Forms.Button btn_AdoptionFollowing;
        public System.Windows.Forms.Button btn_AdopterInfo;
    }
}
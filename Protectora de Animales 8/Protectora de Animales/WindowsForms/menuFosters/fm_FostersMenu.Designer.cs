namespace WindowsForms.menuFosters
{
    partial class fm_FostersMenu
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
            lb_MenuTitle = new Label();
            btn_menuAnimals = new Button();
            btn_menuSightings = new Button();
            btn_menuAdoptions = new Button();
            pb_headerpic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_headerpic).BeginInit();
            SuspendLayout();
            // 
            // lb_MenuTitle
            // 
            lb_MenuTitle.BackColor = Color.DarkOliveGreen;
            lb_MenuTitle.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_MenuTitle.ForeColor = SystemColors.ButtonHighlight;
            lb_MenuTitle.ImageAlign = ContentAlignment.MiddleRight;
            lb_MenuTitle.Location = new Point(-1, 81);
            lb_MenuTitle.Margin = new Padding(5, 0, 5, 0);
            lb_MenuTitle.Name = "lb_MenuTitle";
            lb_MenuTitle.Size = new Size(130, 64);
            lb_MenuTitle.TabIndex = 5;
            lb_MenuTitle.Text = "MENU";
            // 
            // btn_menuAnimals
            // 
            btn_menuAnimals.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_menuAnimals.Location = new Point(106, 304);
            btn_menuAnimals.Margin = new Padding(5, 4, 5, 4);
            btn_menuAnimals.Name = "btn_menuAnimals";
            btn_menuAnimals.Size = new Size(289, 40);
            btn_menuAnimals.TabIndex = 13;
            btn_menuAnimals.Text = "Animales";
            btn_menuAnimals.UseVisualStyleBackColor = true;
            btn_menuAnimals.Click += btn_menuAnimals_Click;
            // 
            // btn_menuSightings
            // 
            btn_menuSightings.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_menuSightings.Location = new Point(106, 384);
            btn_menuSightings.Margin = new Padding(5, 4, 5, 4);
            btn_menuSightings.Name = "btn_menuSightings";
            btn_menuSightings.Size = new Size(289, 40);
            btn_menuSightings.TabIndex = 12;
            btn_menuSightings.Text = "Avistamientos";
            btn_menuSightings.UseVisualStyleBackColor = true;
            btn_menuSightings.Click += btn_menuSightings_Click;
            // 
            // btn_menuAdoptions
            // 
            btn_menuAdoptions.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_menuAdoptions.Location = new Point(106, 213);
            btn_menuAdoptions.Margin = new Padding(5, 4, 5, 4);
            btn_menuAdoptions.Name = "btn_menuAdoptions";
            btn_menuAdoptions.Size = new Size(289, 40);
            btn_menuAdoptions.TabIndex = 11;
            btn_menuAdoptions.Text = "Adopciones";
            btn_menuAdoptions.UseVisualStyleBackColor = true;
            btn_menuAdoptions.Click += btn_menuAdoptions_Click;
            // 
            // pb_headerpic
            // 
            pb_headerpic.Dock = DockStyle.Top;
            pb_headerpic.Image = Properties.Resources.Studio_Ghibli__Cattt__;
            pb_headerpic.Location = new Point(0, 0);
            pb_headerpic.Margin = new Padding(5, 4, 5, 4);
            pb_headerpic.Name = "pb_headerpic";
            pb_headerpic.Size = new Size(520, 147);
            pb_headerpic.SizeMode = PictureBoxSizeMode.CenterImage;
            pb_headerpic.TabIndex = 4;
            pb_headerpic.TabStop = false;
            // 
            // fm_FostersMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 553);
            Controls.Add(btn_menuAnimals);
            Controls.Add(btn_menuSightings);
            Controls.Add(btn_menuAdoptions);
            Controls.Add(lb_MenuTitle);
            Controls.Add(pb_headerpic);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "fm_FostersMenu";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)pb_headerpic).EndInit();
            ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.Label lb_MenuTitle;
        private System.Windows.Forms.PictureBox pb_headerpic;
        public System.Windows.Forms.Button btn_menuAnimals;
        protected System.Windows.Forms.Button btn_menuSightings;
        public System.Windows.Forms.Button btn_menuAdoptions;
    }
}
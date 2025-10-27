namespace WindowsForms.menuVolunteer
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
            btn_menuAnimals = new Button();
            btn_menuSightings = new Button();
            btn_menuAdoptions = new Button();
            lb_MenuTitle = new Label();
            pb_headerpic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_headerpic).BeginInit();
            SuspendLayout();
            // 
            // btn_menuAnimals
            // 
            btn_menuAnimals.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_menuAnimals.Location = new Point(33, 223);
            btn_menuAnimals.Margin = new Padding(4, 3, 4, 3);
            btn_menuAnimals.Name = "btn_menuAnimals";
            btn_menuAnimals.Size = new Size(373, 30);
            btn_menuAnimals.TabIndex = 18;
            btn_menuAnimals.Text = "Animales";
            btn_menuAnimals.UseVisualStyleBackColor = true;
            btn_menuAnimals.Click += btn_menuAnimals_Click;
            // 
            // btn_menuSightings
            // 
            btn_menuSightings.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_menuSightings.Location = new Point(33, 284);
            btn_menuSightings.Margin = new Padding(4, 3, 4, 3);
            btn_menuSightings.Name = "btn_menuSightings";
            btn_menuSightings.Size = new Size(373, 30);
            btn_menuSightings.TabIndex = 17;
            btn_menuSightings.Text = "Avistamientos";
            btn_menuSightings.UseVisualStyleBackColor = true;
            btn_menuSightings.Click += btn_menuSightings_Click;
            // 
            // btn_menuAdoptions
            // 
            btn_menuAdoptions.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_menuAdoptions.Location = new Point(33, 161);
            btn_menuAdoptions.Margin = new Padding(4, 3, 4, 3);
            btn_menuAdoptions.Name = "btn_menuAdoptions";
            btn_menuAdoptions.Size = new Size(373, 30);
            btn_menuAdoptions.TabIndex = 16;
            btn_menuAdoptions.Text = "Revisar Adopciones";
            btn_menuAdoptions.UseVisualStyleBackColor = true;
            btn_menuAdoptions.Click += btn_menuAdoptions_Click;
            // 
            // lb_MenuTitle
            // 
            lb_MenuTitle.BackColor = Color.DarkOliveGreen;
            lb_MenuTitle.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_MenuTitle.ForeColor = SystemColors.ButtonHighlight;
            lb_MenuTitle.ImageAlign = ContentAlignment.MiddleRight;
            lb_MenuTitle.Location = new Point(0, 62);
            lb_MenuTitle.Margin = new Padding(4, 0, 4, 0);
            lb_MenuTitle.Name = "lb_MenuTitle";
            lb_MenuTitle.Size = new Size(114, 48);
            lb_MenuTitle.TabIndex = 15;
            lb_MenuTitle.Text = "MENU";
            // 
            // pb_headerpic
            // 
            pb_headerpic.Dock = DockStyle.Top;
            pb_headerpic.Image = Properties.Resources.Studio_Ghibli__Cattt__;
            pb_headerpic.Location = new Point(0, 0);
            pb_headerpic.Margin = new Padding(4, 3, 4, 3);
            pb_headerpic.Name = "pb_headerpic";
            pb_headerpic.Size = new Size(455, 110);
            pb_headerpic.SizeMode = PictureBoxSizeMode.CenterImage;
            pb_headerpic.TabIndex = 14;
            pb_headerpic.TabStop = false;
            // 
            // fm_VolunteerMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 415);
            Controls.Add(btn_menuAnimals);
            Controls.Add(btn_menuSightings);
            Controls.Add(btn_menuAdoptions);
            Controls.Add(lb_MenuTitle);
            Controls.Add(pb_headerpic);
            Name = "fm_VolunteerMenu";
            Text = "fm_VolunteerMenu";
            ((System.ComponentModel.ISupportInitialize)pb_headerpic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Button btn_menuAnimals;
        protected Button btn_menuSightings;
        public Button btn_menuAdoptions;
        protected internal Label lb_MenuTitle;
        private PictureBox pb_headerpic;
    }
}
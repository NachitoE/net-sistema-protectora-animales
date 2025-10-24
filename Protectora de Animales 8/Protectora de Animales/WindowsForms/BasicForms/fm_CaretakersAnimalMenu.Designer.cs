namespace WindowsForms.menuFoster
{
    partial class fm_CaretakersAnimalMenu
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
            pb_headerpic = new PictureBox();
            btn_AnimalsMedicalCheckup = new Button();
            btn_CaretakersAnimals = new Button();
            lb_MenuTitle = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_headerpic).BeginInit();
            SuspendLayout();
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
            pb_headerpic.TabIndex = 16;
            pb_headerpic.TabStop = false;
            // 
            // btn_AnimalsMedicalCheckup
            // 
            btn_AnimalsMedicalCheckup.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_AnimalsMedicalCheckup.Location = new Point(99, 246);
            btn_AnimalsMedicalCheckup.Margin = new Padding(4, 3, 4, 3);
            btn_AnimalsMedicalCheckup.Name = "btn_AnimalsMedicalCheckup";
            btn_AnimalsMedicalCheckup.Size = new Size(212, 30);
            btn_AnimalsMedicalCheckup.TabIndex = 22;
            btn_AnimalsMedicalCheckup.Text = "Registro Medico";
            btn_AnimalsMedicalCheckup.UseVisualStyleBackColor = true;
            btn_AnimalsMedicalCheckup.Click += btn_AnimalsMedicalCheckup_Click;
            // 
            // btn_CaretakersAnimals
            // 
            btn_CaretakersAnimals.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_CaretakersAnimals.Location = new Point(99, 175);
            btn_CaretakersAnimals.Margin = new Padding(4, 3, 4, 3);
            btn_CaretakersAnimals.Name = "btn_CaretakersAnimals";
            btn_CaretakersAnimals.Size = new Size(212, 30);
            btn_CaretakersAnimals.TabIndex = 21;
            btn_CaretakersAnimals.Text = "Mis Animales";
            btn_CaretakersAnimals.UseVisualStyleBackColor = true;
            btn_CaretakersAnimals.Click += btn_CaretakersAnimals_Click;
            // 
            // lb_MenuTitle
            // 
            lb_MenuTitle.BackColor = Color.DarkOliveGreen;
            lb_MenuTitle.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_MenuTitle.ForeColor = SystemColors.ButtonHighlight;
            lb_MenuTitle.ImageAlign = ContentAlignment.MiddleRight;
            lb_MenuTitle.Location = new Point(-2, 61);
            lb_MenuTitle.Margin = new Padding(4, 0, 4, 0);
            lb_MenuTitle.Name = "lb_MenuTitle";
            lb_MenuTitle.Size = new Size(114, 48);
            lb_MenuTitle.TabIndex = 20;
            lb_MenuTitle.Text = "MENU";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(99, 305);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(212, 30);
            button1.TabIndex = 23;
            button1.Text = "Nuevo Registro Medico";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // fm_CaretakersAnimalMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 415);
            Controls.Add(button1);
            Controls.Add(btn_AnimalsMedicalCheckup);
            Controls.Add(btn_CaretakersAnimals);
            Controls.Add(lb_MenuTitle);
            Controls.Add(pb_headerpic);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "fm_CaretakersAnimalMenu";
            Text = "fm_FosterAnimalMenu";
            ((System.ComponentModel.ISupportInitialize)pb_headerpic).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_headerpic;
        public System.Windows.Forms.Button btn_AnimalsMedicalCheckup;
        public System.Windows.Forms.Button btn_CaretakersAnimals;
        protected internal System.Windows.Forms.Label lb_MenuTitle;
        public Button button1;
    }
}
namespace WindowsForms.menuAdmin
{
    partial class fm_AdminAdoptionMenu
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
            pb_headerPic = new PictureBox();
            btn_Modify_Adoption = new Button();
            btn_AdoptionFollowings = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_headerPic).BeginInit();
            SuspendLayout();
            // 
            // lb_MenuTitle
            // 
            lb_MenuTitle.AutoSize = true;
            lb_MenuTitle.BackColor = Color.Olive;
            lb_MenuTitle.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_MenuTitle.ForeColor = SystemColors.ControlLight;
            lb_MenuTitle.Location = new Point(-1, 90);
            lb_MenuTitle.Name = "lb_MenuTitle";
            lb_MenuTitle.Size = new Size(119, 47);
            lb_MenuTitle.TabIndex = 3;
            lb_MenuTitle.Text = "MENU";
            lb_MenuTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pb_headerPic
            // 
            pb_headerPic.BackgroundImage = Properties.Resources.Studio_Ghibli__Cattt__;
            pb_headerPic.Location = new Point(-164, -97);
            pb_headerPic.Name = "pb_headerPic";
            pb_headerPic.Size = new Size(612, 234);
            pb_headerPic.TabIndex = 2;
            pb_headerPic.TabStop = false;
            // 
            // btn_Modify_Adoption
            // 
            btn_Modify_Adoption.Location = new Point(77, 189);
            btn_Modify_Adoption.Name = "btn_Modify_Adoption";
            btn_Modify_Adoption.Size = new Size(250, 23);
            btn_Modify_Adoption.TabIndex = 10;
            btn_Modify_Adoption.Text = "Modificar Adopciones";
            btn_Modify_Adoption.UseVisualStyleBackColor = true;
            btn_Modify_Adoption.Click += btn_Modify_Adoption_Click;
            // 
            // btn_AdoptionFollowings
            // 
            btn_AdoptionFollowings.Location = new Point(77, 245);
            btn_AdoptionFollowings.Name = "btn_AdoptionFollowings";
            btn_AdoptionFollowings.Size = new Size(250, 23);
            btn_AdoptionFollowings.TabIndex = 10;
            btn_AdoptionFollowings.Text = "Seguimiento de Adopciones";
            btn_AdoptionFollowings.UseVisualStyleBackColor = true;
            btn_AdoptionFollowings.Click += btn_AdoptionFollowings_Click;
            // 
            // fm_AdminAdoptionMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 400);
            Controls.Add(btn_AdoptionFollowings);
            Controls.Add(btn_Modify_Adoption);
            Controls.Add(lb_MenuTitle);
            Controls.Add(pb_headerPic);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "fm_AdminAdoptionMenu";
            Text = "fm_AdoptionMenu";
            ((System.ComponentModel.ISupportInitialize)pb_headerPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_MenuTitle;
        private PictureBox pb_headerPic;
        private Button btn_Modify_Adoption;
        private Button btn_AdoptionFollowings;
    }
}
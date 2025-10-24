namespace WindowsForms.menuAdmin
{
    partial class fm_AdminReportsMenu
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
            btn_AdoptionReport = new Button();
            btn_CaretakersHReport = new Button();
            lb_MenuTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)pb_headerPic).BeginInit();
            SuspendLayout();
            // 
            // pb_headerPic
            // 
            pb_headerPic.BackgroundImage = Properties.Resources.Studio_Ghibli__Cattt__;
            pb_headerPic.Dock = DockStyle.Top;
            pb_headerPic.Location = new Point(0, 0);
            pb_headerPic.Name = "pb_headerPic";
            pb_headerPic.Size = new Size(379, 87);
            pb_headerPic.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_headerPic.TabIndex = 1;
            pb_headerPic.TabStop = false;
            // 
            // btn_AdoptionReport
            // 
            btn_AdoptionReport.Location = new Point(53, 177);
            btn_AdoptionReport.Name = "btn_AdoptionReport";
            btn_AdoptionReport.Size = new Size(272, 23);
            btn_AdoptionReport.TabIndex = 2;
            btn_AdoptionReport.Text = "Reporte de Adopciones";
            btn_AdoptionReport.UseVisualStyleBackColor = true;
            btn_AdoptionReport.Click += btn_AdoptionReport_Click;
            // 
            // btn_CaretakersHReport
            // 
            btn_CaretakersHReport.Location = new Point(53, 252);
            btn_CaretakersHReport.Name = "btn_CaretakersHReport";
            btn_CaretakersHReport.Size = new Size(272, 23);
            btn_CaretakersHReport.TabIndex = 3;
            btn_CaretakersHReport.Text = "Histórico de cuidadores";
            btn_CaretakersHReport.UseVisualStyleBackColor = true;
            btn_CaretakersHReport.Click += btn_CaretakersHReport_Click;
            // 
            // lb_MenuTitle
            // 
            lb_MenuTitle.AutoSize = true;
            lb_MenuTitle.BackColor = Color.Olive;
            lb_MenuTitle.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_MenuTitle.ForeColor = SystemColors.ControlLight;
            lb_MenuTitle.Location = new Point(0, 40);
            lb_MenuTitle.Name = "lb_MenuTitle";
            lb_MenuTitle.Size = new Size(119, 47);
            lb_MenuTitle.TabIndex = 4;
            lb_MenuTitle.Text = "MENU";
            lb_MenuTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fm_AdminReportsMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 400);
            Controls.Add(lb_MenuTitle);
            Controls.Add(btn_CaretakersHReport);
            Controls.Add(btn_AdoptionReport);
            Controls.Add(pb_headerPic);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "fm_AdminReportsMenu";
            Text = "fm_ReportsMenu";
            ((System.ComponentModel.ISupportInitialize)pb_headerPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb_headerPic;
        private Button btn_AdoptionReport;
        private Button btn_CaretakersHReport;
        private Label lb_MenuTitle;
    }
}
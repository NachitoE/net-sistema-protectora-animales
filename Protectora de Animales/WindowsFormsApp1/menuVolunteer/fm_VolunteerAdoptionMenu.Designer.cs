namespace WindowsFormsApp1.menuVolunteer
{
    partial class fm_VolunteerAdoptionMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fm_VolunteerAdoptionMenu));
            this.pb_UnderConstructionImg = new System.Windows.Forms.PictureBox();
            this.lb_EnConstruccion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_UnderConstructionImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_UnderConstructionImg
            // 
            this.pb_UnderConstructionImg.Image = ((System.Drawing.Image)(resources.GetObject("pb_UnderConstructionImg.Image")));
            this.pb_UnderConstructionImg.Location = new System.Drawing.Point(0, 22);
            this.pb_UnderConstructionImg.Name = "pb_UnderConstructionImg";
            this.pb_UnderConstructionImg.Size = new System.Drawing.Size(801, 327);
            this.pb_UnderConstructionImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_UnderConstructionImg.TabIndex = 10;
            this.pb_UnderConstructionImg.TabStop = false;
            // 
            // lb_EnConstruccion
            // 
            this.lb_EnConstruccion.AutoSize = true;
            this.lb_EnConstruccion.BackColor = System.Drawing.Color.Gold;
            this.lb_EnConstruccion.Location = new System.Drawing.Point(176, 416);
            this.lb_EnConstruccion.Name = "lb_EnConstruccion";
            this.lb_EnConstruccion.Size = new System.Drawing.Size(423, 13);
            this.lb_EnConstruccion.TabIndex = 9;
            this.lb_EnConstruccion.Text = "¡EL EQUIPO ESTÁ TRABAJANDO PARA RESOLVERLO LO MÁS PRONTO POSIBLE!";
            // 
            // fm_VolunteerAdoptionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb_UnderConstructionImg);
            this.Controls.Add(this.lb_EnConstruccion);
            this.Name = "fm_VolunteerAdoptionMenu";
            this.Text = "fm_VolunteerAdoptionMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pb_UnderConstructionImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_UnderConstructionImg;
        private System.Windows.Forms.Label lb_EnConstruccion;
    }
}
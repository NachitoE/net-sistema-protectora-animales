namespace WindowsForms.BasicForms
{
    partial class fm_AnimalsMedicalCheckUp
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
            lb_EnConstruccion = new Label();
            pb_UnderConstructionImg = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_UnderConstructionImg).BeginInit();
            SuspendLayout();
            // 
            // lb_EnConstruccion
            // 
            lb_EnConstruccion.AutoSize = true;
            lb_EnConstruccion.BackColor = Color.Gold;
            lb_EnConstruccion.Location = new Point(201, 458);
            lb_EnConstruccion.Margin = new Padding(4, 0, 4, 0);
            lb_EnConstruccion.Name = "lb_EnConstruccion";
            lb_EnConstruccion.Size = new Size(421, 15);
            lb_EnConstruccion.TabIndex = 3;
            lb_EnConstruccion.Text = "¡EL EQUIPO ESTÁ TRABAJANDO PARA RESOLVERLO LO MÁS PRONTO POSIBLE!";
            // 
            // pb_UnderConstructionImg
            // 
            pb_UnderConstructionImg.Image = Properties.Resources.en_construcción__1_1;
            pb_UnderConstructionImg.Location = new Point(0, 47);
            pb_UnderConstructionImg.Margin = new Padding(4, 3, 4, 3);
            pb_UnderConstructionImg.Name = "pb_UnderConstructionImg";
            pb_UnderConstructionImg.Size = new Size(934, 377);
            pb_UnderConstructionImg.SizeMode = PictureBoxSizeMode.Zoom;
            pb_UnderConstructionImg.TabIndex = 2;
            pb_UnderConstructionImg.TabStop = false;
            // 
            // fm_AnimalsMedicalCheckUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(lb_EnConstruccion);
            Controls.Add(pb_UnderConstructionImg);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "fm_AnimalsMedicalCheckUp";
            Text = "fm_AnimalsMedicalCheckUp";
            ((System.ComponentModel.ISupportInitialize)pb_UnderConstructionImg).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_EnConstruccion;
        private System.Windows.Forms.PictureBox pb_UnderConstructionImg;
    }
}
namespace WindowsFormsApp1
{
    partial class fm_SignUp
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
            this.pb_headerpic = new System.Windows.Forms.PictureBox();
            this.lb_welcome = new System.Windows.Forms.Label();
            this.lb_SingUpInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_headerpic)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_headerpic
            // 
            this.pb_headerpic.Image = global::WindowsFormsApp1.Properties.Resources.Studio_Ghibli__Cattt__;
            this.pb_headerpic.Location = new System.Drawing.Point(33, 12);
            this.pb_headerpic.Name = "pb_headerpic";
            this.pb_headerpic.Size = new System.Drawing.Size(726, 90);
            this.pb_headerpic.TabIndex = 1;
            this.pb_headerpic.TabStop = false;
            // 
            // lb_welcome
            // 
            this.lb_welcome.AutoSize = true;
            this.lb_welcome.BackColor = System.Drawing.Color.LimeGreen;
            this.lb_welcome.Font = new System.Drawing.Font("Microsoft YaHei Light", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_welcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_welcome.Location = new System.Drawing.Point(342, 48);
            this.lb_welcome.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.lb_welcome.Name = "lb_welcome";
            this.lb_welcome.Size = new System.Drawing.Size(130, 16);
            this.lb_welcome.TabIndex = 2;
            this.lb_welcome.Text = "BIENVENIDOS A ANTUEL";
            // 
            // lb_SingUpInfo
            // 
            this.lb_SingUpInfo.AutoSize = true;
            this.lb_SingUpInfo.Location = new System.Drawing.Point(30, 116);
            this.lb_SingUpInfo.Name = "lb_SingUpInfo";
            this.lb_SingUpInfo.Size = new System.Drawing.Size(346, 13);
            this.lb_SingUpInfo.TabIndex = 3;
            this.lb_SingUpInfo.Text = "Por favor, complete los siguientes datos para ingresar a nuestro sistema:";
            // 
            // fm_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_SingUpInfo);
            this.Controls.Add(this.lb_welcome);
            this.Controls.Add(this.pb_headerpic);
            this.Name = "fm_SignUp";
            this.Text = "Registrarse";
            ((System.ComponentModel.ISupportInitialize)(this.pb_headerpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_headerpic;
        private System.Windows.Forms.Label lb_welcome;
        private System.Windows.Forms.Label lb_SingUpInfo;
    }
}
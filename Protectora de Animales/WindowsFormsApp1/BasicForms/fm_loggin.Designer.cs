using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class fm_loggin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_Protectora = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_loggin = new System.Windows.Forms.Button();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.llb_singup = new System.Windows.Forms.LinkLabel();
            this.lb_singup = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Studio_Ghibli__Cattt__;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 90);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_Protectora
            // 
            this.lb_Protectora.AutoSize = true;
            this.lb_Protectora.BackColor = System.Drawing.Color.Cornsilk;
            this.lb_Protectora.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Protectora.Location = new System.Drawing.Point(230, 72);
            this.lb_Protectora.Name = "lb_Protectora";
            this.lb_Protectora.Size = new System.Drawing.Size(386, 30);
            this.lb_Protectora.TabIndex = 1;
            this.lb_Protectora.Text = "PROTECTORA DE ANIMALES \"ANTUEL\"";
            this.lb_Protectora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(361, 268);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(187, 20);
            this.tb_password.TabIndex = 2;
            this.tb_password.KeyDown += TextBox_KeyDown;
            // 
            // btn_loggin
            // 
            this.btn_loggin.Location = new System.Drawing.Point(346, 323);
            this.btn_loggin.Name = "btn_loggin";
            this.btn_loggin.Size = new System.Drawing.Size(216, 42);
            this.btn_loggin.TabIndex = 3;
            this.btn_loggin.Text = "Iniciar sesión";
            this.btn_loggin.UseVisualStyleBackColor = true;
            this.btn_loggin.Click += new System.EventHandler(this.btn_loggin_Click);
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(361, 249);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(64, 13);
            this.lb_password.TabIndex = 4;
            this.lb_password.Text = "Contraseña:";
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.Location = new System.Drawing.Point(364, 184);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(46, 13);
            this.lb_usuario.TabIndex = 5;
            this.lb_usuario.Text = "Usuario:";
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(361, 201);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(187, 20);
            this.tb_user.TabIndex = 6;
            this.tb_user.KeyDown += TextBox_KeyDown;

            // 
            // llb_singup
            // 
            this.llb_singup.AutoSize = true;
            this.llb_singup.Location = new System.Drawing.Point(491, 381);
            this.llb_singup.Name = "llb_singup";
            this.llb_singup.Size = new System.Drawing.Size(71, 13);
            this.llb_singup.TabIndex = 7;
            this.llb_singup.TabStop = true;
            this.llb_singup.Text = "Crear Usuario";
            this.llb_singup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_singup_LinkClicked);
            // 
            // lb_singup
            // 
            this.lb_singup.AutoSize = true;
            this.lb_singup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_singup.Location = new System.Drawing.Point(348, 381);
            this.lb_singup.Name = "lb_singup";
            this.lb_singup.Size = new System.Drawing.Size(89, 13);
            this.lb_singup.TabIndex = 8;
            this.lb_singup.Text = "¿Nuevo Aquí?";
            // 
            // fm_loggin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 569);
            this.Controls.Add(this.lb_singup);
            this.Controls.Add(this.llb_singup);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.lb_usuario);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.btn_loggin);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lb_Protectora);
            this.Controls.Add(this.pictureBox1);
            this.Name = "fm_loggin";
            this.Text = "INICIO";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_Protectora;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_loggin;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_usuario;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.LinkLabel llb_singup;
        private System.Windows.Forms.Label lb_singup;
    }
}


namespace WindowsForms.BasicForms
{
    partial class fm_loggin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            lb_Protectora = new Label();
            tb_password = new TextBox();
            btn_loggin = new Button();
            lb_password = new Label();
            lb_usuario = new Label();
            tb_user = new TextBox();
            llb_singup = new LinkLabel();
            lb_singup = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Studio_Ghibli__Cattt__;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(854, 477);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lb_Protectora
            // 
            lb_Protectora.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lb_Protectora.BackColor = Color.ForestGreen;
            lb_Protectora.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Protectora.ForeColor = Color.WhiteSmoke;
            lb_Protectora.Location = new Point(189, 70);
            lb_Protectora.Margin = new Padding(4, 0, 4, 0);
            lb_Protectora.Name = "lb_Protectora";
            lb_Protectora.Size = new Size(450, 35);
            lb_Protectora.TabIndex = 1;
            lb_Protectora.Text = "PROTECTORA DE ANIMALES \"ATUEL\"";
            lb_Protectora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_password
            // 
            tb_password.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tb_password.BackColor = Color.White;
            tb_password.Location = new Point(307, 243);
            tb_password.Margin = new Padding(4, 3, 4, 3);
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '*';
            tb_password.Size = new Size(218, 23);
            tb_password.TabIndex = 2;
            // 
            // btn_loggin
            // 
            btn_loggin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_loggin.AutoSize = true;
            btn_loggin.FlatStyle = FlatStyle.Popup;
            btn_loggin.Location = new Point(289, 307);
            btn_loggin.Margin = new Padding(4, 3, 4, 3);
            btn_loggin.Name = "btn_loggin";
            btn_loggin.Size = new Size(273, 37);
            btn_loggin.TabIndex = 3;
            btn_loggin.Text = "Iniciar sesión";
            btn_loggin.UseVisualStyleBackColor = true;
            btn_loggin.Click += btn_loggin_Click;
            // 
            // lb_password
            // 
            lb_password.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lb_password.AutoSize = true;
            lb_password.BorderStyle = BorderStyle.Fixed3D;
            lb_password.Location = new Point(307, 227);
            lb_password.Margin = new Padding(4, 0, 4, 0);
            lb_password.Name = "lb_password";
            lb_password.Size = new Size(72, 17);
            lb_password.TabIndex = 4;
            lb_password.Text = "Contraseña:";
            // 
            // lb_usuario
            // 
            lb_usuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lb_usuario.AutoSize = true;
            lb_usuario.BorderStyle = BorderStyle.Fixed3D;
            lb_usuario.Location = new Point(307, 149);
            lb_usuario.Margin = new Padding(4, 0, 4, 0);
            lb_usuario.Name = "lb_usuario";
            lb_usuario.Size = new Size(52, 17);
            lb_usuario.TabIndex = 5;
            lb_usuario.Text = "Usuario:";
            // 
            // tb_user
            // 
            tb_user.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tb_user.BackColor = Color.White;
            tb_user.ForeColor = SystemColors.InfoText;
            tb_user.Location = new Point(307, 166);
            tb_user.Margin = new Padding(4, 3, 4, 3);
            tb_user.Name = "tb_user";
            tb_user.Size = new Size(218, 23);
            tb_user.TabIndex = 6;
            tb_user.TextChanged += tb_user_TextChanged;
            // 
            // llb_singup
            // 
            llb_singup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            llb_singup.AutoSize = true;
            llb_singup.BackColor = Color.Transparent;
            llb_singup.BorderStyle = BorderStyle.FixedSingle;
            llb_singup.Location = new Point(458, 374);
            llb_singup.Margin = new Padding(4, 0, 4, 0);
            llb_singup.Name = "llb_singup";
            llb_singup.Size = new Size(80, 17);
            llb_singup.TabIndex = 7;
            llb_singup.TabStop = true;
            llb_singup.Text = "Crear Usuario";
            llb_singup.LinkClicked += llb_singup_LinkClicked;
            // 
            // lb_singup
            // 
            lb_singup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lb_singup.AutoSize = true;
            lb_singup.BackColor = Color.Transparent;
            lb_singup.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lb_singup.Location = new Point(307, 374);
            lb_singup.Margin = new Padding(4, 0, 4, 0);
            lb_singup.Name = "lb_singup";
            lb_singup.Size = new Size(77, 13);
            lb_singup.TabIndex = 8;
            lb_singup.Text = "¿Nuevo Aquí?";
            // 
            // fm_loggin
            // 
            AcceptButton = btn_loggin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(854, 477);
            Controls.Add(lb_singup);
            Controls.Add(llb_singup);
            Controls.Add(tb_user);
            Controls.Add(lb_usuario);
            Controls.Add(lb_password);
            Controls.Add(btn_loggin);
            Controls.Add(tb_password);
            Controls.Add(lb_Protectora);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "fm_loggin";
            Text = "INICIO";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

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
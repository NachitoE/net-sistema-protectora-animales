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
            this.lb_SignUpName = new System.Windows.Forms.Label();
            this.tb_SignUpName = new System.Windows.Forms.TextBox();
            this.lb_SignUpSurname = new System.Windows.Forms.Label();
            this.tb_SignUpSurName = new System.Windows.Forms.TextBox();
            this.lb_SignUpdni = new System.Windows.Forms.Label();
            this.tb_SignUpDni = new System.Windows.Forms.TextBox();
            this.tb_SignUpPasswordCheck = new System.Windows.Forms.TextBox();
            this.lb_SignUpUserType = new System.Windows.Forms.Label();
            this.tb_SignUpPassword = new System.Windows.Forms.TextBox();
            this.lb_SignUpPassword = new System.Windows.Forms.Label();
            this.tb_SignUpUserName = new System.Windows.Forms.TextBox();
            this.lb_SignUpUser = new System.Windows.Forms.Label();
            this.lb_SignUpPassCheck = new System.Windows.Forms.Label();
            this.btn_SingUpconfirm = new System.Windows.Forms.Button();
            this.cb_userType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_headerpic)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_headerpic
            // 
            this.pb_headerpic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_headerpic.Image = global::WindowsFormsApp1.Properties.Resources.Studio_Ghibli__Cattt__;
            this.pb_headerpic.Location = new System.Drawing.Point(61, 12);
            this.pb_headerpic.Name = "pb_headerpic";
            this.pb_headerpic.Size = new System.Drawing.Size(585, 75);
            this.pb_headerpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_headerpic.TabIndex = 1;
            this.pb_headerpic.TabStop = false;
            // 
            // lb_welcome
            // 
            this.lb_welcome.AutoSize = true;
            this.lb_welcome.BackColor = System.Drawing.Color.LimeGreen;
            this.lb_welcome.Font = new System.Drawing.Font("Microsoft YaHei Light", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_welcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_welcome.Location = new System.Drawing.Point(285, 43);
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
            // lb_SignUpName
            // 
            this.lb_SignUpName.AutoSize = true;
            this.lb_SignUpName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_SignUpName.Location = new System.Drawing.Point(30, 159);
            this.lb_SignUpName.Name = "lb_SignUpName";
            this.lb_SignUpName.Size = new System.Drawing.Size(47, 13);
            this.lb_SignUpName.TabIndex = 4;
            this.lb_SignUpName.Text = "Nombre:";
            this.lb_SignUpName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_SignUpName
            // 
            this.tb_SignUpName.Location = new System.Drawing.Point(115, 163);
            this.tb_SignUpName.Name = "tb_SignUpName";
            this.tb_SignUpName.Size = new System.Drawing.Size(214, 20);
            this.tb_SignUpName.TabIndex = 5;
            // 
            // lb_SignUpSurname
            // 
            this.lb_SignUpSurname.AutoSize = true;
            this.lb_SignUpSurname.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_SignUpSurname.Location = new System.Drawing.Point(30, 192);
            this.lb_SignUpSurname.Name = "lb_SignUpSurname";
            this.lb_SignUpSurname.Size = new System.Drawing.Size(47, 13);
            this.lb_SignUpSurname.TabIndex = 6;
            this.lb_SignUpSurname.Text = "Apellido:";
            this.lb_SignUpSurname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_SignUpSurName
            // 
            this.tb_SignUpSurName.Location = new System.Drawing.Point(115, 189);
            this.tb_SignUpSurName.Name = "tb_SignUpSurName";
            this.tb_SignUpSurName.Size = new System.Drawing.Size(214, 20);
            this.tb_SignUpSurName.TabIndex = 7;
            // 
            // lb_SignUpdni
            // 
            this.lb_SignUpdni.AutoSize = true;
            this.lb_SignUpdni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_SignUpdni.Location = new System.Drawing.Point(30, 222);
            this.lb_SignUpdni.Name = "lb_SignUpdni";
            this.lb_SignUpdni.Size = new System.Drawing.Size(29, 13);
            this.lb_SignUpdni.TabIndex = 8;
            this.lb_SignUpdni.Text = "DNI:";
            this.lb_SignUpdni.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_SignUpDni
            // 
            this.tb_SignUpDni.Location = new System.Drawing.Point(115, 215);
            this.tb_SignUpDni.MaxLength = 8;
            this.tb_SignUpDni.Name = "tb_SignUpDni";
            this.tb_SignUpDni.Size = new System.Drawing.Size(214, 20);
            this.tb_SignUpDni.TabIndex = 9;
            // 
            // tb_SignUpPasswordCheck
            // 
            this.tb_SignUpPasswordCheck.Location = new System.Drawing.Point(461, 215);
            this.tb_SignUpPasswordCheck.Name = "tb_SignUpPasswordCheck";
            this.tb_SignUpPasswordCheck.PasswordChar = '*';
            this.tb_SignUpPasswordCheck.Size = new System.Drawing.Size(214, 20);
            this.tb_SignUpPasswordCheck.TabIndex = 15;
            // 
            // lb_SignUpUserType
            // 
            this.lb_SignUpUserType.AutoSize = true;
            this.lb_SignUpUserType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_SignUpUserType.Location = new System.Drawing.Point(347, 248);
            this.lb_SignUpUserType.Name = "lb_SignUpUserType";
            this.lb_SignUpUserType.Size = new System.Drawing.Size(83, 13);
            this.lb_SignUpUserType.TabIndex = 14;
            this.lb_SignUpUserType.Text = "Tipo de usuario:";
            this.lb_SignUpUserType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_SignUpPassword
            // 
            this.tb_SignUpPassword.Location = new System.Drawing.Point(461, 189);
            this.tb_SignUpPassword.Name = "tb_SignUpPassword";
            this.tb_SignUpPassword.PasswordChar = '*';
            this.tb_SignUpPassword.Size = new System.Drawing.Size(214, 20);
            this.tb_SignUpPassword.TabIndex = 13;
            // 
            // lb_SignUpPassword
            // 
            this.lb_SignUpPassword.AutoSize = true;
            this.lb_SignUpPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_SignUpPassword.Location = new System.Drawing.Point(347, 192);
            this.lb_SignUpPassword.Name = "lb_SignUpPassword";
            this.lb_SignUpPassword.Size = new System.Drawing.Size(64, 13);
            this.lb_SignUpPassword.TabIndex = 12;
            this.lb_SignUpPassword.Text = "Contraseña:";
            this.lb_SignUpPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_SignUpUserName
            // 
            this.tb_SignUpUserName.Location = new System.Drawing.Point(461, 163);
            this.tb_SignUpUserName.Name = "tb_SignUpUserName";
            this.tb_SignUpUserName.Size = new System.Drawing.Size(214, 20);
            this.tb_SignUpUserName.TabIndex = 11;
            // 
            // lb_SignUpUser
            // 
            this.lb_SignUpUser.AutoSize = true;
            this.lb_SignUpUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_SignUpUser.Location = new System.Drawing.Point(347, 166);
            this.lb_SignUpUser.Name = "lb_SignUpUser";
            this.lb_SignUpUser.Size = new System.Drawing.Size(46, 13);
            this.lb_SignUpUser.TabIndex = 10;
            this.lb_SignUpUser.Text = "Usuario:";
            this.lb_SignUpUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_SignUpPassCheck
            // 
            this.lb_SignUpPassCheck.AutoSize = true;
            this.lb_SignUpPassCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_SignUpPassCheck.Location = new System.Drawing.Point(347, 218);
            this.lb_SignUpPassCheck.Name = "lb_SignUpPassCheck";
            this.lb_SignUpPassCheck.Size = new System.Drawing.Size(101, 13);
            this.lb_SignUpPassCheck.TabIndex = 16;
            this.lb_SignUpPassCheck.Text = "Repetir Contraseña:";
            this.lb_SignUpPassCheck.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_SingUpconfirm
            // 
            this.btn_SingUpconfirm.BackColor = System.Drawing.Color.DarkGray;
            this.btn_SingUpconfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SingUpconfirm.ForeColor = System.Drawing.Color.Black;
            this.btn_SingUpconfirm.Location = new System.Drawing.Point(628, 300);
            this.btn_SingUpconfirm.Name = "btn_SingUpconfirm";
            this.btn_SingUpconfirm.Size = new System.Drawing.Size(75, 23);
            this.btn_SingUpconfirm.TabIndex = 18;
            this.btn_SingUpconfirm.Text = "Aceptar";
            this.btn_SingUpconfirm.UseVisualStyleBackColor = false;
            this.btn_SingUpconfirm.Click += new System.EventHandler(this.btn_SingUpconfirm_Click);
            // 
            // cb_userType
            // 
            this.cb_userType.AllowDrop = true;
            this.cb_userType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_userType.FormattingEnabled = true;
            this.cb_userType.Items.AddRange(new object[] {
            "Transito",
            "Voluntario",
            "Adoptante"});
            this.cb_userType.Location = new System.Drawing.Point(436, 245);
            this.cb_userType.Name = "cb_userType";
            this.cb_userType.Size = new System.Drawing.Size(121, 21);
            this.cb_userType.TabIndex = 19;
            // 
            // fm_SignUp
            // 
            this.AcceptButton = this.btn_SingUpconfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 335);
            this.Controls.Add(this.cb_userType);
            this.Controls.Add(this.btn_SingUpconfirm);
            this.Controls.Add(this.lb_SignUpPassCheck);
            this.Controls.Add(this.tb_SignUpPasswordCheck);
            this.Controls.Add(this.lb_SignUpUserType);
            this.Controls.Add(this.tb_SignUpPassword);
            this.Controls.Add(this.lb_SignUpPassword);
            this.Controls.Add(this.tb_SignUpUserName);
            this.Controls.Add(this.lb_SignUpUser);
            this.Controls.Add(this.tb_SignUpDni);
            this.Controls.Add(this.lb_SignUpdni);
            this.Controls.Add(this.tb_SignUpSurName);
            this.Controls.Add(this.lb_SignUpSurname);
            this.Controls.Add(this.tb_SignUpName);
            this.Controls.Add(this.lb_SignUpName);
            this.Controls.Add(this.lb_SingUpInfo);
            this.Controls.Add(this.lb_welcome);
            this.Controls.Add(this.pb_headerpic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Label lb_SignUpName;
        private System.Windows.Forms.TextBox tb_SignUpName;
        private System.Windows.Forms.Label lb_SignUpSurname;
        private System.Windows.Forms.TextBox tb_SignUpSurName;
        private System.Windows.Forms.Label lb_SignUpdni;
        private System.Windows.Forms.TextBox tb_SignUpDni;
        private System.Windows.Forms.TextBox tb_SignUpPasswordCheck;
        private System.Windows.Forms.Label lb_SignUpUserType;
        private System.Windows.Forms.TextBox tb_SignUpPassword;
        private System.Windows.Forms.Label lb_SignUpPassword;
        private System.Windows.Forms.TextBox tb_SignUpUserName;
        private System.Windows.Forms.Label lb_SignUpUser;
        private System.Windows.Forms.Label lb_SignUpPassCheck;
        private System.Windows.Forms.Button btn_SingUpconfirm;
        private System.Windows.Forms.ComboBox cb_userType;
    }
}
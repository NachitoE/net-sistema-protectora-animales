namespace WindowsForms
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
            pb_headerpic = new PictureBox();
            lb_welcome = new Label();
            lb_SingUpInfo = new Label();
            lb_SignUpName = new Label();
            tb_SignUpName = new TextBox();
            lb_SignUpSurname = new Label();
            tb_SignUpSurName = new TextBox();
            lb_SignUpdni = new Label();
            tb_SignUpDni = new TextBox();
            tb_SignUpPasswordCheck = new TextBox();
            lb_SignUpUserType = new Label();
            tb_SignUpPassword = new TextBox();
            lb_SignUpPassword = new Label();
            tb_SignUpUserName = new TextBox();
            lb_SignUpUser = new Label();
            lb_SignUpPassCheck = new Label();
            btn_SingUpconfirm = new Button();
            cb_userType = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pb_headerpic).BeginInit();
            SuspendLayout();
            // 
            // pb_headerpic
            // 
            pb_headerpic.Image = WindowsForms.Properties.Resources.Studio_Ghibli__Cattt__;
            pb_headerpic.Location = new Point(71, 14);
            pb_headerpic.Margin = new Padding(4, 3, 4, 3);
            pb_headerpic.Name = "pb_headerpic";
            pb_headerpic.Size = new Size(682, 87);
            pb_headerpic.SizeMode = PictureBoxSizeMode.CenterImage;
            pb_headerpic.TabIndex = 1;
            pb_headerpic.TabStop = false;
            // 
            // lb_welcome
            // 
            lb_welcome.AutoSize = true;
            lb_welcome.BackColor = Color.LimeGreen;
            lb_welcome.Font = new Font("Microsoft YaHei Light", 8.25F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lb_welcome.ForeColor = SystemColors.ButtonHighlight;
            lb_welcome.Location = new Point(332, 50);
            lb_welcome.Margin = new Padding(4, 0, 4, 0);
            lb_welcome.MaximumSize = new Size(1167, 1154);
            lb_welcome.Name = "lb_welcome";
            lb_welcome.Size = new Size(122, 16);
            lb_welcome.TabIndex = 2;
            lb_welcome.Text = "BIENVENIDOS A ATUEL";
            // 
            // lb_SingUpInfo
            // 
            lb_SingUpInfo.AutoSize = true;
            lb_SingUpInfo.Location = new Point(35, 134);
            lb_SingUpInfo.Margin = new Padding(4, 0, 4, 0);
            lb_SingUpInfo.Name = "lb_SingUpInfo";
            lb_SingUpInfo.Size = new Size(386, 15);
            lb_SingUpInfo.TabIndex = 3;
            lb_SingUpInfo.Text = "Por favor, complete los siguientes datos para ingresar a nuestro sistema:";
            // 
            // lb_SignUpName
            // 
            lb_SignUpName.AutoSize = true;
            lb_SignUpName.FlatStyle = FlatStyle.Popup;
            lb_SignUpName.Location = new Point(35, 183);
            lb_SignUpName.Margin = new Padding(4, 0, 4, 0);
            lb_SignUpName.Name = "lb_SignUpName";
            lb_SignUpName.Size = new Size(54, 15);
            lb_SignUpName.TabIndex = 4;
            lb_SignUpName.Text = "Nombre:";
            lb_SignUpName.TextAlign = ContentAlignment.TopCenter;
            // 
            // tb_SignUpName
            // 
            tb_SignUpName.Location = new Point(134, 188);
            tb_SignUpName.Margin = new Padding(4, 3, 4, 3);
            tb_SignUpName.Name = "tb_SignUpName";
            tb_SignUpName.Size = new Size(249, 23);
            tb_SignUpName.TabIndex = 5;
            // 
            // lb_SignUpSurname
            // 
            lb_SignUpSurname.AutoSize = true;
            lb_SignUpSurname.FlatStyle = FlatStyle.Popup;
            lb_SignUpSurname.Location = new Point(35, 222);
            lb_SignUpSurname.Margin = new Padding(4, 0, 4, 0);
            lb_SignUpSurname.Name = "lb_SignUpSurname";
            lb_SignUpSurname.Size = new Size(54, 15);
            lb_SignUpSurname.TabIndex = 6;
            lb_SignUpSurname.Text = "Apellido:";
            lb_SignUpSurname.TextAlign = ContentAlignment.TopCenter;
            // 
            // tb_SignUpSurName
            // 
            tb_SignUpSurName.Location = new Point(134, 218);
            tb_SignUpSurName.Margin = new Padding(4, 3, 4, 3);
            tb_SignUpSurName.Name = "tb_SignUpSurName";
            tb_SignUpSurName.Size = new Size(249, 23);
            tb_SignUpSurName.TabIndex = 7;
            // 
            // lb_SignUpdni
            // 
            lb_SignUpdni.AutoSize = true;
            lb_SignUpdni.FlatStyle = FlatStyle.Popup;
            lb_SignUpdni.Location = new Point(35, 256);
            lb_SignUpdni.Margin = new Padding(4, 0, 4, 0);
            lb_SignUpdni.Name = "lb_SignUpdni";
            lb_SignUpdni.Size = new Size(30, 15);
            lb_SignUpdni.TabIndex = 8;
            lb_SignUpdni.Text = "DNI:";
            lb_SignUpdni.TextAlign = ContentAlignment.TopCenter;
            // 
            // tb_SignUpDni
            // 
            tb_SignUpDni.Location = new Point(134, 248);
            tb_SignUpDni.Margin = new Padding(4, 3, 4, 3);
            tb_SignUpDni.MaxLength = 8;
            tb_SignUpDni.Name = "tb_SignUpDni";
            tb_SignUpDni.Size = new Size(249, 23);
            tb_SignUpDni.TabIndex = 9;
            // 
            // tb_SignUpPasswordCheck
            // 
            tb_SignUpPasswordCheck.Location = new Point(538, 248);
            tb_SignUpPasswordCheck.Margin = new Padding(4, 3, 4, 3);
            tb_SignUpPasswordCheck.Name = "tb_SignUpPasswordCheck";
            tb_SignUpPasswordCheck.PasswordChar = '*';
            tb_SignUpPasswordCheck.Size = new Size(249, 23);
            tb_SignUpPasswordCheck.TabIndex = 15;
            // 
            // lb_SignUpUserType
            // 
            lb_SignUpUserType.AutoSize = true;
            lb_SignUpUserType.FlatStyle = FlatStyle.Popup;
            lb_SignUpUserType.Location = new Point(405, 286);
            lb_SignUpUserType.Margin = new Padding(4, 0, 4, 0);
            lb_SignUpUserType.Name = "lb_SignUpUserType";
            lb_SignUpUserType.Size = new Size(92, 15);
            lb_SignUpUserType.TabIndex = 14;
            lb_SignUpUserType.Text = "Tipo de usuario:";
            lb_SignUpUserType.TextAlign = ContentAlignment.TopCenter;
            // 
            // tb_SignUpPassword
            // 
            tb_SignUpPassword.Location = new Point(538, 218);
            tb_SignUpPassword.Margin = new Padding(4, 3, 4, 3);
            tb_SignUpPassword.Name = "tb_SignUpPassword";
            tb_SignUpPassword.PasswordChar = '*';
            tb_SignUpPassword.Size = new Size(249, 23);
            tb_SignUpPassword.TabIndex = 13;
            // 
            // lb_SignUpPassword
            // 
            lb_SignUpPassword.AutoSize = true;
            lb_SignUpPassword.FlatStyle = FlatStyle.Popup;
            lb_SignUpPassword.Location = new Point(405, 222);
            lb_SignUpPassword.Margin = new Padding(4, 0, 4, 0);
            lb_SignUpPassword.Name = "lb_SignUpPassword";
            lb_SignUpPassword.Size = new Size(70, 15);
            lb_SignUpPassword.TabIndex = 12;
            lb_SignUpPassword.Text = "Contraseña:";
            lb_SignUpPassword.TextAlign = ContentAlignment.TopCenter;
            // 
            // tb_SignUpUserName
            // 
            tb_SignUpUserName.Location = new Point(538, 188);
            tb_SignUpUserName.Margin = new Padding(4, 3, 4, 3);
            tb_SignUpUserName.Name = "tb_SignUpUserName";
            tb_SignUpUserName.Size = new Size(249, 23);
            tb_SignUpUserName.TabIndex = 11;
            // 
            // lb_SignUpUser
            // 
            lb_SignUpUser.AutoSize = true;
            lb_SignUpUser.FlatStyle = FlatStyle.Popup;
            lb_SignUpUser.Location = new Point(405, 192);
            lb_SignUpUser.Margin = new Padding(4, 0, 4, 0);
            lb_SignUpUser.Name = "lb_SignUpUser";
            lb_SignUpUser.Size = new Size(50, 15);
            lb_SignUpUser.TabIndex = 10;
            lb_SignUpUser.Text = "Usuario:";
            lb_SignUpUser.TextAlign = ContentAlignment.TopCenter;
            // 
            // lb_SignUpPassCheck
            // 
            lb_SignUpPassCheck.AutoSize = true;
            lb_SignUpPassCheck.FlatStyle = FlatStyle.Popup;
            lb_SignUpPassCheck.Location = new Point(405, 252);
            lb_SignUpPassCheck.Margin = new Padding(4, 0, 4, 0);
            lb_SignUpPassCheck.Name = "lb_SignUpPassCheck";
            lb_SignUpPassCheck.Size = new Size(110, 15);
            lb_SignUpPassCheck.TabIndex = 16;
            lb_SignUpPassCheck.Text = "Repetir Contraseña:";
            lb_SignUpPassCheck.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_SingUpconfirm
            // 
            btn_SingUpconfirm.BackColor = Color.DarkGray;
            btn_SingUpconfirm.FlatStyle = FlatStyle.Popup;
            btn_SingUpconfirm.ForeColor = Color.Black;
            btn_SingUpconfirm.Location = new Point(733, 346);
            btn_SingUpconfirm.Margin = new Padding(4, 3, 4, 3);
            btn_SingUpconfirm.Name = "btn_SingUpconfirm";
            btn_SingUpconfirm.Size = new Size(88, 27);
            btn_SingUpconfirm.TabIndex = 18;
            btn_SingUpconfirm.Text = "Aceptar";
            btn_SingUpconfirm.UseVisualStyleBackColor = false;
            btn_SingUpconfirm.Click += btn_SingUpconfirm_Click;
            // 
            // cb_userType
            // 
            cb_userType.AllowDrop = true;
            cb_userType.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_userType.FormattingEnabled = true;
            cb_userType.Items.AddRange(new object[] { "Transito", "Voluntario", "Adoptante" });
            cb_userType.Location = new Point(509, 283);
            cb_userType.Margin = new Padding(4, 3, 4, 3);
            cb_userType.Name = "cb_userType";
            cb_userType.Size = new Size(140, 23);
            cb_userType.TabIndex = 19;
            // 
            // fm_SignUp
            // 
            AcceptButton = btn_SingUpconfirm;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 387);
            Controls.Add(cb_userType);
            Controls.Add(btn_SingUpconfirm);
            Controls.Add(lb_SignUpPassCheck);
            Controls.Add(tb_SignUpPasswordCheck);
            Controls.Add(lb_SignUpUserType);
            Controls.Add(tb_SignUpPassword);
            Controls.Add(lb_SignUpPassword);
            Controls.Add(tb_SignUpUserName);
            Controls.Add(lb_SignUpUser);
            Controls.Add(tb_SignUpDni);
            Controls.Add(lb_SignUpdni);
            Controls.Add(tb_SignUpSurName);
            Controls.Add(lb_SignUpSurname);
            Controls.Add(tb_SignUpName);
            Controls.Add(lb_SignUpName);
            Controls.Add(lb_SingUpInfo);
            Controls.Add(lb_welcome);
            Controls.Add(pb_headerpic);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "fm_SignUp";
            Text = "Registrarse";
            ((System.ComponentModel.ISupportInitialize)pb_headerpic).EndInit();
            ResumeLayout(false);
            PerformLayout();

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
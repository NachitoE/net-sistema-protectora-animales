namespace WindowsForms.BasicForms
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
            pictureBox1 = new PictureBox();
            lb_Welcome = new Label();
            lb_Name = new Label();
            lb_Surname = new Label();
            lb_Dni = new Label();
            lb_Username = new Label();
            tb_SUName = new TextBox();
            tb_SUSurname = new TextBox();
            tb_SUDni = new TextBox();
            tb_SUUsername = new TextBox();
            tb_SUPassword = new TextBox();
            lb_Password = new Label();
            lb_PasswordCheck = new Label();
            lb_SelectUT = new Label();
            btn_ConfirmSU = new Button();
            lb_InfoSU = new Label();
            cb_UserType = new ComboBox();
            tb_SUPasswordCheck = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Studio_Ghibli__Cattt__;
            pictureBox1.Location = new Point(38, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(637, 70);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lb_Welcome
            // 
            lb_Welcome.AutoSize = true;
            lb_Welcome.BackColor = Color.Olive;
            lb_Welcome.ForeColor = Color.White;
            lb_Welcome.Location = new Point(297, 36);
            lb_Welcome.Name = "lb_Welcome";
            lb_Welcome.Size = new Size(127, 15);
            lb_Welcome.TabIndex = 1;
            lb_Welcome.Text = "BIENVENIDOS A ATUEL";
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.Location = new Point(38, 143);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(54, 15);
            lb_Name.TabIndex = 2;
            lb_Name.Text = "Nombre:\r\n";
            // 
            // lb_Surname
            // 
            lb_Surname.AutoSize = true;
            lb_Surname.Location = new Point(38, 175);
            lb_Surname.Name = "lb_Surname";
            lb_Surname.Size = new Size(54, 15);
            lb_Surname.TabIndex = 3;
            lb_Surname.Text = "Apellido:";
            // 
            // lb_Dni
            // 
            lb_Dni.AutoSize = true;
            lb_Dni.Location = new Point(38, 204);
            lb_Dni.Name = "lb_Dni";
            lb_Dni.Size = new Size(30, 15);
            lb_Dni.TabIndex = 4;
            lb_Dni.Text = "DNI:";
            // 
            // lb_Username
            // 
            lb_Username.AutoSize = true;
            lb_Username.Location = new Point(313, 143);
            lb_Username.Name = "lb_Username";
            lb_Username.Size = new Size(112, 15);
            lb_Username.TabIndex = 5;
            lb_Username.Text = "Nombre de usuario:";
            // 
            // tb_SUName
            // 
            tb_SUName.Location = new Point(93, 138);
            tb_SUName.Name = "tb_SUName";
            tb_SUName.Size = new Size(213, 23);
            tb_SUName.TabIndex = 6;
            // 
            // tb_SUSurname
            // 
            tb_SUSurname.Location = new Point(93, 167);
            tb_SUSurname.Name = "tb_SUSurname";
            tb_SUSurname.Size = new Size(213, 23);
            tb_SUSurname.TabIndex = 7;
            // 
            // tb_SUDni
            // 
            tb_SUDni.Location = new Point(93, 196);
            tb_SUDni.MaxLength = 8;
            tb_SUDni.Name = "tb_SUDni";
            tb_SUDni.Size = new Size(213, 23);
            tb_SUDni.TabIndex = 8;
            // 
            // tb_SUUsername
            // 
            tb_SUUsername.Location = new Point(426, 138);
            tb_SUUsername.MaxLength = 10;
            tb_SUUsername.Name = "tb_SUUsername";
            tb_SUUsername.Size = new Size(213, 23);
            tb_SUUsername.TabIndex = 9;
            // 
            // tb_SUPassword
            // 
            tb_SUPassword.Location = new Point(426, 167);
            tb_SUPassword.Name = "tb_SUPassword";
            tb_SUPassword.PasswordChar = '*';
            tb_SUPassword.Size = new Size(213, 23);
            tb_SUPassword.TabIndex = 10;
            // 
            // lb_Password
            // 
            lb_Password.AutoSize = true;
            lb_Password.Location = new Point(313, 170);
            lb_Password.Name = "lb_Password";
            lb_Password.Size = new Size(70, 15);
            lb_Password.TabIndex = 13;
            lb_Password.Text = "Contraseña:";
            // 
            // lb_PasswordCheck
            // 
            lb_PasswordCheck.AutoSize = true;
            lb_PasswordCheck.Location = new Point(313, 199);
            lb_PasswordCheck.Name = "lb_PasswordCheck";
            lb_PasswordCheck.Size = new Size(110, 15);
            lb_PasswordCheck.TabIndex = 14;
            lb_PasswordCheck.Text = "Repetir Contraseña:";
            // 
            // lb_SelectUT
            // 
            lb_SelectUT.AutoSize = true;
            lb_SelectUT.Location = new Point(313, 228);
            lb_SelectUT.Name = "lb_SelectUT";
            lb_SelectUT.Size = new Size(92, 15);
            lb_SelectUT.TabIndex = 15;
            lb_SelectUT.Text = "Tipo de Usuario:";
            // 
            // btn_ConfirmSU
            // 
            btn_ConfirmSU.FlatStyle = FlatStyle.Popup;
            btn_ConfirmSU.Location = new Point(620, 272);
            btn_ConfirmSU.Name = "btn_ConfirmSU";
            btn_ConfirmSU.Size = new Size(75, 23);
            btn_ConfirmSU.TabIndex = 16;
            btn_ConfirmSU.Text = "Aceptar";
            btn_ConfirmSU.UseVisualStyleBackColor = true;
            btn_ConfirmSU.Click += btn_ConfirmSU_Click;
            // 
            // lb_InfoSU
            // 
            lb_InfoSU.AutoSize = true;
            lb_InfoSU.Location = new Point(67, 108);
            lb_InfoSU.Name = "lb_InfoSU";
            lb_InfoSU.Size = new Size(379, 15);
            lb_InfoSU.TabIndex = 17;
            lb_InfoSU.Text = "Por favor, complete los sigientes datos para ingresar a nuestro sistema:";
            // 
            // cb_UserType
            // 
            cb_UserType.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_UserType.FormattingEnabled = true;
            cb_UserType.Items.AddRange(new object[] { "Transito", "Voluntario", "Adoptante" });
            cb_UserType.Location = new Point(426, 225);
            cb_UserType.Name = "cb_UserType";
            cb_UserType.Size = new Size(213, 23);
            cb_UserType.TabIndex = 18;
            // 
            // tb_SUPasswordCheck
            // 
            tb_SUPasswordCheck.Location = new Point(426, 196);
            tb_SUPasswordCheck.Name = "tb_SUPasswordCheck";
            tb_SUPasswordCheck.PasswordChar = '*';
            tb_SUPasswordCheck.Size = new Size(213, 23);
            tb_SUPasswordCheck.TabIndex = 19;
            // 
            // fm_SignUp
            // 
            AcceptButton = btn_ConfirmSU;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 315);
            Controls.Add(tb_SUPasswordCheck);
            Controls.Add(cb_UserType);
            Controls.Add(lb_InfoSU);
            Controls.Add(btn_ConfirmSU);
            Controls.Add(lb_SelectUT);
            Controls.Add(lb_PasswordCheck);
            Controls.Add(lb_Password);
            Controls.Add(tb_SUPassword);
            Controls.Add(tb_SUUsername);
            Controls.Add(tb_SUDni);
            Controls.Add(tb_SUSurname);
            Controls.Add(tb_SUName);
            Controls.Add(lb_Username);
            Controls.Add(lb_Dni);
            Controls.Add(lb_Surname);
            Controls.Add(lb_Name);
            Controls.Add(lb_Welcome);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "fm_SignUp";
            Text = "fm_SignUp";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lb_Welcome;
        private Label lb_Name;
        private Label lb_Surname;
        private Label lb_Dni;
        private Label lb_Username;
        private TextBox tb_SUName;
        private TextBox tb_SUSurname;
        private TextBox tb_SUDni;
        private TextBox tb_SUUsername;
        private TextBox tb_SUPassword;
        private Label lb_Password;
        private Label lb_PasswordCheck;
        private Label lb_SelectUT;
        private Button btn_ConfirmSU;
        private Label lb_InfoSU;
        private ComboBox cb_UserType;
        private TextBox tb_SUPasswordCheck;
    }
}
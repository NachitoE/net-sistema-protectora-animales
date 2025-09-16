namespace WindowsForms.menuAdmin.Users
{
    partial class fm_DeleteUsers
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
            btn_AcceptUsn = new Button();
            llb_ShowAllUsers = new LinkLabel();
            tb_getUsername = new TextBox();
            lb_ModInfo = new Label();
            lb_MUser = new Label();
            pb_headerpic = new PictureBox();
            dgv_User = new DataGridView();
            lb_UserData = new Label();
            pb_Background = new PictureBox();
            btnAcceptDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_headerpic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_User).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Background).BeginInit();
            SuspendLayout();
            // 
            // btn_AcceptUsn
            // 
            btn_AcceptUsn.Location = new Point(268, 98);
            btn_AcceptUsn.Margin = new Padding(4, 3, 4, 3);
            btn_AcceptUsn.Name = "btn_AcceptUsn";
            btn_AcceptUsn.Size = new Size(88, 27);
            btn_AcceptUsn.TabIndex = 18;
            btn_AcceptUsn.Text = "Aceptar";
            btn_AcceptUsn.UseVisualStyleBackColor = true;
            btn_AcceptUsn.Click += btn_AcceptUsn_Click;
            // 
            // llb_ShowAllUsers
            // 
            llb_ShowAllUsers.AutoSize = true;
            llb_ShowAllUsers.Location = new Point(68, 137);
            llb_ShowAllUsers.Margin = new Padding(4, 0, 4, 0);
            llb_ShowAllUsers.Name = "llb_ShowAllUsers";
            llb_ShowAllUsers.Size = new Size(189, 15);
            llb_ShowAllUsers.TabIndex = 17;
            llb_ShowAllUsers.TabStop = true;
            llb_ShowAllUsers.Text = "No recuerdo el nombre de Usuario";
            // 
            // tb_getUsername
            // 
            tb_getUsername.Location = new Point(71, 98);
            tb_getUsername.Margin = new Padding(4, 3, 4, 3);
            tb_getUsername.Name = "tb_getUsername";
            tb_getUsername.Size = new Size(178, 23);
            tb_getUsername.TabIndex = 16;
            // 
            // lb_ModInfo
            // 
            lb_ModInfo.AutoSize = true;
            lb_ModInfo.BackColor = Color.OliveDrab;
            lb_ModInfo.ForeColor = SystemColors.ButtonHighlight;
            lb_ModInfo.Location = new Point(71, 58);
            lb_ModInfo.Margin = new Padding(4, 0, 4, 0);
            lb_ModInfo.Name = "lb_ModInfo";
            lb_ModInfo.Size = new Size(327, 15);
            lb_ModInfo.TabIndex = 15;
            lb_ModInfo.Text = "Por favor,ingrese el nombre del usuario que desee modificar:";
            // 
            // lb_MUser
            // 
            lb_MUser.AutoSize = true;
            lb_MUser.BackColor = Color.OliveDrab;
            lb_MUser.ForeColor = SystemColors.ButtonHighlight;
            lb_MUser.Location = new Point(71, 27);
            lb_MUser.Margin = new Padding(4, 0, 4, 0);
            lb_MUser.Name = "lb_MUser";
            lb_MUser.Size = new Size(96, 15);
            lb_MUser.TabIndex = 14;
            lb_MUser.Text = "Eliminar Usuario:";
            // 
            // pb_headerpic
            // 
            pb_headerpic.Dock = DockStyle.Left;
            pb_headerpic.Image = Properties.Resources.Studio_Ghibli__Cattt__;
            pb_headerpic.Location = new Point(0, 0);
            pb_headerpic.Margin = new Padding(4, 3, 4, 3);
            pb_headerpic.Name = "pb_headerpic";
            pb_headerpic.Size = new Size(64, 519);
            pb_headerpic.SizeMode = PictureBoxSizeMode.CenterImage;
            pb_headerpic.TabIndex = 19;
            pb_headerpic.TabStop = false;
            // 
            // dgv_User
            // 
            dgv_User.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_User.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_User.Location = new Point(392, 98);
            dgv_User.Margin = new Padding(4, 3, 4, 3);
            dgv_User.Name = "dgv_User";
            dgv_User.Size = new Size(542, 130);
            dgv_User.TabIndex = 21;
            // 
            // lb_UserData
            // 
            lb_UserData.AutoSize = true;
            lb_UserData.BackColor = Color.OliveDrab;
            lb_UserData.ForeColor = SystemColors.ButtonHighlight;
            lb_UserData.Location = new Point(584, 58);
            lb_UserData.Margin = new Padding(4, 0, 4, 0);
            lb_UserData.Name = "lb_UserData";
            lb_UserData.Size = new Size(121, 15);
            lb_UserData.TabIndex = 20;
            lb_UserData.Text = "DATOS DEL USUARIO:";
            // 
            // pb_Background
            // 
            pb_Background.BackColor = Color.OliveDrab;
            pb_Background.Location = new Point(374, 76);
            pb_Background.Margin = new Padding(4, 3, 4, 3);
            pb_Background.Name = "pb_Background";
            pb_Background.Size = new Size(614, 187);
            pb_Background.TabIndex = 22;
            pb_Background.TabStop = false;
            // 
            // btnAcceptDelete
            // 
            btnAcceptDelete.Location = new Point(832, 479);
            btnAcceptDelete.Margin = new Padding(4, 3, 4, 3);
            btnAcceptDelete.Name = "btnAcceptDelete";
            btnAcceptDelete.Size = new Size(88, 27);
            btnAcceptDelete.TabIndex = 23;
            btnAcceptDelete.Text = "Aceptar";
            btnAcceptDelete.UseVisualStyleBackColor = true;
            // 
            // fm_DeleteUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(btnAcceptDelete);
            Controls.Add(dgv_User);
            Controls.Add(lb_UserData);
            Controls.Add(pb_headerpic);
            Controls.Add(btn_AcceptUsn);
            Controls.Add(llb_ShowAllUsers);
            Controls.Add(tb_getUsername);
            Controls.Add(lb_ModInfo);
            Controls.Add(lb_MUser);
            Controls.Add(pb_Background);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fm_DeleteUsers";
            Text = "fm_DeleteUsers";
            ((System.ComponentModel.ISupportInitialize)pb_headerpic).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_User).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Background).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AcceptUsn;
        private System.Windows.Forms.LinkLabel llb_ShowAllUsers;
        private System.Windows.Forms.TextBox tb_getUsername;
        private System.Windows.Forms.Label lb_ModInfo;
        private System.Windows.Forms.Label lb_MUser;
        private System.Windows.Forms.PictureBox pb_headerpic;
        private System.Windows.Forms.DataGridView dgv_User;
        private System.Windows.Forms.Label lb_UserData;
        private System.Windows.Forms.PictureBox pb_Background;
        private System.Windows.Forms.Button btnAcceptDelete;
    }
}
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
            this.btn_AcceptUsn = new System.Windows.Forms.Button();
            this.llb_ShowAllUsers = new System.Windows.Forms.LinkLabel();
            this.tb_getUsername = new System.Windows.Forms.TextBox();
            this.lb_ModInfo = new System.Windows.Forms.Label();
            this.lb_MUser = new System.Windows.Forms.Label();
            this.pb_headerpic = new System.Windows.Forms.PictureBox();
            this.dgv_User = new System.Windows.Forms.DataGridView();
            this.lb_UserData = new System.Windows.Forms.Label();
            this.pb_Background = new System.Windows.Forms.PictureBox();
            this.btnAcceptDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_headerpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Background)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AcceptUsn
            // 
            this.btn_AcceptUsn.Location = new System.Drawing.Point(230, 85);
            this.btn_AcceptUsn.Name = "btn_AcceptUsn";
            this.btn_AcceptUsn.Size = new System.Drawing.Size(75, 23);
            this.btn_AcceptUsn.TabIndex = 18;
            this.btn_AcceptUsn.Text = "Aceptar";
            this.btn_AcceptUsn.UseVisualStyleBackColor = true;
            this.btn_AcceptUsn.Click += new System.EventHandler(this.btn_AcceptUsn_Click);
            // 
            // llb_ShowAllUsers
            // 
            this.llb_ShowAllUsers.AutoSize = true;
            this.llb_ShowAllUsers.Location = new System.Drawing.Point(58, 119);
            this.llb_ShowAllUsers.Name = "llb_ShowAllUsers";
            this.llb_ShowAllUsers.Size = new System.Drawing.Size(169, 13);
            this.llb_ShowAllUsers.TabIndex = 17;
            this.llb_ShowAllUsers.TabStop = true;
            this.llb_ShowAllUsers.Text = "No recuerdo el nombre de Usuario";
            this.llb_ShowAllUsers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_ShowAllUsers_LinkClicked);
            // 
            // tb_getUsername
            // 
            this.tb_getUsername.Location = new System.Drawing.Point(61, 85);
            this.tb_getUsername.Name = "tb_getUsername";
            this.tb_getUsername.Size = new System.Drawing.Size(153, 20);
            this.tb_getUsername.TabIndex = 16;
            // 
            // lb_ModInfo
            // 
            this.lb_ModInfo.AutoSize = true;
            this.lb_ModInfo.BackColor = System.Drawing.Color.OliveDrab;
            this.lb_ModInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_ModInfo.Location = new System.Drawing.Point(61, 50);
            this.lb_ModInfo.Name = "lb_ModInfo";
            this.lb_ModInfo.Size = new System.Drawing.Size(156, 26);
            this.lb_ModInfo.TabIndex = 15;
            this.lb_ModInfo.Text = "Por favor,ingrese el nombre del \r\nusuario que desee modificar:";
            // 
            // lb_MUser
            // 
            this.lb_MUser.AutoSize = true;
            this.lb_MUser.BackColor = System.Drawing.Color.OliveDrab;
            this.lb_MUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_MUser.Location = new System.Drawing.Point(61, 23);
            this.lb_MUser.Name = "lb_MUser";
            this.lb_MUser.Size = new System.Drawing.Size(85, 13);
            this.lb_MUser.TabIndex = 14;
            this.lb_MUser.Text = "Eliminar Usuario:";
            // 
            // pb_headerpic
            // 
            this.pb_headerpic.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_headerpic.Image = global::WindowsFormsApp1.Properties.Resources.Studio_Ghibli__Cattt__;
            this.pb_headerpic.Location = new System.Drawing.Point(0, 0);
            this.pb_headerpic.Name = "pb_headerpic";
            this.pb_headerpic.Size = new System.Drawing.Size(55, 450);
            this.pb_headerpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_headerpic.TabIndex = 19;
            this.pb_headerpic.TabStop = false;
            // 
            // dgv_User
            // 
            this.dgv_User.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_User.Location = new System.Drawing.Point(323, 50);
            this.dgv_User.Name = "dgv_User";
            this.dgv_User.Size = new System.Drawing.Size(465, 113);
            this.dgv_User.TabIndex = 21;
            // 
            // lb_UserData
            // 
            this.lb_UserData.AutoSize = true;
            this.lb_UserData.BackColor = System.Drawing.Color.OliveDrab;
            this.lb_UserData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_UserData.Location = new System.Drawing.Point(479, 8);
            this.lb_UserData.Name = "lb_UserData";
            this.lb_UserData.Size = new System.Drawing.Size(123, 13);
            this.lb_UserData.TabIndex = 20;
            this.lb_UserData.Text = "DATOS DEL USUARIO:";
            // 
            // pb_Background
            // 
            this.pb_Background.BackColor = System.Drawing.Color.OliveDrab;
            this.pb_Background.Location = new System.Drawing.Point(311, 27);
            this.pb_Background.Name = "pb_Background";
            this.pb_Background.Size = new System.Drawing.Size(526, 162);
            this.pb_Background.TabIndex = 22;
            this.pb_Background.TabStop = false;
            // 
            // btnAcceptDelete
            // 
            this.btnAcceptDelete.Location = new System.Drawing.Point(713, 415);
            this.btnAcceptDelete.Name = "btnAcceptDelete";
            this.btnAcceptDelete.Size = new System.Drawing.Size(75, 23);
            this.btnAcceptDelete.TabIndex = 23;
            this.btnAcceptDelete.Text = "Aceptar";
            this.btnAcceptDelete.UseVisualStyleBackColor = true;
            this.btnAcceptDelete.Click += new System.EventHandler(this.btnAcceptDelete_Click);
            // 
            // fm_DeleteUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAcceptDelete);
            this.Controls.Add(this.dgv_User);
            this.Controls.Add(this.lb_UserData);
            this.Controls.Add(this.pb_headerpic);
            this.Controls.Add(this.btn_AcceptUsn);
            this.Controls.Add(this.llb_ShowAllUsers);
            this.Controls.Add(this.tb_getUsername);
            this.Controls.Add(this.lb_ModInfo);
            this.Controls.Add(this.lb_MUser);
            this.Controls.Add(this.pb_Background);
            this.Name = "fm_DeleteUsers";
            this.Text = "fm_DeleteUsers";
            ((System.ComponentModel.ISupportInitialize)(this.pb_headerpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
namespace WindowsFormsApp1.menuAdmin.Users
{
    partial class fm_ModifyUsers
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
            this.lb_UserData = new System.Windows.Forms.Label();
            this.lb_MUser = new System.Windows.Forms.Label();
            this.lb_ModInfo = new System.Windows.Forms.Label();
            this.tb_getUsername = new System.Windows.Forms.TextBox();
            this.llb_ShowAllUsers = new System.Windows.Forms.LinkLabel();
            this.pb_Background = new System.Windows.Forms.PictureBox();
            this.btn_AcceptUsn = new System.Windows.Forms.Button();
            this.btn_AcceptMod = new System.Windows.Forms.Button();
            this.dgv_User = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pb_headerpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_headerpic
            // 
            this.pb_headerpic.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_headerpic.Image = global::WindowsFormsApp1.Properties.Resources.Studio_Ghibli__Cattt__;
            this.pb_headerpic.Location = new System.Drawing.Point(0, 0);
            this.pb_headerpic.Name = "pb_headerpic";
            this.pb_headerpic.Size = new System.Drawing.Size(55, 450);
            this.pb_headerpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_headerpic.TabIndex = 6;
            this.pb_headerpic.TabStop = false;
            // 
            // lb_UserData
            // 
            this.lb_UserData.AutoSize = true;
            this.lb_UserData.BackColor = System.Drawing.Color.OliveDrab;
            this.lb_UserData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_UserData.Location = new System.Drawing.Point(471, 9);
            this.lb_UserData.Name = "lb_UserData";
            this.lb_UserData.Size = new System.Drawing.Size(123, 13);
            this.lb_UserData.TabIndex = 7;
            this.lb_UserData.Text = "DATOS DEL USUARIO:";
            // 
            // lb_MUser
            // 
            this.lb_MUser.AutoSize = true;
            this.lb_MUser.BackColor = System.Drawing.Color.OliveDrab;
            this.lb_MUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_MUser.Location = new System.Drawing.Point(72, 9);
            this.lb_MUser.Name = "lb_MUser";
            this.lb_MUser.Size = new System.Drawing.Size(92, 13);
            this.lb_MUser.TabIndex = 8;
            this.lb_MUser.Text = "Modificar Usuario:";
            // 
            // lb_ModInfo
            // 
            this.lb_ModInfo.AutoSize = true;
            this.lb_ModInfo.BackColor = System.Drawing.Color.OliveDrab;
            this.lb_ModInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_ModInfo.Location = new System.Drawing.Point(72, 36);
            this.lb_ModInfo.Name = "lb_ModInfo";
            this.lb_ModInfo.Size = new System.Drawing.Size(156, 26);
            this.lb_ModInfo.TabIndex = 9;
            this.lb_ModInfo.Text = "Por favor,ingrese el nombre del \r\nusuario que desee modificar:";
            // 
            // tb_getUsername
            // 
            this.tb_getUsername.Location = new System.Drawing.Point(75, 79);
            this.tb_getUsername.Name = "tb_getUsername";
            this.tb_getUsername.Size = new System.Drawing.Size(153, 20);
            this.tb_getUsername.TabIndex = 10;
            // 
            // llb_ShowAllUsers
            // 
            this.llb_ShowAllUsers.AutoSize = true;
            this.llb_ShowAllUsers.Location = new System.Drawing.Point(72, 114);
            this.llb_ShowAllUsers.Name = "llb_ShowAllUsers";
            this.llb_ShowAllUsers.Size = new System.Drawing.Size(169, 13);
            this.llb_ShowAllUsers.TabIndex = 11;
            this.llb_ShowAllUsers.TabStop = true;
            this.llb_ShowAllUsers.Text = "No recuerdo el nombre de Usuario";
            this.llb_ShowAllUsers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_ShowAllUsers_LinkClicked_1);
            // 
            // pb_Background
            // 
            this.pb_Background.BackColor = System.Drawing.Color.OliveDrab;
            this.pb_Background.Location = new System.Drawing.Point(339, 25);
            this.pb_Background.Name = "pb_Background";
            this.pb_Background.Size = new System.Drawing.Size(471, 319);
            this.pb_Background.TabIndex = 12;
            this.pb_Background.TabStop = false;
            // 
            // btn_AcceptUsn
            // 
            this.btn_AcceptUsn.Location = new System.Drawing.Point(235, 79);
            this.btn_AcceptUsn.Name = "btn_AcceptUsn";
            this.btn_AcceptUsn.Size = new System.Drawing.Size(75, 23);
            this.btn_AcceptUsn.TabIndex = 13;
            this.btn_AcceptUsn.Text = "Aceptar";
            this.btn_AcceptUsn.UseVisualStyleBackColor = true;
            this.btn_AcceptUsn.Click += new System.EventHandler(this.btn_AcceptUsn_Click);
            // 
            // btn_AcceptMod
            // 
            this.btn_AcceptMod.Location = new System.Drawing.Point(735, 415);
            this.btn_AcceptMod.Name = "btn_AcceptMod";
            this.btn_AcceptMod.Size = new System.Drawing.Size(75, 23);
            this.btn_AcceptMod.TabIndex = 14;
            this.btn_AcceptMod.Text = "Aceptar";
            this.btn_AcceptMod.UseVisualStyleBackColor = true;
            // 
            // dgv_User
            // 
            this.dgv_User.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_User.Location = new System.Drawing.Point(357, 51);
            this.dgv_User.Name = "dgv_User";
            this.dgv_User.Size = new System.Drawing.Size(437, 262);
            this.dgv_User.TabIndex = 15;
           
            // 
            // fm_ModifyUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.dgv_User);
            this.Controls.Add(this.btn_AcceptMod);
            this.Controls.Add(this.btn_AcceptUsn);
            this.Controls.Add(this.pb_Background);
            this.Controls.Add(this.llb_ShowAllUsers);
            this.Controls.Add(this.tb_getUsername);
            this.Controls.Add(this.lb_ModInfo);
            this.Controls.Add(this.lb_MUser);
            this.Controls.Add(this.lb_UserData);
            this.Controls.Add(this.pb_headerpic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fm_ModifyUsers";
            this.Text = "Modificar Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.pb_headerpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_headerpic;
        private System.Windows.Forms.Label lb_UserData;
        private System.Windows.Forms.Label lb_MUser;
        private System.Windows.Forms.Label lb_ModInfo;
        private System.Windows.Forms.TextBox tb_getUsername;
        private System.Windows.Forms.LinkLabel llb_ShowAllUsers;
        private System.Windows.Forms.PictureBox pb_Background;
        private System.Windows.Forms.Button btn_AcceptUsn;
        private System.Windows.Forms.Button btn_AcceptMod;
        private System.Windows.Forms.DataGridView dgv_User;
    }
}
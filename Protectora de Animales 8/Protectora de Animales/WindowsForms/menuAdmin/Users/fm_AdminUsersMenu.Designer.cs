namespace WindowsForms.menusAdmin
{
    partial class fm_AdminUsersMenu
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
            this.lb_MenuTitle = new System.Windows.Forms.Label();
            this.pb_headerpic = new System.Windows.Forms.PictureBox();
            this.btn_ModifyUsers = new System.Windows.Forms.Button();
            this.btn_DeleteUsers = new System.Windows.Forms.Button();
            this.btn_ShowAllUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_headerpic)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_MenuTitle
            // 
            this.lb_MenuTitle.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lb_MenuTitle.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MenuTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_MenuTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_MenuTitle.Location = new System.Drawing.Point(-1, 53);
            this.lb_MenuTitle.Name = "lb_MenuTitle";
            this.lb_MenuTitle.Size = new System.Drawing.Size(98, 42);
            this.lb_MenuTitle.TabIndex = 5;
            this.lb_MenuTitle.Text = "MENU";
            // 
            // pb_headerpic
            // 
            this.pb_headerpic.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb_headerpic.Image = global::WindowsFormsApp1.Properties.Resources.Studio_Ghibli__Cattt__;
            this.pb_headerpic.Location = new System.Drawing.Point(0, 0);
            this.pb_headerpic.Name = "pb_headerpic";
            this.pb_headerpic.Size = new System.Drawing.Size(390, 95);
            this.pb_headerpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_headerpic.TabIndex = 4;
            this.pb_headerpic.TabStop = false;
            // 
            // btn_ModifyUsers
            // 
            this.btn_ModifyUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ModifyUsers.Location = new System.Drawing.Point(87, 198);
            this.btn_ModifyUsers.Name = "btn_ModifyUsers";
            this.btn_ModifyUsers.Size = new System.Drawing.Size(217, 26);
            this.btn_ModifyUsers.TabIndex = 13;
            this.btn_ModifyUsers.Text = "Modificar Usuarios";
            this.btn_ModifyUsers.UseVisualStyleBackColor = true;
            this.btn_ModifyUsers.Click += new System.EventHandler(this.btn_ModifyUsers_Click);
            // 
            // btn_DeleteUsers
            // 
            this.btn_DeleteUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DeleteUsers.Location = new System.Drawing.Point(87, 150);
            this.btn_DeleteUsers.Name = "btn_DeleteUsers";
            this.btn_DeleteUsers.Size = new System.Drawing.Size(217, 26);
            this.btn_DeleteUsers.TabIndex = 12;
            this.btn_DeleteUsers.Text = "Eliminar Usuarios";
            this.btn_DeleteUsers.UseVisualStyleBackColor = true;
            this.btn_DeleteUsers.Click += new System.EventHandler(this.btn_DeleteUsers_Click);
            // 
            // btn_ShowAllUsers
            // 
            this.btn_ShowAllUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ShowAllUsers.Location = new System.Drawing.Point(87, 252);
            this.btn_ShowAllUsers.Name = "btn_ShowAllUsers";
            this.btn_ShowAllUsers.Size = new System.Drawing.Size(217, 26);
            this.btn_ShowAllUsers.TabIndex = 11;
            this.btn_ShowAllUsers.Text = "Ver Usuarios";
            this.btn_ShowAllUsers.UseVisualStyleBackColor = true;
            this.btn_ShowAllUsers.Click += new System.EventHandler(this.btn_ShowAllUsers_Click);
            // 
            // fm_AdminUsersMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 360);
            this.Controls.Add(this.btn_ModifyUsers);
            this.Controls.Add(this.btn_DeleteUsers);
            this.Controls.Add(this.btn_ShowAllUsers);
            this.Controls.Add(this.lb_MenuTitle);
            this.Controls.Add(this.pb_headerpic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fm_AdminUsersMenu";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.pb_headerpic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.Label lb_MenuTitle;
        private System.Windows.Forms.PictureBox pb_headerpic;
        public System.Windows.Forms.Button btn_ModifyUsers;
        protected System.Windows.Forms.Button btn_DeleteUsers;
        public System.Windows.Forms.Button btn_ShowAllUsers;
    }
}
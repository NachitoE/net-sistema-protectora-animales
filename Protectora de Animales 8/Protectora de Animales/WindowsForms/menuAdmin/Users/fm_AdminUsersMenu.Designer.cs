namespace WindowsForms.menuAdmin.Users
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
            lb_MenuTitle = new Label();
            pb_headerpic = new PictureBox();
            btn_ModifyUsers = new Button();
            btn_DeleteUsers = new Button();
            btn_ShowAllUsers = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_headerpic).BeginInit();
            SuspendLayout();
            // 
            // lb_MenuTitle
            // 
            lb_MenuTitle.BackColor = Color.DarkOliveGreen;
            lb_MenuTitle.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_MenuTitle.ForeColor = SystemColors.ButtonHighlight;
            lb_MenuTitle.ImageAlign = ContentAlignment.MiddleRight;
            lb_MenuTitle.Location = new Point(-1, 61);
            lb_MenuTitle.Margin = new Padding(4, 0, 4, 0);
            lb_MenuTitle.Name = "lb_MenuTitle";
            lb_MenuTitle.Size = new Size(114, 48);
            lb_MenuTitle.TabIndex = 5;
            lb_MenuTitle.Text = "MENU";
            // 
            // pb_headerpic
            // 
            pb_headerpic.Dock = DockStyle.Top;
            pb_headerpic.Image = Properties.Resources.Studio_Ghibli__Cattt__;
            pb_headerpic.Location = new Point(0, 0);
            pb_headerpic.Margin = new Padding(4, 3, 4, 3);
            pb_headerpic.Name = "pb_headerpic";
            pb_headerpic.Size = new Size(455, 110);
            pb_headerpic.SizeMode = PictureBoxSizeMode.CenterImage;
            pb_headerpic.TabIndex = 4;
            pb_headerpic.TabStop = false;
            // 
            // btn_ModifyUsers
            // 
            btn_ModifyUsers.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_ModifyUsers.Location = new Point(102, 228);
            btn_ModifyUsers.Margin = new Padding(4, 3, 4, 3);
            btn_ModifyUsers.Name = "btn_ModifyUsers";
            btn_ModifyUsers.Size = new Size(253, 30);
            btn_ModifyUsers.TabIndex = 13;
            btn_ModifyUsers.Text = "Modificar Usuarios";
            btn_ModifyUsers.UseVisualStyleBackColor = true;
            btn_ModifyUsers.Click += btn_ModifyUsers_Click;
            // 
            // btn_DeleteUsers
            // 
            btn_DeleteUsers.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_DeleteUsers.Location = new Point(102, 173);
            btn_DeleteUsers.Margin = new Padding(4, 3, 4, 3);
            btn_DeleteUsers.Name = "btn_DeleteUsers";
            btn_DeleteUsers.Size = new Size(253, 30);
            btn_DeleteUsers.TabIndex = 12;
            btn_DeleteUsers.Text = "Eliminar Usuarios";
            btn_DeleteUsers.UseVisualStyleBackColor = true;
            btn_DeleteUsers.Click += btn_DeleteUsers_Click;
            // 
            // btn_ShowAllUsers
            // 
            btn_ShowAllUsers.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_ShowAllUsers.Location = new Point(102, 291);
            btn_ShowAllUsers.Margin = new Padding(4, 3, 4, 3);
            btn_ShowAllUsers.Name = "btn_ShowAllUsers";
            btn_ShowAllUsers.Size = new Size(253, 30);
            btn_ShowAllUsers.TabIndex = 11;
            btn_ShowAllUsers.Text = "Ver Usuarios";
            btn_ShowAllUsers.UseVisualStyleBackColor = true;
            btn_ShowAllUsers.Click += btn_ShowAllUsers_Click;
            // 
            // fm_AdminUsersMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 415);
            Controls.Add(btn_ModifyUsers);
            Controls.Add(btn_DeleteUsers);
            Controls.Add(btn_ShowAllUsers);
            Controls.Add(lb_MenuTitle);
            Controls.Add(pb_headerpic);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "fm_AdminUsersMenu";
            Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)pb_headerpic).EndInit();
            ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.Label lb_MenuTitle;
        private System.Windows.Forms.PictureBox pb_headerpic;
        public System.Windows.Forms.Button btn_ModifyUsers;
        protected System.Windows.Forms.Button btn_DeleteUsers;
        public System.Windows.Forms.Button btn_ShowAllUsers;
    }
}
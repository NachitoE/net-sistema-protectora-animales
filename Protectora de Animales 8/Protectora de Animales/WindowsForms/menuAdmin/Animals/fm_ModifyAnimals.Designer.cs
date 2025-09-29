namespace WindowsForms.menuAdmin.Animals
{
    partial class fm_ModifyAnimals
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
            lb_UserData = new Label();
            lb_MUser = new Label();
            lb_ModInfo = new Label();
            tb_getAnimalName = new TextBox();
            llb_ShowAllUsers = new LinkLabel();
            pb_Background = new PictureBox();
            btn_AcceptUsn = new Button();
            btn_AcceptMod = new Button();
            dgv_User = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pb_headerpic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Background).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_User).BeginInit();
            SuspendLayout();
            // 
            // pb_headerpic
            // 
            pb_headerpic.Dock = DockStyle.Left;
            pb_headerpic.Image = Properties.Resources.Studio_Ghibli__Cattt__;
            pb_headerpic.Location = new Point(0, 0);
            pb_headerpic.Margin = new Padding(5, 4, 5, 4);
            pb_headerpic.Name = "pb_headerpic";
            pb_headerpic.Size = new Size(73, 692);
            pb_headerpic.SizeMode = PictureBoxSizeMode.CenterImage;
            pb_headerpic.TabIndex = 6;
            pb_headerpic.TabStop = false;
            // 
            // lb_UserData
            // 
            lb_UserData.AutoSize = true;
            lb_UserData.BackColor = Color.OliveDrab;
            lb_UserData.ForeColor = SystemColors.ButtonHighlight;
            lb_UserData.Location = new Point(629, 13);
            lb_UserData.Margin = new Padding(5, 0, 5, 0);
            lb_UserData.Name = "lb_UserData";
            lb_UserData.Size = new Size(147, 20);
            lb_UserData.TabIndex = 7;
            lb_UserData.Text = "DATOS DEL ANIMAL:";
            // 
            // lb_MUser
            // 
            lb_MUser.AutoSize = true;
            lb_MUser.BackColor = Color.OliveDrab;
            lb_MUser.ForeColor = SystemColors.ButtonHighlight;
            lb_MUser.Location = new Point(96, 13);
            lb_MUser.Margin = new Padding(5, 0, 5, 0);
            lb_MUser.Name = "lb_MUser";
            lb_MUser.Size = new Size(127, 20);
            lb_MUser.TabIndex = 8;
            lb_MUser.Text = "Modificar Animal:";
            // 
            // lb_ModInfo
            // 
            lb_ModInfo.AutoSize = true;
            lb_ModInfo.BackColor = Color.OliveDrab;
            lb_ModInfo.ForeColor = SystemColors.ButtonHighlight;
            lb_ModInfo.Location = new Point(96, 56);
            lb_ModInfo.Margin = new Padding(5, 0, 5, 0);
            lb_ModInfo.Name = "lb_ModInfo";
            lb_ModInfo.Size = new Size(408, 20);
            lb_ModInfo.TabIndex = 9;
            lb_ModInfo.Text = "Por favor,ingrese el nombre del animal que desee modificar:";
            // 
            // tb_getUsername
            // 
            tb_getAnimalName.Location = new Point(101, 121);
            tb_getAnimalName.Margin = new Padding(5, 4, 5, 4);
            tb_getAnimalName.Name = "tb_getUsername";
            tb_getAnimalName.Size = new Size(203, 27);
            tb_getAnimalName.TabIndex = 10;
            // 
            // llb_ShowAllUsers
            // 
            llb_ShowAllUsers.AutoSize = true;
            llb_ShowAllUsers.Location = new Point(96, 176);
            llb_ShowAllUsers.Margin = new Padding(5, 0, 5, 0);
            llb_ShowAllUsers.Name = "llb_ShowAllUsers";
            llb_ShowAllUsers.Size = new Size(157, 20);
            llb_ShowAllUsers.TabIndex = 11;
            llb_ShowAllUsers.TabStop = true;
            llb_ShowAllUsers.Text = "No recuerdo el animal";
            llb_ShowAllUsers.LinkClicked += llb_ShowAllUsers_LinkClicked;
            // 
            // pb_Background
            // 
            pb_Background.BackColor = Color.OliveDrab;
            pb_Background.Location = new Point(422, 39);
            pb_Background.Margin = new Padding(5, 4, 5, 4);
            pb_Background.Name = "pb_Background";
            pb_Background.Size = new Size(658, 491);
            pb_Background.TabIndex = 12;
            pb_Background.TabStop = false;
            // 
            // btn_AcceptUsn
            // 
            btn_AcceptUsn.Location = new Point(313, 121);
            btn_AcceptUsn.Margin = new Padding(5, 4, 5, 4);
            btn_AcceptUsn.Name = "btn_AcceptUsn";
            btn_AcceptUsn.Size = new Size(101, 36);
            btn_AcceptUsn.TabIndex = 13;
            btn_AcceptUsn.Text = "Aceptar";
            btn_AcceptUsn.UseVisualStyleBackColor = true;
            btn_AcceptUsn.Click += btn_AcceptUsn_Click;
            // 
            // btn_AcceptMod
            // 
            btn_AcceptMod.Location = new Point(981, 639);
            btn_AcceptMod.Margin = new Padding(5, 4, 5, 4);
            btn_AcceptMod.Name = "btn_AcceptMod";
            btn_AcceptMod.Size = new Size(101, 36);
            btn_AcceptMod.TabIndex = 14;
            btn_AcceptMod.Text = "Aceptar";
            btn_AcceptMod.UseVisualStyleBackColor = true;
            btn_AcceptMod.Click += btn_AcceptMod_Click;
            // 
            // dgv_User
            // 
            dgv_User.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_User.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_User.Location = new Point(439, 79);
            dgv_User.Margin = new Padding(5, 4, 5, 4);
            dgv_User.Name = "dgv_User";
            dgv_User.RowHeadersWidth = 51;
            dgv_User.Size = new Size(619, 403);
            dgv_User.TabIndex = 15;
            // 
            // fm_ModifyAnimals
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 692);
            Controls.Add(dgv_User);
            Controls.Add(btn_AcceptMod);
            Controls.Add(btn_AcceptUsn);
            Controls.Add(pb_Background);
            Controls.Add(llb_ShowAllUsers);
            Controls.Add(tb_getAnimalName);
            Controls.Add(lb_ModInfo);
            Controls.Add(lb_MUser);
            Controls.Add(lb_UserData);
            Controls.Add(pb_headerpic);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "fm_ModifyAnimals";
            Text = "Modificar Animal";
            ((System.ComponentModel.ISupportInitialize)pb_headerpic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Background).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_User).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_headerpic;
        private System.Windows.Forms.Label lb_UserData;
        private System.Windows.Forms.Label lb_MUser;
        private System.Windows.Forms.Label lb_ModInfo;
        private System.Windows.Forms.TextBox tb_getAnimalName;
        private System.Windows.Forms.LinkLabel llb_ShowAllUsers;
        private System.Windows.Forms.PictureBox pb_Background;
        private System.Windows.Forms.Button btn_AcceptUsn;
        private System.Windows.Forms.Button btn_AcceptMod;
        private System.Windows.Forms.DataGridView dgv_User;
    }
}
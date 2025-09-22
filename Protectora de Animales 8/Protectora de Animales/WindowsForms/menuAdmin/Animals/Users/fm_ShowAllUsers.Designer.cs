namespace WindowsForms.menuAdmin.Users
{
    partial class fm_ShowAllUsers
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
            lb_MUsu = new Label();
            lb_UserFilter = new Label();
            dgv_Users = new DataGridView();
            btn_filterbyAdopters = new Button();
            btn_FilterByVolunteers = new Button();
            btn_FilterByFosters = new Button();
            btn_AllUsers = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_headerpic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Users).BeginInit();
            SuspendLayout();
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
            pb_headerpic.TabIndex = 5;
            pb_headerpic.TabStop = false;
            // 
            // lb_MUsu
            // 
            lb_MUsu.AutoSize = true;
            lb_MUsu.BackColor = Color.OliveDrab;
            lb_MUsu.ForeColor = SystemColors.ButtonHighlight;
            lb_MUsu.Location = new Point(88, 29);
            lb_MUsu.Margin = new Padding(4, 0, 4, 0);
            lb_MUsu.Name = "lb_MUsu";
            lb_MUsu.Size = new Size(141, 15);
            lb_MUsu.TabIndex = 6;
            lb_MUsu.Text = "Usuarios de la protectora:";
            // 
            // lb_UserFilter
            // 
            lb_UserFilter.AutoSize = true;
            lb_UserFilter.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lb_UserFilter.Location = new Point(71, 54);
            lb_UserFilter.Margin = new Padding(4, 0, 4, 0);
            lb_UserFilter.Name = "lb_UserFilter";
            lb_UserFilter.Size = new Size(225, 13);
            lb_UserFilter.TabIndex = 7;
            lb_UserFilter.Text = "Si lo desea, puede aplicar los siguientes filtros:";
            // 
            // dgv_Users
            // 
            dgv_Users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_Users.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_Users.BackgroundColor = SystemColors.Window;
            dgv_Users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Users.GridColor = Color.ForestGreen;
            dgv_Users.Location = new Point(357, 29);
            dgv_Users.Margin = new Padding(4, 3, 4, 3);
            dgv_Users.Name = "dgv_Users";
            dgv_Users.ReadOnly = true;
            dgv_Users.Size = new Size(552, 474);
            dgv_Users.TabIndex = 8;
            // 
            // btn_filterbyAdopters
            // 
            btn_filterbyAdopters.Location = new Point(91, 110);
            btn_filterbyAdopters.Margin = new Padding(4, 3, 4, 3);
            btn_filterbyAdopters.Name = "btn_filterbyAdopters";
            btn_filterbyAdopters.Size = new Size(212, 27);
            btn_filterbyAdopters.TabIndex = 9;
            btn_filterbyAdopters.Text = "Adoptantes";
            btn_filterbyAdopters.UseVisualStyleBackColor = true;
            btn_filterbyAdopters.Click += btn_filterbyAdopters_Click;
            // 
            // btn_FilterByVolunteers
            // 
            btn_FilterByVolunteers.Location = new Point(91, 222);
            btn_FilterByVolunteers.Margin = new Padding(4, 3, 4, 3);
            btn_FilterByVolunteers.Name = "btn_FilterByVolunteers";
            btn_FilterByVolunteers.Size = new Size(212, 27);
            btn_FilterByVolunteers.TabIndex = 10;
            btn_FilterByVolunteers.Text = "Voluntarios";
            btn_FilterByVolunteers.UseVisualStyleBackColor = true;
            btn_FilterByVolunteers.Click += btn_FilterByVolunteers_Click;
            // 
            // btn_FilterByFosters
            // 
            btn_FilterByFosters.Location = new Point(91, 165);
            btn_FilterByFosters.Margin = new Padding(4, 3, 4, 3);
            btn_FilterByFosters.Name = "btn_FilterByFosters";
            btn_FilterByFosters.Size = new Size(212, 27);
            btn_FilterByFosters.TabIndex = 11;
            btn_FilterByFosters.Text = "Tránsitos";
            btn_FilterByFosters.UseVisualStyleBackColor = true;
            btn_FilterByFosters.Click += btn_FilterByFosters_Click;
            // 
            // btn_AllUsers
            // 
            btn_AllUsers.Location = new Point(91, 275);
            btn_AllUsers.Margin = new Padding(4, 3, 4, 3);
            btn_AllUsers.Name = "btn_AllUsers";
            btn_AllUsers.Size = new Size(212, 27);
            btn_AllUsers.TabIndex = 12;
            btn_AllUsers.Text = "Todos los usuarios";
            btn_AllUsers.UseVisualStyleBackColor = true;
            btn_AllUsers.Click += btn_AllUsers_Click;
            // 
            // fm_ShowAllUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(btn_AllUsers);
            Controls.Add(btn_FilterByFosters);
            Controls.Add(btn_FilterByVolunteers);
            Controls.Add(btn_filterbyAdopters);
            Controls.Add(dgv_Users);
            Controls.Add(lb_UserFilter);
            Controls.Add(lb_MUsu);
            Controls.Add(pb_headerpic);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "fm_ShowAllUsers";
            Text = "USUARIOS";
            ((System.ComponentModel.ISupportInitialize)pb_headerpic).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Users).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_headerpic;
        private System.Windows.Forms.Label lb_MUsu;
        private System.Windows.Forms.Label lb_UserFilter;
        private System.Windows.Forms.DataGridView dgv_Users;
        private System.Windows.Forms.Button btn_filterbyAdopters;
        private System.Windows.Forms.Button btn_FilterByVolunteers;
        private System.Windows.Forms.Button btn_FilterByFosters;
        private System.Windows.Forms.Button btn_AllUsers;
    }
}
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
            this.pb_headerpic = new System.Windows.Forms.PictureBox();
            this.lb_MUsu = new System.Windows.Forms.Label();
            this.lb_UserFilter = new System.Windows.Forms.Label();
            this.dgv_Users = new System.Windows.Forms.DataGridView();
            this.btn_filterbyAdopters = new System.Windows.Forms.Button();
            this.btn_FilterByVolunteers = new System.Windows.Forms.Button();
            this.btn_FilterByFosters = new System.Windows.Forms.Button();
            this.btn_AllUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_headerpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).BeginInit();
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
            this.pb_headerpic.TabIndex = 5;
            this.pb_headerpic.TabStop = false;
            // 
            // lb_MUsu
            // 
            this.lb_MUsu.AutoSize = true;
            this.lb_MUsu.BackColor = System.Drawing.Color.OliveDrab;
            this.lb_MUsu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_MUsu.Location = new System.Drawing.Point(75, 25);
            this.lb_MUsu.Name = "lb_MUsu";
            this.lb_MUsu.Size = new System.Drawing.Size(128, 13);
            this.lb_MUsu.TabIndex = 6;
            this.lb_MUsu.Text = "Usuarios de la protectora:";
            // 
            // lb_UserFilter
            // 
            this.lb_UserFilter.AutoSize = true;
            this.lb_UserFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UserFilter.Location = new System.Drawing.Point(61, 47);
            this.lb_UserFilter.Name = "lb_UserFilter";
            this.lb_UserFilter.Size = new System.Drawing.Size(225, 13);
            this.lb_UserFilter.TabIndex = 7;
            this.lb_UserFilter.Text = "Si lo desea, puede aplicar los siguientes filtros:";
            // 
            // dgv_Users
            // 
            this.dgv_Users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Users.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Users.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Users.GridColor = System.Drawing.Color.ForestGreen;
            this.dgv_Users.Location = new System.Drawing.Point(306, 25);
            this.dgv_Users.Name = "dgv_Users";
            this.dgv_Users.ReadOnly = true;
            this.dgv_Users.Size = new System.Drawing.Size(473, 411);
            this.dgv_Users.TabIndex = 8;
            // 
            // btn_filterbyAdopters
            // 
            this.btn_filterbyAdopters.Location = new System.Drawing.Point(78, 95);
            this.btn_filterbyAdopters.Name = "btn_filterbyAdopters";
            this.btn_filterbyAdopters.Size = new System.Drawing.Size(182, 23);
            this.btn_filterbyAdopters.TabIndex = 9;
            this.btn_filterbyAdopters.Text = "Adoptantes";
            this.btn_filterbyAdopters.UseVisualStyleBackColor = true;
            this.btn_filterbyAdopters.Click += new System.EventHandler(this.btn_filterbyAdopters_Click);
            // 
            // btn_FilterByVolunteers
            // 
            this.btn_FilterByVolunteers.Location = new System.Drawing.Point(78, 192);
            this.btn_FilterByVolunteers.Name = "btn_FilterByVolunteers";
            this.btn_FilterByVolunteers.Size = new System.Drawing.Size(182, 23);
            this.btn_FilterByVolunteers.TabIndex = 10;
            this.btn_FilterByVolunteers.Text = "Voluntarios";
            this.btn_FilterByVolunteers.UseVisualStyleBackColor = true;
            this.btn_FilterByVolunteers.Click += new System.EventHandler(this.btn_FilterByVolunteers_Click);
            // 
            // btn_FilterByFosters
            // 
            this.btn_FilterByFosters.Location = new System.Drawing.Point(78, 143);
            this.btn_FilterByFosters.Name = "btn_FilterByFosters";
            this.btn_FilterByFosters.Size = new System.Drawing.Size(182, 23);
            this.btn_FilterByFosters.TabIndex = 11;
            this.btn_FilterByFosters.Text = "Tránsitos";
            this.btn_FilterByFosters.UseVisualStyleBackColor = true;
            this.btn_FilterByFosters.Click += new System.EventHandler(this.btn_FilterByFosters_Click);
            // 
            // btn_AllUsers
            // 
            this.btn_AllUsers.Location = new System.Drawing.Point(78, 238);
            this.btn_AllUsers.Name = "btn_AllUsers";
            this.btn_AllUsers.Size = new System.Drawing.Size(182, 23);
            this.btn_AllUsers.TabIndex = 12;
            this.btn_AllUsers.Text = "Todos los usuarios";
            this.btn_AllUsers.UseVisualStyleBackColor = true;
            this.btn_AllUsers.Click += new System.EventHandler(this.btn_AllUsers_Click);
            // 
            // fm_ShowAllUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_AllUsers);
            this.Controls.Add(this.btn_FilterByFosters);
            this.Controls.Add(this.btn_FilterByVolunteers);
            this.Controls.Add(this.btn_filterbyAdopters);
            this.Controls.Add(this.dgv_Users);
            this.Controls.Add(this.lb_UserFilter);
            this.Controls.Add(this.lb_MUsu);
            this.Controls.Add(this.pb_headerpic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fm_ShowAllUsers";
            this.Text = "USUARIOS";
            ((System.ComponentModel.ISupportInitialize)(this.pb_headerpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
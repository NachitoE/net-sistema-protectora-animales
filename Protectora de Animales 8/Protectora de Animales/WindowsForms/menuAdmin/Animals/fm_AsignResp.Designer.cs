namespace WindowsForms.menuAdmin.Animals
{
    partial class fm_AsignResp
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
            dgv_users = new DataGridView();
            dgv_animals = new DataGridView();
            btn_cancel = new Button();
            btn_accept = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_users).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_animals).BeginInit();
            SuspendLayout();
            // 
            // dgv_users
            // 
            dgv_users.AllowUserToAddRows = false;
            dgv_users.AllowUserToDeleteRows = false;
            dgv_users.AllowUserToResizeColumns = false;
            dgv_users.AllowUserToResizeRows = false;
            dgv_users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_users.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_users.Location = new Point(14, 14);
            dgv_users.Margin = new Padding(4, 3, 4, 3);
            dgv_users.MultiSelect = false;
            dgv_users.Name = "dgv_users";
            dgv_users.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_users.Size = new Size(449, 333);
            dgv_users.TabIndex = 0;
            // 
            // dgv_animals
            // 
            dgv_animals.AllowUserToAddRows = false;
            dgv_animals.AllowUserToDeleteRows = false;
            dgv_animals.AllowUserToResizeColumns = false;
            dgv_animals.AllowUserToResizeRows = false;
            dgv_animals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_animals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_animals.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_animals.Location = new Point(470, 14);
            dgv_animals.Margin = new Padding(4, 3, 4, 3);
            dgv_animals.MultiSelect = false;
            dgv_animals.Name = "dgv_animals";
            dgv_animals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_animals.Size = new Size(449, 333);
            dgv_animals.TabIndex = 1;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(832, 479);
            btn_cancel.Margin = new Padding(4, 3, 4, 3);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(88, 27);
            btn_cancel.TabIndex = 2;
            btn_cancel.Text = "Cancelar";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_accept
            // 
            btn_accept.BackColor = SystemColors.ButtonFace;
            btn_accept.ForeColor = Color.Black;
            btn_accept.Location = new Point(726, 479);
            btn_accept.Margin = new Padding(4, 3, 4, 3);
            btn_accept.Name = "btn_accept";
            btn_accept.Size = new Size(88, 27);
            btn_accept.TabIndex = 3;
            btn_accept.Text = "Aceptar";
            btn_accept.UseVisualStyleBackColor = false;
            btn_accept.Click += btn_accept_Click;
            // 
            // fm_AsignResp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(btn_accept);
            Controls.Add(btn_cancel);
            Controls.Add(dgv_animals);
            Controls.Add(dgv_users);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "fm_AsignResp";
            Text = "ASIGNAR CUIDADOR";
            ((System.ComponentModel.ISupportInitialize)dgv_users).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_animals).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_users;
        private System.Windows.Forms.DataGridView dgv_animals;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_accept;
    }
}
namespace WindowsForms.menuAdopter
{
    partial class fm_ShowAdoptionProgress
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
            dgv_UsersAdoption = new DataGridView();
            lb_MyAdoptions = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_UsersAdoption).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgv_UsersAdoption
            // 
            dgv_UsersAdoption.BackgroundColor = SystemColors.Control;
            dgv_UsersAdoption.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_UsersAdoption.Location = new Point(82, 115);
            dgv_UsersAdoption.Name = "dgv_UsersAdoption";
            dgv_UsersAdoption.Size = new Size(652, 342);
            dgv_UsersAdoption.TabIndex = 0;
            // 
            // lb_MyAdoptions
            // 
            lb_MyAdoptions.AutoSize = true;
            lb_MyAdoptions.BackColor = Color.OliveDrab;
            lb_MyAdoptions.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_MyAdoptions.ForeColor = SystemColors.ButtonHighlight;
            lb_MyAdoptions.Location = new Point(335, 87);
            lb_MyAdoptions.Name = "lb_MyAdoptions";
            lb_MyAdoptions.Size = new Size(152, 25);
            lb_MyAdoptions.TabIndex = 1;
            lb_MyAdoptions.Text = "Mis Adopciones";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.OliveDrab;
            pictureBox2.Location = new Point(57, 76);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(705, 409);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // fm_ShowAdoptionProgress
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 550);
            Controls.Add(lb_MyAdoptions);
            Controls.Add(dgv_UsersAdoption);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fm_ShowAdoptionProgress";
            Text = "fm_AdoptionFollowing";
            ((System.ComponentModel.ISupportInitialize)dgv_UsersAdoption).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dgv_UsersAdoption;
        private Label lb_MyAdoptions;
        private PictureBox pictureBox2;
    }
}
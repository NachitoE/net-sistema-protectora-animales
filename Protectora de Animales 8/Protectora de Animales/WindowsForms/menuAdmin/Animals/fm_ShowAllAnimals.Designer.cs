namespace WindowsForms.menuAdmin.Animals
{
    partial class fm_ShowAllAnimals
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
            this.dgv_animals = new System.Windows.Forms.DataGridView();
            this.lb_MATitle = new System.Windows.Forms.Label();
            this.pb_headerpic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_animals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_headerpic)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_animals
            // 
            this.dgv_animals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_animals.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_animals.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_animals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_animals.GridColor = System.Drawing.Color.ForestGreen;
            this.dgv_animals.Location = new System.Drawing.Point(253, 27);
            this.dgv_animals.Name = "dgv_animals";
            this.dgv_animals.ReadOnly = true;
            this.dgv_animals.Size = new System.Drawing.Size(473, 411);
            this.dgv_animals.TabIndex = 1;
            // 
            // lb_MATitle
            // 
            this.lb_MATitle.AutoSize = true;
            this.lb_MATitle.Location = new System.Drawing.Point(90, 44);
            this.lb_MATitle.Name = "lb_MATitle";
            this.lb_MATitle.Size = new System.Drawing.Size(129, 13);
            this.lb_MATitle.TabIndex = 5;
            this.lb_MATitle.Text = "Animales de la protectora:";
            // 
            // pb_headerpic
            // 
            this.pb_headerpic.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_headerpic.Image = global::WindowsForms.Properties.Resources.Studio_Ghibli__Cattt__;
            this.pb_headerpic.Location = new System.Drawing.Point(0, 0);
            this.pb_headerpic.Name = "pb_headerpic";
            this.pb_headerpic.Size = new System.Drawing.Size(55, 450);
            this.pb_headerpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_headerpic.TabIndex = 4;
            this.pb_headerpic.TabStop = false;
            // 
            // fm_ShowAllAnimals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_MATitle);
            this.Controls.Add(this.pb_headerpic);
            this.Controls.Add(this.dgv_animals);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fm_ShowAllAnimals";
            this.Text = "Mis Animales";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_animals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_headerpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        
        }

        #endregion

                private System.Windows.Forms.DataGridView dgv_animals;
        private System.Windows.Forms.PictureBox pb_headerpic;
        private System.Windows.Forms.Label lb_MATitle;
    }
}
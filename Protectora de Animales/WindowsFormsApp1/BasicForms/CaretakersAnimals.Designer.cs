namespace WindowsFormsApp1.BasicForms
{
    partial class fm_CaretakersAnimals
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
            this.dgv_userAnimals = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pb_headerpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userAnimals)).BeginInit();
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
            this.pb_headerpic.TabIndex = 8;
            this.pb_headerpic.TabStop = false;
            // 
            // dgv_userAnimals
            // 
            this.dgv_userAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_userAnimals.Location = new System.Drawing.Point(177, 12);
            this.dgv_userAnimals.Name = "dgv_userAnimals";
            this.dgv_userAnimals.Size = new System.Drawing.Size(570, 349);
            this.dgv_userAnimals.TabIndex = 9;
            // 
            // CaretakersAnimals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_userAnimals);
            this.Controls.Add(this.pb_headerpic);
            this.Name = "CaretakersAnimals";
            this.Text = "CaretakersAnimals";
            ((System.ComponentModel.ISupportInitialize)(this.pb_headerpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userAnimals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_headerpic;
        private System.Windows.Forms.DataGridView dgv_userAnimals;
    }
}
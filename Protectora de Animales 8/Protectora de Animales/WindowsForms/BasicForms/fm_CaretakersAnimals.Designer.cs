namespace WindowsForms.NewFolder1
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
            pb_headerpic = new PictureBox();
            dgv_userAnimals = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pb_headerpic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_userAnimals).BeginInit();
            SuspendLayout();
            // 
            // pb_headerpic
            // 
            pb_headerpic.Dock = DockStyle.Left;
            pb_headerpic.Image = Properties.Resources.Studio_Ghibli__Cattt__;
            pb_headerpic.Location = new Point(0, 0);
            pb_headerpic.Margin = new Padding(4, 3, 4, 3);
            pb_headerpic.Name = "pb_headerpic";
            pb_headerpic.Size = new Size(71, 519);
            pb_headerpic.TabIndex = 8;
            pb_headerpic.TabStop = false;
            // 
            // dgv_userAnimals
            // 
            dgv_userAnimals.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_userAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_userAnimals.Location = new Point(206, 14);
            dgv_userAnimals.Margin = new Padding(4, 3, 4, 3);
            dgv_userAnimals.Name = "dgv_userAnimals";
            dgv_userAnimals.Size = new Size(665, 403);
            dgv_userAnimals.TabIndex = 9;
            // 
            // fm_CaretakersAnimals
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(dgv_userAnimals);
            Controls.Add(pb_headerpic);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fm_CaretakersAnimals";
            Text = "CaretakersAnimals";
            ((System.ComponentModel.ISupportInitialize)pb_headerpic).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_userAnimals).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_headerpic;
        private System.Windows.Forms.DataGridView dgv_userAnimals;
    }
}
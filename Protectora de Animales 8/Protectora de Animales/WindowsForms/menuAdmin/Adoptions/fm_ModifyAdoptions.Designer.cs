namespace WindowsForms.menuAdmin.Adoptions
{
    partial class fm_ModifyAdoptions
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
            btn_AcceptChanges = new Button();
            pb_Background = new PictureBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            pb_headerpic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_Background).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_headerpic).BeginInit();
            SuspendLayout();
            // 
            // btn_AcceptChanges
            // 
            btn_AcceptChanges.Location = new Point(834, 473);
            btn_AcceptChanges.Name = "btn_AcceptChanges";
            btn_AcceptChanges.Size = new Size(97, 23);
            btn_AcceptChanges.TabIndex = 19;
            btn_AcceptChanges.Text = "aceptar";
            btn_AcceptChanges.UseVisualStyleBackColor = true;
            btn_AcceptChanges.Click += btn_AcceptChanges_Click;
            // 
            // pb_Background
            // 
            pb_Background.BackColor = Color.OliveDrab;
            pb_Background.Location = new Point(119, 54);
            pb_Background.Margin = new Padding(4, 3, 4, 3);
            pb_Background.Name = "pb_Background";
            pb_Background.Size = new Size(802, 397);
            pb_Background.TabIndex = 18;
            pb_Background.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(137, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(765, 333);
            dataGridView1.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.OliveDrab;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(359, 9);
            label1.Name = "label1";
            label1.Size = new Size(197, 25);
            label1.TabIndex = 21;
            label1.Text = "Modificar Adopciones";
            // 
            // pb_headerpic
            // 
            pb_headerpic.Dock = DockStyle.Left;
            pb_headerpic.Image = Properties.Resources.Studio_Ghibli__Cattt__;
            pb_headerpic.Location = new Point(0, 0);
            pb_headerpic.Margin = new Padding(4, 3, 4, 3);
            pb_headerpic.Name = "pb_headerpic";
            pb_headerpic.Size = new Size(71, 508);
            pb_headerpic.TabIndex = 22;
            pb_headerpic.TabStop = false;
            // 
            // fm_ModifyAdoptions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 508);
            Controls.Add(pb_headerpic);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btn_AcceptChanges);
            Controls.Add(pb_Background);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "fm_ModifyAdoptions";
            Text = "fm_ModifyAdoptions";
            ((System.ComponentModel.ISupportInitialize)pb_Background).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_headerpic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_AcceptChanges;
        private PictureBox pb_Background;
        private DataGridView dataGridView1;
        private Label label1;
        private PictureBox pb_headerpic;
    }
}